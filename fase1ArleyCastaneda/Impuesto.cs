using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fase1ArleyCastaneda
{
   public  class Impuesto
    {
       
        public String Placa { get; set; }
        public String TipoVehiculo { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public double AvaluoComercial { get; set; }
        public String NombrePropietario { get; set; }
        public String Cedula { get; set; }
        public DateTime Fecha { get; set; }

        //calculo de avaluo
        
        public double avaluo(double AvaluoComercial)
        {
            double Resultado = 0;
            if(AvaluoComercial <= 39000000)
                {
                    Resultado = AvaluoComercial * 0.025;
                }else if(AvaluoComercial > 39000000)
                {
                    Resultado = AvaluoComercial * 0.04;
                }

            return Resultado;
            
        }
    }
}
