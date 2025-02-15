select * from HumanResources.Employee
select JobTitle ,Gender,LoginID from HumanResources.Employee

select * from HumanResources.Department



select 'Department Number'=DepartmentID,'DepartmentName'=Name from HumanResources.Department

select DepartmentID as 'Department Number',Name as 'Department Name' from HumanResources.Department

select BusinessEntityID ,'Desgination: 'as k,JobTitle from HumanResources.Employee


select Name + '   department comes under  '+ GroupName +'  group   ' as Department from HumanResources.Department

  
select * from HumanResources.EmployeePayHistory

select BusinessEntityID,Rate,per_day_rate=8*Rate from HumanResources.EmployeePayHistory


select * from HumanResources.Department where groupname='research and development'


  
select * from HumanResources.Employee
--here relational operators are used...to check condition
select BusinessEntityID ,NationalIDNumber,JobTitle,VacationHours from 
HumanResources.Employee where VacationHours > 20



select * from humanresources.Department where Groupname='Manufacturing' or Groupname='Inventory management'

select * from Humanresources.Employee where JobTitle='production Technician - wc60' and Gender='M'

select * from HumanResources.Department where Groupname='Manufacturing' or NOT GroupName='quality Assurance'



select BusinessEntityID,VacationHours  from Humanresources.Employee
where vacationhours between 20 and 50

select BusinessEntityID,VacationHours from Humanresources.Employee where
vacationhours not between 20 and 80


select BusinessEntityID,JobTitle,LoginID from HumanResources.Employee where
JobTitle  in('Recruiter','Stocker') 

select BusinessEntityID,JobTitle,LoginID from Humanresources.Employee where
JobTitle not in('recruiter','stocked','janitor')

--retriving records that contain matched pattern
select * from HumanResources.Department where Name Like 'Production [c]%'
select * from HumanResources.Department
select * from HumanResources.Department where Name like 'Pro%'

select * from HumanResources.Department where Name like 'Sale_'

  
create table hi( names varchar(10), rollno int)


insert into hi values ('Karsen',200)
insert into hi values('Karson',500)
insert into hi values('raghu',62)
insert into hi values ('Carsen',100)
insert into hi values('kiran',46)
insert into hi values ('Carson',300)

select * from hi;
select * from hi where names like '[CK]ars[eo]n'
select * from hi where names like '[^K]ars[eo]n'

select * from hi where names like '[ck]ir[ad]n'
select * from hi where names like '[re][da]g[kh]u'
select * from hi where names like '[^c]ars[^e]n'



drop table hi



-- Retriving record that contain null values

select * from [HumanResources].[EmployeeDepartmentHistory]
select BusinessEntityID,EndDate from 
HumanResources.EmployeeDepartmentHistory where EndDate is null

select BusinessEntityID,Enddate from
HumanResources.EmployeeDepartmentHistory where Enddate is not null
select DepartmentID ,BusinessEntityID from HumanResources.EmployeeDepartmentHistory
order by DepartmentID


select * from HumanResources.Department
select DepartmentID ,Name from HumanResources.Department order by Name 


select * from HumanResources.EmployeeDepartmentHistory 
select top 3 BusinessEntityID,Enddate 
from HumanResources.EmployeeDepartmentHistory where Enddate is not null

select top 50 percent * from HumanResources .EmployeeDepartmentHistory


Aggregate functions 

select count(*) as k from HumanResources.EmployeePayHistory

select sum(Rate) from HumanResources.EmployeePayHistory

select max(Rate) from HumanResources.EmployeePayHistory

select min(Rate) from HumanResources.EmployeePayHistory

select avg(Rate) from HumanResources.EmployeePayHistory

  
create table id(id int)
insert into id values(1),(2),(1),(3),(1),(2),(3),(1)

select * from id
select *from id group by id;
select count(id) as count from id--returns total value
select *,count(id) from id group by id 

--------------------------------------------

create table dept1(
  deptno int ,
  dname  varchar(14),
  loc    varchar(13),
  constraint pkk1 primary key(deptno)
);
 
 create table emp1(
  empno    int primary key,
  ename    varchar(10),
  job      varchar(9),
  mgr      int,
  hiredate date,
  sal      int,
  comm     int,
  deptno   int  foreign key  references dept1 (deptno)
);

insert into dept1 values(10, 'ACCOUNTING', 'NEW YORK');
insert into dept1 values(20, 'RESEARCH', 'DALLAS');
insert into dept1
values(30, 'SALES', 'CHICAGO');
insert into dept1
values(40, 'OPERATIONS', 'BOSTON'); 

