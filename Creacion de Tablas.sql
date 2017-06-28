Use DB_GRUPO3

--Tabla Estudiante
create table PACIENTE(
	Cedula		char(11)		not null primary key,
	NombreP		varchar(15)		not null,
	Apellido1	varchar(15)		not null,
	Apellido2	varchar(15),
	Edad		int				not null,
	Sexo		char(1)			not null,
	Valoracion	varchar(500)	not null,
	Email		varchar(50),
	Numero		int,
	Comentarios	varchar(500),
)

--Tabla Cirugias
create table CIRUGIAS(
	CedPaciente	char(11)	not null,
	Cirugia		varchar(50)	not null,
	Objetivos	varchar(500) not null,
	primary key (CedPaciente, Cirugia),
	foreign key	(CedPaciente) references PACIENTE(Cedula)
		on delete no action
)

--Tabla Plan_Tratamiento
create table PLAN_TRATAMIENTO(
	CedPaciente	char(11)	not null,
	Pad_Actual	varchar(50)	not null,
	Objetivos	varchar(500),
	primary key (CedPaciente, Pad_Actual),
	foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action
)

--Tabla Plan_Tratamiento
create table PLAN_EJERCICIOS(
	CedPaciente	char(11)	not null,
	Padec_Act	varchar(50)	not null,
	Nivel		varchar(10) not null,
	Objetivos	varchar(500),
	primary key (CedPaciente, Padec_Act, Nivel),
	foreign key (CedPaciente,Padec_Act) references PLAN_TRATAMIENTO(CedPaciente,Pad_Actual)
		on delete no action
)

--Tabla Cita
create table CITA(
	CedPaciente	char(11)	not null,
	Padec_Act	varchar(50)	not null,
	Fecha		datetime	not null,
	Precio		int			not null,
	Descripcion	varchar(500),
	Duracion	time,
	Lugar		varchar(50),
	Estado_Paciente varchar(50),
	primary key (CedPaciente, Padec_Act, Fecha),
	foreign key (CedPaciente,Padec_Act) references PLAN_TRATAMIENTO(CedPaciente,Pad_Actual)
		on delete no action
)

--Tabla Antecedentes Patologicos
create table ANT_PAT(
	Nombre		varchar(50)	not null primary key,
	Descripcion	varchar(500)
)

--Tabla Tipo de Antecedentes Patologicos
create table TIPO_ANT(
	Nombre_Ant		varchar(50)	not null,
	Tipo			varchar(50) not null,
	primary key (Nombre_Ant, Tipo),
	foreign key (Nombre_Ant) references ANT_PAT(Nombre)
		on delete no action,
)

--Tabla Datos Clinicos
create table DATOS_CLINICOS(
	CedPaciente	char(11)		not null,
	Dato		varchar(500)	not null,
	primary key (CedPaciente, Dato),
	foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action,
)

--Tabla Tecnicas
create table TECNICAS(
	Nombre		varchar(50)		not null primary key,
	Descripcion	varchar(500)	not null,
	Precio		int
)

--Tabla Se Realiza
create table SE_REALIZA(
	CedPaciente	char(11)	not null,
	Padec_Act	varchar(50)	not null,
	Fecha_Cita	datetime	not null,
	Nombre_Tec	varchar(50)	not null
	primary key (CedPaciente, Padec_Act, Fecha_Cita, Nombre_Tec),
	foreign key (CedPaciente,Padec_Act,Fecha_Cita) references CITA(CedPaciente, Padec_Act, Fecha)
		on delete no action,
	foreign key (Nombre_Tec) references TECNICAS(Nombre)
		on delete no action
)

--Tabla Material
create table MATERIAL(
	Nombre		varchar(50) not null primary key,
	Precio		int
)

--Tabla Requiere de 
create table REQUIERE_DE(
	Nombre_Tec	varchar(50)	not null,
	Nombre_Mat	varchar(50) not null ,
	Cantidad	int,
	foreign key (Nombre_Tec) references TECNICAS(Nombre)
		on delete no action,
	foreign key (Nombre_Mat) references MATERIAL(Nombre)
		on delete no action
)

--Tabla Tareas del plan de ejercicios
create table TAREAS_PLAN_EJERCICIOS(
	CedPaciente	char(11)	not null,
	Padec_Act	varchar(50)	not null,
	Nivel_Plan	varchar(10)	not null,
	Tarea		varchar(50)	not null
	primary key (CedPaciente, Padec_Act, Nivel_Plan, Tarea),
	foreign key (CedPaciente,Padec_Act,Nivel_Plan) references PLAN_EJERCICIOS(CedPaciente,Padec_Act,Nivel)
		on delete no action
)

--Tabla Ejercicios
create table EJERCICIO(
	Nombre		varchar(50) not null primary key,
	Descripcion	varchar(500) not null,
	Imagen		image,
)

--Tabla Consta de 
create table CONSTA_DE(
	CedPaciente	char(11)	not null,
	Padec_Act	varchar(50)	not null,
	Nivel_Plan	varchar(10)	not null,
	Nombre_Eje	varchar(50)	not null,
	Tiempo		int,
	Repeticion	int,
	primary key (CedPaciente, Padec_Act, Nivel_Plan, Nombre_Eje),
	foreign key (CedPaciente,Padec_Act,Nivel_Plan) references PLAN_EJERCICIOS(CedPaciente,Padec_Act,Nivel)
		on delete no action,
	foreign key (Nombre_Eje) references EJERCICIO(Nombre)
		on delete no action,
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
/*
Drop table PACIENTE
Drop table CIRUGIAS
Drop table PLAN_TRATAMIENTO
Drop table PLAN_EJERCICIOS
Drop table CITA
Drop table ANT_PAT
Drop table TIPO_ANT
Drop table DATOS_CLINICOS
Drop table TECNICAS
Drop table SE_REALIZA
Drop table MATERIAL
Drop table REQUIERE_DE
Drop table TAREAS_PLAN_EJERCICIOS
Drop table EJERCICIO
Drop table CONSTA_DE
*/