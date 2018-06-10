create table EmpHours (
empHoursID int identity(1,1) not null constraint PK_EmpHours_EmpHoursID primary key,
EmpID int not null  constraint FK_Employee_EmpID  foreign key (EmpID) References Employees(EmpID) ON DELETE CASCADE,
WorkDate date not null,
Hours int not null
)