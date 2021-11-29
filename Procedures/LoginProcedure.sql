CREATE proc [dbo].[Usp_Login]( @Username nvarchar(25) , @Password nvarchar(20))

AS

IF Not Exists (Select 1 From LOGIN Where Username = @Username and Password=@Password)
BEGIN
	select * from LOGIN where Username=@Username and Password=@Password

RETURN 0
END
ELSE
BEGIN
RETURN 1
END