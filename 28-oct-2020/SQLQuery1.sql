
create database assign_28_oct

use assign_28_oct

create table student(
stu_id int not null primary key identity(1,1),
stu_fname varchar(50),
stu_lname varchar(100),
stu_location varchar(100))

insert into student values('kavya','pn','banglore');


insert into student values('lakshman','p','hyderabad');


insert into student values('ram','pn','tumkur');

insert into student values('kavitha','s','banglore');
select * from student

create table employee(
id int not null primary key identity(1,1),
emp_name varchar(100),
emp_designation varchar(100),
emp_location varchar(100))

insert into employee values('ramya','hr','karnataka')
insert into employee values('gnana','technician','hyderabad')

insert into employee values('lakshmi','trainee','manglore')

insert into employee values('asha','developer','delhi')

insert into employee values('ayush','tester','mumbai')
select * from employee

create table cricket(
jersey_num int not null,
fname varchar(100),
lname varchar(100),
no_of_century int)

create table railway(
train_no int not null,
train_name varchar(100),
source varchar(100),
destination varchar(100),
arrival_time time)

create table bank(
emp_id int not null primary key identity(1,1),
emp_name varchar(100),
emp_depat varchar(100),
emp_location varchar(100))

select * from cricket

insert into cricket values(18,'virat','kohli',27)
insert into cricket values(19,'rahul','dravid',36)
insert into cricket values(07,'ms','dhoni',6)
insert into cricket values(10,'sachin','tendulkar',51)

alter table railway
drop column arrival_time

alter table railway
add  arrival_time time(0);

select * from railway
insert into railway values(12356,'karnatakaexpress','banglore','hubli','09:12:00')
insert into railway values(12323,'RaniChennammaExpress','hubli','banglore','23:12:23')

insert into railway values(14432,'Ahmedabad mumbai passenger','ahemadabad','mumbau','10:12:00')

insert into railway values(12122,'Anand vihar','Newdelhi','dibrugarh','13:12:00')

insert into railway values(14344,'Andaman express','mata vishnu devikotta','mgrcentral','12:23:00')


select * from bank

insert into bank values('gnana','cashsection','banglore')
insert into bank values('seema','passbooksection','mumbai')

insert into bank values('karthik','creditcardsection','chennai')

insert into bank values('sham','debitcardsection','hyderabad')
insert into bank values('nayana','accountsection','delhi')










