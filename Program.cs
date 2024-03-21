using System;
using System.Runtime.ConstrainedExecution;

namespace TallerDeAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:
            //- Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
            //-Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
            //-Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
            //- Si el IMC es mayor de 29.9 entonces tiene obesidad.
            //Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular

            //Fórmula: peso(kg) / [estatura(m)]2

            var banderita = "S";
           
            while (banderita == "S") 
            {
                int peso;
                double estatura;
                double imc;

                Console.WriteLine("Digite su peso en Kilogramos: ");
                peso = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite por favor su estatura en centimetros (ex: 1,75): ");
                estatura = Convert.ToDouble(Console.ReadLine());

                imc = peso / estatura * estatura;

                if (imc <= 18.5)
                {
                    Console.WriteLine("Tiene peso insuficiente.");
                }
                if (imc >= 18.5 && imc <= 24.9)
                {
                    Console.WriteLine("Tienes el peso saludable");
                }
                if (imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine("Tienes sobre peso");
                }
                if (imc >= 30)
                {
                    Console.WriteLine("Tienes obesidad");
                }

                Console.WriteLine("Quiere volver a calcular su IMC ?  S/N");
                banderita = Console.ReadLine();
            }


        }
    }
}
