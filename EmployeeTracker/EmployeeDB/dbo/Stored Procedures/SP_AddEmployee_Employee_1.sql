CREATE PROCEDURE SP_AddEmployee_Employee 
@FirstName varchar(20) not null,
 @LastName varchar(30) not null,
 @Email varchar(50) not null,
 @DOB date not null,
 @Phone varchar(12) not null
AS
BEGIN
INSERT INTO 
Employees
Values(@FirstName, @LastName, @Email, @DOB, @Phone)

END