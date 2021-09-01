CREATE TABLE [dbo].[ServiceUser]
(
	[Id] NVARCHAR(128) NOT NULL,
	[FirstName] nvarchar(256) NOT NULL,
	[LastName] nvarchar(256) NOT NULL,
	[Email] NVARCHAR(256) NOT NULL,
	[NormalizedEmail] NVARCHAR(256) NOT NULL,
	[PasswordHash] NVARCHAR(MAX) NULL,
	[TwoFactorEnabled] BIT NOT NULL DEFAULT 0,
	[DateOfCreation] DATETIME2 NOT NULL DEFAULT getdate(),
	[PhoneNumber] NVARCHAR(MAX) NULL,
	[PhoneNumberConfirmed] BIT NOT NULL DEFAULT 0,
	[Corporation] BIT NOT NULL,
	[CorporationId] NVARCHAR(128) NULL,
	CONSTRAINT [PK_dbo.ServiceUser] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_ServiceUser_Corporation] FOREIGN KEY ([CorporationId]) REFERENCES [dbo].[ServiceCorporation] ([CorporationId])
)