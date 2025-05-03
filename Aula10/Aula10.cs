//  Enumeradores (enum)

using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){

        //  DiasSemana ds = DiasSemana.Domingo;
       
        //  Acessando atraves do index
        //  DiasSemana ds = (DiasSemana)0;

        //  Pegando index
        int ds = (int)DiasSemana.Domingo;

        Console.WriteLine(ds);

    }

}