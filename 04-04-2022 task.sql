use AdventureWorks2019
go
--1
--count()
select  count(Name) as TotalNoOfDept 
from HumanResources.Department
--Sum()
select sum(ListPrice) as Total
from Production.ProductListPriceHistory
--Datediff()
select Datediff(yy,StartDate,EndDate) as DateDifference
from Production.ProductCostHistory
--DateAdd()
select DateAdd(year,3,12/10/2022) as Afteradd
--Convert()
select Convert(int,88.00)
--Left()
select Left('Abdul',2) as ExString
--Len()
select Len('Abdul')
--Reverse()
Select Reverse('Abdul Alsudais')
--2
create function fn_RupeesSi(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesSi(rate) as Rupee 
from HumanResources.EmployeePayHistory

--3
create table tbl_student
(
Sno int,
StuName varchar(20),
StuAge int
)
alter table tbl_Student
add Gender char(1)
select * from tbl_Student
alter table tbl_Student
add MobileNO int
insert into tbl_Student values(1,'ABDUL',22,'M',638355772)
alter table tbl_Student
alter column MobileNO char(20)
create view stud
as
select [Sno],[StuName],[StuAge]
from [dbo].[tbl_Student]
go
select *from stud
insert into tbl_student values(2,'Fathima',38,'F',879654321)
--4
use AdventureWorks2019
Create table tbl_just
(
sno int,
name varchar(50),
age int,
gender char(1)
)

create proc task_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

task_sp 'Abdul','M'

create proc task_spup
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task_spup 1,19,'Abdul'

create proc task_spDel
@sno int
as
delete from tbl_just where sno = @sno

--5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

--6
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

--7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name
