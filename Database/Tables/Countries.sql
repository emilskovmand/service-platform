CREATE TABLE [dbo].[Countries]
(
	[CountryId] INT NOT NULL,
	[OfficialName] NVARCHAR(MAX),
	[ShortName] NVARCHAR(256),
	[CountryCode] NVARCHAR(128),
	[CountryInitials] NVARCHAR(10),
	CONSTRAINT [PK_dbo.Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
)
