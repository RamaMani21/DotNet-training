create database employeedb;

use employeedb;

create table employee
(empid int not null primary key,
empname varchar(50) not null,
ssn bigint not null,
salary float not null,
deptid int not null);

insert into employee values(1, 'rama', 12345, 30000.5, 1);
insert into employee values(2, 'dhoni', 15685, 40000.5, 9);
insert into employee values(3, 'virat', 16789, 25000.5, 8);
insert into employee values(4, 'shreyas', 56848, 20000.5, 3);


select * from employee;




create database deptdb;
use deptdb;

create table dept
(deptid int not null primary key,
deptname varchar(50) not null);
insert into dept values(1,'ece');
insert into dept values(2,'cse');
insert into dept values(3,'ece');
insert into dept values(4,'cse');
select * from dept;

update employee set salary=30000 where empid=4;
update employee set salary=40000 where deptid=1;

select * from employee where salary between 25000 and 30000;
select * from employee where salary < 30000;



select  deptid, deptname from dept where deptname = 'ece';



alter table dept
add description varchar(100);

select* from dept;

update dept set description = 'this is an ece department with higher activities' where deptid=1;




alter table employee
add constraint FK_deptid foreign key(deptid) references dept(deptid);



ALTER Table employee
add dob date

select* from employee;
update employee set dob='12.21.1997';

alter table employee
add constraint Chk_dob check (dob between '12.1.1997' and '12.31.1997');