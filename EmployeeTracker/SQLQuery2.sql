USE [EmployeeDB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SP_DisplayEmployees_Employee]

SELECT	@return_value as 'Return Value'

GO
