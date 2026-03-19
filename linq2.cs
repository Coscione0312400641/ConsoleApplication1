
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    public class linq2
    {
        static void Main(string[] args)
        {
            string basePath = AppContext.BaseDirectory;

            string jsonPath = Path.Combine(basePath, "studente.json");
            string csvPath = Path.Combine(basePath, "studenti.csv");

            List<Studente> studenti;

            // LETTURA JSON
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                studenti = JsonSerializer.Deserialize<List<Studente>>(json) ?? new List<Studente>();
            }
            else
            {
                studenti = new List<Studente>();
            }

            Console.WriteLine("1 Inserisci JSON");
            Console.WriteLine("2 Visualizza JSON");
            Console.WriteLine("3 Elimina JSON");
            Console.WriteLine("4 Leggi CSV (nome e cognome)");
            Console.WriteLine("5 Filtra CSV per età");
            Console.WriteLine("6 Ordina CSV per età");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    InserisciStudente(jsonPath, studenti);
                    break;

                case 2:
                    Visualizza(studenti);
                    break;

                case 3:
                    EliminaStudente(jsonPath, studenti);
                    break;

                case 4:
                    LeggiCSV(csvPath);
                    break;

                case 5:
                    FiltraCSV(csvPath);
                    break;

                case 6:
                    OrdinaCSV(csvPath);
                    break;
            }
        }

        // ✅ AGGIUNTA JSON
        static void InserisciStudente(string path, List<Studente> studenti)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Eta: ");
            int eta = int.Parse(Console.ReadLine());

            studenti.Add(new Studente
            {
                Nome = nome,
                Cognome = cognome,
                Eta = eta
            });

            File.WriteAllText(path, JsonSerializer.Serialize(studenti, new JsonSerializerOptions { WriteIndented = true }));
        }

        // ✅ VISUALIZZA
        static void Visualizza(List<Studente> studenti)
        {
            foreach (var s in studenti)
            {
                Console.WriteLine($"{s.Nome} {s.Cognome} {s.Eta}");
            }
        }

        // ✅ ELIMINA
        static void EliminaStudente(string path, List<Studente> studenti)
        {
            Console.Write("Indice studente: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < studenti.Count)
            {
                studenti.RemoveAt(index);
                File.WriteAllText(path, JsonSerializer.Serialize(studenti, new JsonSerializerOptions { WriteIndented = true }));
            }
            else
            {
                Console.WriteLine("Indice non valido");
            }
        }

        // ✅ LETTURA CSV (nome e cognome)
        static void LeggiCSV(string path)
        {
            var righe = File.ReadAllLines(path);

            foreach (var riga in righe.Skip(1)) // salta intestazione
            {
                var parti = riga.Split(',');

                Console.WriteLine($"{parti[0]} {parti[1]}");
            }
        }

        // ✅ FILTRO PER ETÀ
        static void FiltraCSV(string path)
        {
            Console.Write("Eta minima: ");
            int min = int.Parse(Console.ReadLine());

            var righe = File.ReadAllLines(path);

            foreach (var riga in righe.Skip(1))
            {
                var p = riga.Split(',');

                int eta = int.Parse(p[2]);

                if (eta >= min)
                {
                    Console.WriteLine($"{p[0]} {p[1]} {eta}");
                }
            }
        }

        // ✅ ORDINAMENTO
        static void OrdinaCSV(string path)
        {
            var righe = File.ReadAllLines(path);

            var studenti = righe.Skip(1)
                .Select(r =>
                {
                    var p = r.Split(',');
                    return new Studente
                    {
                        Nome = p[0],
                        Cognome = p[1],
                        Eta = int.Parse(p[2])
                    };
                })
                .OrderBy(s => s.Eta);

            foreach (var s in studenti)
            {
                Console.WriteLine($"{s.Nome} {s.Cognome} {s.Eta}");
            }
        }
    }

    class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
    }
}