select * from dept1;
insert into emp1 values( 7839, 'KING', 'PRESIDENT', null,'1981-11-17' , 5000, null, 10);
insert into emp1 values( 7698, 'BLAKE', 'MANAGER', 7839,'1981-05-01',2850, null, 30);
insert into emp1 values( 7782, 'CLARK', 'MANAGER', 7839,'1981-06-09', 2450, null, 10);
insert into emp1 values( 7566, 'JONES', 'MANAGER', 7839,'1981-04-02', 2975, null, 20);
insert into emp1 values( 7788, 'SCOTT', 'ANALYST', 7566,'1987-04-19', 3000, null, 20);
insert into emp1 values( 7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, null, 20);
insert into emp1 values( 7369, 'SMITH', 'CLERK', 7902,'1980-12-17', 800, null, 20);
insert into emp1 values( 7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30);
insert into emp1 values(  7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30);
insert into emp1 values( 7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30);
insert into emp1 values(  7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30);
insert into emp1 values( 7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, null, 20);
insert into emp1 values( 7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, null, 30);
insert into emp1 values( 7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, null, 10);


select * from dept1;
select * from emp1;

select deptno,count(ename) from emp1 group by deptno;
select deptno,count(deptno) from emp1 group by deptno;
select job,count(ename) as no_of_employees from emp1 group by job
select job,max(sal) as max_salary from emp1 group by job
select job,min(sal) as min_salary from emp1 group by job
select job ,sum(sal) from emp1 group by job 
select job ,sum(sal) from emp1 group by job having sum(sal)>5000


 create table dept3(deptid int primary key ,deptname varchar(30));
insert into dept3 values(10,'sales'),(20,'Marketing'),
(30,'Software'),(40,'HR');
create table emp3(empid int primary key ,empname varchar(30),
worksin int foreign key 
references dept3(deptid));
insert into emp3 values(101,'ravi',10),
(102,'kiran',20),(103,'mahesh',30),(104,'suresh',20),
(105,'satish',null);

select * from dept3;
select * from emp3;

select e1.empname,d1.deptname from emp3 e1 inner join dept3 d1
on e1.worksin=d1.deptid;

select e1.empname,d1.deptname from emp3 e1 left join dept3 d1
on e1.worksin=d1.deptid;

select e1.empname,d1.deptname from emp3 e1 right join dept3 d1
on e1.worksin=d1.deptid;

select empid,deptname from emp3  inner join dept3 on worksin=deptid;--working
select empid,deptname from emp3  left join dept3 on worksin=deptid;--working
select empid,deptname from emp3  right join dept3 on worksin=deptid;--working


select deptname,empname from dept3 left join emp3 on deptid=worksin
where empname is null
  
select d1.deptname,count(e1.empname) from emp3 e1 join dept3 d1
on e1.worksin =d1.deptid group by d1.deptname

-- give me all the employees who have got location and also dept 
select e1.empname,d1.deptname,l1.locname from emp3 e1 join dept3 d1 on e1.worksin=d1.deptid
join location l1 on e1.empid=l1.empid;

-- give me all the employees who got dept but not locaton 
select e1.empname,d1.deptname,l1.locname from emp3 e1 join dept3 d1 on e1.worksin=d1.deptid
left join location l1 on e1.empid=l1.empid;-- to find null values 

select e1.empname,d1.deptname,l1.locname from emp3 e1 join dept3 d1 on e1.worksin=d1.deptid
left join location l1 on e1.empid=l1.empid where l1.locname is null;-- after this filtering

select e1.empname from emp3 e1 join dept3 d1 on e1.worksin=d1.deptid
left join location l1 on e1.empid=l1.empid where l1.locname is null

-- give me all employees who got location but not dept 

select e1.empname,d1.deptname,l1.locname from emp3 e1 left join dept3 d1 on e1.worksin=d1.deptid
 join location l1 on e1.empid=l1.empid;-- to find null values 

select e1.empname,d1.deptname,l1.locname from emp3 e1 left join dept3 d1 on e1.worksin=d1.deptid
 join location l1 on e1.empid=l1.empid where d1.deptname is null;-- after this filtering

select e1.empname from emp3 e1 left join dept3 d1 on e1.worksin=d1.deptid
 join location l1 on e1.empid=l1.empid where d1.deptname is null


CREATE TABLE Employees_A (
    employee_id INT,
    first_name NVARCHAR(50),
    last_name NVARCHAR(50));

INSERT INTO Employees_A (employee_id, first_name, last_name)
VALUES (1, 'John', 'Doe'),
       (2, 'Jane', 'Smith'),
       (3, 'Alice', 'Johnson');

-- Table: Employees_B
CREATE TABLE Employees_B (
    employee_id INT,
    first_name NVARCHAR(50),
    last_name NVARCHAR(50));

