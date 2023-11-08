CREATE OR ALTER PROCEDURE ProcBookSelect
AS
BEGIN
	SELECT * FROM Book
END
GO

CREATE OR ALTER PROCEDURE ProcBookInsert
	@Title NVARCHAR(50),
	@ISBN NVARCHAR(50),
	@PublisherId INT,
	@AuthorId INT,
	@CategoryId INT,
	@BookId INT OUT
AS
BEGIN
	
	INSERT INTO Book
	(
		Title,
		ISBN,
		PublisherId,
		AuthorId,
		CategoryId
	)
	VALUES
	(
		@Title,
		@ISBN,
		@PublisherId,
		@AuthorId,
		@CategoryId
	)

	SET @BookId = @@IDENTITY
END
GO

CREATE OR ALTER PROCEDURE ProcBookUpdate
	@Title NVARCHAR(50),
	@ISBN NVARCHAR(50),
	@PublisherId INT,
	@AuthorId INT,
	@CategoryId INT,
	@BookId INT
AS
BEGIN
	UPDATE Book
	SET 
		Title = @Title,
		ISBN = @ISBN,
		PublisherId = @PublisherId,
		AuthorId = @AuthorId,
		CategoryId = @CategoryId
	WHERE 
		BookId = @BookId
END
GO

CREATE OR ALTER PROCEDURE ProcBookDelete
	@BookId INT
AS
BEGIN
	DELETE FROM Book
	WHERE BookId = @BookId
END
GO

CREATE OR ALTER PROCEDURE ProcAuthorSelect
AS
BEGIN
	SELECT * FROM Author
END
GO

CREATE OR ALTER PROCEDURE ProcAuthorInsert
	@AuthorName NVARCHAR(50),
	@AuthorId INT OUT
AS
BEGIN
	
	INSERT INTO Author
	(
		AuthorName
	)
	VALUES
	(
		@AuthorName
	)

	SET @AuthorId = @@IDENTITY
END
GO

CREATE OR ALTER PROCEDURE ProcAuthorUpdate
	@AuthorName NVARCHAR(50),
	@AuthorId INT
AS
BEGIN
	UPDATE Author
	SET 
		AuthorName = @AuthorName
	WHERE 
		AuthorId = @AuthorId
END
GO

CREATE OR ALTER PROCEDURE ProcAuthorDelete
	@AuthorId INT
AS
BEGIN
	DELETE FROM Author
	WHERE AuthorId = @AuthorId
END
GO

CREATE OR ALTER PROCEDURE ProcPublisherSelect
AS
BEGIN
	SELECT * FROM Publisher
END
GO

CREATE OR ALTER PROCEDURE ProcPublisherInsert
	@PublisherName NVARCHAR(50),
	@PublisherId INT OUT
AS
BEGIN
	
	INSERT INTO Publisher
	(
		PublisherName
	)
	VALUES
	(
		@PublisherName
	)

	SET @PublisherId = @@IDENTITY
END
GO

CREATE OR ALTER PROCEDURE ProcPublisherUpdate
	@PublisherName NVARCHAR(50),
	@PublisherId INT
AS
BEGIN
	UPDATE Publisher
	SET 
		PublisherName = @PublisherName
	WHERE 
		PublisherId = @PublisherId
END
GO

CREATE OR ALTER PROCEDURE ProcPublisherDelete
	@PublisherId INT
AS
BEGIN
	DELETE FROM Publisher
	WHERE PublisherId = @PublisherId
END
GO

CREATE OR ALTER PROCEDURE ProcCategorySelect
AS
BEGIN
	SELECT * FROM Category
END
GO

CREATE OR ALTER PROCEDURE ProcCategoryInsert
	@CategoryName NVARCHAR(50),
	@CategoryId INT OUT
AS
BEGIN
	
	INSERT INTO Category
	(
		CategoryName
	)
	VALUES
	(
		@CategoryName
	)

	SET @CategoryId = @@IDENTITY
END
GO

CREATE OR ALTER PROCEDURE ProcCategoryUpdate
	@CategoryName NVARCHAR(50),
	@CategoryId INT
AS
BEGIN
	UPDATE Category
	SET 
		CategoryName = @CategoryName
	WHERE 
		CategoryId = @CategoryId
END
GO

CREATE OR ALTER PROCEDURE ProcCategoryDelete
	@CategoryId INT
AS
BEGIN
	DELETE FROM Category
	WHERE CategoryId = @CategoryId
END
GO