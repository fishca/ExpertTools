﻿USE [DATABASE_NAME];
BULK INSERT [TABLE_NAME]
FROM '[BULK_FILE_PATH]'
WITH (FIRSTROW = 2, CODEPAGE = '1251', FIELDTERMINATOR = '[FIELD_SEPARATOR]', ROWTERMINATOR = '[ROW_SEPARATOR]')