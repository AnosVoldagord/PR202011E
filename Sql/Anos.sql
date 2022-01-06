----------session #05----------
create database PR202011E
use PR202011E
---------Data Definition Language (DDL)---------
--(create, alter, drop)----------
--creating table in a database------
create table students
(
   id int primary key identity, ----identity autoincrement
   Std_Name varchar(50),
   Email varchar(50) unique,
   Phone int,
   Pwd varchar(50),
   Age int check (Age >=18)
)
-----changing data type-----
alter table students alter column Pwd varchar(50) not null
---adding column in an existing table---
alter table students add fees money
---- adding constraints--------
alter table students add check (Age >=18)
alter table students add unique (Email)
-------drop-----
alter table students drop CK__students__Age__25869641
alter table students drop UQ__students__A9D1053400E8C533
drop table students
----Renaming a column---
---use built in stored procedure----
exec sp_rename 'students.Pwd' , 'Password'
-------Data MAnipulation Language (select,insert, update,delete)
select * from students
---insert record in a table
insert into students values('Raheel','raheel@gmail.com',03457894,'1234',20)
insert into students values('Anus','anus@gmail.com',03457894,'1234',20)
insert into students values('Jazil','jazil@gmail.com',03457894,'1234',19)
insert into students values('Huzaifa',null,03457894,'1234',19)
insert into students values('Faizan','fazi@gmail.com',03457894,'1234',21)
insert into students values('Ahmed','ahmed@gmail.com',03457894,'1234',21)
insert into students values('Hammad','hammad@gmail.com',03457894,'1234',22)
insert into students values('Subhan','subhan@gmail.com',03457894,'1234',22)
insert into students values('Hamza','hamza@gmail.com',03457894,'1234',23)
select * from students
--inserting records  in  specific columns------------
insert into students(Std_Name,Email,Phone,Password) values('Saif','saif@gmail.com',03457894,'1234')
---Alias Data type-------
create type  v  from varchar(50)
-----predicates (in,between,like,contain)
--find record of students age lies between 19 to 20----
select id, std_name, Age 
from students 
where Age between 19 and 20
----in ------
select id, std_name, Age 
from students 
where id in(4,6,9)
----like(search)-----
select *
from students 
where std_name like 'a%' ---> wild card character

select *
from students 
where std_name like '%na%' 

select *
from students 
where contains ((std_name,email),'ali')
------Operators (comparision,logical, arithmetic, concatenation, assignment)-----------------------
---comparision(>,<,>=,<=,=,!=,!>)
select * from students where Age>20
select * from students where Age<20
select * from students where Age>=20
select * from students where Age<=20
select * from students where Age!=20
select * from students where Age!>20
select * from students where Age!<20
-------logical(AND, OR, NOT)---------------
select *from students where Age=23 AND Std_Name = 'Raheel'
select *from students where Age=23 OR Std_Name = 'Raheel'
select * from students where id not in(4,6,9)
--------Arithmetic Operator-------------
alter table students add Eng int
alter table students add Math int
alter table students add Comp int 
alter table students add TotalMarks int
alter table students alter column Perc int
--------Expressions-------------------
update  students set TotalMarks = Eng + Math + Comp
alter table students add Perc float
update students set Perc = (TotalMarks)*100/300
select * from students order by Perc desc
----------Concatenation---------------------
select Std_Name+'/'+Email as 'Concatenation' from Students
select Std_Name,Eng,Math,Comp,TotalMarks,convert(varchar(50),Perc)+'%' as 'Percentage' from Students 
-------Assignment------------
---variables--------
declare @a int,@b varchar(50)
set @a = 8
set @b= 'Sahia' 
select @a
select @b+' You are awesome '
------control flow------------
declare @Age int
set @Age= 20
while @Age <=60
 begin
  select @Age
  set @Age = @Age+1
  end 

  select GETDATE()