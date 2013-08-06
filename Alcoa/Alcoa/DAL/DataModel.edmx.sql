
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/23/2013 12:36:08
-- Generated from EDMX file: E:\DotNet\ClinicaMedica\trunk\DAL\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [clinicasalutealfenas_com2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LoginMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medico] DROP CONSTRAINT [FK_LoginMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginPaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paciente] DROP CONSTRAINT [FK_LoginPaciente];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_PacienteConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_MedicoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilLogin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Login] DROP CONSTRAINT [FK_PerfilLogin];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoCidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cidade] DROP CONSTRAINT [FK_EstadoCidade];
GO
IF OBJECT_ID(N'[dbo].[FK_CidadePaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paciente] DROP CONSTRAINT [FK_CidadePaciente];
GO
IF OBJECT_ID(N'[dbo].[FK_CidadeMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medico] DROP CONSTRAINT [FK_CidadeMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteCirurgia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cirurgia] DROP CONSTRAINT [FK_PacienteCirurgia];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoExameDadosExame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameDados] DROP CONSTRAINT [FK_TipoExameDadosExame];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuSubMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubMenu] DROP CONSTRAINT [FK_MenuSubMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_SubMenuPerfil_SubMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubMenuPerfil] DROP CONSTRAINT [FK_SubMenuPerfil_SubMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_SubMenuPerfil_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubMenuPerfil] DROP CONSTRAINT [FK_SubMenuPerfil_Perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginFuncionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Funcionario] DROP CONSTRAINT [FK_LoginFuncionario];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteExameImagem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameImagem] DROP CONSTRAINT [FK_PacienteExameImagem];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteExameDados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameDados] DROP CONSTRAINT [FK_PacienteExameDados];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaAnamneseConsultaErica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnamneseConsultaErica] DROP CONSTRAINT [FK_ConsultaAnamneseConsultaErica];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaAnamneseConsultaRaphael]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnamneseConsultaRaphael] DROP CONSTRAINT [FK_ConsultaAnamneseConsultaRaphael];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaAnamneseConsultaMarcela]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnamneseConsultaMarcela] DROP CONSTRAINT [FK_ConsultaAnamneseConsultaMarcela];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaAnamneseConsultaOlavo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnamneseConsultaOlavo] DROP CONSTRAINT [FK_ConsultaAnamneseConsultaOlavo];
GO
IF OBJECT_ID(N'[dbo].[FK_CirurgiaAnamneseCirurgiaOlavo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnamneseCirurgiaOlavo] DROP CONSTRAINT [FK_CirurgiaAnamneseCirurgiaOlavo];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaAnamneseConsultaGuilherme]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnamneseConsultaGuilherme] DROP CONSTRAINT [FK_ConsultaAnamneseConsultaGuilherme];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteMedidaPaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedidaPaciente] DROP CONSTRAINT [FK_PacienteMedidaPaciente];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoExameExameImagem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExameImagem] DROP CONSTRAINT [FK_TipoExameExameImagem];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoCirurgia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cirurgia] DROP CONSTRAINT [FK_MedicoCirurgia];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Login]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Login];
GO
IF OBJECT_ID(N'[dbo].[Medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medico];
GO
IF OBJECT_ID(N'[dbo].[Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paciente];
GO
IF OBJECT_ID(N'[dbo].[Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consulta];
GO
IF OBJECT_ID(N'[dbo].[Perfil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfil];
GO
IF OBJECT_ID(N'[dbo].[TipoExame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoExame];
GO
IF OBJECT_ID(N'[dbo].[Cidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cidade];
GO
IF OBJECT_ID(N'[dbo].[Estado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estado];
GO
IF OBJECT_ID(N'[dbo].[Cirurgia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cirurgia];
GO
IF OBJECT_ID(N'[dbo].[ExameImagem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExameImagem];
GO
IF OBJECT_ID(N'[dbo].[ExameDados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExameDados];
GO
IF OBJECT_ID(N'[dbo].[MedidaPaciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedidaPaciente];
GO
IF OBJECT_ID(N'[dbo].[Menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu];
GO
IF OBJECT_ID(N'[dbo].[SubMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubMenu];
GO
IF OBJECT_ID(N'[dbo].[Funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Funcionario];
GO
IF OBJECT_ID(N'[dbo].[AnamneseConsultaErica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamneseConsultaErica];
GO
IF OBJECT_ID(N'[dbo].[AnamneseConsultaRaphael]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamneseConsultaRaphael];
GO
IF OBJECT_ID(N'[dbo].[AnamneseConsultaMarcela]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamneseConsultaMarcela];
GO
IF OBJECT_ID(N'[dbo].[AnamneseConsultaOlavo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamneseConsultaOlavo];
GO
IF OBJECT_ID(N'[dbo].[AnamneseCirurgiaOlavo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamneseCirurgiaOlavo];
GO
IF OBJECT_ID(N'[dbo].[AnamneseConsultaGuilherme]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamneseConsultaGuilherme];
GO
IF OBJECT_ID(N'[dbo].[SubMenuPerfil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubMenuPerfil];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Login'
CREATE TABLE [dbo].[Login] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'Medico'
CREATE TABLE [dbo].[Medico] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CRM] int  NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NULL,
    [DataNascimento] datetime  NULL,
    [RG] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Login_Id] int  NOT NULL,
    [Cidade_Id] int  NOT NULL
);
GO

-- Creating table 'Paciente'
CREATE TABLE [dbo].[Paciente] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [RG] nvarchar(max)  NOT NULL,
    [Convenio] nvarchar(max)  NULL,
    [GrauInstrucao] nvarchar(max)  NULL,
    [EstadoCivil] nvarchar(max)  NULL,
    [NomePai] nvarchar(max)  NULL,
    [NomeMae] nvarchar(max)  NULL,
    [Profissao] nvarchar(max)  NULL,
    [Sexo] nvarchar(max)  NULL,
    [Foto] nvarchar(max)  NULL,
    [Diabetes] bit  NOT NULL,
    [InsuficienciaCardiaca] bit  NOT NULL,
    [Arritmias] bit  NOT NULL,
    [Apneia] bit  NOT NULL,
    [ArtrosesJoelhos] bit  NOT NULL,
    [PatologiasNaColuna] nvarchar(max)  NULL,
    [Dismenorreia] bit  NOT NULL,
    [HipoTireoidismo] bit  NOT NULL,
    [VarizesMMII] bit  NOT NULL,
    [Hirsutismo] bit  NOT NULL,
    [DRGE] bit  NOT NULL,
    [Depressao] bit  NOT NULL,
    [Colelitiase] bit  NOT NULL,
    [Esterilidade] bit  NOT NULL,
    [HAS] bit  NOT NULL,
    [Coronariopatia] bit  NOT NULL,
    [Dispneia] bit  NOT NULL,
    [BronquiteAsma] bit  NOT NULL,
    [ArtrosesTornozelos] bit  NOT NULL,
    [DoencaHemorroidaria] bit  NOT NULL,
    [Hipertiroidismo] bit  NOT NULL,
    [MedicacaoEmUso] nvarchar(max)  NULL,
    [CirurgiasRealizadas] nvarchar(max)  NULL,
    [Etilista] nvarchar(max)  NULL,
    [Tabagista] nvarchar(max)  NULL,
    [HistoricoPatologiasFamilia] nvarchar(max)  NULL,
    [AcompanhamentoMedico] nvarchar(max)  NULL,
    [ClassificacaoObesidade] nvarchar(max)  NULL,
    [Login_Id] int  NOT NULL,
    [Cidade_Id] int  NOT NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataConsulta] datetime  NOT NULL,
    [QueixaPrincipal] nvarchar(max)  NULL,
    [Retorno] bit  NOT NULL,
    [Realizada] bit  NOT NULL,
    [Agendada] bit  NOT NULL,
    [Acompanhante] nvarchar(max)  NULL,
    [GrauParentescoAcompanhante] nvarchar(max)  NULL,
    [HistoriaMolestiaAtual] nvarchar(max)  NULL,
    [Paciente_Id] int  NOT NULL,
    [Medico_Id] int  NOT NULL
);
GO

-- Creating table 'Perfil'
CREATE TABLE [dbo].[Perfil] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoExame'
CREATE TABLE [dbo].[TipoExame] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CategoriaExame] nvarchar(max)  NULL
);
GO

-- Creating table 'Cidade'
CREATE TABLE [dbo].[Cidade] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Estado_Id] int  NOT NULL
);
GO

-- Creating table 'Estado'
CREATE TABLE [dbo].[Estado] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Sigla] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cirurgia'
CREATE TABLE [dbo].[Cirurgia] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataCirurgia] datetime  NOT NULL,
    [Nome] nvarchar(max)  NULL,
    [Observacoes] nvarchar(max)  NULL,
    [DataAlta] datetime  NULL,
    [PesoAlta] float  NULL,
    [TempoCirurgia] datetime  NULL,
    [AvaliacaoEndocrinologica] nvarchar(max)  NULL,
    [AvaliacaoCardiologica] nvarchar(max)  NULL,
    [AvaliacaoPneumologica] nvarchar(max)  NULL,
    [AvaliacaoNutricional] nvarchar(max)  NULL,
    [AvaliacaoPsicologica] nvarchar(max)  NULL,
    [AvaliacaoFisioterapica] nvarchar(max)  NULL,
    [AvaliacaoAnestesiologica] nvarchar(max)  NULL,
    [Paciente_Id] int  NOT NULL,
    [Medico_Id] int  NOT NULL
);
GO

-- Creating table 'ExameImagem'
CREATE TABLE [dbo].[ExameImagem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Imagem] nvarchar(max)  NULL,
    [Indicacao] nvarchar(max)  NOT NULL,
    [DataExame] datetime  NOT NULL,
    [Laudo] nvarchar(max)  NULL,
    [Paciente_Id] int  NOT NULL,
    [TipoExame_Id] int  NOT NULL
);
GO

-- Creating table 'ExameDados'
CREATE TABLE [dbo].[ExameDados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [Descricao] nvarchar(max)  NULL,
    [DataExame] datetime  NOT NULL,
    [TipoExame_Id] int  NOT NULL,
    [Paciente_Id] int  NOT NULL
);
GO

-- Creating table 'MedidaPaciente'
CREATE TABLE [dbo].[MedidaPaciente] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataMedicao] datetime  NOT NULL,
    [Peso] float  NULL,
    [Altura] float  NULL,
    [CircunferenciaBraco] float  NULL,
    [CircunferenciaCintura] float  NULL,
    [CircunferenciaQuadril] float  NULL,
    [PorcentagemGordura] float  NULL,
    [PorcentagemMuscular] float  NULL,
    [PorcentagemGorduraVisceraol] float  NULL,
    [PressaoArterial] nvarchar(max)  NULL,
    [Paciente_Id] int  NOT NULL
);
GO

-- Creating table 'Menu'
CREATE TABLE [dbo].[Menu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [ClassName] nvarchar(max)  NULL
);
GO

-- Creating table 'SubMenu'
CREATE TABLE [dbo].[SubMenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Link] nvarchar(max)  NOT NULL,
    [ClassName] nvarchar(max)  NULL,
    [Menu_Id] int  NOT NULL
);
GO

-- Creating table 'Funcionario'
CREATE TABLE [dbo].[Funcionario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [RG] nvarchar(max)  NOT NULL,
    [Login_Id] int  NOT NULL
);
GO

-- Creating table 'AnamneseConsultaErica'
CREATE TABLE [dbo].[AnamneseConsultaErica] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TempoProblemaFoiObservado] nvarchar(max)  NULL,
    [FoiConsultadoEspecialistas] nvarchar(max)  NULL,
    [FazTratamentoMedico] nvarchar(max)  NULL,
    [FazUsoSubstanciaPsicoativa] nvarchar(max)  NULL,
    [Observacoes] nvarchar(max)  NULL,
    [CondicaoSaudeMaeNaGravidez] nvarchar(max)  NULL,
    [LevouQuedaOuSusto] nvarchar(max)  NULL,
    [CondicoesEmocionaisMaeNaGravidez] nvarchar(max)  NULL,
    [TempoNascimento] nvarchar(max)  NULL,
    [TipoParto] nvarchar(max)  NULL,
    [ProblemasPosParto] nvarchar(max)  NULL,
    [SofreuAcidente] nvarchar(max)  NULL,
    [SubmeteuCirurgia] nvarchar(max)  NULL,
    [ProblemaVisao] nvarchar(max)  NULL,
    [ProblemaAudicao] nvarchar(max)  NULL,
    [DorCabeca] bit  NOT NULL,
    [DesmaiouAlgumaVez] nvarchar(max)  NULL,
    [TemConvulsao] bit  NOT NULL,
    [ProblemasFamilia] nvarchar(max)  NULL,
    [Alimentacao] nvarchar(max)  NULL,
    [Sono] nvarchar(max)  NULL,
    [Desenvolvimento] nvarchar(max)  NULL,
    [QuaisMedidasParaDisciplinar] nvarchar(max)  NULL,
    [ComoReageAoSerContrariado] nvarchar(max)  NULL,
    [QuaisAsAtividadesPreferidas] nvarchar(max)  NULL,
    [GostaIrEscola] bit  NOT NULL,
    [RepetiuSerieAlgumaVez] bit  NOT NULL,
    [GostaEstudar] bit  NOT NULL,
    [HorarioEstudar] nvarchar(max)  NULL,
    [AuxilioPaisNaEscola] bit  NOT NULL,
    [Consulta_Id] int  NOT NULL
);
GO

-- Creating table 'AnamneseConsultaRaphael'
CREATE TABLE [dbo].[AnamneseConsultaRaphael] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HabitosAlimentares] nvarchar(max)  NULL,
    [ExameFisico] nvarchar(max)  NULL,
    [HipotesesDiagnosticadas] nvarchar(max)  NULL,
    [PlanoPropedeutico] nvarchar(max)  NULL,
    [Consulta_Id] int  NOT NULL
);
GO

-- Creating table 'AnamneseConsultaMarcela'
CREATE TABLE [dbo].[AnamneseConsultaMarcela] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PrimeiraMeta] nvarchar(max)  NULL,
    [AtividadeFisica] nvarchar(max)  NULL,
    [TipoCirurgia] nvarchar(max)  NULL,
    [TempoTratamentoPreOperatorio] nvarchar(max)  NULL,
    [UsoSuplementos] nvarchar(max)  NULL,
    [FuncaoIntestinal] nvarchar(max)  NULL,
    [AlteracoesGastricas] nvarchar(max)  NULL,
    [Intolerancias] nvarchar(max)  NULL,
    [ObjetivoTratamento] nvarchar(max)  NULL,
    [DocesChocolates] bit  NOT NULL,
    [Refrigerante] bit  NOT NULL,
    [Massa] bit  NOT NULL,
    [CarneGorda] bit  NOT NULL,
    [Oleo] bit  NOT NULL,
    [Sal] bit  NOT NULL,
    [Quitandas] bit  NOT NULL,
    [Frituras] bit  NOT NULL,
    [Verduras] bit  NOT NULL,
    [Legumes] bit  NOT NULL,
    [Agua] bit  NOT NULL,
    [AlimentacaoNoturna] bit  NOT NULL,
    [CompulsaoAlimentar] bit  NOT NULL,
    [Ansiedade] bit  NOT NULL,
    [LeiteDerivados] bit  NOT NULL,
    [AlimentoNaoGosta] nvarchar(max)  NULL,
    [AlimentoGosta] nvarchar(max)  NULL,
    [ComoEFimSemana] nvarchar(max)  NULL,
    [Observacoes] nvarchar(max)  NULL,
    [RotinaDiaria] nvarchar(max)  NULL,
    [Frutas] bit  NOT NULL,
    [Consulta_Id] int  NOT NULL
);
GO

-- Creating table 'AnamneseConsultaOlavo'
CREATE TABLE [dbo].[AnamneseConsultaOlavo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HipertensaoFamilia] bit  NOT NULL,
    [InfartoMiocardio] bit  NOT NULL,
    [AVC] bit  NOT NULL,
    [SalComidaPronta] bit  NOT NULL,
    [PilulaAnticoncepcional] bit  NOT NULL,
    [Gota] bit  NOT NULL,
    [Nefropatia] bit  NOT NULL,
    [Claudicacao] bit  NOT NULL,
    [IndiciosHASecundaria] bit  NOT NULL,
    [ImpotenciaSexual] bit  NOT NULL,
    [Insonia] bit  NOT NULL,
    [ContraIndicacao] nvarchar(max)  NULL,
    [Coracao] nvarchar(max)  NULL,
    [Pulmoes] nvarchar(max)  NULL,
    [Abdome] nvarchar(max)  NULL,
    [SoproAbdominal] bit  NOT NULL,
    [EdemaMembros] bit  NOT NULL,
    [Carotideo] nvarchar(max)  NULL,
    [Radial] nvarchar(max)  NULL,
    [Femural] nvarchar(max)  NULL,
    [Pedioso] nvarchar(max)  NULL,
    [TibialPosterior] nvarchar(max)  NULL,
    [MSD] bit  NOT NULL,
    [MSE] bit  NOT NULL,
    [DecubitoDorsal] nvarchar(max)  NULL,
    [Sentado] nvarchar(max)  NULL,
    [Ereto] nvarchar(max)  NULL,
    [Sal] nvarchar(max)  NULL,
    [Calorias] nvarchar(max)  NULL,
    [Medicacao] nvarchar(max)  NULL,
    [EfeitosColaterais] nvarchar(max)  NULL,
    [Observacoes] nvarchar(max)  NULL,
    [Consulta_Id] int  NOT NULL
);
GO

-- Creating table 'AnamneseCirurgiaOlavo'
CREATE TABLE [dbo].[AnamneseCirurgiaOlavo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ASA] nvarchar(max)  NULL,
    [Goldman] nvarchar(max)  NULL,
    [Lee] nvarchar(max)  NULL,
    [Consideracoes] nvarchar(max)  NULL,
    [Cirurgia_Id] int  NOT NULL
);
GO