INSERT INTO Employees_B (employee_id, first_name, last_name)
VALUES (2, 'Jane', 'Smith'),
       (3, 'Alice', 'Johnson'),
       (4, 'Bob', 'Brown');

SELECT employee_id, first_name, last_name FROM Employees_A
SELECT employee_id, first_name, last_name FROM Employees_B;

-- Get all distinct employees from both tables
SELECT employee_id, first_name, last_name FROM Employees_A
UNION
SELECT employee_id, first_name, last_name FROM Employees_B;


-- Get the employees that are present in both tables
SELECT employee_id, first_name, last_name FROM Employees_A
INTERSECT
SELECT employee_id, first_name, last_name FROM Employees_B;



-- Get employees that are present in Employees_A but not in Employees_B
SELECT employee_id, first_name, last_name FROM Employees_A
EXCEPT
SELECT employee_id, first_name, last_name FROM Employees_B;


-- Combine UNION, INTERSECT, and EXCEPT in one query
-- Step 1: Find all employees from both tables using UNION
-- Step 2: Find common employees using INTERSECT
-- Step 3: Find employees that are only in Employees_A but not in Employees_B using EXCEPT
SELECT employee_id, first_name, last_name FROM Employees_A
UNION
SELECT employee_id, first_name, last_name FROM Employees_B
INTERSECT
SELECT employee_id, first_name, last_name FROM Employees_A
EXCEPT
SELECT employee_id, first_name, last_name FROM Employees_B;



-- using joins along with set operators 
--------------------------------------------
-- let us take emp1 and dept1 
select * from dept1;
select * from emp1 ;

-- give me all the employees who are working as clerk job or working in dept sales 

select e1.ename from emp1 e1 join dept1 d1 on e1.deptno=d1.deptno where e1.job='CLERK'
union
select e1.ename from emp1 e1 join dept1 d1 on e1.deptno=d1.deptno where d1.dname='SALES'

-- give me all the employees who are working as clerk job and working in dept sales 
select e1.ename from emp1 e1 join dept1 d1 on e1.deptno=d1.deptno where e1.job='CLERK'
intersect 
select e1.ename from emp1 e1 join dept1 d1 on e1.deptno=d1.deptno where d1.dname='SALES'

-- give me all the  employees who are working as clerk job but not in  working in dept sales 
select e1.ename from emp1 e1 join dept1 d1 on e1.deptno=d1.deptno where e1.job='CLERK'
except
select e1.ename from emp1 e1 join dept1 d1 on e1.deptno=d1.deptno where d1.dname='SALES'
----------------------------------------------------------------------------------------------------------------

--assingment
create table students(studentid int ,studentname varchar(30));
insert into students values(1,'john'),(2,'Matt'),(3,'James');
create table classes(classid int ,classname varchar(30));
insert into classes values(1,'art'),(2,'history'),(3,'Maths');
create table studentclass(studentid int,classid int );
insert into studentclass values(1,1),(1,2),(3,1),(3,2),(3,3);

select * from students;
select * from classes;
select * from studentclass;

--Q)what will be best possible join if i want to know 
-- all the students u have taken classes ?

select s1.studentname from students s1 join studentclass sc1 on s1.studentid=sc1.studentid
left join classes c1 on sc1.classid=c1.classid group by s1.studentname--no need of this line only group by needed


--q) what will be the best possible join if we want to retrive 
--all the students who have  not signed for any batches ?

select s1.studentname from students s1 left join studentclass sc1 on s1.studentid=sc1.studentid
WHERE sc1.studentid IS NULL  




--self join 

create table Employee(id int primary key ,
name varchar(50) not null,
managerid int );


insert into employee values(1,'mike',3),(2,'David',3),(3,'Roger',null),(4,'Marry',2),(5,'Joseph',2),
(7,'Ben',2);

select * from employee;


--Q1) give me all the employees with names and their coresspnding manager means display 
-- employee name and manager name as well 

select e1.name as Employeename, e2.name as manager from Employee e1 
join Employee e2 on  e1.managerid=e2.id

--Q2)-- give me the name of the employee also in the list who is not having manager 
-- and if he is top manager of the company tell it as top manager like that okay 
-- hint copy the same above code and for null specify left and use ifnull function over here 
-- like this u can do it for any column by joining any no of tables eventhough u dont 
-- have to perfom self join and instead null display temperorlay some value means use ifnull okay 


 select e1.name as employeename ,isnull(e2.name,'CEO') as manager 
 from  Employee e1 left join Employee e2 on e1.managerid=e2.id;



 --cross join--------- 

select * from dept3 
select * from emp3;

select * from dept3 cross join emp3 ;











