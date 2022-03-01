using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Enunciado: Faça um programa que receba um número e que calcule a tabuada desse número. 
             * O programa deve:
             * a) Aceitar números de 1 a 10. Caso seja entrado um número fora dessa faixa deve mostrar uma mensagem de erro e terminar a execução do programa.
             * b) Mostrar o nome da tabuada por extenso. Ex: “Tabuada do OITO”;
             * c) Mostrar a tabuada do número;*/

            Console.Write("Escolha uma Tabuada [1 a 10]: " );
            int Escolha = int.Parse(Console.ReadLine());
            
            string NomeTab = "Vazio";
            int Resultado = 0;
            int Numero = 1;

            //Nome da tabuada por extenso
            if (Escolha <= 10)
            {
                switch (Escolha)
                {
                    case 1:
                        NomeTab = "UM";
                        break;

                    case 2:
                        NomeTab = "DOIS";
                        break;

                    case 3:
                        NomeTab = "TRÊS";
                        break;

                    case 4:
                        NomeTab = "QUATRO";
                        break;

                    case 5:
                        NomeTab = "CINCO";
                        break;

                    case 6:
                        NomeTab = "SEIS";
                        break;

                    case 7:
                        NomeTab = "SETE";
                        break;

                    case 8:
                        NomeTab = "OITO";
                        break;

                    case 9:
                        NomeTab = "NOVE";
                        break;

                    case 10:
                        NomeTab = "DEZ";
                        break;
                }

                Console.WriteLine("Tabuada do {0}: ", NomeTab);

                //Para aumentar o limite da tabuada basta alterar o máximo do índice
                for (int i = 0; i < 10; i++)
                {
                    Resultado = Escolha * Numero;
                    Console.WriteLine("{0} x {1} = {2}", Escolha, Numero, Resultado);
                    Numero++;
                }
            }

            else
            {
                Console.WriteLine("Tabuada Inválida!");
            }


        }
    }
}
