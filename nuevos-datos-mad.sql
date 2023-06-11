--tabla de ususarios

use PIAMADConnectionString;

CREATE TABLE tipo_usuario (
  ID int  primary key identity (1,1) NOT NULL,
  nombre varchar(45) NOT NULL,
) ;


CREATE TABLE usuarios (
  ID int  primary key identity (1,1) NOT NULL,
  usuario varchar(45) NOT NULL,
  password varchar(80) NOT NULL,
  nombre varchar(50) NOT NULL,
  id_tipo int NOT NULL,
  usuDom varchar(255),
	usuNac date,
	usuTel numeric(10,0),
		fecReg date
);

--foreing key 

ALTER TABLE tipo_usuario ADD  id_tipo int not null;
ALTER TABLE tipo_usuario DROP COLUMN id_tipo;

delete from tipo_usuario where nombre='Operativo';


ALTER TABLE usuarios ADD constraint fk_usuario_tipo foreign key (id_tipo)
REFERENCES  tipo_usuario(ID);

EXEC SP_RENAME 'usuarios.contraseña', 'password', 'COLUMN'  

CREATE PROCEDURE CreateUsuario
(@usuario varchar(45),
 @password varchar(80),
 @nombre varchar(50),
 @id_tipo int,
 @usuDom varchar(255),
 @usuNac date,
 @usuTel numeric(10,0),
 @fecReg date) AS
BEGIN
INSERT INTO usuarios (usuario, password, nombre, id_tipo, usuDom, usuNac, usuTel, fecReg) VALUES (@usuario, @password, @nombre, @id_tipo, @usuDom, @usuNac, @usuTel, @fecReg);

END

CREATE PROCEDURE ModifyUsuario
(@ID int,
 @usuario varchar(45),
 @password varchar(80),
 @nombre varchar(50),
 @id_tipo int,
 @usuDom varchar(255),
 @usuNac date,
 @usuTel numeric(10,0),
 @fecReg date) AS
BEGIN
 
UPDATE usuarios SET usuario = @usuario,
					  password = @password,
					  nombre = @nombre,
					  id_tipo = @id_tipo,
					  usuDom = @usuDom,
					  usuNac = @usuNac,
					  usuTel = @usuTel,
					  fecReg = @fecReg
				  WHERE ID = @ID;

END

CREATE PROCEDURE GetUsuario
AS BEGIN

SELECT usuarios.ID, usuarios.usuario, usuarios.password, usuarios.id_tipo, usuarios.usuDom, usuarios.usuNac, usuarios.usuTel, usuarios.fecReg
FROM usuarios

END;

CREATE PROCEDURE RemoveUsuario
(@ID int) AS
BEGIN

DELETE FROM usuarios WHERE ID = @ID;

END

-- escrito de codigo

INSERT INTO tipo_usuario
VALUES ( 'Operativo');



DROP TABLE tipo_usuario;

SELECT * FROM tipo_usuario;

SELECT * FROM usuarios;



SELECT * FROM Cuentas;

ALTER TABLE Cuentas ADD  Numero_Nomina varchar (50) ;
ALTER TABLE Cuentas ADD  Fecha_nac date  ;
ALTER TABLE Cuentas ADD  usuTel varchar (15)   ;


ALTER TABLE Cuentas DROP COLUMN Numero_Nomina;
ALTER TABLE Cuentas DROP COLUMN usuNac;
ALTER TABLE Cuentas DROP COLUMN usuTel;





---------------------------------tablas de hotel-----------------------------

CREATE TABLE Hotel_registro_D (
    hotelId int PRIMARY KEY identity (1,1) NOT NULL  ,
    -- Resto de las columnas de la tabla
	numpiso numeric(3,0) not null,
	hotelNom varchar(255) not null,
	iniOper date  not null,
	hotelDom varchar(255) not null,
	cantHab numeric(3,0) not null,
	cantTipo numeric(3,0) not null,
	zonaTur varchar(255) not null,
	hotelCd varchar(255) not null,
	hotelEst varchar(255) not null,
	hotelPais varchar(255) not null,
	fecCreacion date  not null
);

