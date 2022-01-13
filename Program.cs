using System;
class ArrayExample
{
    static void Main()
    {
        //Define un array de caracteres llamado letters
        //Se reserva memoria para ... elementos de tipo char
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        //Nos muestra valores enteros de 10 caracteres
        int[] a = new int[10];
        //Variable for que nos suma 1 al valor i, mostrandonos el nombre mas el valor a
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    //Mensaje que aparece en la consola al depurar el codigo
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}