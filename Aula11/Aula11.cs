//  Conversões de tipos (typecast)

using System;

class Aula11{

    static void Main(){
        //  Conversão Implícita = Segura
        //  int n1=10;
        //  float n2=n1;

        //  Converção Explícita = Não segura, sendo necessario um cast
        //  float n1=10.5f;
        //  int n2=(int)n1;

        int vInt = 10;
        short vShort = (short)vInt;

        Console.WriteLine(vShort);


    }

}