using System;

namespace DesafioSofrecom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "";
            Console.WriteLine("Ingrese el mensaje a calcular.");
            mensaje = Console.ReadLine().ToLower();

            MensajeCore mensajeCore = new MensajeCore();

            string resultado = mensajeCore.SecuenciaByMensaje(mensaje);

            Console.WriteLine("La secuencia numerica del mensaje ingresado es: ");

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
