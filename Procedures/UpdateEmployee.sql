USE [Employee Portal]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateEmployeeDetails]    Script Date: 15-11-2021 14:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_UpdateEmployeeDetails] (@IP1 int,@IP2 varchar(25),@IP3 varchar(25),@IP4 int,@IP5 varchar(25))
as 
begin 
begin try
if @IP1>0
begin
if LEN(@IP2)<10
begin
if LEN(@IP3)<10
begin
if @IP4>0
begin
if @IP5 is not null
begin
update employee
set EmployeeId = @Ip1,
FirstName = @IP2,
LastName = @IP2 ,
salary =@IP4 ,
DepartmentID = @Ip5 
where EmployeeId = 1001;
end
else
begin
return -1
end
end
else
begin
return -2
end
end
else
begin
return -3
end
end
else
begin
return -4
end
end
else
begin
return -5
end
end try
begin catch
return -7
end catch
end
