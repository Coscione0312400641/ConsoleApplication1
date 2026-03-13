using System;
using System.Collections.Generic;
namespace ConsoleApplication1;

public class Program2
{
    class Calcolatrice
    {
        public static int somma(int dx, int dy)
        {
            return dx + dy;
        }
    }

    class Calcolatore
    {
        public int SommaUno(int ms, int my)
        {
            return ms + my;
        }

        public int SommaUno(int ms, int my, int mz)
        {
            return ms + my + mz;
        }

        public double SommaUno(double ms, double mz)
        {
            return ms + mz;
        }
    }
    internal class Program
    {
        
        static void calcola(int aa, int bb, out int sommatoria, out int prodotto)
        {
            sommatoria = aa + bb;
            prodotto = aa*bb;
        }
        static void aumenta(ref int numbr)
        {
            numbr = numbr + 10;
            Console.WriteLine(numbr);
        }

        class Persone
        {
            public string nombre;

            public void Saluta()
            {
                Console.WriteLine("Ciao sono " + nombre);
            }

/*
            public static void Main(string[] args)
            {
                Random random = new Random();
                //metodi
                Calcolatore cc=new Calcolatore();
                Console.WriteLine(cc.SommaUno(10, 20));
                Console.WriteLine(cc.SommaUno(10,20,49));
                Console.WriteLine(cc.SommaUno(10.2,25.7));
                
                int sv;
                int pv;
                calcola(4,3,out sv,out pv);
                Console.WriteLine("La somma è "+sv);
                Console.WriteLine("Il prodotto è "+pv);
                int kappa = 5;
                aumenta(ref kappa);
                int risultato = Calcolatrice.somma(10, 20);
                Console.WriteLine(risultato);
                Persone p1 = new Persone();
                p1.nombre = "Mario";
                p1.Saluta();
                //liste
                List<int> numerini = new List<int>();
                for (int er = 0; er < 5; er++)
                {
                    Console.WriteLine("Inserisci un numero ");
                    int number = int.Parse(Console.ReadLine());
                }

                numerini.Add(1);
                numerini.Add(2);
                for (int tt = 0; tt < numerini.Count; tt++)
                    foreach (int mv in numerini)
                    {
                        Console.WriteLine(mv);
                    }

                numerini.Remove(2);
                if (numerini.Contains(1))
                {
                    Console.WriteLine("Il numero esiste");
                }

                //esercizio su list
                List<string> Persona = new List<string>();
                string name = "";
                int nom = 0;
                bool pr = false;
                while (pr != true)
                {
                    Console.WriteLine("Inserisci un numero ");
                    nom = int.Parse(Console.ReadLine());
                    switch (nom)
                    {
                        case 1:
                            Console.WriteLine("Aggiungo Persona, scrivi il nome");
                            name = Console.ReadLine();
                            Persona.Add(name);
                            break;
                        case 2:
                            Console.WriteLine("Mostra lista");
                            for (int z = 0; z < Persona.Count; z++)
                            {
                                Console.WriteLine(Persona[z]);
                            }

                            break;
                        case 3:
                            Console.WriteLine("Scrivi il nome da cercare");
                            name = Console.ReadLine();
                            if (Persona.Contains(name))
                            {
                                Console.WriteLine("Il nome esiste");
                            }
                            else
                            {
                                Console.WriteLine("Il nome non esiste");
                            }

                            break;
                        case 4:
                            Console.WriteLine("Rimozione contatto, scrivi quale");
                            name = Console.ReadLine();
                            if (Persona.Contains(name))
                            {
                                Console.WriteLine("Il nome esiste, procedo con l'eliminazione");
                                Persona.Remove(name);
                            }

                            for (int zz = 0; zz < Persona.Count; zz++)
                            {
                                Console.WriteLine(Persona[zz]);
                            }

                            break;
                        case 0:
                            Console.WriteLine("Uscita");
                            pr = true;
                            break;


                    }
                }

                //array
                int[] numeri = { 10, 20, 30 };
                int[] numeri2 = new int[3];
                numeri2[0] = 10;
                numeri2[1] = 20;
                numeri2[2] = 30;
                for (int i = 0; i < numeri.Length; i++)
                {
                    Console.WriteLine(numeri[i]);
                }

                foreach (int n in numeri2)
                {
                    Console.WriteLine(n);
                }


            int[] numeri3 = new int[5];
            for (int i = 0; i < numeri3.Length; i++)
            {
                Console.WriteLine("Inserisci numero");
                numeri3[i]=int.Parse(Console.ReadLine());
                //Console.WriteLine(numeri3[i]);
            }

                int[] numeri4 = { 5, 10, 20, 25, 30 };
                int somma = 0;
                for (int i = 0; i < numeri4.Length; i++)
                {
                    somma += numeri4[i];
                }

                Console.WriteLine("La somma è " + somma);
                //esercizio 1 array
                int[] a = new int[5];
                for (int j = 0; j < a.Length; j++)
                {
                    Console.WriteLine("Inserisci intero " + j);
                    a[j] = int.Parse(Console.ReadLine());

                }

                for (int jj = 0; jj < a.Length; jj++)
                {
                    Console.WriteLine(a[jj]);
                }

                //Esercizio 2
                int[] b = { 1, 4, 7, 10, 15, 19, 26, 30, 40, 50 };
                int soma = 0;
                for (int k = 0; k < b.Length; k++)
                {
                    soma += b[k];
                }

                Console.WriteLine("La somma è " + soma);
                //esercizio 3
                int[] c = { 5, 12, 3, 20, 7, 9 };
                int maggiore = 0;
                for (int l = 0; l < c.Length; l++)
                {
                    if (c[l] > maggiore)
                    {
                        maggiore = c[l];
                    }
                }

                Console.WriteLine(maggiore);
                int[,] matrice =
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                };
                for (int w = 0; w < 2; w++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        Console.Write(matrice[w, x] + " ");
                    }

                    Console.WriteLine();
                }

                int[,] matr = new int[2, 3];
                for (int y = 0; y < 2; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write("Inserisci un numero ");
                        //matrice[y,z]=+int.Parse(Console.ReadLine());
                        matrice[y, z] = random.Next(1, 91);
                        Console.Write(matrice[y, z]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }

                //esercizio 1 array 2D
                int[,] mat1 =
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };
                for (int q = 0; q < 3; q++)
                {
                    for (int qq = 0; qq < 3; qq++)
                    {
                        Console.Write(mat1[q, qq]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
                int[,] mat2 = new int[2, 3];
                for (int r = 0; r < 2; r++)
                {
                    for (int rr = 0; rr < 3; rr++)
                    {
                        Console.Write("Inserisci numero ");
                        mat2[r, rr] = int.Parse(Console.ReadLine());
                        Console.Write(mat2[r, rr]);
                        Console.Write(" ");

                    }

                    for (int var = 0; var < 2; var++)
                    {
                        for (int varr = 0; varr < 3; varr++)
                        {
                            Console.Write(mat2[var, varr]);
                            Console.Write(" ");
                        }

                        Console.WriteLine();

                    }
                }

                int numero_scelto = 0;
                Console.WriteLine("Esercizio 3: inserisci numero righe matrice");
                numero_scelto = int.Parse(Console.ReadLine());
                int colonne_scelte = 0;
                Console.WriteLine("Esercizio 3: inserisci numero colonne matrice");
                colonne_scelte = int.Parse(Console.ReadLine());
                int[,] mat3 = new int[numero_scelto, colonne_scelte];
                int so = 0;
                int so_riga = 0;
                int so_diag = 0;
                for (int k = 0; k < numero_scelto; k++)
                {
                    so_riga = 0;
                    for (int kj = 0; kj < colonne_scelte; kj++)
                    {
                        mat3[k, kj] = random.Next(1, 51);
                        Console.Write(mat3[k, kj]);
                        Console.Write(" ");
                        so += mat3[k, kj];
                        so_riga += mat3[k, kj];
                        if (numero_scelto == colonne_scelte)
                        {
                            if (k == kj)
                            {
                                so_diag += mat3[k, kj];
                            }
                        }

                        Console.WriteLine("Riga " + kj + " ha la somma di: " + so_riga);
                    }

                    Console.WriteLine("Somma dei numeri della diagonale " + so_diag);

                }

                for (int gg = 0; gg < numero_scelto; gg++)
                {
                    for (int qg = 0; qg < colonne_scelte; qg++)
                    {
                        Console.Write(mat3[gg, qg]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }
            }*/
        }
            } 
    }
    /*using System;

namespace ConsoleApplication1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Random random = new Random();
            int nu=random.Next(1,10);
            Console.WriteLine(nu);
            for (int h= 0; h < 10; h++)
            {
                int numeroUno = random.Next(1, 11);
                Console.WriteLine(numeroUno);
            }
            //esercizio 1 random
            int numeroDue = random.Next(1, 7);
            int numeroFacce = random.Next(1, 21);
            int numeroDadi = 0;
            Console.WriteLine("Scegli il numero di dadi");
            string appoggio=Console.ReadLine();
            numeroDadi=Convert.ToInt32(appoggio);
            for (int cubo = 0; cubo < numeroDadi; cubo++)
            {
                Console.WriteLine("Lancio del dado: " + cubo);
                Console.WriteLine("Numero dadi uscito: "+ random.Next(1, numeroFacce));
            }

            //esercizio 2 random
            int lancio = 0;
            string tentativo = "";
            int conve = 0;
            Console.WriteLine("Gioco del numero casuale");
            while (true)
            {
                nu = random.Next(1, 50);
                tentativo=Console.ReadLine();
                conve=Convert.ToInt32(tentativo);
                if (nu> conve)
                {
                    Console.WriteLine("Numero troppo basso, riprova");
                }
                else if (nu < conve)
                {
                    Console.WriteLine("Numero troppo alto, riprova");
                }
                else
                {
                    Console.WriteLine("Numero ESATTO, Hai indovinato!");
                    break;
                }
            }
            for (int l = 1; l <= 5; l++)
            {
                Console.WriteLine("Numero " + l);
            }

            Console.WriteLine("esercizio 1");
            for (int a=10;a>=1;a--)
            {
                Console.WriteLine("Numero " + a);
            }
            Console.WriteLine("esercizio 2");
            for (int q = 1; q <= 20; q++)
            {
                if (q % 2 == 0)
                    Console.WriteLine("Numero " + q);
            }
            Console.WriteLine("esercizio 3");
            for(int ii=0;ii<=50;ii++)
            {
                if (ii % 5== 0)
                    Console.WriteLine("Numero " + ii);
            }
            Console.WriteLine("esercizio 4, inserisci numero");
            //esercizio 4
            string numo=Console.ReadLine();
            int numero=Convert.ToInt32(numo);
            int j = 0;
            for (int v = 1; v <= numero; v++)
            {
                j += v;
                //Console.WriteLine(j); 
            }
            Console.WriteLine(j);
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //esercizi while
            Console.WriteLine("Esercizio while 1");
            int m = 1;
            while (m <= 20)
            {
                if (m % 3 == 0)
                    Console.WriteLine(m);
                m++;
            }
            Console.WriteLine("Esercizio while 2: inserisci numero");
            string numero2 = Console.ReadLine();
            int p=Convert.ToInt32(numero2);
            while (p != 0)
            {
                Console.WriteLine("inserisci numero intero");
                numero2 = Console.ReadLine();
                p = Convert.ToInt32(numero2);
            }

            //esercizio 3
            Console.WriteLine("Esercizio while 3: inserisci numero intero");
            string numero3 = Console.ReadLine();
            int numero4 = Convert.ToInt32(numero3);
            while (numero4 >= 0)
            {
                Console.WriteLine("Esercizio while 3: inserisci altro intero");
                numero3=Console.ReadLine();
                numero4 = Convert.ToInt32(numero3);
            }

            int somma = 0;
            int w = 1;
            while (w <= 5)
            {
                Console.WriteLine("Esercizio while 4: inserisci l'intero "+w);
                numero3=Console.ReadLine();
                numero4 = Convert.ToInt32(numero3); 
                somma += numero4;
                w += 1;
            }
            Console.WriteLine(somma);
            int r = 1;
            do
            {
                Console.WriteLine("Numero " + r);
                r++;
            } while (r <= 10);

            int number=0;
            while (true)
            {
                Console.WriteLine("Inserisci un numero (0 per uscire) " + number);
                number=int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("Uscita in corso");
                    break;
                }
                Console.WriteLine("Hai inserito questo numero: " + number);
            }
            //esercizio do while 1
            string psw = "password";
            Console.WriteLine("Password richiesta");
            string alph=Console.ReadLine();
            do
            {
                if (alph == "password") Console.WriteLine("Confermata la password");
                else
                {
                    Console.WriteLine("Hai inserito password errata, riprova");
                    alph = Console.ReadLine();
                }
        } while (alph != psw);
           
            Console.WriteLine("Password corretta");
            //esercizio 2 do while
            string prova = "";
            Console.WriteLine("Inserisci un numero");
            int passeggio=Convert.ToInt32(Console.ReadLine());
            do
            {
                if(passeggio <0 && passeggio >10)
                {
                    Console.WriteLine("Inserisci un numero valido");
                    prova = Console.ReadLine();
                    passeggio = Convert.ToInt32(prova);
                }
            } while (passeggio < 0 && passeggio > 10);
            
            //esercizio 3 do while
            Console.WriteLine("Esercizio 3");
            Console.WriteLine("Menù, digita un numero per avviare");
            
            string richiesta = Console.ReadLine();
            int intero = Convert.ToInt32(richiesta);
            
            do
            {
                Console.WriteLine("1 stampa stringa, 2 stampa intero,3 converti in float,0 exit");
                richiesta = Console.ReadLine();
                intero = Convert.ToInt32(richiesta);
                
                switch (intero)
                {
                    case 1:
                        Console.WriteLine("Scelta 1: stampa questa stringa");
                        break;
                    case 2:
                        Console.WriteLine("Scelta 2: stampa " + 50);
                        break;
                    case 3:
                        Console.WriteLine("Scelta 3 " + Convert.ToDouble(intero));
                        break;
                    

                }
            } while (intero != 0); 
            Console.WriteLine("Scelta 0: Uscita");
            
            //esercizio 4 do while
            
            string pas = "";
            int passaggio = 0;
            int conto = 0;
            do
            {
                Console.WriteLine("Inserisci numero");
                passaggio=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Programma in corso");
                if (passaggio!=0)
                    conto ++;
            } while(passaggio!=0);
            Console.WriteLine("Sono stati inseriti "+conto+" numeri");

        }
    }
}*/