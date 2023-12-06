CREATE TABLE [dbo].[Thing]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(50) NOT NULL, 
    [CreationDate] DATETIME NOT NULL ,
    [CategoryId] INT NOT NULL,
)