CREATE PROCEDURE CreateHotel
(@numpiso numeric(3,0),
	@hotelNom varchar(255),
	@iniOper date,
	@hotelDom varchar(255),
	@cantHab numeric(3,0),
	@cantTipo numeric(3,0),
	@zonaTur varchar(255),
	@hotelCd varchar(255),
	@hotelEst varchar(255),
	@hotelPais varchar(255),
	@fecCreacion date) AS
BEGIN
INSERT INTO Hotel_registro_D (numpiso, hotelNom, iniOper, hotelDom, cantHab, cantTipo, zonaTur, hotelCd, hotelEst, hotelPais, fecCreacion) VALUES (@numpiso, @hotelNom, @iniOper, @hotelDom, @cantHab, @cantTipo, @zonaTur, @hotelCd, @hotelEst, @hotelPais, @fecCreacion);

END;

CREATE PROCEDURE ModifyHotel
(@hotelId int,
	@numpiso numeric(3,0),
	@hotelNom varchar(255),
	@iniOper date,
	@hotelDom varchar(255),
	@cantHab numeric(3,0),
	@cantTipo numeric(3,0),
	@zonaTur varchar(255),
	@hotelCd varchar(255),
	@hotelEst varchar(255),
	@hotelPais varchar(255),
	@fecCreacion date) AS
BEGIN
 
UPDATE Hotel_registro_D SET numpiso = @numpiso,
					  hotelNom = @hotelNom,
					  iniOper = @iniOper,
					  hotelDom = @hotelDom,
					  cantHab = @cantHab,
					  cantTipo = @cantTipo,
					  zonaTur = @zonaTur,
					  hotelCd = @hotelCd,
					  hotelEst = @hotelEst,
					  hotelPais = @hotelPais
				  WHERE hotelId = @hotelId;

END;

CREATE PROCEDURE GetHotel
AS BEGIN

SELECT Hotel_registro_D.hotelId, Hotel_registro_D.numpiso, Hotel_registro_D.hotelNom, Hotel_registro_D.iniOper, Hotel_registro_D.hotelDom, Hotel_registro_D.cantHab, Hotel_registro_D.cantTipo, Hotel_registro_D.zonaTur, Hotel_registro_D.hotelCd, Hotel_registro_D.hotelEst, Hotel_registro_D.hotelPais, Hotel_registro_D.fecCreacion
FROM Hotel_registro_D

END;

CREATE PROCEDURE RemoveHotel
(@hotelID int) AS
BEGIN

DELETE FROM Hotel_registro_D WHERE hotelID = @hotelID;

END;

CREATE TABLE Habitacion_registro_D (
    habId numeric(1,1) NOT NULL,
    habNivel varchar(64) NOT NULL,
    habDesc varchar(255) NOT NULL,
    habCam varchar(64) NOT NULL,
    habPrecio numeric(5,2) NOT NULL,
    habCantPer numeric(2,0) NOT NULL,
    numCama numeric(2,0) NOT NULL,
    habHoraReg time NOT NULL,
    hotelId int ,
    -- Resto de las columnas de la tabla
    PRIMARY KEY (habId),
    FOREIGN KEY (hotelId) REFERENCES Hotel_registro_D(hotelId)
);

CREATE PROCEDURE CreateHabitacion
(@habId numeric(1,1),
    @habNivel varchar(64),
    @habDesc varchar(255),
    @habCam varchar(64),
    @habCantPer numeric(2,0),
    @habPrecio numeric(5,2),
    @numCama numeric(2,0),
    @habHoraReg time,
    @hotelId int) AS
BEGIN
INSERT INTO Habitacion_registro_D (habId, habNivel, habDesc, habCam, habCantPer, habPrecio, numCama, habHoraReg, hotelId) VALUES (@habId, @habNivel, @habDesc, @habCam, @habCantPer, @habPrecio, @numCama, @habHoraReg, @hotelId);

END;

