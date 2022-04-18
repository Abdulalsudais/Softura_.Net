create database Activity
use Activity
go
--
create table tbl_Product
(
ProductId int Identity(1,1),
ProductName varchar(50),
ProductPrice Money,
MFD date default getdate(),
ExpiryDate date default getdate(),
)
Insert tbl_Product values('maaza',200,getdate(),Dateadd(month,4,getdate()))
Insert tbl_Product values('Frooti',220,getdate(),Dateadd(month,2,getdate()))
Insert tbl_Product values('Slice',180,getdate(),Dateadd(month,1,getdate()))
Insert tbl_Product values('MinuteMaid',210,getdate(),Dateadd(month,3,getdate()))

select * from tbl_Product
--
Create table tbl_Customer
(
CustomerID int identity(1,1),
CustomerName varchar(20),
Gender varchar(10),
DOB varchar(20),
ContactNo varchar(30),
EmailId varchar(30),
City varchar(20)
)


Insert tbl_Customer values('Giri','Male','1999-05-22','8945624784','giri@gmail.com','GOA')
Insert tbl_Customer values('Haris','Male','1999-05-22','7485961425','Haris@gmail.com','MUMBAI')
Insert tbl_Customer values('Jeyanthi','Female','1999-05-22','6598741225','Jeyanthi@gmail.com','CHENNAI')
Insert tbl_Customer values('Vishal','Male','1999-05-22','9647256574','Vishal@gmail.com','KARNATAKA')

select * from tbl_Customer

--
create table tbl_Purchase
(
PurchasedDate date default getdate(),
BillNo int identity(1001,1),
CustomerID int,
ProductId int,
Quantity int,
TotalAmt int,
)
drop table tbl_Product
drop table tbl_Customer
drop table tbl_Purchase
select * from tbl_Purchase


select  ptt.CustomerID,pt.ProductId,ProductName,ProductPrice,ptt.Quantity,TotalAmt
from tbl_Product pt join tbl_Purchase ptt 
on pt.ProductId = ptt.ProductId 
where CustomerId = 2

insert tbl_Purchase (CustomerID,ProductID,Quantity,TotalAmt)values (2,2,5,30)