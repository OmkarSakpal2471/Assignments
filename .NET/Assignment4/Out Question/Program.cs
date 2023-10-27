namespace Account
{
    internal class Program
    {

        public static int count(int num,out int count)
        {
            int num1 = num;
            int sum = 0;
            int c=0;
            while(num1 > 0)
            {
                sum += num1 % 10;
                num1 /= 10;
                c++;
                
            }
            count = c;
            return sum;
        }
        static void Main(string[] args)
        {
            int i;
            int j;
            i=count(123,out j);
            Console.WriteLine(i);
            Console.WriteLine(j);





        }
    }
}
