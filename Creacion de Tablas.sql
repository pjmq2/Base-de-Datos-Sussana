Use DB_GRUPO3

--Tabla Usuario

CREATE TABLE Usuario(
	cedulaUsuario	char(9)	NOT NULL,
	nombreUsuario	varchar(40)	NOT NULL,
	passwordHash	binary(64)	NOT NULL,
	salt UNIQUEIDENTIFIER
)

--Tabla Paciente
create table PACIENTE(
	Cedula		char(9)			not null,
	NombreP		varchar(20)		not null,
	Apellido1	varchar(20)		not null,
	Apellido2	varchar(20),
	FechaNac	date			not null,
	Sexo		char(1)			not null	DEFAULT 'M',
	Valoracion	varchar(500)	not null,
	Email		varchar(50),
	Telefono	varchar(12),
	Comentarios	varchar(500),
	Constraint PKPaciente primary key (Cedula)
)

--Tabla Cirugias
create table CIRUGIAS(
	CedPaciente	char(9)		not null,
	Cirugia		varchar(50)	not null,
	Constraint PKCirugia primary key (CedPaciente, Cirugia),
	Constraint FKCaPaciente foreign key	(CedPaciente) references PACIENTE(Cedula)
		on delete no action
		on update no action
)

alter table Cirugias
alter column Cirugia varchar(200)

--Tabla Plan_Tratamiento
create table PLAN_TRATAMIENTO(
	CedPaciente	char(9)		not null,
	Pad_Actual	varchar(50)	not null,
	Objetivos	varchar(500),
	Constraint PKPlan_Tratamiento primary key (CedPaciente, Pad_Actual),
	Constraint PKPTaPaciente foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action
		on update no action
)

--Tabla Plan_Tratamiento
create table PLAN_EJERCICIOS(
	CedPaciente	char(9)		not null,
	Padec_Act	varchar(50)	not null,
	Nivel		varchar(10)	not null,
	Objetivos	varchar(500),
	Constraint PKPlan_Ejercicios primary key (CedPaciente, Padec_Act, Nivel),
	Constraint FKPEaPlan_Tratamiento foreign key (CedPaciente, Padec_Act) references PLAN_TRATAMIENTO(CedPaciente, Pad_Actual)
		on delete no action
		on update no action
)

--Tabla Cita
create table CITA(
	CedPaciente	char(9)		not null,
	Padec_Act	varchar(50)	not null,
	Fecha		varchar(18)	not null,
	Precio		int			not null,
	Descripcion	varchar(500),
	Duracion	Decimal(4, 2),
		CHECK (Duracion >= 1.0 AND Duracion <= 4.0),
	Lugar		varchar(50),
	Estado_Paciente varchar(50),
	Constraint PKCita primary key (CedPaciente, Padec_Act, Fecha),
	Constraint FKCaPlan_Tratamiento foreign key (CedPaciente, Padec_Act) references PLAN_TRATAMIENTO(CedPaciente, Pad_Actual)
		on delete no action
		on update no action
)

--Tabla Antecedentes Patologicos
create table ANT_PAT(
	Nombre		varchar(50)	not null
	Constraint PKAnt_Pat primary key (Nombre),
	
)

--Tabla Tipo de Antecedentes Patologicos
create table TIPO_ANT(
	Nombre_Ant		varchar(50)	not null,
	Tipo			varchar(50)	not null,
	Constraint PKTipo_Ant primary key (Nombre_Ant, Tipo),
	Constraint FKTAaAnt_Pat foreign key (Nombre_Ant) references ANT_PAT(Nombre)
		on delete cascade
		on update cascade
)

--Tabla de la relación M a N entre Antecedentes y Paciente
create table HA_TENIDO(
	CedulaPac char(9) not null,
	Nombre_A varchar(50) not null,
	Descripcion varchar(500),
	Constraint PKTHa_Tenido primary key (CedulaPac, Nombre_A),
	Constraint FKTHTaAnt_Pat foreign key (Nombre_A) references ANT_PAT(Nombre)
		on delete cascade
		on update cascade,
	Constraint FKTHTaPAC foreign key (CedulaPac) references PACIENTE(Cedula)
		on delete no action
		on update no action
)

--Tabla Datos Clinicos
create table DATOS_CLINICOS(
	CedPaciente	char(9)			not null,
	Dato		varchar(500)	not null,
	Archivo		varbinary(MAX),
	Constraint PKDatos_Clinicos primary key (CedPaciente, Dato),
	Constraint FKDCaPaciente foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action
		on update no action
)

--Tabla Tecnica
create table TECNICA(
	Nombre		varchar(50)		not null,
	Descripcion	varchar(500),
	Precio		int
	Constraint PKTecnica primary key (Nombre)
)

