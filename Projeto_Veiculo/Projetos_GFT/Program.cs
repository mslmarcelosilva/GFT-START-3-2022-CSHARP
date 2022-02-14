using System;
using Projeto_Veiculo.Entities;

namespace Projeto_Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo("GM", "Astra", "BOT1234", "Azul", "3000", true, 10, 30, 5000.00);

            Console.WriteLine("-------------------Menu de opções -------------");
            Console.WriteLine("Opção 1: Visualizar Veiculo");
            Console.WriteLine("Opção 2: Abastecer Veiculo");
            Console.WriteLine("Opção 3: Acelerar Veiculo");
            Console.WriteLine("Opção 4: Frear Veiculo");
            Console.WriteLine("Opção 5: Pintar Veiculo");
            Console.WriteLine("Opção 6: Desligar Veiculo");
            Console.WriteLine("Opção 7: Ligar Veiculo");
            Console.WriteLine("Ou tecle X para sair");
            Console.WriteLine("Selecione a opção que deseja executar: ");
            string opc = Console.ReadLine();

            while(opc.ToUpper() != "X")
            {
                switch (opc)
                {
                    case "1":
                        Console.WriteLine(v1);
                        break;
                    case "2":
                        Console.Write("Insira a quantidade em Litros que deseja abastecer:");
                        int abastecer = int.Parse(Console.ReadLine());
                        v1.Abastecer(abastecer);
                        Console.WriteLine("Tanque: " + v1.LitrosCombustivel);
                        Console.WriteLine();
                        break;
                    case "3":
                        v1.Acelerar();
                        Console.WriteLine("Velocidade: " + v1.Velocidade);
                        Console.WriteLine();
                        break;
                    case "4":
                        v1.Frear();
                        Console.WriteLine("Velocidade: " + v1.Velocidade);
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Digite a nova cor do veiculo: ");
                        string cor = Console.ReadLine();
                        v1.Pintar(cor.ToUpper());
                        Console.WriteLine("Nova cor do veiculo: " + v1.Cor);
                        Console.WriteLine();
                        break;
                    case "6":
                        v1.Desligar();
                        break;
                    case "7":
                        v1.Ligar();
                        break;
                    default:
                        Console.WriteLine("Opção invalida, escolha uma das opções abaixo");
                        break;
                }
                Console.WriteLine("-------------------Menu de opções -------------");
                Console.WriteLine("Opção 1: Visualizar Veiculo");
                Console.WriteLine("Opção 2: Abastecer Veiculo");
                Console.WriteLine("Opção 3: Acelerar Veiculo");
                Console.WriteLine("Opção 4: Frear Veiculo");
                Console.WriteLine("Opção 5: Pintar Veiculo");
                Console.WriteLine("Opção 6: Desligar Veiculo");
                Console.WriteLine("Opção 7: Ligar Veiculo");
                Console.WriteLine("Ou tecle X para sair");
                Console.WriteLine("Selecione a opção que deseja executar: ");
                opc = Console.ReadLine();
            }            
        }
    }
}
