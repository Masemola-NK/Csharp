create procedure [dbo].[UpdateEmp]
@EmpID int,
@EmpName nvarchar(50),
@EmpSurname nvarchar(50),
@EmpDep nvarchar(20),
@EmpJDate datetime,
@EmpSex nvarchar(10)
as 
begin
update EmpTestT 
	set EmpName=@EmpName,
	EmpSurname=@EmpSurname,
	EmpDep=@EmpDep,
	EmpJDate=@EmpJDate,
	EmpSex=@EmpSex
	where EmpID=@EmpID
end