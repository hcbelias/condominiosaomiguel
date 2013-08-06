INSERT INTO Estado (Nome
    , Sigla)
VALUES
    ('Minas Gerais'
    , 'MG')
GO


INSERT INTO Estado (Nome
    , Sigla)
VALUES
    ('São Paulo'
    , 'SP')
GO


INSERT INTO Estado (Nome
    , Sigla)
VALUES
    ('Rio de Janeiro'
    , 'RJ')
GO


INSERT INTO Cidade (Nome
    , Estado_Id)
VALUES
    ('Alfenas'
    , 1)
GO


INSERT INTO Cidade (Nome
    , Estado_Id)
VALUES
    ('São Paulo'
    , 2)
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Administrador')
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Paciente')
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Cirurgiao')
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Nutricionista')
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Endocrino')
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Psicologa')
GO


INSERT INTO Perfil (Nome)
VALUES
    ('Funcionario')
GO


INSERT INTO dbo.Login (Password
    , Email
    , Perfil_Id)
VALUES
    ('201286'
    , 'hcbe2004@gmail.com'
    , 1)
GO


INSERT INTO dbo.Login (Password
    , Email
    , Perfil_Id)
VALUES
    ('olavo123'
    , 'olavoguimaraesjr@gmail.com'
    , 3)
GO


INSERT INTO dbo.Login (Password
    , Email
    , Perfil_Id)
VALUES
    ('guilherme123'
    , 'braga.morais@gmail.com'
    , 3)
GO


INSERT INTO dbo.Login (Password
    , Email
    , Perfil_Id)
VALUES
    ('marcela123'
    , 'marcelaavilazevedo@hotmail.com'
    , 3)
GO


INSERT INTO dbo.Login (Password
    , Email
    , Perfil_Id)
VALUES
    ('erica123'
    , 'erica.psicologia@yahoo.com.br'
    , 3)
GO

INSERT INTO dbo.Login (Password, Email, Perfil_Id)
VALUES ('raphael123', 'raphapenzim@hotmail.com', 3)
GO


INSERT INTO dbo.Paciente (Nome
    , DataNascimento
    , Endereco
    , Telefone
    , Celular
    , CPF
    , RG
    , Convenio
    , GrauInstrucao
    , EstadoCivil
    , NomePai
    , NomeMae
    , Profissao
    , Sexo
    , Foto
    , Diabetes
    , InsuficienciaCardiaca
    , Arritmias
    , Apneia
    , ArtrosesJoelhos
    , PatologiasNaColuna
    , Dismenorreia
    , HipoTireoidismo
    , VarizesMMII
    , Hirsutismo
    , DRGE
    , Depressao
    , Colelitiase
    , Esterilidade
    , HAS
    , Coronariopatia
    , Dispneia
    , BronquiteAsma
    , ArtrosesTornozelos
    , DoencaHemorroidaria
    , Hipertiroidismo
    , MedicacaoEmUso
    , CirurgiasRealizadas
    , Etilista
    , Tabagista
    , HistoricoPatologiasFamilia
    , AcompanhamentoMedico
    , ClassificacaoObesidade
    , Login_Id
    , Cidade_Id)
VALUES
    ('Henrique Carvalho Barboza Elias'
    , '1986-12-20'
    , 'Rua timbiras, 2163 / apto 1502'
    , '(31) 8871-0995'
    , NULL
    , '08036408627'
    , '99999999212212'
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , 0
    , 0
    , 0
    , 0
    , 0
    , NULL
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , 0
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , NULL
    , 1
    , 1)
GO


INSERT INTO dbo.Medico (Nome
    , CRM
    , Endereco
    , Telefone
    , Celular
    , DataNascimento
    , RG
    , CPF
    , Login_Id
    , Cidade_Id)
VALUES
    ('Guilherme Braga'
    , 9999999
    , 'sadasd'
    , '999999'
    , '999999'
    , '1999-01-01'
    , '999'
    , '999999'
    , 3
    , 1)
