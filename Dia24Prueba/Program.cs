using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia24;
using System.Threading;

namespace Dia24Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Numeros ejemplo = new Numeros();
                string[] split;

                Console.WriteLine(("\n" + ejemplo.Titulo));

                //if (Console.KeyAvailable == false)
                //{
                //    Thread.Sleep(7000);
                //    Console.WriteLine("Debe especificar una opción.");
                //}

                string opcion = Console.ReadLine();
                //Console.WriteLine(opcion);
                split = opcion.Split(new Char[] { ' ' });

                //foreach (string s in split)
                //{
                //    if (s.Trim() != "")
                //        Console.Write(s);         
                //}

                if (split[0] == "/esprimo")
                {
                    int numero;
                    bool esNumerico = int.TryParse(split[1], out numero);

                    if (split.Length == 2 && esNumerico)
                    {
                        //Console.WriteLine(numero);
                        if (ejemplo.VerificarSiEsPrimo(numero))
                            Console.WriteLine("El número " + numero + " SI es primo.");
                        else
                            Console.WriteLine("El número " + numero + " NO es primo.");
                    }
                    else
                        Console.WriteLine("Opción desconocida; el número no es entero.");
                }
                else if (split[0] == "/sonprimos")
                {
                    int numero;
                    bool esNumerico;
                    int i = 1;

                    while (i < split.Length)
                    {
                        //Console.WriteLine(split[i]);
                        esNumerico = int.TryParse(split[i], out numero);
                        if (esNumerico)
                        {
                            if (ejemplo.VerificarSiEsPrimo(numero))
                                Console.WriteLine("El número " + numero + " es primo.");
                        }
                        else                       
                            Console.WriteLine("Opción desconocida; el número no es entero.");
                        
                        i++;
                    }
                }
                else if (split[0] == "/buscaprimos")
                {
                    int inicio, fin, i;
                    int[] numerosPrimos = new int[200];
                    bool esNumericoInicio = int.TryParse(split[1], out inicio);
                    bool esNumericoFin = int.TryParse(split[2], out fin);

                    if (split.Length == 3 && esNumericoInicio && esNumericoFin)
                    {
                        Console.WriteLine("\n" + "Los números primos de este rango son: ");
                        numerosPrimos = ejemplo.ObtenerNumerosPrimosEnUnRango(inicio, fin);
                        i = 0;
                        while (i < numerosPrimos.Length && numerosPrimos[i] != 0)
                        {
                            Console.WriteLine("\n" + numerosPrimos[i]);
                            i++;
                        }
                    }
                    else
                        Console.WriteLine("Opción desconocida; los números no son enteros");
                }
                else
                    Console.WriteLine("Opción desconocida");

                //Console.WriteLine("Presione cualquier tecla para salir...");
                //Console.Read();
            }
        }
    }
}

