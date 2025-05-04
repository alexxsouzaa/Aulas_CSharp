//  IF aninhado

using System;

class Aula14{

    static void Main(){

        int nota = 0;
        string resultado = "Reprovado";

        Console.Write("Digite a nota: ");
        nota = int.Parse(Console.ReadLine());

        if(nota >= 60){
            if(nota >= 90){
                resultado = "Aprovado com louvor";
            }else{
                resultado = "Aprovado";
            }
            
        }
        else{
            if(nota >= 40){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", nota, resultado);
    }

}