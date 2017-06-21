Use DB_GRUPO3

--Tabla Estudiante
create table PACIENTE(
	Cedula		char(11)	not null primary key,
	NombreP		varchar(15)	not null,
	Apellido1	varchar(15)	not null,
	Apellido2	varchar(15),
	Edad		int not null,
	Sexo		char(1)		not null,
	Email		varchar(50),
	Numero		int
)

--Tabla Cirugias
create table CIRUGIAS(
	CedPaciente	char(11)	not null,
	Cirugia		varchar(50)	not null,
	primary key (CedPaciente, Cirugia),
	foreign key	(CedPaciente) references PACIENTE(Cedula)
		on delete no action
)

--Tabla Plan_Tratamiento
create table PLAN_TRATAMIENTO(
	CedPaciente	char(11)	not null,
	Pad_Actual	varchar(50)	not null,
	Objetivos	varchar(50),
	primary key (CedPaciente, Pad_Actual),
	foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action
)

--Tabla Plan_Tratamiento
create table PLAN_EJERCICIOS(
	CedPaciente	char(11)	not null,
	Padec_Act	varchar(50)	not null,
	Nivel		varchar(10) not null,
	Objetivos	varchar(50),
	primary key (CedPaciente, Padec_Act, Nivel),
	foreign key (CedPaciente) references PACIENTE(Cedula)
		on delete no action,
	foreign key (Padec_Act) references PLAN_TRATAMIENTO(Pad_Actual)
		on delete no action
)

--Tabla Cita