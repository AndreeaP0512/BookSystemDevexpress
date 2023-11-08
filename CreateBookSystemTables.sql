IF NOT EXISTS 
(
	SELECT 1 FROM sys.tables WHERE name = 'Author'
)
BEGIN
    CREATE TABLE [Author]
	(
		[AuthorId] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
		[AuthorName] NVARCHAR(50) NOT NULL UNIQUE
	)
END
GO

IF NOT EXISTS 
(
	SELECT 1 FROM sys.tables WHERE name = 'Category'
)
BEGIN
    CREATE TABLE [Category]
	(
		[CategoryId] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
		[CategoryName] NVARCHAR(50) NOT NULL UNIQUE
	)
END
GO

IF NOT EXISTS 
(
	SELECT 1 FROM sys.tables WHERE name = 'Publisher'
)
BEGIN
    CREATE TABLE [Publisher]
	(
		[PublisherId] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
		[PublisherName] NVARCHAR(50) NOT NULL UNIQUE
	)
END
GO

IF NOT EXISTS 
(
	SELECT 1 FROM sys.tables WHERE name = 'Book'
)
BEGIN
    CREATE TABLE [Book]
	(
		[BookId] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
		[Title] NVARCHAR(50) NOT NULL UNIQUE,
		[ISBN] NVARCHAR(50) NOT NULL UNIQUE,
		[PublisherId] INT NOT NULL FOREIGN KEY REFERENCES [Publisher] ([PublisherId]),
		[AuthorId] INT NOT NULL FOREIGN KEY REFERENCES [Author] ([AuthorId]),
		[CategoryId] INT NOT NULL FOREIGN KEY REFERENCES [Category] ([CategoryId])
	)
END
GO

