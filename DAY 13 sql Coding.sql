CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50)
);
-- here identity means u will not create primary key system will create the primary key from where it will start 
--it is written theere 1,1 means 1 is starting point and i will increment by 1 i will not provie values while entering or inserting 


-- Insert some sample data
INSERT INTO Employees (FirstName, LastName, Department)
VALUES 
('John', 'Doe', 'HR'),
('Jane', 'Smith', 'Engineering'),
('Mark', 'Brown', 'Sales');

select * from Employees

delete from Employees where Department='Engineering';

insert into Employees values('Mark1', 'Brown1', 'Sales1');

truncate table Employees ;

--truncate table Employees where Department='Engineering';
-- first difference which i am seeing it above is i will not use where clasue in truncate command 

--now let us take another table 
drop table EmpInfo
create table EmpInfo(empid int identity(1,1) primary key ,empname varchar(40),
salary int )

insert into EmpInfo values('ravi',34000);
insert into EmpInfo values('suresh',45000)
insert into EmpInfo values('sita',39000)

select * from EmpInfo

delete EmpInfo

insert into EmpInfo values('jyothi',59000)

insert into EmpInfo values('satish',34000);
insert into EmpInfo values('monika',45000)
insert into EmpInfo values('madhu',39000)


truncate table EmpInfo 

insert into EmpInfo values('satish1',34000);
insert into EmpInfo values('monika1',45000)
insert into EmpInfo values('madhu1',39000)


---alter commands 
--it is used to modify the structure of exsisting table using which u can perform any of the following tasks 

--1)change the datatype of the column 
--2)Increase or Decrese the width of the columnm
--3)change  null to not null and not null to null 
--4)add a new column 
--5)drop an exsisting column 
--6)add a new constraint
--7)drop an exisiting constraint .
create table students (sno int,sname varchar(50),class int)

insert into students values (101,'ravi',12)
insert into students values(102,'kumar',4)
insert into students values (103,'senthil',8)

select * from students;

--for 1,2,3 
-- alter table <Tname> alter column <colname><dtype>[width][notnull/null]

-- always change data type in compatible manner only mean  string to string or number to number 

-- change varchar to char or int to decimal like that 

alter table students alter column sname char(60) not null;

sp_help students-- to check type has been chnaged or not 

--adding a new column 

--alter table <Tname> add <colname> <dtype><width>[not null]
--[constraint <cname>] 

alter table students add city varchar(40) not null -- this command is giving error 

-- above command will not work with not null both creation of new column and  filling 
-- the values at a time is not possible 

-- so i will write like ths 

alter table students add city varchar(40)

select * from Students;

--now run select u can see a column added wit null values 

--101	ravi                                                        	12	NULL
--102	kumar                                                       	4	NULL
--103	senthil                                                     	8	NULL

--so a I am getting values like this but u know i want to put not null also along with adding column 
--so updae nulll values then u add frist command which is adding null with change of type which i will not do 

update students set city ='Hyderabad' where sno in (101,102,103)

-- go to first command see above formula 

--alter table <Tname> alter column <colname><dtype>[width][notnull/null]

alter table students alter column city varchar(40) not null -- now it will work 

-- drop an exisiting column 
--alter table <Tname> drop column <colname>

alter table students drop column city 

select * from students

-- adding a new constraint 

--alter table <Tname> add [constraint<const_name>]
--typeofconstraint(<collist>)
-- adding  a constraint on class column 
alter table students add constraint ck12 check(class <=12);

insert into students values(104,'sohan',14);--error

--dropping a constraint
--alter table <table_name> drop constraint <constraint_name>
alter table students drop constraint ck12


insert into students values(104,'sohan',14) -- now no error as constraint is removed


-- can i add primary key for the above which is one type of constraint same formuala

--alter table <Tname> add [constraint<const_name>]
--typeofconstraint(<collist>)

alter table students add constraint pk34 primary key(sno);-- error 

--why because column is nulllable first make the column not null using first formuaa

