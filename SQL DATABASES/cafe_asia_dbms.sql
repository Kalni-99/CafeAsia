create database Cafe_Asia;
use Cafe_Asia;

create table registerr
(
   username varchar (50),
   password char(8) unique,
   confirm_password char(8),
   email varchar(80),
   contact_no integer,
   primary key(username,password)
);

create table payments
(
  card_type varchar(20),
  name_on_card varchar(50),
  card_no  varchar(16) ,
  card_expr_ varchar(10),
  cvv_no integer
);

 create table fooditem
(
  Item_Name varchar(50),
  Unit_Price float
);

create table food
(
  Item_Name varchar(50),
  Unit_Price float,
  quantity integer,
  Price float,
);

create table sales
(
  Item_Name_ varchar(50),
  Unit_Price_ float,
  quantity_ integer,
  Price_ float,
);

create table delivary
(
   fname varchar(30),
   lname varchar(30),
   addr_line1 varchar (50),
   addre_line2 varchar (50),
   city varchar(40),
   contact_no integer,
   email varchar(50)
);



drop table delivary;
drop table register;
drop table sales;
drop table foods;
drop table payment;

delete  from food;

select * from food;
select * from sales;
select * from fooditem;
select * from register;
select * from payments;
select * from delivary;

