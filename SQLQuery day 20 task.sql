use AdventureWorks2019
go
-- task 1
select[FirstName][LastName]
from Person.Person
where Title is not Null
-- task 2
select[FirstName],[LastName]
from Person.Person
where FirstName like '%a%' or LastName like '%a%'
-- task 3
select sa.Name as CurrencyCode,Name
from Sales.Currency Sa
join Sales.CountryRegionCurrency Sacr
on sa.CurrencyCode=sacr.CurrencyCode
create view view_table
as
select CurrencyCode,Name
from Sales.Currency
go
select * from view_table


-- task 4
create table HR_Department
(
EmptID int identity(2001,1),
EmpFname varchar(20),
EmpLname varchar(50),
)
insert HR_Department values ('Abdul','Alsudais')
select * from HR_Department




-- task 5
create table tbl
(
Sno int identity(1,1),
FName varchar(50),
LName varchar(50),
Gender char,
ModifiedDate date default getdate()
)
select * from tbl
insert into tbl(Fname,LName,Gender) 
values('ABDUL','S','M')
insert into tbl(Fname,LName,Gender) 
values('BAGA','Z','M')
insert into tbl(Fname,LName,Gender) 
values('GIRI','S','M')
insert into tbl(Fname,LName,Gender) 
values('VENKAT','I','M')
insert into tbl(Fname,LName,Gender) 
values('HUDA','L','M')
insert into tbl(Fname,LName,Gender) 
values('ABU','S','M')
insert into tbl(Fname,LName,Gender) 
values('UMAR','O','M')
insert into tbl(Fname,LName,Gender) 
values('HARIS','A','M')

-- task 6
select businessentityid,addresstypeid
from HumanResources.Department
inner join person.BusinessEntityAddress
ON HumanResources.Department.DepartmentID = person.BusinessEntityAddress.BusinessEntityID
-- task 7
select distinct GroupName
from HumanResources.Department
-- task 8
select a.standardcost,sum(listprice) sum1,sum(a.standardcost) Sum2
from Production.Product a
join Production.ProductCostHistory b
on a.ProductID = b.ProductID
group by a.StandardCost
-- task 9
select DATEDIFF (yy,StartDate, EndDate) as YearsORole, BusinessEntityID
from HumanResources.EmployeeDepartmentHistory
-- task 10

-- task 11
select max(TaxRate) as Tax_rate 
from Sales.SalesTaxRate
-- task 12
select EmpH.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee Emp
join HumanResources.EmployeeDepartmentHistory EmpH
on Emp.BusinessEntityID=EmpH.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=EmpH.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as Age 
from HumanResources.Employee
-- task 13
create view age
as
select  datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee

select * from age

-- task 14
SELECT count(*) as No_of_HR_Rows
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]
-- task 15
select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name
-- task 16
select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null
-- task 17
select ProductID,LocationID,Shelf 
from [Production].[ProductInventory]
where ProductID>300 and ProductID<=350 and locationID=50
-- task 18
select p.LocationID,Shelf,Name
from [Production].[ProductInventory] pp
join [Production].[Location] p
on pp.LocationID=p.LocationID
-- task 19
select AddressID,AddressLine1,AddressLine2, pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince ps
join Person.Address pa
on ps.StateProvinceID=pa.StateProvinceID

--task 20
select sum([SubTotal]),sum([TaxAmt])
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]