--alter table <Tname> alter column <colname><dtype>[width][notnull/null]
alter table students alter column sno int not null

-- after making not null now apply that formuals of adding constraint 

alter table students add constraint pk34 primary key(sno) -- now no error 

--now primary key is applied 

sp_help students

-- can  i remove primay key constraint 

alter table students drop constraint pk34;

--yes i can remove 

--Transaction Demo 

CREATE TABLE Employeedata (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50)
);
--code for rollback transaction 
-----------------------------------

BEGIN TRANSACTION;
DECLARE @EmpID INT;
-- Insert a new employee and get the generated EmployeeID
INSERT INTO Employeedata (FirstName, LastName, Department) 
VALUES ('ravi1', 'kumar1', 'software1');

SET @EmpID = SCOPE_IDENTITY(); -- Get the last inserted ID

-- Update the inserted employee
UPDATE Employeedata SET Department='Testing' WHERE EmployeeID = @EmpID;

-- Force rollback by checking for an ID that does not exist
IF NOT EXISTS (SELECT * FROM Employeedata WHERE EmployeeID = 9999) -- EmployeeID 9999 does not exist
BEGIN
    PRINT 'Error: Employee not found, rolling back the transaction';
    ROLLBACK TRANSACTION;
END
ELSE
BEGIN
    PRINT 'No errors, committing transaction';
    COMMIT TRANSACTION;
END
--checking ---

select * from Employeedata

-------code for commit transaction ----
BEGIN TRANSACTION;

DECLARE @EmpID1 INT;

-- Insert a new employee and get the generated EmployeeID
INSERT INTO Employeedata (FirstName, LastName, Department) 
VALUES ('ravi1', 'kumar1', 'software1');

SET @EmpID1 = SCOPE_IDENTITY(); -- Get the last inserted ID

-- Update the inserted employee
UPDATE Employeedata SET Department='Testing' WHERE EmployeeID = @EmpID1;

-- Check if the employee exists
IF NOT EXISTS (SELECT * FROM Employeedata WHERE EmployeeID = @EmpID1)
BEGIN
    PRINT 'Error: Employee not found, rolling back the transaction';
    ROLLBACK TRANSACTION;
END
ELSE
BEGIN
    PRINT 'No errors, committing transaction';
    COMMIT TRANSACTION;
END


--chekcing transaction 

select * from Employeedata

---code for savepoint ------

BEGIN TRANSACTION;
DECLARE @EmpID3 INT;

-- Insert a new employee and get the generated EmployeeID
INSERT INTO Employeedata (FirstName, LastName, Department) 
VALUES ('ravi3', 'kumar3', 'software3');
save transaction savepoint1;
SET @EmpID3 = SCOPE_IDENTITY(); -- Get the last inserted ID
-- Update the inserted employee
UPDATE Employeedata SET Department='Testing6' WHERE EmployeeID = @EmpID3;

-- Check if the employee exists
IF NOT EXISTS (SELECT * FROM Employeedata WHERE EmployeeID = 999)
BEGIN
   PRINT 'An error occurred, rolling back only part of the transaction';
    ROLLBACK TRANSACTION savepoint1; -- Rollback to before Employee 2 insert
    PRINT 'Rolled back the error, but Employee is only inserted but that is not updated ';
END
ELSE
BEGIN
    PRINT 'No errors, committing transaction';
    COMMIT TRANSACTION;
END

-- chekcing whether save point is applied or not 

select * from Employeedata ;

---scalar functions 

--CREATE FUNCTION <function_name>
--(@input_variables  type)
--RETURNS data_type of result returned by function
--AS
--BEGIN
--.....  SQL Statements
--    RETURN (data_value)
--END
--demo1 

create function multiply(@x int ,@y int)
returns int
as
begin
return @x*@y;
end 

select dbo.multiply(12,3);

select * from students

select dbo.multiply(sno,class) from students;

