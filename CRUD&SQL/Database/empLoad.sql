
GO
CREATE PROCEDURE LoadEmp
AS
BEGIN
Select * from [EMpMS].[dbo].[EmpTestT]
END;
GO

exec LoadEmp