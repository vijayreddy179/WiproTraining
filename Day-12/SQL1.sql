/* String Functions */ 

/* charindex() : Used to display the first occurence
of the given character */ 

SELECT CHARINDEX('l','hello');
GO

SELECT Name, CHARINDEX('a', Name) AS PositionOfA
FROM Employ;
GO
/* Reverse() : used to display name in reverse order */

SELECT REVERSE('Vijay');
GO

SELECT Name, REVERSE(Name) AS ReversedName
FROM Employ;
GO

/* Left() : used to display no.of left-side chars */ 

SELECT LEFT('Vijay',4);
GO

SELECT Name, LEFT(Name,3) AS LeftChars
FROM Employ;
GO

/* Right() : Used to display no.of right-side chars */ 

SELECT RIGHT('Vijay',4);
GO

SELECT Name, RIGHT(Name,3) AS RightChars
FROM Employ;
GO

/* Len() : Used to display the length of given string */ 

SELECT LEN('vamsi');
GO

SELECT Name, LEN(Name) AS NameLength
FROM Employ;
GO

/* Subsring() : Used to display the part of the string */

SELECT SUBSTRING('welcome to sql',2,3);
-- starts at position 2, prints 3 characters
GO

SELECT Name, SUBSTRING(Name,1,4) AS ShortName
FROM Employ;
GO-- from 2nd char it prints 3 chars 

/* Replace() : used to display the part of the string */ 

SELECT REPLACE('Java Training','Java','SQL');
GO

SELECT Name, REPLACE(Name,'a','@') AS ModifiedName
FROM Employ;
GO

SELECT * FROM Employ;