--example 2 on scalar function 
--____________________________
create table orders(orderid int primary key ,orderdate datetime,
whichcustomer varchar(10))

insert into orders values(101,'1996-08-01','c01')
insert into orders values(102,'1997-04-02','c01')
insert into orders values(103,'2012-08-01','c01')
insert into orders values(104,'2013-08-05','c02')
insert into orders values(105,'2014-08-01','c02')

select * from orders;
--write a function to find last or latest  order ordered by the given customer ..
-- having two customers i will give customer id which is whichcustomer you have to 
-- tell me his latest order usingn a function

create function findlatestorder(@custid varchar(10))
returns datetime
as begin
declare @recentorder datetime;

select @recentorder= max(orderdate) from orders where whichcustomer=@custid;
return @recentorder;
end 

select dbo.findlatestorder('c01')

--suppose u want to alter the fucntion like u didint like the variable name 
-- @recentorder1 u can do it so for available functions only  u can alter 
-- dont alter the function which is not there 

alter function findlatestorder(@custid varchar(10))
returns datetime
as begin
declare @recentorder1 datetime;

select @recentorder1= max(orderdate) from orders where whichcustomer=@custid;
return @recentorder1;
end 

--Example 3 on scalar function 
--__________________________________
create table Books(
title_id varchar(10),
pages int,
qty_sold int)

insert into Books values('bo101',200,89)
insert into Books values('b0102',300,79)
insert into Books values('b0103',700,85)

select * from Books
--Q) write a function on this table which will give me no of books sold
--based on id value u provide to the function ?

create function copies_sold(@title_id varchar(10))
returns int
as
begin 
declare @quantity int;
select @quantity=0;
select @quantity=qty_sold from Books where title_id=@title_id
return @quantity;
end 

select dbo.copies_sold('bo101')


--syntax:
----------



--create function <function_name> (parameters-list)
--returns @table Table (list_of_column_names)
--as
--begin 
--insert @table 
----------
-------
--end 


---- Example on inline table valued function 
--_______________________________________________
create table employee_info(
     ID          int,
     name        varchar (10),
     salary      int,
     start_date  datetime,
     city       varchar (10),
     region      char (1))

insert into employee_info
               values (1,  'Jason', 40420,  '02/01/94', 'New York', 'W')
 insert into employee_info 
               values (2,  'Robert',14420,  '01/02/95', 'Vancouver','N')
 insert into employee_info 
               values (3,  'Celia', 24020,  '12/03/96', 'Toronto',  'W')

select * from employee_info
select name ,'hello' from employee_info

-- write a inline table value function to find employees in the region 

--create function <function_name>(parameters_list)
--returns table as
--return (<any select command which will give me resultset>)

alter function listemp (@region char(1))
returns table as 
return select * from employee_info where region=@region;


select * from listemp('W')

-- write a multiline table value function to find employees in the region 

--create function <function_name> (parameters-list)
--returns @table Table (list_of_column_names)
--as
--begin 
--insert @table 
----------
-------
--end 

create function listempmultiline(@region char(1))
returns @table Table 
(
 ID  int not null,
 name  varchar (50),
 city       varchar (40),
 message varchar(100)
)
as 
begin
if exists(select ID,name,city from employee_info where region=@region)

begin
insert into @table(ID,name,city,message)
select ID,name,city,'present in that region' from employee_info where region=@region;
end

else

begin
insert into @table(ID,name,city,message) values(0,'Nodata','Nodata','No values are there in the table for that region');

end
return;
end

select * from listempmultiline('Z')

--1)Mathematical functions:
--_______________________

--a) abs(n) : it returns a absolute value of given number n
   eg: select abs(-12)=12
--b)square(n) : It return the square of n
eg: select square(25)=9
--c)sqrt(n) :it will give u square root of n
eg: select sqrt(4)=2
--d)power(n,m) :it will give u n to the power of m value
eg:select power(2,3) =8
--e)round(n,size):it will round a value n is the value 
--and size is how many values to round
eg:select round(156.6789,2)=156.68
     select round(156.6789,0)=157
      select round(156.6789,-1)=160
