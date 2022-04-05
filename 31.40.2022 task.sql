use Task
go
create table Registrationform
(
SNo int identity(1,1),
firstName varchar(20),
Lastname varchar(20),
age int constraint chk_age check(age >22),
dob varchar(20),
gender char(1) constraint ck_gen check (gender in ('M','F')),
Collegename char(25),
streetname varchar(35),
locality varchar(20),
pincode int,
District char(10),
Country char(10),
Phonenumber int,
backlogs varchar(1) constraint ck_backlogs check (backlogs < 3),
Sslcmark int,
hscmark int,
Collegecgpa int,
RegDate date default getdate()
)
insert Registrationform values ('Abdul','Alsudais','23','22061999','M','REC','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','88','77','72',getdate())
insert Registrationform values ('Giri','dharan','23','22061999','M','CIT','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','86','76','72',getdate())
insert Registrationform values ('sid','Rober','24','22061999','M','Sathyabama','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','85','75','72',getdate())
insert Registrationform values ('aanand','Thangam','24','22061999','M','St.Joseph','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','84','74','72',getdate())
select* from Registrationform