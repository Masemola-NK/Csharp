CREATE PROCEDURE InsertEmp_sp
@EmpID int,
@EmpName nvarchar(50),
@EmpSurname nvarchar(50),
@EmpDep nvarchar(20),
@EmpJDate datetime,
@EmpSex nvarchar(10)
AS
BEGIN
INSERT into [EmpMS].[dbo].[EmpTestT] (EmpID,EmpName,EmpSurname,EmpDep,EmpJDate,EmpSex)
VALUES (@EmpID,@EmpName,@EmpSurname,@EmpDep,@EmpJDate,@EmpSex)
END;

exec InsertEmp_sp 8,'Jane','Van sky', 'Cleaner','20-09-2024','female'