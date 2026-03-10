using System;

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
}