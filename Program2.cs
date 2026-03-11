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


            public static void Main(string[] args)
            {
                Random random = new Random();
                //metodi
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

/*
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
                }*/
            }
        }
            } 
    }