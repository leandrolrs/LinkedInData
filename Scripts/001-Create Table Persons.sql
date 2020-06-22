CREATE TABLE dbo.Persons
	(
	PersonId int NOT NULL,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	CurrentRole varchar(150) NULL,
	Country varchar(100) NULL,
	Industry varchar(100) NULL,
	NumberOfRecommendations int NULL,
	NumberOfConnections int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Persons ADD CONSTRAINT
	PK_Persons PRIMARY KEY CLUSTERED 
	(
	PersonId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
