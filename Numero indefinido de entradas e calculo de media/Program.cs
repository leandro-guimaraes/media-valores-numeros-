using System;

namespace Numero_indefinido_de_entradas_e_calculo_de_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada,media,resultado=0;
            int contador=0;

            do
            {

                Console.WriteLine("insira um  valor de entrada: ");
                entrada=double.Parse(Console.ReadLine());
                if (entrada > 0)
                {
                    resultado = resultado + entrada;
                    contador++;
                }

            }
            while (entrada > 0);

            media = resultado / contador;

            Console.WriteLine("a media foi: " + media);
        }
    }
}
