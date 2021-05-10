SELECT * FROM Armamentos
DELETE FROM Armamentos
DBCC CHECKIDENT('[Armamentos]', RESEED, 0)