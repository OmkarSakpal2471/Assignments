using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerADO
{
    internal class Strongly_type
    {

        private string _connectionString;

        public Strongly_type(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public SqlConnection gettConnection()
        {
            SqlConnection sqlconn=new SqlConnection();
            sqlconn.ConnectionString = _connectionString;   
            return sqlconn;
        }

        public int AddData(Customer c1)
        {
            SqlConnection sqlcon = null;
            SqlCommand sqlcmd = null;
            int record=0;
            try
            {
                sqlcon = gettConnection();
                sqlcmd = new SqlCommand("addcustomer", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.Add("@cname", SqlDbType.NVarChar).Value = c1.Name;
                sqlcmd.Parameters.Add("@caddrress", SqlDbType.NVarChar).Value = c1.Address;
                sqlcmd.Parameters.Add("@cmob", SqlDbType.NChar).Value = c1.mob_num;
                sqlcon.Open();
                record = sqlcmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlcon.Close();
            }
            return record;
            
        }

        public List<Customer> GetAll()
        {
            var listCustomer=new List<Customer>();
            try
            {
                using(SqlConnection sqlcon = gettConnection())
                {
                    SqlCommand sqlcmd = new SqlCommand("getallcustomer", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcon.Open();
                    SqlDataReader rdr = sqlcmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listCustomer.Add(new Customer
                        {
                            Id = Convert.ToInt32(rdr["ID"]),
                            Name = rdr["Name"].ToString(),
                            Address = rdr["Address"].ToString(),
                            mob_num = rdr["MobileNo"].ToString()
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return listCustomer;
        }

        public List<Customer> GetCustId(int Id)
        {
            var listCustomer = new List<Customer>();
            try
            {
                using (SqlConnection sqlcon = gettConnection())
                {
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Customer WHERE Id=@pId", sqlcon);
                    sqlcmd.Parameters.AddWithValue("@pId", Id);

                    sqlcon.Open();
                    SqlDataReader rdr = sqlcmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listCustomer.Add(new Customer
                        {
                            Id = Convert.ToInt32(rdr["ID"]),
                            Name = rdr["Name"].ToString(),
                            Address = rdr["Address"].ToString(),
                            mob_num = rdr["MobileNo"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listCustomer;
        }

        public List<Customer> GetCustIdName(string name,string mobileno)
        {
            var listCustomer = new List<Customer>();
            try
            {
                using (SqlConnection sqlcon = gettConnection())
                {
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Customer WHERE Name=@pName AND MobileNo=@pMobile", sqlcon);
                    sqlcmd.Parameters.AddWithValue("@pName", name);
                    sqlcmd.Parameters.AddWithValue("@pMobile", mobileno);

                    sqlcon.Open();
                    SqlDataReader rdr = sqlcmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listCustomer.Add(new Customer
                        {
                            Id = Convert.ToInt32(rdr["ID"]),
                            Name = rdr["Name"].ToString(),
                            Address = rdr["Address"].ToString(),
                            mob_num = rdr["MobileNo"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listCustomer;
        }


        public int Del(int Id)
        {
            SqlConnection sqconn = null;
            SqlCommand sqlcmd;
            int no = 0;
            using(sqconn = gettConnection())
            {
                sqconn.Open();
                sqlcmd = new SqlCommand("DELETE FROM Customer WHERE id=@pId", sqconn);
                sqlcmd.Parameters.AddWithValue("@pId", Id);
                no=sqlcmd.ExecuteNonQuery();
            }

            return no;  
        }

        public int Update(int Id,string name) {
            SqlConnection sqconn = null;
            SqlCommand sqlcmd;
            int no = 0;
            using (sqconn = gettConnection())
            {
                sqconn.Open();
                sqlcmd = new SqlCommand("UPDATE Customer SET Name=@pname WHERE id=@pId", sqconn);
                sqlcmd.Parameters.AddWithValue("@pId", Id);
                sqlcmd.Parameters.AddWithValue("@pname", name);
                no = sqlcmd.ExecuteNonQuery();
            }

            return no;

        }


    }
}
