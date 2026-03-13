using System;
using System.Collections.Generic;
namespace Tombola
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

        public decimal Montepremi(int players, int card_scelte)
        {
            return players * card_scelte * 0.50m;//50 cents a cartella
        }

        
        public List<decimal> SoldiVinci(decimal premio)
        {
            List<decimal> tombolata = new List<decimal>();
            tombolata.Add(premio*0.01m);//soldi per l'ambo
            tombolata.Add(premio*0.09m);//soldi per il terno
            tombolata.Add(premio*0.2m);//soldi per la quaterna
            tombolata.Add(premio*0.3m);//soldi per la cinquina
            tombolata.Add(premio*0.4m);//soldi per la tombola
            return tombolata;
            //Ambo 1%,terno 9%,quaterna 20%,cinquina 30%,tombola40%
        }
        
    }
    class Program
    {
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
                List<int[,]> cartelleDue = cartelleGiocatori[g];

                for (int k = 0; k < cartelleDue.Count; k++)
                {
                    Console.WriteLine($"\n Cartella {k + 1}:");
                    c1.StampaCartella(cartelleDue[k]);
                }
            }
            decimal cassa=c1.Montepremi(numeroGiocatori, numCartellePerGiocatore);
            Console.WriteLine("Il montepremi da dividere è: "+cassa);
            List<decimal> divisiPremio=c1.SoldiVinci(cassa);
            Console.WriteLine("Ecco le possibili vincite" + divisiPremio);
            for (int k = 0; k < divisiPremio.Count; k++)
            {
                if (k == 0)
                    Console.WriteLine($"\n Ambo: ");
                else if (k == 1)
                    Console.WriteLine($"\n Terno: ");
                else if (k == 2)
                    Console.WriteLine($"\n Quaterna: "); 
                else if (k == 3)
                    Console.WriteLine($"\n Cinquina: ");
                else
                {
                    Console.WriteLine($"\n Tombola: ");
                }
                Console.WriteLine(divisiPremio[k]);
            }

            // ###########################################################
            // ############## CODICE DELLA PRIMA PARTE ###################
            // ###########################################################
            List<int[,]> tutteCartelle = new List<int[,]>();

            foreach (var giocatore in cartelleGiocatori)
            {
                foreach (var cartella in giocatore)
                {
                    tutteCartelle.Add(cartella);
                }
            }
  
            
            int n_cartelle = tutteCartelle.Count;
            int[][,] cartelle = tutteCartelle.ToArray();
            
            // Arrivo ad iniziare il gioco. 
            // Iniziamo ad estrarre un target, che sarà a quanto dobbiamo arrivare
            int target = 2; 
            
            // Definisco inoltre la flag del target, per segnalare se il target è già stato raggiunto
            // ad esempio, ambo già stato fatto
            bool flag_target = false;
            
            // Definisco le cartelle di flag delle vittorie. Mi sembra il modo migliore sia la matrice 3D
            bool[][,] matrici_flag = new bool[n_cartelle][,];
            for (int i = 0; i < n_cartelle; i++)
            {
                matrici_flag[i] = new bool[cartelle[0].GetLength(0),cartelle[0].GetLength(1)];
            }

            //Primo passo, definisco la variabile per estrarre i numeri e giocare
            Gioco game = new Gioco();
            
            game.Genera_tabellone();
            game.Stampa_cartellone();
            
            game.Estrai_numero();
            game.Stampa_numero();
            game.Aggiorna_tabellone();
            game.Stampa_cartellone();
            
            // continua finchè qualcuno non fa tombola. 5 sono cinquina, 6 tombola, 7 è finito.
            while (target < 7)
            {
                
                
                game.Estrai_numero();
                game.Aggiorna_tabellone();
                //game.Stampa_numero();
                
                // Ok ora voglio fare il check di ogni cartella direi
                for (int k = 0; k < n_cartelle; k++)
                {
                    game.Check_cartella(cartelle[k], ref matrici_flag[k]);
                    game.Check_vittorie(k, matrici_flag[k], target, ref flag_target);
                }

                // Se la flag è vera, incremento il target e riporto la flag falsa e daje.
                if (flag_target)
                {
                    target++;
                    flag_target = false;
                }
                // A questo punto non manca nulla. 
            }
            
            Console.WriteLine("Gioco finito, complimenti al vincitore!!!");
            
        }
        
    }
}

