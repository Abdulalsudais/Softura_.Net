use ProjectA
go
---------------------------USER TABLE & PROCEDURE--------------------------------------------
Create Table UserLogin(
UserName varchar(20),
FirstName varchar(20),
LastName varchar(20),
Pasword varchar(10)
)
drop table UserLogin
select * from UserLogin
insert into  UserLogin values('Abdul','Abdul','Alsudais','123') 
--STORED PROCEDURE--
create proc VrfUsr
@uname varchar(20),
@Pasword varchar(10)
as
select*from UserLogin   where UserName=@uname and Pasword=@Pasword
drop proc VrfUsr
------------------------DOCTOR TABLE & PROCEDURE-------------------------------------------------
Create Table Doctor(
FirstName varchar(20),
LastName varchar(20),
Gender varchar(20),
Specialization varchar(30),
Visitinghours varchar(10)
)
select * from Doctor
truncate table Doctor
insert into Doctor values('Giridharan','Natarajan','Male','NeuroSurgen','2pm-3pm')
drop table Doctor
--STORED PROCEDURE--
create proc AddDoc
@fname varchar(20),
@lname varchar(20),
@gen varchar(8),
@spec varchar(20),
@vis varchar(10)
as
insert into Doctor(FirstName,LastName,Gender,Specialization,Visitinghours)
 values(@fname,@lname,@gen,@spec,@vis)
 exec AddDoc 
 drop proc AddDoc
----------------------------PATIENT TABLE & PROCEDURE-----------------------------------------------------
Create Table Patient(
PatientId int identity,
FirstName varchar(20),
LastName varchar(20),
Gender varchar(20),
Age int,
DOB date
)
select * from Patient
insert into Patient values('1','Ricky','John','Male','21','26-06-2000')
drop table Patient
--STORED PROCEDURE--
create proc AddPat
@finame varchar(20),
@laname varchar(20),
@gend varchar(1),
@Dob date
as
begin
declare @age int
set @age=(select DATEDIFF(YEAR,@Dob,getdate()))
insert into Patient(FirstName,LastName,Gender,DOB,Age)
values(@finame,@laname,@gend,@Dob,@age)
end
exec AddPat 'giri','dharan','Male','2000-06-13'
drop proc  AddPat
----------------------------APPOINTMENT TABLE & PROCEDURE--------------------------------------------------
create table Schedules
(
AppointmentID int identity(1,1),
Specializations varchar(30),
DoctorName varchar(20),
PatientName varchar(30),
VisitDate varchar(20),
AppointmentTime varchar(10)
)
select * from Schedules
drop table Schedules
--STORED PROCEDURE--
create proc AddSchedule
@spec Varchar(20),
@Doc varchar(20),
@pat varchar(50),
@visit Varchar(20),
@app varchar(20)
as
insert into Schedules(Specializations,DoctorName,PatientName,VisitDate,AppointmentTime) 
values (@spec,@Doc,@pat,@visit,@app)
 drop proc AddSchedule
-----------------------FECTHING DETAILS------------------------------
--STORED PROCEDURE--
create proc GetApss
as
select AppointmentId,Specializations,DoctorName,PatientName,VisitDate,AppointmentTime 
from Schedules where VisitDate >=CONVERT(date,GETDATE())
drop proc GetApss
drop table Appoint
select *from ScheduleAppointment
----------------------------DELETE APPOINTMENT PROCEDURE---------------------------------------------------------
--STORED PROCEDURE--
create proc DelSchedule
@appid int
as
delete from Schedules where AppointmentID=@appid
drop proc DelSchedule
exec DelSchedule
----------------------------NOT SCHEDULE IF NO PATIENTID IS ADDED----------------------------------------
Create Proc GetPatientN
@pid int
as

 

 