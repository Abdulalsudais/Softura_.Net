use sql1
go

create proc sp_nTask
@sno int, @StuName Varchar(20)
as
insert [dbo].[tbl_new] values (@sno,@StuName)

select * from [dbo].[tbl_new]
create proc upd_task
@sno int ,@stuName varchar(20)
as
update [dbo].[tbl_new] set SName = @stuName where sno=@sno

create proc del_task
@sno int
as
delete [dbo].[tbl_new] where sno=@sno