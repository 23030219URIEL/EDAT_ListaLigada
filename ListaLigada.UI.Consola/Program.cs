using ListaLigada.Logica;

internal class Program

{
    private static void Main(string[] args)
    {
        



        var singleList = new SingleList<string>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Pris");
        singleList.Add("Luis");
        singleList.Add("Uriel");

        Console.WriteLine(singleList);

        Console.ReadKey();
    }
}