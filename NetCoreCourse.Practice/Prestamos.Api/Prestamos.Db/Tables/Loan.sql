CREATE TABLE [dbo].[Loan]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Date] DATETIME NOT NULL, 
    [ReturnDate] DATETIME NULL, 
    [Status] NCHAR(10) NOT NULL,
    [PersonId] INT NOT NULL,
    [ThingId] INT NOT NULL
 )
 GO
ALTER TABLE [dbo].[Loan]  ADD  CONSTRAINT [FK_Loan_Person_PersonId] FOREIGN KEY([PersonId]) REFERENCES [dbo].[Person] ([Id])
GO
 GO
ALTER TABLE [dbo].[Loan]  ADD  CONSTRAINT [FK_Loan_Thing_ThingId] FOREIGN KEY([ThingId]) REFERENCES [dbo].[Thing] ([Id])
GO