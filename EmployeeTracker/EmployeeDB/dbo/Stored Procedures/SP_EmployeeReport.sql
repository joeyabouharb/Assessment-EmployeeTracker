CREATE PROCEDURE SP_EmployeeReport
@EmpID int not null
AS 
Begin
SELECT e.EmpID, FirstName, LastName, SUM(Hours) as TotalHoursWorked
FROM Employees e, EmpHours eh
Where e.EmpID = eh.EmpID 
and eh.EmpID  = @empID
group by e.EmpID
END