create table Employees(
EmpID int identity(1,1) not null primary key,
 FirstName varchar(20) not null,
 LastName varchar(30) not null,
 Email varchar(50) not null,
 DOB date not null,
 Phone varchar(12) not null
 )
 go

create table EmpHours (
empHoursID int identity(1,1) not null constraint PK_EmpHours_EmpHoursID primary key,
EmpID int not null  constraint FK_Employee_EmpID  foreign key (EmpID) References Employee(EmpID) ON DELETE CASCADE,
WorkDate date not null,
Hours int not null
)
go

Drop Table EmpHours