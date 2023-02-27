using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] hedelmät = { "mandariini", "banaani", "luumu", "omena", "kiivi" }; //listan alustus
        Console.WriteLine("Tehtava 8.1"); //tulostaa tehtävän nimen ja numeron
        Console.WriteLine(); //tyhjä rivi
        Console.WriteLine("-------------"); //katkoviiva
        Console.Write("Montako hedelmää haluat nähdä? "); //kysyy käyttäjältä halutun määrän hedelmiä
        int aloitusNumero = int.Parse(Console.ReadLine()); //käyttäjäsyöte, parsittu string-syötteestä tyyppiin int
        for (int i = aloitusNumero; i > 0; i--) //for-silmukka, jonka kautta käyttäjän määrittämä määrä hedelmiä tulostuu. Jos arvoalue määritellään >= 0, tulostuu 4kpl hedelmiä
        {
            Console.WriteLine(hedelmät[i]); //tulostuslause, tulostetaan dataa hedelmät-listasta for-silmukan i-muuttujan määrittelemän määrän verran
        }
    }
}