create proc sp_role_login
@uname nvarchar(50),
@upass nvarchar(50)
as
begin
	select * from tb_Login_Role where username = @uname AND password = @upass
end