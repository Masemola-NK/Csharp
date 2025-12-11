
create procedure [dbo].[DeleteEmp]
@EmpID int
as 
begin
delete EmpTestT 
	where EmpID=@EmpID
end