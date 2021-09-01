CREATE TABLE [dbo].[ServiceCorporation]
(
	[CorporationId] NVARCHAR(128) NOT NULL,
	[Navn] NVARCHAR(256) NOT NULL,
	[CVR] NVARCHAR(MAX) NOT NULL,
	[VATNumber] NVARCHAR(MAX) NOT NULL,
	[CountryId] NVARCHAR(MAX) NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	[DateOfCreation] DATETIME2 NOT NULL DEFAULT getdate(),
	[CorporationPhoneNumber] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_dbo.ServiceCorporation] PRIMARY KEY CLUSTERED ([CorporationId] ASC)
)
