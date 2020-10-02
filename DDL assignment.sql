create database Dxc
 
use DXC

--create table Client 
CREATE TABLE Client 
(Client_ID int IDENTITY(1,1) NOT NULL primary key,
Client_Name varchar(64) not null,
Contact_Person varchar(40),
Agreement_Date date)

 --create table Project with foreign key
CREATE TABLE Project 
(Prj_ID int IDENTITY(1,1) NOT NULL primary key,
Prj_Name varchar(64) not null,
Prj_Description varchar(1024),
Prj_Start_Date date,
Client int,
CONSTRAINT FK_Client FOREIGN KEY (Client) REFERENCES Client(Client_ID) ON DELETE CASCADE
)

--create department table
CREATE TABLE Dept
(ID int IDENTITY(1,1) NOT NULL primary key,
DeptName varchar(32) NOT NULL)
  
--create table Employee
create table Employee
(EmpID varchar(8) NOT NULL primary key,
EmpName varchar(64) NOT NULL,
Email varchar(64) NULL,
Phone varchar(815) NOT NULL,
Dept int NOT NULL,
constraint fkk foreign key(Dept) references Dept(ID))
 

-- 1. Adding new column
alter table Project 
ADD Prj_Cost decimal(12, 2) NULL

-- 2. updating existing column   
alter table Project 
ALTER COLUMN Prj_Description varchar(512)


 


