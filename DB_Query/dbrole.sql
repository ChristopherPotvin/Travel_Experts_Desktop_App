--create users within a given database (databse must be selected)

CREATE USER AndrewM
FOR LOGIN AndrewM
WITH DEFAULT_SCHEMA = dbo
GO

CREATE USER ChrisP
FOR LOGIN ChrisP
WITH DEFAULT_SCHEMA = dbo
GO

CREATE USER PeterO
FOR LOGIN PeterO
WITH DEFAULT_SCHEMA = dbo
GO

CREATE USER runner
FOR LOGIN runner
WITH DEFAULT_SCHEMA = dbo
GO

--Assign roles for different users

EXEC sp_addrolemember 'db_owner', 'AndrewM'
EXEC sp_addrolemember 'db_datawriter', 'AndrewM'
EXEC sp_addrolemember 'db_datareader', 'AndrewM'
EXEC sp_addrolemember 'db_ddladmin', 'AndrewM'
GO

EXEC sp_addrolemember 'db_owner', 'ChrisP'
EXEC sp_addrolemember 'db_datawriter', 'ChrisP'
EXEC sp_addrolemember 'db_datareader', 'ChrisP'
EXEC sp_addrolemember 'db_ddladmin', 'ChrisP'
GO

EXEC sp_addrolemember 'db_owner', 'PeterO'
EXEC sp_addrolemember 'db_datawriter', 'PeterO'
EXEC sp_addrolemember 'db_datareader', 'PeterO'
EXEC sp_addrolemember 'db_ddladmin', 'PeterO'
GO

EXEC sp_addrolemember 'db_datawriter', 'runner'
EXEC sp_addrolemember 'db_datareader', 'runner'
GO