CREATE DATABASE [TripApp]

USE [TripApp]

CREATE TABLE [Roles]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE [Users]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[FirstName] NVARCHAR(50) NOT NULL
	,[LastName] NVARCHAR(50) NOT NULL
	,[PhoneNumber] NVARCHAR(13) 
	,[Email] NVARCHAR(100) NOT NULL
	,[PasswordHashed] NVARCHAR(MAX) NOT NULL
	,[Country] NVARCHAR(50) 
	,[City] NVARCHAR(50) 
	,[IsEmailConfirmed] BIT
	,[IsSubscriptionPaid] BIT
	--,[VehicleId] INT FOREIGN KEY REFERENCES [Vehicles]([Id]) NULL
	,[RoleId] INT FOREIGN KEY REFERENCES [Roles]([Id]) NOT NULL
	,[IsDeleted] BIT
	,[Salt] NVARCHAR(MAX) NOT NULL
)

CREATE TABLE [Posts]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[FromDestination] NVARCHAR(50) NOT NULL
	,[ToDestination] NVARCHAR(50) NOT NULL
	,[Description] NVARCHAR(500) NOT NULL
	,[PriceForSeat] DECIMAL(18,2)
	,[FreeSeats] INT
	,[Baggage] BIT
	,[Pets] BIT
	,[IsCompleted] BIT
	,[DateAndTime] DATETIME2
	,[CreatorId] INT FOREIGN KEY REFERENCES[Users]([Id]) NOT NULL
	--,[GroupId] INT FOREIGN KEY REFERENCES[Groups]([Id]) NULL
	,[IsActive] BIT
)

CREATE TABLE [Groups]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[PostId] INT FOREIGN KEY REFERENCES[Posts]([Id]) NOT NULL
	,[CreatorId] INT FOREIGN KEY REFERENCES[Users]([Id]) NOT NULL
	,[IsDeleted] BIT
)

ALTER TABLE [Posts]
ADD [GroupId] INT FOREIGN KEY REFERENCES[Groups]([Id]) NULL

CREATE TABLE [Logs]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[Text] NVARCHAR(300) NOT NULL
	,[UserId] INT FOREIGN KEY REFERENCES[Users]([Id]) NULL
	,[DateTime] DATETIME2 NOT NULL
)

CREATE TABLE [Messages]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[Text] NVARCHAR(1000) NOT NULL
	,[CreatorId] INT FOREIGN KEY REFERENCES[Users](Id) NOT NULL
	,[GroupId] INT FOREIGN KEY REFERENCES[Groups](Id) NOT NULL
	,[SendTime] DATETIME2 NOT NULL
	,[IsDeleted] BIT
)

CREATE TABLE [Reviews]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[CreatorId] INT FOREIGN KEY REFERENCES[Users]([Id]) NOT NULL
	,[Rating] INT
	,[Text] NVARCHAR(300) NULL
	,[ReciverId] INT FOREIGN KEY REFERENCES[Users]([Id]) NOT NULL
	,[IsDeleted] BIT
)

CREATE TABLE [UsersGroups]
(
	[UserId] INT FOREIGN KEY REFERENCES[Users]([Id]) NOT NULL
	,[GroupId] INT FOREIGN KEY REFERENCES[Groups]([Id]) NOT NULL
	,PRIMARY KEY([UserId], [GroupId])
)

CREATE TABLE [UsersSubscriptions]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[UserId] INT FOREIGN KEY REFERENCES[Users]([Id])
	,[IsPaid] BIT
	,[DateTimePaid] DATETIME2
)

CREATE TABLE [Vehicles]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[Brand] NVARCHAR(50) NOT NULL
	,[Model] NVARCHAR(50) NOT NULL
	,[Year] INT
	,[Fuel] INT
	,[OwnerId] INT FOREIGN KEY REFERENCES[Users]([Id]) NOT NULL
	,[SeatCount] INT
	,[PictureLink] NVARCHAR(MAX) NULL
	,[ACSystem] BIT
)

ALTER TABLE [Users]
ADD [VehicleId] INT FOREIGN KEY REFERENCES [Vehicles]([Id]) NULL

CREATE TABLE [VerificationEmails]
(
	[Id] INT PRIMARY KEY IDENTITY
	,[Email] NVARCHAR(100) NOT NULL
	,[IsVerified] BIT
	,[UserId] INT FOREIGN KEY REFERENCES[Users]([Id])
)