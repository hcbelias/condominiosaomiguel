using DAL;
using Model;
namespace BLL
{
    public partial class PerfilBLL
    {
        public static Model.PerfilModel GetPerfilPaciente()
        {
            Perfil v_Perfil = Perfil.GetPerfil((int)Util.Enum.Perfil.Paciente);
            if (v_Perfil == null)
                return null;
            return (PerfilModel)(new BLL.PerfilBLL(v_Perfil).getModel());
        }

    }
}
