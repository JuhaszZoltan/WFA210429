--CREATE DATABASE hasznaltkombajn;
--USE hasznaltkombajn;

CREATE TABLE tulajdonos(
id INT PRIMARY KEY,
nev VARCHAR(255),
telefonszam CHAR(12));

CREATE TABLE kombajn(
id INT PRIMARY KEY IDENTITY,
tipus VARCHAR(255),
gyartasiEv INT,
tulajdonosId INT FOREIGN KEY REFERENCES tulajdonos(id),
atvevoHely VARCHAR(255),
iranyAr INT NULL);

INSERT INTO tulajdonos VALUES
(1,'Csiga János',  '+36203948510'),
(2,'Nekeress Pál', '+36304456110'),
(3,'Bödő Jóska',   '+36203122233'),
(4,'Vajling Vera', '+36303000122'),
(5,'Benkó Pista',  '+36707323448');

INSERT INTO kombajn VALUES
('John Deere W540',                2008, 1, 'Győrszemere',   null    ),
('John Deere T660 4WD Hillmaster', 2009, 2, 'Sárbogárd',     29300000),
('John Deere T560i HM',            2017, 2, 'Sárbogárd',     null    ),
('Claas Medion 340',               2001, 3, 'Nádudvar',      null    ),
('Rostselmash 595 Plus',           2018, 3, 'Nádudvar',      null    ),
('John Deere 1450',                2002, 3, 'Nádudvar',       8000000),
('Claas Commander 114 CS',         1987, 4, 'Pellérd',        4500000),
('New Holland CX860',              2002, 1, 'Győrszemere',   null    ),
('John Deere T670',                2011, 5, 'Telekgerendás', 31500000),
('UNIA PYRA 2',                    2009, 3, 'Nádudvar',       5500000),
('Claas Lexion 580',               2005, 2, 'Sárbogárd',     22000000),
('New Holland CS 640',             2005, 1, 'Szászberek',    null    );