/*Escrever um algoritmo que lê um conjunto de 4 valores i, a, b, c,
onde i é um valor inteiro e positivo e a, b, c, são quaisquer valores
reais e os escreva. A seguir:
a) Se i=1 escrever os três valores a, b, c em ordem crescente.
b) Se i= 2 escrever os três valores a, b, c em ordem decrescente.
c) Se i=3 escrever os três valores a, b, c de forma que o maior entre
a, b, c fique dentre os dois.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int codigo;

        Console.WriteLine("Insira o número 1, 2 ou 3: ");
        codigo = Convert.ToInt32(Console.ReadLine());
        

        switch (codigo)
        {
            case 1:
             Console.WriteLine("Um");
            break;
            case 2:
            Console.WriteLine("Dois");
            break;
            case 3:
            Console.WriteLine("Três");
            break;
            
            default:
            Console.WriteLine("Número inválido");
            break;
        }
    }
}