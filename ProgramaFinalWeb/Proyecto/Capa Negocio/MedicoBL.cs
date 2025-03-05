using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio

{
    public class MedicoBL
    {
        public List<MedicosCLS> ListarMedicos()
        {
            
            MedicosDAL obj = new MedicosDAL();
            return obj.ListarMedicos();
        }

        public int GuardarMedicos(MedicosCLS oMedicoCLS)
        {
            ValidarMedico(oMedicoCLS);
            MedicosDAL obj = new MedicosDAL();
            return obj.GuardarMedico(oMedicoCLS);
        }
        private void ValidarMedico(MedicosCLS oMedicoCLS)
        {
            if (oMedicoCLS.nombre == null)
            {
                throw new Exception("El nombre no puede ser nulo");
            }
            if (oMedicoCLS.apellido == null)
            {
                throw new Exception("El apellido no puede ser nulo");
            }
            if (oMedicoCLS.especialidadId == 0)
            {
                throw new Exception("La especialidad no puede ser nula");
            }
            if (oMedicoCLS.telefono == null)
            {
                throw new Exception("El telefono no puede ser nulo");
            }
            if (oMedicoCLS.email == null)
            {
                throw new Exception("El email no puede ser nulo");
            }
        }
    }
}
