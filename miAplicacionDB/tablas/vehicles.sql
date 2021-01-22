CREATE TABLE [dbo].[clientes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [last_longitude ] FLOAT NULL, 
    [last_latitude ] FLOAT NULL, 
    [battery] INT NULL, 
    [last_checkin] DATETIME NULL, 
    [in_use] BIT NULL, 
    [vehicle_type] NVARCHAR(50) NOT NULL
)
