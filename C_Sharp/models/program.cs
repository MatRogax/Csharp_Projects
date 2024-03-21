﻿/*using C_Sharp.models;

Console.WriteLine("Digite o primeiro numero da operação:     ");
double  Num1    = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero da operação:      ");
double  Num2    = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite qual operação voce irá utilizar:   ");
string?  op      =  Console.ReadLine();

Calculator calc = new Calculator(Num1,Num2,op);
calc.Choice();
calc.PrintResult();

*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do cliente: ");
        string cliente = Console.ReadLine();

        if (string.IsNullOrEmpty(cliente))
        {
            Console.WriteLine("O cliente não foi informado");
        }
        else
        {
            while (true)
            {
                string searchCliente, AlterCliente;

                Console.Clear();
                Console.WriteLine("Digite alguma das opções abaixo");
                Console.WriteLine("(1) - Buscar Cliente");
                Console.WriteLine("(2) - Incluir Cliente");
                Console.WriteLine("(3) - Alterar Cliente");
                Console.WriteLine("(4) - Excluir Cliente");
                Console.WriteLine("(5) - Encerrar Programa");

                Console.Write("Opção: ");
                int option;
                
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Opção inválida. Por favor, digite um número válido.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente que deseja buscar: ");
                        searchCliente = Console.ReadLine();

                        if (searchCliente == cliente)
                        {
                            Console.WriteLine($"Usuário {cliente} encontrado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine($"Usuário{cliente} não encontrado");
                        }
                        break;

                    case 2:
                        Console.Write("Digite o nome do cliente que deseja incluir: ");
                        cliente = Console.ReadLine();
                        Console.WriteLine($"cliente: {cliente} incluido com sucesso");
                        break;

                    case 3:
                        Console.Write("Digite o novo nome do cliente: ");
                        AlterCliente = Console.ReadLine();
                        cliente = AlterCliente;
                        Console.WriteLine($"cliente alterado para: {cliente} ");
                        break;

                    case 4:
                        Console.WriteLine($"Cliente {cliente} excluído com sucesso");
                        cliente = "";
                        break;

                    case 5:
                        Console.WriteLine("Menu Encerrado");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, digite um número entre 1 e 5.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}


