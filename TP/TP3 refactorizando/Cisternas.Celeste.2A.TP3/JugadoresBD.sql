USE WikiCrafteoDB;

DBCC CHECKIDENT(JUGADORES, RESEED,0) --ACTUALIZO PRIMARY KEY
DELETE FROM JUGADORES --BORRAR



INSERT INTO JUGADORES (USUARIO,CAPACIDAD_INVENTARIO)
VALUES
('celes22',20),
('UTN',10),
('Ger0',15),
('KIRA',5),
('zayles',3),
('ali3n',3),
('2A',3);