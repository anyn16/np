using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia24
{
    public class Numeros : Dia24Base.Numeros
    {
        //public Numeros()
        //{

        //}

        string Titulo
        {
            get { return Titulo; }
        }

        public override string Autor
        {
            get { return "Karen Stephanie Fletes Tejeda"; }
        }

        public override int[] ObtenerNumerosPrimosEnUnRango(int inicioDelRango, int finDelRango)
        {
            int[] numerosPrimos = new int[200];
            int posicion = 0;
            int contador;
            int x;

            for (x = inicioDelRango; x < finDelRango; x++)
            {
                contador = 0;
                int i;

                for (i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                        contador++;
                }

                if (contador == 2)
                {
                    numerosPrimos[posicion] = x;
                    posicion++;
                }
            }
            return numerosPrimos;
        }

        public override bool VerificarSiEsPrimo(int numero)
        {
            int contador = 0;

            for (int i = 1; i <= numero; i++) {
                if (numero % i == 0)
                    contador++;
            }
            if (contador == 2)
                return true;
            else
                return false;
        }
    }
}
