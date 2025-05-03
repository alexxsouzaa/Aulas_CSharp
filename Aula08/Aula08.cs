// Lendo inputs do teclado

using System;

class Aula08{

    static void Main(){

        int v1, v2, soma;

        Console.WriteLine("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
        soma=v1+v2;
        Console.WriteLine("A soma dos valoes é: {0}", soma);

    }

}