GO


INSERT INTO dbo.Medico (Nome
    , CRM
    , Endereco
    , Telefone
    , Celular
    , DataNascimento
    , RG
    , CPF
    , Login_Id
    , Cidade_Id)
VALUES
    ('Érica Machado'
    , 9999999
    , 'sadasd'
    , '999999'
    , '999999'
    , '1999-01-01'
    , '999'
    , '999999'
    , 5
    , 1)
GO


INSERT INTO dbo.Medico (Nome
    , CRM
    , Endereco
    , Telefone
    , Celular
    , DataNascimento
    , RG
    , CPF
    , Login_Id
    , Cidade_Id)
VALUES
    ('Marcela Ávila'
    , 9999999
    , 'sadasd'
    , '999999'
    , '999999'
    , '1999-01-01'
    , '999'
    , '999999'
    , 4
    , 1)
GO


INSERT INTO dbo.Medico (Nome
    , CRM
    , Endereco
    , Telefone
    , Celular
    , DataNascimento
    , RG
    , CPF
    , Login_Id
    , Cidade_Id)
VALUES
    ('Olavo Guimarães'
    , 9999999
    , 'sadasd'
    , '999999'
    , '999999'
    , '1999-01-01'
    , '999'
    , '999999'
    , 2
    , 1)
GO


INSERT INTO dbo.Medico (Nome
    , CRM
    , Endereco
    , Telefone
    , Celular
    , DataNascimento
    , RG
    , CPF
    , Login_Id
    , Cidade_Id)
VALUES
    ('Raphael'
    , 9999999
    , 'sadasd'
    , '999999'
    , '999999'
    , '1999-01-01'
    , '999'
    , '999999'
    , 6
    , 1)
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Hb')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ht')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Leucog')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Plaque')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Glicemia')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Insulina')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ca Iônico')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Sódio')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Potássio')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Uréia')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Creatinina')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Tempo Protromb')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('RNI')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Colesterol Total')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('HDL')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('LDL')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Triglicérides')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Pnt Total')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Albumina')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('TSH')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('T4 Livre')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ácido Úrico')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ácido Fólico')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ferritina Serc')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('TGO')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('TGP')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Gama GT')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('F. Alcalina')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Bile T')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Bile Dir')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Bile Ind')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Peptídeo C')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Magnésio')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Fósforo')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Urina I')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('EPF')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Sg Oculto')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ativ Protrom')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Tipagem sg')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Vitamina B12')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ferro sérico')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('PTH')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('25(OH) Vit d3')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Ca Urin 24hs')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Sorol Hept B')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Beta HCG')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Zinco')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('Hepatite C')
GO


INSERT INTO dbo.TipoExame (Nome)
VALUES
    ('HIV')
GO


INSERT INTO dbo.ExameDados (Valor
    , Descricao
    , DataExame
    , TipoExame_Id
    , Paciente_Id)
VALUES
    ('e12'
    , 'dfdsf'
    , '2013-06-28 10:39:00'
    , 1
    , 1)
GO


INSERT INTO dbo.ExameDados (Valor
    , Descricao
    , DataExame
    , TipoExame_Id
    , Paciente_Id)
VALUES
    ('sdasad'
    , NULL
    , '2013-06-28 10:41:00'
    , 1
    , 1)
GO


INSERT INTO dbo.ExameDados (Valor
    , Descricao
    , DataExame
    , TipoExame_Id
    , Paciente_Id)
VALUES
    ('dsfd'
    , NULL
    , '2013-06-11'
    , 1
    , 1)
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Hma')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('HM')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('HB')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('HBA1C')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('TSH')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('T4L')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('ACT ANTI-PO')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Trab')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Tireoide')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Abdome Total')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Hemoglobina')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Hematocrito')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Leucocitos')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Bast')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Neutr')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Eosin')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Linf')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Plaquetas')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('TS')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('TTPA')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('TP/AP')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('INR')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('NA')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('K')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Ureia')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Creatinina')
GO


