using System;

class Program
{
    static void Main()
    {

        Nakladne nakladne1 = new Nakladne(Auto.TypPaliva.Nafta,100,50,1000);
        /*
        nakladne1.settypPaliva("Diesel");
        nakladne1.setVelkostNadrz(150);
        nakladne1.setPalivo(50);
        */

        Osobne osobne1 = new Osobne(Auto.TypPaliva.Benzin,60,51,5);
        /*
        osobne1.settypPaliva("Benzin");
        osobne1.setVelkostNadrz(60);
        osobne1.setPalivo(50);
        osobne1.setMaxOsoby(5);
        */

        
        Console.WriteLine("----------------------------------------------------------");

        Console.WriteLine(nakladne1);
        Console.WriteLine(osobne1);
        osobne1.Natankuj(Auto.TypPaliva.Benzin,20);
        Console.WriteLine(osobne1);
        osobne1.radioshow();

        osobne1.setKmitocet(12.5);
        osobne1.radioshow();
        osobne1.setradio("on");
        osobne1.radioshow();
        osobne1.NastavPredvolbuRadio(10);
        osobne1.setKmitocet(10.5);
        osobne1.radioshow();
        osobne1.nastavNaPredvolbuRadio(10);
        osobne1.radioshow();


    }
}
