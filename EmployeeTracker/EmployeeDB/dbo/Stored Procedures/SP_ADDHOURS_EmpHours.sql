CREATE PROCEDURE SP_ADDHOURS_EmpHours
@EmpID int not null ,
@WorkDate date not null,
@Hours int not null
AS
BEGIN
INSERT
INTO
EmpHours
VALUES(@EmpID, @WorkDate, @Hours)
END