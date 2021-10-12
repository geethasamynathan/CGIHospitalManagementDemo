create database Hospitalmanagement
create table beds(Name varchar(20) primary key, Gender varchar(10), MobileNo bigint, Dob date, HLocation varchar(500), DOAdmission date, Department varchar(50));

insert into beds values('Aishwarya', 'female', 9036574711, '2021-10-11', 'bangalore', '2021-11-15', 'heart department')
create table vaccination(Name varchar(20) primary key, Gender varchar(10), MobileNo bigint, Dob date, HLocation varchar(500), DOAdmission date,  Tt time);

insert into vaccination values('Aishwarya', 'female', 9036574711, '2021-10-11', 'bangalore', '2021-11-15', '12:00' )
select * from beds
select * from vaccination

Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=Hospitalmanagement;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models