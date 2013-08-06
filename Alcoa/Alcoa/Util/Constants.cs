using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;


namespace Util
{
    public class Constants
    {
        public const string URL_BOOTSTRAP_CSS = "//cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/css/bootstrap.min.css";
        public const string URL_BOOTSTRAP_JS = "//cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/js/bootstrap.min.js";
        public const string URL_JQUERY_JS = "http://code.jquery.com/jquery-1.9.1.js";
        public const string URL_SITE_JS = "~/Scripts/site.js";
        public const string URL_CONTENT_CSS = "~/Content/content.css";
        public const string URL_BOOTBOX_JS = "~/Scripts/bootbox.min.js";

        public static class Translate
        {
            public static string ID { get { return Internationalization.Id; } }
            public static string TELEFONE { get { return Internationalization.Telefone; } }
            public static string NOME { get { return Internationalization.Nome; } }
            public static string CELULAR { get { return Internationalization.Celular; } }
            public static string ENDERECO { get { return Internationalization.Endereco; } }
            public static string DATANASCIMENTO { get { return Internationalization.DataNascimento; } }
            public static string DATA { get { return Internationalization.Data; } }
            public static string CIDADE { get { return Internationalization.Cidade; } }
            public static string EMAIL { get { return Internationalization.Email; } }
            public static string USUARIO { get { return Internationalization.Usuario; } }
            public static string REALIZADO { get { return Internationalization.Realizado; } }
            public static string OBSERVACOES { get { return Internationalization.Observacoes; } }
            public static string DATAACOMPANHAMENTO { get { return Internationalization.DataAcompanhamento; } }
            public static string PESO { get { return Internationalization.Peso; } }
            public static string IMC { get { return Internationalization.IMC; } }
            public static string TIPO { get { return Internationalization.Tipo; } }
            public static string DATACIRURGIA { get { return Internationalization.DataCirurgia; } }
            public static string DESCRICAO { get { return Internationalization.Descricao; } }
            public static string HORAINICIO { get { return Internationalization.HoraInicio; } }
            public static string VALOR { get { return Internationalization.Valor; } }
            public static string DATAEXAME { get { return Internationalization.DataExame; } }
            public static string CAMINHOIMAGEM { get { return Internationalization.CaminhoImagem; } }
            public static string CRM { get { return Internationalization.CRM; } }
            public static string PASSWORD { get { return Internationalization.Password; } }
            public static string PESOANTESCIRURGIA { get { return Internationalization.PesoAntesCirurgia; } }
            public static string PESOALTAHOSPITALAR { get { return Internationalization.PesoAltaHospitalar; } }
            public static string DATAALTA { get { return Internationalization.DataAlta; } }
            public static string DURACAOCIRURGIA { get { return Internationalization.PesoAntesCirurgia; } }
            public static string CATETERPERIDURAL { get { return Internationalization.CateterPeridural; } }
            public static string UTIPOSOPERATORIO { get { return Internationalization.UTIPosOperatorio; } }
            public static string MOTIVOUTIPOSOPERATORIO { get { return Internationalization.MotivoUTIPosOperatorio; } }
            public static string ACOES { get { return Internationalization.Acoes; } }
            public static string EDITAROUREMOVER { get { return Internationalization.EditarOuRemover; } }
            public static string DATACONSULTA { get { return Internationalization.DataConsulta; } }
            public static string DATAAGENDAMENTO { get { return Internationalization.DataAgendamento; } }
            public static string RETORNO { get { return Internationalization.Retorno; } }
            public static string HORARIO { get { return Internationalization.Horario; } }
            public static string ESPECIALIDADE { get { return Internationalization.Especialidade; } }
            public static string NOMEMEDICO { get { return Internationalization.NomeMedico; } }
            public static string PACIENTE { get { return Internationalization.Paciente; } }
            public static string TIPOEXAME { get { return Internationalization.TipoExame; } }
            public static string IMAGEM { get { return Internationalization.Imagem; } }
            public static string MOTIVO { get { return Internationalization.Motivo; } }
            public static string NOMEPACIENTE { get { return Internationalization.NomePaciente; } }
            public static string REMOVER { get { return Internationalization.Remover; } }
        }

        public static class Page
        {
            public static string CANCEL { get { return Internationalization.Cancel; } }
            public static string CREATE { get { return Internationalization.Create; } }
            public static string DELETE { get { return Internationalization.Delete; } }
            public static string EDIT { get { return Internationalization.Edit; } }
            public static string SAVE { get { return Internationalization.Save; } }
            public static string SUCCESS_MESSAGE_CLASS { get { return "alert alert-success"; } }
            public static string SUCCESS_ICON { get { return "icon-ok"; } }
            public static string ERROR_MESSAGE_CLASS { get { return "alert alert-error"; } }
            public static string ERROR_ICON_CLASS { get { return "icon-exclamation-sign"; } }
            public static string INFO_MESSAGE_CLASS { get { return "alert alert-info"; } }
            public static string INFO_ICON_CLASS { get { return "icon-info-sign"; } }
            public static string BUSCAR { get { return Internationalization.Buscar; } }
            public static string NEW { get { return Internationalization.New; } }
            public static string USUARIO { get { return Internationalization.Usuario; } }
            public static string EMAIL { get { return Internationalization.Email; } }
        }
    }
}