-- Creating table 'AnamneseConsultaGuilherme'
CREATE TABLE [dbo].[AnamneseConsultaGuilherme] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TempoObesidade] nvarchar(max)  NULL,
    [Classificacao] nvarchar(max)  NULL,
    [PesoMaximo] nvarchar(max)  NULL,
    [PesoMinimo] nvarchar(max)  NULL,
    [TempoAtingirPesoMinimo] nvarchar(max)  NULL,
    [EpisodioDeterminante] nvarchar(max)  NULL,
    [HabitosAlimentares] nvarchar(max)  NULL,
    [HabitosVida] nvarchar(max)  NULL,
    [Dieta] nvarchar(max)  NULL,
    [NumeroTentativasTratamento] int  NULL,
    [InternacaoSPA] bit  NOT NULL,
    [MotivoInsucesso] nvarchar(max)  NULL,
    [ParentesObesos] nvarchar(max)  NULL,
    [Gestacoes] nvarchar(max)  NULL,
    [TratamentoPsiquiatrico] nvarchar(max)  NULL,
    [ObitosFamilia] nvarchar(max)  NULL,
    [Consulta_Id] int  NOT NULL
);
GO

-- Creating table 'SubMenuPerfil'
CREATE TABLE [dbo].[SubMenuPerfil] (
    [SubMenu_Id] int  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Login'
ALTER TABLE [dbo].[Login]
ADD CONSTRAINT [PK_Login]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medico'
ALTER TABLE [dbo].[Medico]
ADD CONSTRAINT [PK_Medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [PK_Paciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Perfil'
ALTER TABLE [dbo].[Perfil]
ADD CONSTRAINT [PK_Perfil]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoExame'
ALTER TABLE [dbo].[TipoExame]
ADD CONSTRAINT [PK_TipoExame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cidade'
ALTER TABLE [dbo].[Cidade]
ADD CONSTRAINT [PK_Cidade]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [PK_Estado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cirurgia'
ALTER TABLE [dbo].[Cirurgia]
ADD CONSTRAINT [PK_Cirurgia]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExameImagem'
ALTER TABLE [dbo].[ExameImagem]
ADD CONSTRAINT [PK_ExameImagem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExameDados'
ALTER TABLE [dbo].[ExameDados]
ADD CONSTRAINT [PK_ExameDados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedidaPaciente'
ALTER TABLE [dbo].[MedidaPaciente]
ADD CONSTRAINT [PK_MedidaPaciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Menu'
ALTER TABLE [dbo].[Menu]
ADD CONSTRAINT [PK_Menu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SubMenu'
ALTER TABLE [dbo].[SubMenu]
ADD CONSTRAINT [PK_SubMenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Funcionario'
ALTER TABLE [dbo].[Funcionario]
ADD CONSTRAINT [PK_Funcionario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamneseConsultaErica'
ALTER TABLE [dbo].[AnamneseConsultaErica]
ADD CONSTRAINT [PK_AnamneseConsultaErica]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamneseConsultaRaphael'
ALTER TABLE [dbo].[AnamneseConsultaRaphael]
ADD CONSTRAINT [PK_AnamneseConsultaRaphael]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamneseConsultaMarcela'
ALTER TABLE [dbo].[AnamneseConsultaMarcela]
ADD CONSTRAINT [PK_AnamneseConsultaMarcela]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamneseConsultaOlavo'
ALTER TABLE [dbo].[AnamneseConsultaOlavo]
ADD CONSTRAINT [PK_AnamneseConsultaOlavo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamneseCirurgiaOlavo'
ALTER TABLE [dbo].[AnamneseCirurgiaOlavo]
ADD CONSTRAINT [PK_AnamneseCirurgiaOlavo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamneseConsultaGuilherme'
ALTER TABLE [dbo].[AnamneseConsultaGuilherme]
ADD CONSTRAINT [PK_AnamneseConsultaGuilherme]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [SubMenu_Id], [Perfil_Id] in table 'SubMenuPerfil'
ALTER TABLE [dbo].[SubMenuPerfil]
ADD CONSTRAINT [PK_SubMenuPerfil]
    PRIMARY KEY NONCLUSTERED ([SubMenu_Id], [Perfil_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Login_Id] in table 'Medico'
ALTER TABLE [dbo].[Medico]
ADD CONSTRAINT [FK_LoginMedico]
    FOREIGN KEY ([Login_Id])
    REFERENCES [dbo].[Login]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginMedico'
CREATE INDEX [IX_FK_LoginMedico]
ON [dbo].[Medico]
    ([Login_Id]);
GO

-- Creating foreign key on [Login_Id] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [FK_LoginPaciente]
    FOREIGN KEY ([Login_Id])
    REFERENCES [dbo].[Login]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginPaciente'
CREATE INDEX [IX_FK_LoginPaciente]
ON [dbo].[Paciente]
    ([Login_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[Consulta]
    ([Paciente_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[Medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[Consulta]
    ([Medico_Id]);
GO

-- Creating foreign key on [Perfil_Id] in table 'Login'
ALTER TABLE [dbo].[Login]
ADD CONSTRAINT [FK_PerfilLogin]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[Perfil]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilLogin'
CREATE INDEX [IX_FK_PerfilLogin]
ON [dbo].[Login]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'Cidade'
ALTER TABLE [dbo].[Cidade]
ADD CONSTRAINT [FK_EstadoCidade]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[Estado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoCidade'
CREATE INDEX [IX_FK_EstadoCidade]
ON [dbo].[Cidade]
    ([Estado_Id]);
GO

-- Creating foreign key on [Cidade_Id] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [FK_CidadePaciente]
    FOREIGN KEY ([Cidade_Id])
    REFERENCES [dbo].[Cidade]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CidadePaciente'
CREATE INDEX [IX_FK_CidadePaciente]
ON [dbo].[Paciente]
    ([Cidade_Id]);
GO

-- Creating foreign key on [Cidade_Id] in table 'Medico'
ALTER TABLE [dbo].[Medico]
ADD CONSTRAINT [FK_CidadeMedico]
    FOREIGN KEY ([Cidade_Id])
    REFERENCES [dbo].[Cidade]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CidadeMedico'
CREATE INDEX [IX_FK_CidadeMedico]
ON [dbo].[Medico]
    ([Cidade_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'Cirurgia'
ALTER TABLE [dbo].[Cirurgia]
ADD CONSTRAINT [FK_PacienteCirurgia]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteCirurgia'
CREATE INDEX [IX_FK_PacienteCirurgia]
ON [dbo].[Cirurgia]
    ([Paciente_Id]);
GO

-- Creating foreign key on [TipoExame_Id] in table 'ExameDados'
ALTER TABLE [dbo].[ExameDados]
ADD CONSTRAINT [FK_TipoExameDadosExame]
    FOREIGN KEY ([TipoExame_Id])
    REFERENCES [dbo].[TipoExame]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoExameDadosExame'
CREATE INDEX [IX_FK_TipoExameDadosExame]
ON [dbo].[ExameDados]
    ([TipoExame_Id]);
GO

-- Creating foreign key on [Menu_Id] in table 'SubMenu'
ALTER TABLE [dbo].[SubMenu]
ADD CONSTRAINT [FK_MenuSubMenu]
    FOREIGN KEY ([Menu_Id])
    REFERENCES [dbo].[Menu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuSubMenu'
CREATE INDEX [IX_FK_MenuSubMenu]
ON [dbo].[SubMenu]
    ([Menu_Id]);
GO

-- Creating foreign key on [SubMenu_Id] in table 'SubMenuPerfil'
ALTER TABLE [dbo].[SubMenuPerfil]
ADD CONSTRAINT [FK_SubMenuPerfil_SubMenu]
    FOREIGN KEY ([SubMenu_Id])
    REFERENCES [dbo].[SubMenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Perfil_Id] in table 'SubMenuPerfil'
ALTER TABLE [dbo].[SubMenuPerfil]
ADD CONSTRAINT [FK_SubMenuPerfil_Perfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[Perfil]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SubMenuPerfil_Perfil'
CREATE INDEX [IX_FK_SubMenuPerfil_Perfil]
ON [dbo].[SubMenuPerfil]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Login_Id] in table 'Funcionario'
ALTER TABLE [dbo].[Funcionario]
ADD CONSTRAINT [FK_LoginFuncionario]
    FOREIGN KEY ([Login_Id])
    REFERENCES [dbo].[Login]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginFuncionario'
CREATE INDEX [IX_FK_LoginFuncionario]
ON [dbo].[Funcionario]
    ([Login_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'ExameImagem'
ALTER TABLE [dbo].[ExameImagem]
ADD CONSTRAINT [FK_PacienteExameImagem]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteExameImagem'
CREATE INDEX [IX_FK_PacienteExameImagem]
ON [dbo].[ExameImagem]
    ([Paciente_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'ExameDados'
ALTER TABLE [dbo].[ExameDados]
ADD CONSTRAINT [FK_PacienteExameDados]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteExameDados'
CREATE INDEX [IX_FK_PacienteExameDados]
ON [dbo].[ExameDados]
    ([Paciente_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'AnamneseConsultaErica'
ALTER TABLE [dbo].[AnamneseConsultaErica]
ADD CONSTRAINT [FK_ConsultaAnamneseConsultaErica]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[Consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaAnamneseConsultaErica'
CREATE INDEX [IX_FK_ConsultaAnamneseConsultaErica]
ON [dbo].[AnamneseConsultaErica]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'AnamneseConsultaRaphael'
ALTER TABLE [dbo].[AnamneseConsultaRaphael]
ADD CONSTRAINT [FK_ConsultaAnamneseConsultaRaphael]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[Consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaAnamneseConsultaRaphael'
CREATE INDEX [IX_FK_ConsultaAnamneseConsultaRaphael]
ON [dbo].[AnamneseConsultaRaphael]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'AnamneseConsultaMarcela'
ALTER TABLE [dbo].[AnamneseConsultaMarcela]
ADD CONSTRAINT [FK_ConsultaAnamneseConsultaMarcela]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[Consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaAnamneseConsultaMarcela'
CREATE INDEX [IX_FK_ConsultaAnamneseConsultaMarcela]
ON [dbo].[AnamneseConsultaMarcela]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'AnamneseConsultaOlavo'
ALTER TABLE [dbo].[AnamneseConsultaOlavo]
ADD CONSTRAINT [FK_ConsultaAnamneseConsultaOlavo]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[Consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaAnamneseConsultaOlavo'
CREATE INDEX [IX_FK_ConsultaAnamneseConsultaOlavo]
ON [dbo].[AnamneseConsultaOlavo]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Cirurgia_Id] in table 'AnamneseCirurgiaOlavo'
ALTER TABLE [dbo].[AnamneseCirurgiaOlavo]
ADD CONSTRAINT [FK_CirurgiaAnamneseCirurgiaOlavo]
    FOREIGN KEY ([Cirurgia_Id])
    REFERENCES [dbo].[Cirurgia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CirurgiaAnamneseCirurgiaOlavo'
CREATE INDEX [IX_FK_CirurgiaAnamneseCirurgiaOlavo]
ON [dbo].[AnamneseCirurgiaOlavo]
    ([Cirurgia_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'AnamneseConsultaGuilherme'
ALTER TABLE [dbo].[AnamneseConsultaGuilherme]
ADD CONSTRAINT [FK_ConsultaAnamneseConsultaGuilherme]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[Consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaAnamneseConsultaGuilherme'
CREATE INDEX [IX_FK_ConsultaAnamneseConsultaGuilherme]
ON [dbo].[AnamneseConsultaGuilherme]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'MedidaPaciente'
ALTER TABLE [dbo].[MedidaPaciente]
ADD CONSTRAINT [FK_PacienteMedidaPaciente]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteMedidaPaciente'
CREATE INDEX [IX_FK_PacienteMedidaPaciente]
ON [dbo].[MedidaPaciente]
    ([Paciente_Id]);
GO

-- Creating foreign key on [TipoExame_Id] in table 'ExameImagem'
ALTER TABLE [dbo].[ExameImagem]
ADD CONSTRAINT [FK_TipoExameExameImagem]
    FOREIGN KEY ([TipoExame_Id])
    REFERENCES [dbo].[TipoExame]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoExameExameImagem'
CREATE INDEX [IX_FK_TipoExameExameImagem]
ON [dbo].[ExameImagem]
    ([TipoExame_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'Cirurgia'
ALTER TABLE [dbo].[Cirurgia]
ADD CONSTRAINT [FK_MedicoCirurgia]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[Medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoCirurgia'
CREATE INDEX [IX_FK_MedicoCirurgia]
ON [dbo].[Cirurgia]
    ([Medico_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------