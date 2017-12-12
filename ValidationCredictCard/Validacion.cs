using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationCredictCard
{
    public class Validacion
    {
        public bool validar(string number)
        {
            StringBuilder digitsOnly = new StringBuilder();
         
             int sumaDoble = 0;
             int digito = 0;
             int suma = 0;

             foreach (var v in number)
             {
                 if (Char.IsDigit(v))
                     digitsOnly.Append(v);
             }

             for (int i = digitsOnly.Length-1; i >= 0; i--)
             {
                if (i % 2 == 0)
                {
                    digito = Int32.Parse(digitsOnly.ToString(i, 1));
                    sumaDoble = digito + digito;

                    if (sumaDoble > 9)
                    {
                        sumaDoble -= 9;
                        suma = suma + (sumaDoble);
                    }
                    else
                        suma = suma + (sumaDoble);
                }
                else
                    suma = suma + Int32.Parse(digitsOnly.ToString(i, 1));
             }

             if (suma % 10 == 0)
                 return true;
             else
                 return false;

        }
    }
}
