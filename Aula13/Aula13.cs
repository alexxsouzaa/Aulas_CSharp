//  Condicional IF-ELSE

using System;

class Aula12{

    static void Main(){

        int nota = 0;
        string resultado = "Reprovado";

        Console.Write("Digite a nota: ");
        nota = int.Parse(Console.ReadLine());

        if(nota < 40){
            resultado = "Reprovado";
        }
        else if(nota < 60){
            resultado = "Recuperação";
        }
        else{
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", nota, resultado);
    }

}