CREATE PROCEDURE ModifyHabitacion
(@habId numeric(1,1),
    @habNivel varchar(64),
    @habDesc varchar(255),
    @habCam varchar(64),
    @habCantPer numeric(2,0),
    @habPrecio numeric(5,2),
    @numCama numeric(2,0),
    @habHoraReg time,
    @hotelId int) AS
BEGIN
 
UPDATE Habitacion_registro_D SET habNivel = @habNivel,
					  habDesc = @habDesc,
					  habCam = @habCam,
					  habCantPer = @habCantPer,
					  habPrecio = @habPrecio,
					  numCama = @numCama,
					  habHoraReg = @habHoraReg,
					  hotelId = @hotelId
				  WHERE habId = @habId;

END;

CREATE PROCEDURE GetHabitacion
AS BEGIN

SELECT  Habitacion_registro_D.habId, Habitacion_registro_D.habNivel, Habitacion_registro_D.habDesc, Habitacion_registro_D.habCam, Habitacion_registro_D.habCantPer, Habitacion_registro_D.habPrecio, Habitacion_registro_D.numCama, Habitacion_registro_D.habHoraReg, Habitacion_registro_D.hotelId
FROM Habitacion_registro_D

END;

CREATE PROCEDURE RemoveHabitacion
(@habID int) AS
BEGIN

DELETE FROM Habitacion_registro_D WHERE habID = @habID;

END;

ALTER TABLE Habitacion ADD constraint fk_Hotel_nom foreign key (habId)
REFERENCES  Hotel(hotelId);

create table ServAdic(
	servID numeric(8,0) NOT NULL ,
	existencia int Not null, 
	nombre_serv varchar(255) NOT NULL,
	costo_serv numeric(4,2)NOT NULL,
	primary key(servID),
	hotelId int,
	FOREIGN KEY (hotelId) REFERENCES Hotel_registro_D(hotelId)
);

CREATE PROCEDURE CreateServAdic
(@servID numeric(8,0),
	@existencia int, 
	@nombre_serv varchar(255),
	@costo_serv numeric(4,2),
	@hotelId int) AS
BEGIN
INSERT INTO ServAdic (servID, existencia, nombre_serv, costo_serv, hotelId) VALUES (@servID, @existencia, @nombre_serv, @costo_serv, @hotelId);

END;

CREATE PROCEDURE ModifyServAdic
(@servID numeric(8,0),
	@existencia int, 
	@nombre_serv varchar(255),
	@costo_serv numeric(4,2),
	@hotelId int) AS
BEGIN
 
UPDATE ServAdic SET existencia = @existencia,
					  nombre_serv = @nombre_serv,
					  costo_serv = @costo_serv,
					  hotelId = @hotelId
				  WHERE servID = @servID;

END;

CREATE PROCEDURE GetServAdic
AS BEGIN

SELECT  ServAdic.servID, ServAdic.existencia, ServAdic.nombre_serv, ServAdic.costo_serv, ServAdic.hotelId
FROM ServAdic

END;

CREATE PROCEDURE RemoveServAdic
(@servID int) AS
BEGIN

DELETE FROM ServAdic WHERE servID = @servID;

END;

DROP TABLE Hotel_registro;


SELECT * FROM Hotel_registro;
SELECT * FROM Habitacion;
SELECT*FROM ServAdic;


ALTER TABLE Hotel_registro DROP COLUMN Playa_serv, Wifi_serv,Alberca_serv,SalonEventos_serv,Otro_servicio;


ALTER TABLE Hotel_registro ADD Playa_serv varchar(50) null,
	Wifi_serv varchar(50) null,
	Alberca_serv varchar(50) null,
	SalonEventos_serv varchar(50) null,
	Otro_servicio varchar(50) null ;

create table Cliente(
	RFC varchar(16) NOT NULL,
	cliNac date NOT NULL,
	cliCor varchar(255) NOT NULL,
	cliDom varchar(255) NOT NULL,
	cliNomCom varchar(255) NOT NULL,
	cliRef varchar(255) NOT NULL,
	cliEstCiv varchar(64) NOT NULL,
	cliTel numeric(10,0) NOT NULL,
	cliFecReg date,
	cliHoraReg time,
	cliUsuReg int,
	primary key(RFC),
);

