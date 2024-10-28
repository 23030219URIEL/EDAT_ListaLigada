using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! LISTA LIGADA SIMPLE");

        var singleList = new SingleList<string>();
        int option = 0;
        do
        {
            option = Menu();
            switch (option)
            {
                case 1: AgregarElemento(); break;
                case 2: break;
                case 3: break;
                default: Console.WriteLine("Esta opción no existe"); break;
            }

        } while (option != 0);

        void AgregarElemento()
        {
            Console.WriteLine("Escribir el nombre del nodo");
            var data = Console.ReadLine();
            singleList.Add(data);
        }

        void MostrarLista() {

            Console.WriteLine(singleList);
        }

        Console.WriteLine(singleList);
        Console.ReadKey();
    }

    private static int Menu()
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Agregar elemento");
        Console.WriteLine("2. Mostrar lista");
        Console.WriteLine("0. Salir");

        bool esValido = false;
        int option = 0;
        do
        {
            Console.WriteLine("Elige una opción del menu");
            var opcionValida = Console.ReadLine();
            if (!int.TryParse(opcionValida, out option) || option < 0 || option > 2)
            {
                Console.WriteLine("Digite una opción valida");
                esValido = true;
            }
            else
            {
                esValido = true;
            }
        }
        while (esValido == false);
        return option;
    }
}