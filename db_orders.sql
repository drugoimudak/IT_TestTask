CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [date] DATE NOT NULL, 
    [org] VARCHAR(50) NOT NULL, 
    [city] VARCHAR(50) NOT NULL, 
    [country] NVARCHAR(50) NOT NULL, 
    [manager] NVARCHAR(50) NOT NULL, 
    [quantity] BIGINT NOT NULL, 
    [total] DECIMAL(18, 2) NOT NULL
)