ALTER TABLE Cliente ADD constraint cliUsuReg foreign key (cliUsuReg)
REFERENCES  usuarios(ID);

CREATE PROCEDURE CreateCliente
(@RFC VARCHAR(16),
 @cliNac date,
 @cliCor varchar(255),
 @cliDom varchar(255),
 @cliNomCom varchar(255),
 @cliRef varchar(255),
 @cliEstCiv varchar(64),
 @cliTel numeric(10,0),
 @cliFecReg date,
 @cliHoraReg time,
 @cliUsuReg int) AS
BEGIN
INSERT INTO Cliente (RFC, cliNac, cliCor, cliDom, cliNomCom, cliRef, cliEstCiv, cliTel, cliFecReg, cliHoraReg, cliUsuReg) VALUES (@RFC, @cliNac, @cliCor, @cliDom, @cliNomCom, @cliRef, @cliEstCiv, @cliTel, @cliFecReg, @cliHoraReg, @cliUsuReg);

END

CREATE PROCEDURE ModifyCliente
(@RFC VARCHAR(16),
 @cliNac date,
 @cliCor varchar(255),
 @cliDom varchar(255),
 @cliNomCom varchar(255),
 @cliRef varchar(255),
 @cliEstCiv varchar(64),
 @cliTel numeric(10,0),
 @cliFecReg date,
 @cliHoraReg time,
 @cliUsuReg int) AS
BEGIN
 
UPDATE Cliente SET cliNac = @cliNac,
					  cliCor = @cliCor,
					  cliDom = @cliDom,
					  cliNomCom = @cliNomCom,
					  cliRef = @cliRef,
					  cliEstCiv = @cliEstCiv,
					  cliTel = @cliTel,
					  cliFecReg = @cliFecReg,
					  cliHoraReg = @cliHoraReg,
					  cliUsuReg = @cliUsuReg
				  WHERE RFC = @RFC;

END

CREATE PROCEDURE GetCliente
AS BEGIN

SELECT Cliente.RFC, Cliente.cliNac, Cliente.cliCor, Cliente.cliNomCom, Cliente.cliRef, Cliente.cliEstCiv, Cliente.cliTel, Cliente.cliFecReg, Cliente.cliHoraReg, Cliente.cliUsuReg
FROM Cliente

END;

CREATE PROCEDURE RemoveCliente
(@RFC VARCHAR(16)) AS
BEGIN

DELETE FROM Cliente WHERE RFC = @RFC;

END

create table Reservacion(
	resCod numeric(16,0),
	fecIni date,
	fecFin date,
	resAnt numeric(5,2),
	resFecReg date,
	resHoraReg time,
	resCliRFC varchar(16),
	resHabId numeric(1,1),
	resUsuReg int,
	resMetodo varchar(64),
	primary key(resCod),
	FOREIGN KEY (resUsuReg) references usuarios(ID),
	FOREIGN KEY (resHabId) references Habitacion_registro_D(habId),
	FOREIGN KEY (resCliRFC) references Cliente(RFC)
);

CREATE PROCEDURE CreateReservacion
(@resCod numeric(16,0),
	@fecIni date,
	@fecFin date,
	@resAnt numeric(5,2),
	@resFecReg date,
	@resHoraReg time,
	@resCliRFC varchar(16),
	@resHabId numeric(1,1),
	@resUsuReg int,
	@resMetodo varchar(64)) AS
BEGIN
INSERT INTO Reservacion (resCod, fecIni, fecFin, resAnt, resFecReg, resHoraReg, resCliRFC, resHabId, resUsuReg, resMetodo) VALUES (@resCod, @fecIni, @fecFin, @resAnt, @resFecReg, @resHoraReg, @resCliRFC, @resHabId, @resUsuReg, @resMetodo);
END;

