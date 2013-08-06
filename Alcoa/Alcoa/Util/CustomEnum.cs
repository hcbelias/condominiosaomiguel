using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Util.Enum
{
    public enum Perfil
    {
        Desconhecido = 0,
        Administrador = 1,
        Paciente = 2,
        Cirurgiao = 3,
        Nutricionista = 4,
        Endocrino = 5,
        Psicologa = 6,
        Funcionario = 7
    }

    public enum TipoGrafico
    {
        PesoDuracaoTratamento = 0,
        PesoPressaoArterial = 1,
        PesoTaxaGlicemica = 2,
        PesoTriglicerides = 3,
        PesoHemoglobina = 4,
        PesoColesterol = 5
    }
}