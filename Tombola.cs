using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Cartella
    {
        // Conta quanti numeri non zero ci sono in una riga
        static int ContaNumeri(int[,] cartella, int riga)
        {
            int cont = 0;
            for (int col = 0; col < 9; col++)
            {
                if (cartella[riga, col] != 0) cont++;
            }
            return cont;
        }

        // Crea il tabellone completo 1-90
        public int[,] Tabellone()
        {
            int[,] tabellone = new int[9, 10]; // 9 righe x 10 colonne
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    int numero = r * 10 + c + 1; // calcola numero
                    if (numero <= 90)
                        tabellone[r, c] = numero;
                }
            }
            return tabellone;
        }

        // Stampa il tabellone
        public void StampaTabellone(int[,] tabellone)
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (tabellone[r, c] != 0)
                        Console.Write(tabellone[r, c].ToString("D2") + "\t");
                }
                Console.WriteLine();
            }
        }

        // Genera una cartella 3x9 con 5 numeri per riga
        public int[,] Cards()
        {
            Random rnd = new Random();
            int[,] card = new int[3, 9];

            for (int r = 0; r < 3; r++)
            {
                while (ContaNumeri(card, r) < 5)
                {
                    int col = rnd.Next(0, 9); // colonna casuale
                    if (card[r, col] == 0)
                    {
                        int min = col * 10 + 1;
                        int max = Math.Min(min + 9, 90); // non superare 90
                        int numero = rnd.Next(min, max + 1);

                        // evita numeri duplicati nella stessa colonna
                        bool duplicato = false;
                        for (int rr = 0; rr < 3; rr++)
                        {
                            if (card[rr, col] == numero)
                            {
                                duplicato = true;
                                break;
                            }
                        }
                        if (!duplicato)
                            card[r, col] = numero;
                    }
                }
            }

            return card;
        }

        // Stampa una cartella
        public void StampaCartella(int[,] cartella)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    Console.Write(cartella[r, c].ToString("D2") + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Avvia()
        {
            Console.WriteLine("Il gioco si avvia...\n");
        }

        public static void Main(string[] args)
        {
            Cartella c1 = new Cartella();

            // Genera e stampa il tabellone completo
            int[,] tabellone = c1.Tabellone();
            c1.Avvia();
            Console.WriteLine("Tabellone completo da 1 a 90:");
            c1.StampaTabellone(tabellone);
            Console.WriteLine();

            // Input numero di giocatori e cartelle per giocatore
            Console.Write("Quanti giocatori partecipano? ");
            int numeroGiocatori = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quante cartelle per giocatore? ");
            int numCartellePerGiocatore = Convert.ToInt32(Console.ReadLine());

            // Lista di liste di cartelle (una lista per ogni giocatore)
            List<List<int[,]>> cartelleGiocatori = new List<List<int[,]>>();

            for (int g = 0; g < numeroGiocatori; g++)
            {
                List<int[,]> cartelleGiocatore = new List<int[,]>();
                for (int c = 0; c < numCartellePerGiocatore; c++)
                {
                    int[,] cartella = c1.Cards();
                    cartelleGiocatore.Add(cartella);
                }
                cartelleGiocatori.Add(cartelleGiocatore);
            }

            // Stampa tutte le cartelle per ogni giocatore
            for (int g = 0; g < cartelleGiocatori.Count; g++)
            {
                Console.WriteLine($"\nGiocatore {g + 1}:");
                List<int[,]> cartelle = cartelleGiocatori[g];

                for (int k = 0; k < cartelle.Count; k++)
                {
                    Console.WriteLine($"\n Cartella {k + 1}:");
                    c1.StampaCartella(cartelle[k]);
                }
            }
        }
    }
}