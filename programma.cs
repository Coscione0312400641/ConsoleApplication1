/*using System;
using System.IO;
using System.Collections.Generic;

namespace linq
{
    public class Programma
    {
        static void Main(string[] args)
        {
            string path = "studenti.txt";

            Console.WriteLine("1 Inserisci");
            Console.WriteLine("2 Visualizza");
            Console.WriteLine("3 Aggiorna");
            Console.WriteLine("4 Elimina");

            int scelta = int.Parse(Console.ReadLine());

            List<string> righe = new List<string>();

            //
            if (File.Exists(path))
                righe = new List<string>(File.ReadAllLines(path));

            switch (scelta)
            {
                case 1: // Inserisci
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Cognome: ");
                    string cognome = Console.ReadLine();

                    Console.Write("Eta: ");
                    string eta = Console.ReadLine();

                    righe.Add($"{nome},{cognome},{eta}");
                    File.WriteAllLines(path, righe);

                    Console.WriteLine("Studente inserito");
                    break;

                case 2: // Visualizza + conteggio righe
                    Console.WriteLine("\nElenco studenti:");

                    for (int i = 0; i < righe.Count; i++)
                        Console.WriteLine($"{i}: {righe[i]}");

                    Console.WriteLine($"\nNumero righe: {righe.Count}");
                    break;

                case 3: // Aggiorna
                    Console.Write("Indice riga da modificare: ");
                    int index = int.Parse(Console.ReadLine());

                    if (index >= 0 && index < righe.Count)
                    {
                        Console.Write("Nuova riga (nome,cognome,eta): ");
                        string nuova = Console.ReadLine();

                        righe[index] = nuova;
                        File.WriteAllLines(path, righe);

                        Console.WriteLine("Aggiornato");
                    }
                    else
                    {
                        Console.WriteLine("Indice non valido");
                    }
                    break;

                case 4: // Elimina
                    Console.Write("Indice riga da eliminare: ");
                    int delete = int.Parse(Console.ReadLine());

                    if (delete >= 0 && delete < righe.Count)
                    {
                        righe.RemoveAt(delete);
                        File.WriteAllLines(path, righe);

                        Console.WriteLine("Eliminato");
                    }
                    else
                    {
                        Console.WriteLine("Indice non valido");
                    }
                    break;
            }
        }
    }
}*/