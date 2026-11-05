using System;

namespace CS7 
{
class Program 
   {  
    static void Main(string[] args)
        {
            // Sesion 17: Solucion de examen 
            // 1. Sintaxis Funcion 
            /*
            tipo_dato_devuelto identificador_funcion(parametros)
            {
                Bloque de instrucciones
                    
            }
            */
            // 2. Ciclo ascendente 
            int i = 2;
            while(i <= 27)
            {
                Console.WriteLine($"i: {i}");
                if (i < 6)
                {
                    i += 2 ;
                }
                if (i < 15)
                {
                    i += 3;
                }
                else
                {
                    i += 4;
                }
                i++;
            }

            // 3. Ciclos 
            int Inicio = 9;
            int limite = 22;
            int producto;
            producto = Inicio * limite;
            if (producto < 8 && Inicio > limite)
            {
                //bloque de instrucciones
                // descendete de 9 ejecuciones 
                int m = 9;
                while (m >= 1)
                {
                    m -= 1;
                }
            }
            else
            {
                //Bloque de instrucciones
                // ascendete 
                int n = 3;
                while ( n <= 8)
                {
                    n += 1;
                }
            }
            // 4. Multiplo de 5 
            bool CalcularMultiplo(int numero)
            bool resultado = false;
            {
                if (numero % 5 == 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            bool resultado = CalcularMultiplo(32);
            Console.WriteLine($"Resultado: {resultado}");   

            // 5. Funcion vacia 
            void ImprimirTexto(string materia)
            {
                Console.WriteLine($"Materia: {materia}");
            }
            ImprimirTexto("Programacion III");




        }
   }
}