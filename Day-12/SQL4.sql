use wipro26 
go

-- Display all tables in the current database 

select * from INFORMATION_SCHEMA.TABLES
GO

-- Display Info about Employ table 

sp_help Agent
GO

-- Display all records from Employ Table 

select * from Employ
GO

-- Implementing Projection (Empno, Name, Gender, Basic) from Employ Table 

select Empno, Name, Gender, Basic
from Employ
GO

-- Where Clause : Used to display Filtered Records 

-- Display info whose Empno is 1

select * from Employ WHERE Empno = 1 
GO

-- Display info whose Basic > 80000

select * from Employ WHERE Basic > 80000 
GO 

-- Display Info whose Dept is 'Dotnet' 

select * from Employ WHERE Dept='Dotnet'
GO

-- Display Info whose Gender is 'MALE'

select * from Employ where Gender = 'MALE'
GO

-- Display info about Agent table 

sp_help Agent 
GO

-- Between...AND : Used to display records from start to end 

select * from Employ WHERE Basic BETWEEN 85000 and 99000
GO

select * from Employ WHERE Basic NOT BETWEEN 85000 and 99000
GO



-- IN  Clause : Used to display multiple values of particular attribute 

select * from Employ WHERE Dept IN('Java','Dotnet')
GO



select * from Employ WHERE Dept NOT IN('Java','Dotnet')
GO



-- LIKE Operator : Used to display records w.r.t. Wild Cards 

-- Display records whose name starts with 'S' of Agent table





-- Order By : Used to display records on Particular field(s) in ascending or desc order

select * from Employ
GO

select * from Employ Order By Name 
Go

select * from Employ ORDER By Basic DESC
GO

SELECT * FROM Employ ORDER By Dept, Name 
GO

SELECT * FROM Employ ORDER By Dept, Name DESC
GO



-- TOP Keyword : Used to display top records based on condition

select * from Employ ORDER BY Basic DESC
GO

select TOP 3 * from Employ ORDER BY Basic DESC
GO



-- Distinct : Used to remove duplicate entries at the time of display 

select dept from Employ 
GO

select distinct DEPT From Employ
GO

select * from Employ
GO
-- Generate column at runtime as 'MANAGER' FOR Java Ronald For Dotnet Nissy For SQL Vinod 

select Empno, Name,Dept,Basic ,
CASE Dept 
   WHEN 'JAVA' THEN 'Ronald'
   WHEN 'Dotnet' THEN 'Nissy'
   WHEN 'SQL' THEN 'Vinod'
END 'Manager'
from Employ
GO