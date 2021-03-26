using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba 
{
    class Persona 
    {
       
        
        public string VersiónNo { get; set; }
        public string Fecha { get; set; }
        public string Usuario_Creador { get; set; }
        public string Contenido { get; set; }

       


        public override string ToString()
        {
            return $"Versión No.:  {VersiónNo}" + "%"+ 
                   $"Fecha: {Fecha}" + "%" +
                   $"Usuario: {Usuario_Creador}" + "%" +
                   $"Contenido: {Contenido}";

        }

        /*public static void GuardarVersion(Persona GuardarPersona)
        {
                        
            Versiones.Add(GuardarPersona);          

        }*/
    }
}