CREATE PROCEDURE ModifyReservacion
(@resCod numeric(16,0),
	@fecIni date,
	@fecFin date,
	@resAnt numeric(5,2),
	@resFecReg date,
	@resHoraReg time,
	@resCliRFC varchar(16),
	@resHabId numeric(1,1),
	@resUsuReg int,
	@resMetodo varchar(64)) AS
BEGIN
 
UPDATE Reservacion SET fecIni = @fecIni,
						fecFin = @fecFin,
						resAnt = @resAnt,
						resFecReg = @resFecReg,
						resHoraReg = @resHoraReg,
						resCliRFC = @resCliRFC,
						resHabId = @resCliRFC,
						resUsuReg = @resUsuReg,
						resMetodo = @resMetodo
				  WHERE resCod = @resCod;

END;

CREATE PROCEDURE GetReservacion
AS BEGIN

SELECT Reservacion.resCod, Reservacion.fecIni, Reservacion.fecFin, Reservacion.resAnt, Reservacion.resFecReg, Reservacion.resHoraReg, Reservacion.resCliRFC, Reservacion.resHabId, Reservacion.resUsuReg, Reservacion.resMetodo
FROM Reservacion

END;

CREATE PROCEDURE RemoveReservacion
(@resCod numeric(16, 0)) AS
BEGIN

DELETE FROM Reservacion WHERE resCod = @resCod;

END

create table Factura(
	facNum numeric(16,0),
	montoTotal numeric(5,2),
	facDesc numeric(5,2),
	servUtil varchar(64),
	resFecReg date,
	resHoraReg time,
	facCliRFC varchar(16),
	facHabId numeric(1,1),
	facResCod numeric(16,0),
	facHotelId int,
	primary key(facNum),
	FOREIGN KEY (facResCod) references Reservacion(resCod),
	FOREIGN KEY (facHabId) references Habitacion_registro_D(habId),
	FOREIGN KEY (facCliRFC) references Cliente(RFC),
	FOREIGN KEY (facHotelId) references Hotel_registro_D(HotelId)
);

CREATE PROCEDURE CreateFactura
(@facNum numeric(16,0),
	@montoTotal numeric(5,2),
	@facDesc numeric(5,2),
	@servUtil varchar(64),
	@resFecReg date,
	@resHoraReg time,
	@facCliRFC varchar(16),
	@facHabId numeric(1,1),
	@facResCod numeric(16,0),
	@facHotelId int) AS
BEGIN

INSERT INTO Factura (facNum, montoTotal, facDesc, servUtil, resFecReg, resHoraReg, facCliRFC, facHabId, facResCod, facHotelId) VALUES (@facNum, @montoTotal, @facDesc, @servUtil, @resFecReg, @resHoraReg, @facCliRFC, @facHabId, @facResCod, @facHotelId);
END;

CREATE PROCEDURE ModifyFactura
(@facNum numeric(16,0),
	@montoTotal numeric(5,2),
	@facDesc numeric(5,2),
	@servUtil varchar(64),
	@resFecReg date,
	@resHoraReg time,
	@facCliRFC varchar(16),
	@facHabId numeric(1,1),
	@facResCod numeric(16,0),
	@facHotelId int) AS
BEGIN
 
UPDATE Factura SET montoTotal = @montoTotal,
			facDesc = @facDesc,
			servUtil = @servUtil,
			resFecReg = @resFecReg,
			resHoraReg = @resHoraReg,
			facCliRFC = @facCliRFC,
			facHabId = @facHabId,
			facResCod = @facResCod,
			facHotelId = @facHotelId
				  WHERE facNum = @facNum;

END;

CREATE PROCEDURE GetFactura
AS BEGIN

SELECT Factura.facNum, Factura.montoTotal, Factura.facDesc, Factura.servUtil, Factura.resFecReg, Factura.resHoraReg, Factura.facCliRFC, Factura.facHabId, Factura.facResCod, Factura.facHotelId
FROM Factura

END;

CREATE PROCEDURE RemoveFactura
(@facNum numeric(16, 0)) AS
BEGIN

DELETE FROM Factura WHERE facNum = @facNum;

END