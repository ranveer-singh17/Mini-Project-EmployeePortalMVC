USE [Employee Portal]
GO
/****** Object:  StoredProcedure [dbo].[usp_insertdetail]    Script Date: 15-11-2021 14:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_insertdetail](@IP1 int,@IP2 varchar(25),@IP3 varchar(25),@IP4 int,@IP5 varchar(25))
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
insert into employee(EmployeeId ,
FirstName ,LastName,salary ,DepartmentID
) values(@Ip1 ,@IP2 ,@IP3 ,@IP4,@Ip5 )
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