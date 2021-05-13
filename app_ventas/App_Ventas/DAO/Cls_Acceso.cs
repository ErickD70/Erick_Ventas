using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class Cls_Acceso
    {
        public int acceso(String usuario, String Password)
        {

            int variableAcceso = 0;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var consulta = from user in db.tb_usuario
                               where user.email == usuario && user.contrasena == Password
                               select user;
                if (consulta.Count() > 0)
                {
                    variableAcceso = 1;
                }
            }
            return variableAcceso;
        }
    }
}
