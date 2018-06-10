create table Employees(
EmpID int identity(1,1) not null constraint PK_Employee_EmpID primary key,
 FirstName varchar(20) not null,
 LastName varchar(30) not null,
 Email varchar(50) not null,
 DOB date not null,
 Phone varchar(12) not null
 )