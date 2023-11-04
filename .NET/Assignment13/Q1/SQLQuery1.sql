Create Procedure addcustomer
	@cname NVARCHAR(MAX),
	@caddrress NVARCHAR(MAX),
	@cmob NCHAR(10)
AS
BEGIN
INSERT INTO dbo.Customer(Name,Address,MobileNo) VALUES (@cname ,@caddrress , @cmob)
END