INSERT INTO TipoExame (Nome)
VALUES
    ('Glicemia')
GO


INSERT INTO dbo.Menu (Nome
    , ClassName)
VALUES
    ('Consultas'
    , 'icon-th')
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Agendar Consulta'
    , '/Consulta/Create'
    , 'icon-calendar'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Consultas'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Buscar Consulta'
    , '/Consulta'
    , 'icon-search'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Consultas'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Histórico de Consultas'
    , '/Consulta/HistoricoConsulta'
    , 'icon-th-list'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Consultas'))
GO


INSERT INTO dbo.Menu (Nome
    , ClassName)
VALUES
    ('Exames'
    , 'icon-th')
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Cadastrar Exame Laboratorial'
    , '/ExameDados/Create'
    , 'icon-plus'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Exames'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Buscar Exames Laboratoriais'
    , '/ExameDados'
    , 'icon-search'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Exames'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Cadastrar Exame de Imagem'
    , '/ExameImagem/Create'
    , 'icon-plus'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Exames'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Buscar Exames de Imagens'
    , '/ExameImagem'
    , 'icon-picture'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Exames'))
GO


INSERT INTO dbo.Menu (Nome
    , ClassName)
VALUES
    ('Cirurgias'
    , 'icon-th')
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Cadastrar Cirurgias'
    , '/Cirurgia/Create'
    , 'icon-plus'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Cirurgias'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Buscar Cirurgias'
    , '/Cirurgia'
    , 'icon-search'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Cirurgias'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Histórico de Cirurgias'
    , '/Cirurgia/HistoricoCirurgia'
    , 'icon-ok'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Cirurgias'))
GO


INSERT INTO dbo.Menu (Nome
    , ClassName)
VALUES
    ('Pacientes'
    , 'icon-th')
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Cadastrar Paciente'
    , '/Paciente/Create'
    , 'icon-plus'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Pacientes'))
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Buscar Pacientes'
    , '/Paciente'
    , 'icon-search'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Pacientes'))
GO

INSERT INTO dbo.Menu (Nome, ClassName)
VALUES ('Gráficos', 'icon-th')
GO


INSERT INTO dbo.SubMenu (Nome
    , Link
    , ClassName
    , Menu_Id)
VALUES
    ('Visualizar Gráficos'
    , '/Chart'
    , 'icon-file'
    , (SELECT Id
       FROM Menu
       WHERE Nome = 'Gráficos'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Visualizar Gráficos')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Visualizar Gráficos')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO

INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Visualizar Gráficos')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Visualizar Gráficos')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO

INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Visualizar Gráficos')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO



INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Histórico de Consultas')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame Laboratorial')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames Laboratoriais')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame de Imagem')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames de Imagens')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Histórico de Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Paciente')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Pacientes')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Administrador'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame Laboratorial')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames Laboratoriais')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame de Imagem')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames de Imagens')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Paciente')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Pacientes')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Cirurgiao'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame Laboratorial')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames Laboratoriais')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame de Imagem')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames de Imagens')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Paciente')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Pacientes')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Nutricionista'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame Laboratorial')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames Laboratoriais')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame de Imagem')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames de Imagens')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Paciente')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Pacientes')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Endocrino'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame Laboratorial')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames Laboratoriais')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Exame de Imagem')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Exames de Imagens')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Paciente')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Pacientes')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Psicologa'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Funcionario'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Funcionario'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Cadastrar Paciente')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Funcionario'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Buscar Pacientes')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Funcionario'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Agendar Consulta')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Paciente'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Histórico de Consultas')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Paciente'))
GO


INSERT INTO dbo.SubMenuPerfil (SubMenu_Id
    , Perfil_Id)
VALUES
    ((SELECT Id
      FROM SubMenu
      WHERE Nome = 'Histórico de Cirurgias')
    , (SELECT Id
       FROM Perfil
       WHERE Nome = 'Paciente'))
GO
