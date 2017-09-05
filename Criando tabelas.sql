Create table Funcionario(

IdFuncionario			integer				identity(1,1),
NomeFuncionario			nvarchar(50)		not null,
Funcao					nvarchar(25)		not null,
primary key(IdFuncionario),
check( Funcao in('Gerente', 'Analista','Programador','Designer','DBA'))

)
go

Create table Projeto (

IdProjeto				integer			identity(1,1),
NomeProjeto				nvarchar(50)		not null,
DateInicio				date				not null,
DateFim					date				not null,
primary key(IdProjeto)
)
go

Create table ProjetoFuncionario(

IdProjeto			integer			not null,
IdFuncionario		integer			not null,
primary key(IdProjeto, IdFuncionario),
foreign key(IdProjeto) references Projeto(IdProjeto),
foreign key(IdFuncionario) references Funcionario(IdFuncionario)
)
go