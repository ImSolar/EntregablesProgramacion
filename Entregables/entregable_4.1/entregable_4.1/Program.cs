using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable_4._1
{
    class Program
    {
        const double pi = 3.1416;

        //clase de la bola
        class Bola
        {
            //variables
            
            double radioBola;
            int elasticidadBola;

            //constructor
            public Bola(double radio, int elasticidad)
            {
                radioBola = radio;
                elasticidadBola = elasticidad;
            }

            //properties
            public double RadioBola
            {
                get
                {
                    return radioBola;  
              
                }
                set
                {
                    radioBola = value;
                }

            }

            public int ElasticidadBola
            {
                get

                { 
                    return elasticidadBola;

                }
            }

            //calculo area
           public static double CalcularElAreaDeLaBola(Bola objetoBola)
            {
                return (4 * pi * (objetoBola.RadioBola * objetoBola.RadioBola));

            }
            //calculo del volumen
            public static double CalcularElVolumenDeLaBola(Bola objetoBola)
            {
                return (4 * pi * objetoBola.RadioBola * objetoBola.RadioBola * objetoBola.RadioBola / 3);
            }


            

        }
        //struct esfera
        struct Esfera
        {
            double radioEsfera;
            int elasticidadEsfera;

            public Esfera(double radio, int elasticidad)
            {
                radioEsfera = radio;
                elasticidadEsfera = elasticidad;
            }

            //properties
            public double RadioEsfera
            {
                get
                {
                    return radioEsfera;
                }
                set
                {
                    radioEsfera = value;
                }

            }

            public int ElasticidadEsfera
            {
                get

                {
                    return elasticidadEsfera;

                }
            }

            //calculo area
            public static double CalcularElAreaDeLaEsfera(Esfera objetoEsfera)
            {
                return (4 * pi * (objetoEsfera.RadioEsfera * objetoEsfera.RadioEsfera));

            }
            //calculo del volumen
            public static double CalcularElVolumenDeLaEsfera(Esfera objetoEsfera)
            {
                return (4 * pi * objetoEsfera.RadioEsfera * objetoEsfera.RadioEsfera * objetoEsfera.RadioEsfera / 3);
            }

        }




        static void Main(string[] args)
        {
            //creamos las bolas
            Bola bola1 = new Bola(5.0, 2);
            Bola bola2 = new Bola(10.0, 6);
            
            //imprime areas y volumenes
            Console.WriteLine("El area de la bola1 es " + Bola.CalcularElAreaDeLaBola(bola1));
            Console.WriteLine("El volumen de la bola1 es " + Bola.CalcularElVolumenDeLaBola(bola1));
            Console.WriteLine("El area de la bola2 es " + Bola.CalcularElAreaDeLaBola(bola2));
            Console.WriteLine("El volumen de la bola2 es " + Bola.CalcularElVolumenDeLaBola(bola2));

            //cambia radios
            bola1.RadioBola *= 2;
            bola2.RadioBola *= 2;

            //vuelve a imprimir areas y volumenes
            Console.WriteLine("El area de la bola1 es " + Bola.CalcularElAreaDeLaBola(bola1));
            Console.WriteLine("El volumen de la bola1 es " + Bola.CalcularElVolumenDeLaBola(bola1));
            Console.WriteLine("El area de la bola2 es " + Bola.CalcularElAreaDeLaBola(bola2));
            Console.WriteLine("El volumen de la bola2 es " + Bola.CalcularElVolumenDeLaBola(bola2));

            bola1 = bola2;
            bola1.RadioBola = 15.0;
            Console.WriteLine(bola1.RadioBola);
            Console.WriteLine(bola2.RadioBola);
            Console.WriteLine(bola1.ElasticidadBola);
            Console.WriteLine(bola1.ElasticidadBola);


            //creamos las esferas
            Esfera esfera1 = new Esfera(5.0, 2);
            Esfera esfera2 = new Esfera(10.0, 6);

            Console.WriteLine("El area de la esfera1 es " + Esfera.CalcularElAreaDeLaEsfera(esfera1));
            Console.WriteLine("El area de la esfera2 es " + Esfera.CalcularElAreaDeLaEsfera(esfera2));
            Console.WriteLine("El volumen de la esfera1 es " + Esfera.CalcularElVolumenDeLaEsfera(esfera1));
            Console.WriteLine("El volumen de la esfera2 es " + Esfera.CalcularElVolumenDeLaEsfera(esfera2));

            esfera1.RadioEsfera *= 2;
            esfera2.RadioEsfera *= 2;

            Console.WriteLine("El area de la esfera1 es " + Esfera.CalcularElAreaDeLaEsfera(esfera1));
            Console.WriteLine("El area de la esfera2 es " + Esfera.CalcularElAreaDeLaEsfera(esfera2));
            Console.WriteLine("El volumen de la esfera1 es " + Esfera.CalcularElVolumenDeLaEsfera(esfera1));
            Console.WriteLine("El volumen de la esfera2 es " + Esfera.CalcularElVolumenDeLaEsfera(esfera2));

            esfera1 = esfera2;
            esfera1.RadioEsfera = 15.0;
            Console.WriteLine(esfera1.RadioEsfera);
            Console.WriteLine(esfera2.RadioEsfera);
            Console.WriteLine(esfera1.ElasticidadEsfera);
            Console.WriteLine(esfera2.ElasticidadEsfera);


            Console.ReadLine();

        }
    }
}
