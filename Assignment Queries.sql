create database ABCCompany

use ABCCompany

create table Category
( cid int not null primary key identity(1,1),
 cname varchar(64) not null,
 tax decimal)

 insert into Category values('Men Clothes',12)
 select * from Category

 create table Product
 (pid int not null primary key identity(1,1),
 pname varchar(64) not null,
 open_stock decimal not null,
 cur_stock decimal not null,
 sale_price decimal not null,
 category int not null foreign key references Category(cid))
 
 insert into Product values('Tshirt',10,10,550,3)
 select *  from Product

 create table Customer
 ( custid int not null primary key identity(1,1),
 custname varchar(32) not null,
 mobile_no varchar(15) not null,
 open_bal decimal not null constraint def default 0,
 is_active BIT not null constraint defa default('TRUE'))

 select * from customer
 insert into Customer values ('Ammi',981223445,default,default)

 create table SalesHead
 (sale_inv_no int not null primary key identity(1,1),
 sale_date date not null,
 customer int not null foreign key references  Customer(custid),
 Ptype char(10),
 constraint check_1 check(Ptype='Credit' or Ptype='Paid'))

 insert into SalesHead values('2020-09-23',5,'Credit')
 select * from SalesHead

 create table SalesDetail
 (sale_inv_no int not null foreign key references SalesHead(sale_inv_no),
 product_id int not null foreign key references Product(pid),
 qty decimal not null,
 rate decimal not null)

 insert into SalesDetail values (5,6,3,20000)
 select * from SalesDetail

 select * from Product
 Query1:
 select p.pname,c.cname,p.cur_stock from Product as p ,Category as c where p.category=c.cid

 Query2:
 select custname from Customer where is_active='True'

 Query3:
 select custname ,open_bal from Customer

 Query4:
 select  sum(sd.qty) as SALES from SalesDetail as sd , SalesHead as sh where sale_date > '2020-06-01' and sale_date < '2020-07-01'

 Query5:
 select pname ,sum(qty) QTY from Product as p, SalesDetail as sd where sd.product_id=p.pid 
 group by pname 
 order by (QTY) DESC

 Query6:
 select pname ,sum(qty) QTY from Product as p, SalesDetail as sd where sd.product_id=p.pid 
 group by pname 
 order by (QTY) ASC
 



