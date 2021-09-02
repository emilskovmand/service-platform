MERGE INTO Countries AS TARGET
USING (VALUES
	(1, 'The Kingdom of Denmark', 'Denmark', '+45', 'DK'),
	(2, 'The Kingdom of Sweden', 'Sweden', '+46', 'SWE'),
	(3, 'The Kingdom of Norway', 'Norway', '+47', 'NO'),
	(4, 'The Republic Of Poland', 'Poland', '+48', 'PL'),
	(5, 'The Federal Republic of Germany', 'Germany', '+49', 'DE'),
	(6, 'The French Republic', 'France', '+49', 'FR'),
	(7, 'The French Republic', 'France', '+49', 'FR'),
	(8, 'The Kingdom of England', 'England', '+44', 'EN')
)
AS SOURCE (CountryId, OfficialName, ShortName, CountryCode, CountryInitials)
ON TARGET.CountryId = Source.CountryId
WHEN MATCHED THEN
	UPDATE SET 
		OfficialName = Source.OfficialName,
		ShortName = Source.ShortName,
		CountryCode = Source.CountryCode,
		CountryInitials = Source.CountryInitials
WHEN NOT MATCHED BY TARGET THEN
	INSERT (CountryId, OfficialName, ShortName, CountryCode, CountryInitials)
	VALUES (CountryId, OfficialName, ShortName, CountryCode, CountryInitials);