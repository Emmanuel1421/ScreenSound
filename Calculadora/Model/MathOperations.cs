using System;
using System.Collections.Generic;
using System.Text;

//CALCULADORA
//Emmanuel Guerra

namespace Calculadora.Model;

internal class MathOperations
{
    // public List<Number> num = new();
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    public int Opc { get; set; } 

    public double Num1Input() 
    {
        Console.Clear();
        Console.Write("\nDigite o primeiro número: ");
        Num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Adicionando valor...");
        Thread.Sleep(1000);
        return Num1;
    }
    public double Num2Input() 
    {
        Console.Clear();
        Console.Write("\nDigite o segundo número:");
        Num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nAdicionando valor...");
        Thread.Sleep(1000);
        return Num2;
    }

    public void Addition()
    {
        Console.Clear();
        Num1Input();
        Num2Input();
        InterfaceLine();
        Console.WriteLine($"\nA soma entre {Num1} e {Num2} é = {Num1 + Num2}"); 
    }

    public void Subtraction() 
    {
        Console.Clear();
        Num1Input();
        Num2Input();
        InterfaceLine();
        Console.WriteLine($"\nA subtração entre {Num1} e {Num2} é = {Num1 - Num2}"); 
    }

    public void Multiplication() 
    {
        Console.Clear();
        Num1Input();
        Num2Input();
        InterfaceLine();
        Console.WriteLine($"\nO resultado da multiplicação de {Num1} e {Num2} é = {Num1 * Num2}"); 
    }

    public void Division()
    {
        Console.Clear();
        Num1Input();
        Num2Input();
        InterfaceLine();
        Console.WriteLine($"\nO resultado da divisão de {Num1} com {Num2} é = {Num1 / Num2}");
        

    }

    public void MathMenu() 
    {
        InterfaceMenu();

        do
        {
           
            Console.Write("\nDigite a operação que deseja realizar: ");
            Opc = int.Parse(Console.ReadLine());

            switch (Opc) 
            {    
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Digite um número válido por favor!");
                    break;
            }
        } while (Opc != -1);
    }
    public void InterfaceMenu() 
    {
        InterfaceLine();
        Console.WriteLine("OPERAÇÕES DA CALCULADORA");
        InterfaceLine();

        Console.WriteLine("1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n-1. Sair");
        InterfaceLine();
    }
    public void InterfaceLine() 
    {
        Console.WriteLine("========================");
    }

    public void ExitQuestion() 
    {
        string opc;
        Console.WriteLine("Deseja encerrar o programa?");
        opc = Console.ReadLine();
        if (opc.ToUpper() == "SIM" && opc == "S")
        {
            MathMenu();
        }
        else { Application.Exit()};



    }
}
