CREATE TABLE [dbo].[CustomerUser]
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
	CONSTRAINT [PK_dbo.CustomerUser] PRIMARY KEY CLUSTERED ([Id] ASC),
)
