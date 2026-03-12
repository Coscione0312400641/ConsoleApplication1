using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class Esercizio
    {
        public void Saluta()
        {
            Console.WriteLine("Ciao");
        }

        public void StampaNumero(int n)
        {
            Console.WriteLine(n);
          
        }

        public int Somma(int addendo1, int addendo2)
        {
            return addendo1 + addendo2;
        }

        public int Differ(int sottraendo, int sottratto)
        {
            return sottraendo - sottratto;
        }
        public int Prodotto(int fatto1,int fatto2)
        {
            return fatto1 * fatto2;
        }

        public int Divisi(int dividendo, int divisore)
        {
            return dividendo / divisore;
        }
        
    }
    class Calcolatore
    {
        public int Area(int lato)
        {
            return lato * lato;
        }

        public int Area(int bas,int altezza)
        {
            return bas*altezza;
        }

        public double Area(double raggio)
        {
            return raggio*raggio*3.14;
        }

        private int[] valori = new int[3];
        public void LeggiNumero(int posizione, int nn)
        {
            valori[posizione] = nn;
        }

        public int SommaNumero()
        {
            return valori[0] + valori[1];
        }

        public double Media()
        {
            return (valori[0] + valori[1] + valori[2]) / 3.0;
        }

        public int Maggiore()
        {
            int max = valori[0];

            if (valori[1] > max)
                max = valori[1];

            if (valori[2] > max)
                max = valori[2];

            return max;
        }
    }
    
    class Persona
    {
        public string nombre;
        public int eta;

        public void Presentati(string nombre, int eta)
        {
            Console.WriteLine("Ciao sono " + nombre + " e ho " + eta + " anni");
        }
    }

    internal class Program
    {
        static void Raddoppia(ref int numbr)
        {
            numbr = numbr *2;
            Console.WriteLine(numbr);
        }

        static void Calcola(int aa, int bb, out int somma, out int differenza)
        {
            somma = aa + bb;
            differenza = aa - bb;
        }
        public static void Main(string[] args)
        {
            //esercizio 1
            Esercizio e1 = new Esercizio();
            e1.Saluta();
            //esercizio 2
            e1.StampaNumero(19);
            int pq = 0;
            Console.WriteLine("Inserisci numero");
            pq=int.Parse(Console.ReadLine());
            e1.StampaNumero(pq);
            //esercizio 3
            int pq1 = 4;
            Console.WriteLine("La somma è "+e1.Somma(pq, pq1));
            Console.WriteLine("La differenza è "+ e1.Differ(pq1, pq));
            Console.WriteLine("Il prodotto è "+e1.Prodotto(pq,pq1));
            Console.WriteLine("La divisione è: "+e1.Divisi(pq,pq1));
            //Esercizio 4
            Persona p1=new Persona();
            p1.Presentati("Marco",25);
            //Esercizio 5
            int kappa = 5;
            Raddoppia(ref kappa);
            //Esercizio 6
            int res = 0;
            Calcola(4,7,out res,out kappa);
            Console.WriteLine("Somma e differenza: "+res+" "+kappa);
            //Esercizio 7
            Calcolatore cc=new Calcolatore();
            Console.WriteLine(cc.Area(10));
            Console.WriteLine(cc.Area(10,20));
            Console.WriteLine(cc.Area(10.0)); 
            //Esercizio 8
            Console.WriteLine("numero uno");
            cc.LeggiNumero(0, pq);

            Console.WriteLine("numero due");
            cc.LeggiNumero(1, pq1);

            Console.WriteLine("numero tre");
            cc.LeggiNumero(2, 7);

            Console.WriteLine("Somma: " + cc.SommaNumero());
            Console.WriteLine("Media: " + cc.Media());
            Console.WriteLine("Maggiore: " + cc.Maggiore());
//esercizi metodi class 
            var conto = new ContoBancario(1000);
            conto.Deposita(200);
            Console.WriteLine("Conto "+conto.Saldo);
            conto.Preleva(90);
            Console.WriteLine("Conto finale "+conto.Saldo);
            Auto miaAuto = new Auto();
            miaAuto.Marca = "Fiat";
            miaAuto.NumeroPorte = 4;
            miaAuto.Avvia();//metodo ereditato
            miaAuto.SuonaClacson();
            Animale[] animali =
            {
                new Cane(),
                new Gatto()
            };

            foreach (Animale a in animali)
            {
                a.FaiVerso();
            }
        }
    }

}

         