--f)ceiling(n) :it returns an least integer greater than n
  eg: select ceiling(15.6)=16
         select ceiling (-15.6)=-15
--g)floor(n) :it returns the highest integer less than given n
eg: select floor(15.6)=15
select floor(-15.6)=-16

--2)String functions :strings are nothing but set of chracters so these
--string functions can also be applied to columns having string values.
--_________________________________________________
a) Ascii(s): it returns ascii value of first character in the given string 
eg: select ascii('D')=65
select ascii('def')=100
b)char(n):This is reverse of ascii it takes ascii value 
and returns the character represented by it
eg: select char(65)=A
c)Len(s) : it returns length of given string
eg:select len('Tanzania')=8
select len(Title) from HumanResources.Employee
d)lower(s):it return given string converted into lower case
eg: select left(Title,3) from HumanResources.Employee
e)upper(s):it retuen the given string converted in upper case
eg: select upper('apple')=APPLE
f)  left(s,n) it returns the selected n no of  characters from left
   side of given string
  eg: select  left('Hello',3)=Hel
g)right(s,n) : same as above but from right 
h)substring (s,start,length) :it returns part of string from a given string
    s 
eg: select substring('Hello',1,3)=Hel

g) reverse(n): it returns the given string in reverse order.
eg:select reverse('Hello')=0lleH
h)Ltrim(s) : it eilimates empty character that are present in left side 
of given string s
select Rtrim('hello             ')
eg: select Ltrim('       hello')=hello
i)Rtrim (s) : is is ame as left but at right side we eliminate spaces 
from the given string
eg: select Rtrim('heloo     ')=heloo
j)replace (s,searchstr,replacestr): it replaces each occurence of 
searchstr with replacestr in the given string s
select replace('Hello world','o','x')=Hellx wxrld
k)stuff(s,start,length,replacestr):
it repalces specified no of characters with replace string in the 
given string s
eg: select stuff('abxxcdxx',3,2,'yy')=abyycdxx
select stuff('abxxcdxx',3,2,'yy')



3) Date functions ; 
-----------------------
a)getdate( ) : To get todays date we use getdate( ) function 
 eg: select getdate() as Todaysdate

b) datediff: calculates the no of  date parts between two dates.

   select datediff(mm,'01/01/1990',getdate( ) ) as Ageinmonths
   select datediff(yy,'7/8/1982' ,getdate( )) as Ageinyears
   select datediff(hh,'7/8/1982',getdate() ) as Ageinhours
  select datediff(dd,'7/8/1982',getdate( )) as Ageindays
  select datediff(mi,'7/8/1982',getdate( )) as Age
 
 c) dateadd: It returns the datepart listed from the listed 
date as integer.

    select dateadd(mm,30,getdate( ) )

  d) datename(datepart,d) :it is used for picking any specified 
     date part value from the given date d

   Note: seconds=ss,year =yy,quarter=q,month =mm,
             day =dd,day of the year =dy,weak of the year=wk,
             milliseconds=ms,weekday=dw,hours=hh,minutes=mi

  eg:   select datename(dw,getdate( ))=monday


  4) Conversion functions :
-------------------------
--when we want to convert one data type to another we go for 
--conversion functions they  are of two types
a)conversion functions :
_______________________________

convert(varchar,@x) --here @x is converted to varchar type 
cast(@x as varchar) -- here again @x is converted into varchar type @x can be of any type 

declare @age int ;
declare @name varchar(30)
set @name='ravi'
set @age=23;
print 'The person with the name '+Convert(varchar(30),@name)+' is having '+Convert(varchar(30),@age) +' years of age ';
print 'The person with the name '+@name+' is having '+Convert(varchar(30),@age) +' years of age '; 
print 'The person with the name '+cast(@name as varchar)+' is having '+cast(@age as varchar) +' years of age ';


--- what ever code i had wrttien is temperroy