--Tabla Se Realiza
create table SE_REALIZAN(
	CedPaciente	char(9)	not null,
	Padec_Act	varchar(50)	not null,
	Fecha_Cita	varchar(18)	not null,
	Nombre_Tec	varchar(50)	not null
	Constraint PKSe_Realiza primary key (CedPaciente, Padec_Act, Fecha_Cita, Nombre_Tec),
	Constraint FKSRaCita foreign key (CedPaciente, Padec_Act, Fecha_Cita) references CITA(CedPaciente, Padec_Act, Fecha)
		on delete no action
		on update no action,
	Constraint FKSRaTecnica foreign key (Nombre_Tec) references TECNICA(Nombre)
		on delete no action
		on update cascade
)

--Tabla Material
create table MATERIAL(
	Nombre		varchar(50)	not null,
	Precio		int,
	Constraint PKMaterial primary key (Nombre)
)

--Tabla Requiere de 
create table REQUIERE_DE(
	Nombre_Tec	varchar(50)	not null,
	Nombre_Mat	varchar(50) not null ,
	Cantidad	int,
	Constraint PKRequiere_De primary key (Nombre_Tec, Nombre_Mat),
	Constraint FKRDaTecnica foreign key (Nombre_Tec) references Tecnica(Nombre)
		on delete no action
		on update cascade,
	Constraint FKRDaMaterial foreign key (Nombre_Mat) references MATERIAL(Nombre)
		on delete no action
		on update cascade
)

--Tabla Tareas del plan de ejercicios
create table TAREAS_PLAN_EJERCICIOS(
	CedPaciente	char(9)	not null,
	Padec_Act	varchar(50)	not null,
	Nivel_Plan	varchar(10)	not null,
	Tarea		varchar(50)	not null
	Constraint PKTareas_Plan_Ejercicios primary key (CedPaciente, Padec_Act, Nivel_Plan, Tarea),
	Constraint FKTPEaPlan_Ejercicios foreign key (CedPaciente, Padec_Act, Nivel_Plan) references PLAN_EJERCICIOS(CedPaciente, Padec_Act, Nivel)
		on delete cascade
		on update cascade
)



--Tabla Ejercicios
create table EJERCICIO(
	Nombre		varchar(50)		not null,
	Descripcion	varchar(500)	not null,
	Imagen		image,
	Constraint PKEjercicio primary key (Nombre)
)

--Tabla Consta de 
create table CONSTA_DE(
	CedPaciente	char(9)	not null,
	Padec_Act	varchar(50)	not null,
	Nivel_Plan	varchar(10)	not null,
	Nombre_Eje	varchar(50)	not null,
	Tiempo		int,
	Repeticion	int,
	Constraint PKConsta_De primary key (CedPaciente, Padec_Act, Nivel_Plan, Nombre_Eje),
	Constraint FKCDaPlan_Ejercicios foreign key (CedPaciente,Padec_Act,Nivel_Plan) references PLAN_EJERCICIOS(CedPaciente,Padec_Act,Nivel)
		on delete no action
		on update no action,
	Constraint FKCDaEjercicio foreign key (Nombre_Eje) references EJERCICIO(Nombre)
		on delete no action
		on update no action
)

/*
--Tabla Doctor
create table DOCTOR(
	Telefono	int			not null primary key,
	Nombre		varchar(50) not null
)

--Tabla Especialidad
create table ESPECIALIDAD(
	Tipo		varchar (50) not null primary key
)

--Tabla Se especializa en
create table SE_ESPECIALIZA_EN(
	Tel_Doc		int			not null,
	Tipo_esp	varchar(50) not null,
	primary key (Tel_Doc, Tipo_esp),
	foreign key (Tel_Doc) references DOCTOR(Telefono)
		on delete no action,
	foreign key (Tipo_esp) references ESPECIALIDAD(Tipo)
		on delete no action,
)

--Tabla Referencia
create table REFERENCIA(
	CedPaciente	char(11)	not null,
	Fecha		date		not null,
	Descripcion	varchar(500)	not null,
	Lugar		varchar(50),
	primary key (CedPaciente, Fecha),
	foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action,
)
*/

--Borrar TODO

drop table Usuario
drop table CONSTA_DE
drop table EJERCICIO
drop table TAREAS_PLAN_EJERCICIOS
drop table REQUIERE_DE
drop table MATERIAL
drop table SE_REALIZAN
drop table TECNICA
drop table DATOS_CLINICOS
drop table TIPO_ANT
drop table ANT_PAT
drop table CITA
drop table PLAN_EJERCICIOS
drop table PLAN_TRATAMIENTO
drop table CIRUGIAS
drop table PACIENTE

SELECT M.Nombre
FROM Requiere_De RD RIGHT OUTER JOIN Material M ON RD.Nombre_Mat = M.Nombre
EXCEPT
SELECT M.Nombre
FROM Requiere_De RD RIGHT OUTER JOIN Material M ON RD.Nombre_Mat = M.Nombre JOIN Tecnica T ON T.Nombre = RD.Nombre_Tec AND T.Nombre = 'Tec1'