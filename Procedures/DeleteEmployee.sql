USE [Employee Portal]
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteEmployee]    Script Date: 15-11-2021 14:47:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_DeleteEmployee](@IP1 int)
as 
begin 
begin try
if @IP1>0
begin
delete from employee where EmployeeId = @IP1
end
else
begin
return -1
end
end try
begin catch
return -2
end catch
end