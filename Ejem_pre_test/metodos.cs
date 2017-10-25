using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejem_pre_test
{
    class metodos
    {
        //metodo para multiplicar o sumar
        //en los parametros(los tres primeros son fijos, el ultimo se declara a 0 porque es opcional)
        public static int Multiplicar(int numero_uno, int numero_dos, int contador, int numero_tres = 0)
        {
            
            if (contador == 1)
            {//si nuestro contador de click nos manda uno se multiplican
                int res = numero_uno * numero_dos;
                return res;
            }
            else {
               //si es mas de uno se suma el ultimo numero de la lista con el textbox2
                int res = numero_tres + numero_dos;
                return res;  
             }
            
            
        }
        

    }
}
