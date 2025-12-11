create procedure dbo.AddEmp
@EmpID int,
@EmpName nvarchar(50),
@EmpSurname nvarchar(50),
@EmpDep nvarchar(20),
@EmpJDate datetime,
@EmpSex nvarchar(50)
as 
begin
insert into EmpMS.dbo.EmpTestT (EmpID,EmpName,EmpSurname,EmpDep,EmpJDate,EmpSex)
values(@EmpID,@EmpName,@EmpSurname,@EmpDep,@EmpJDate,@EmpSex)
end 
go 
EXEC dbo.AddEmp 
    @EmpID = 8,
    @EmpName = 'Ndu',
    @EmpSurname = 'Masilela',
    @EmpDep = 'Designer',
    @EmpJDate = '2026-08-03',
    @EmpSex = 'female';
go