using System;
using MySql.Data.MySqlClient;

class Program
{ 
    static void Main(string[] args)
    {
        string connStr = "server=localhost;database=musica;user=root;password=root;";

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            Console.WriteLine("Connessione riuscita");

            //----------------
            // CREATE
            //----------------
            string insertQuery = "INSERT INTO cd (titolo,artista,anno,genere) VALUES (@titolo,@artista,@anno,@genere)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);

            insertCmd.Parameters.AddWithValue("@titolo", "Start of Something Good");
            insertCmd.Parameters.AddWithValue("@artista", "Daughtry");
            insertCmd.Parameters.AddWithValue("@anno", 2009);
            insertCmd.Parameters.AddWithValue("@genere", "Rock");

            insertCmd.ExecuteNonQuery();
            Console.WriteLine("CD inserito");

            //----------------
            // READ
            //----------------
            string selectQuery = "SELECT * FROM cd";
            MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);

            using (MySqlDataReader reader = selectCmd.ExecuteReader())
            {
                Console.WriteLine("\nLista CD:");
                while (reader.Read())
                {
                    Console.WriteLine(
                        reader["id"] + " " +
                        reader["titolo"] + " " +
                        reader["artista"] + " " +
                        reader["anno"] + " " +
                        reader["genere"]);
                }
            } 

            //----------------
            // UPDATE
            //----------------
            string updateQuery = "UPDATE cd SET anno=@anno WHERE id=1";
            MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);

            updateCmd.Parameters.AddWithValue("@anno", 2010);
            updateCmd.ExecuteNonQuery();
            Console.WriteLine("\nCD aggiornato");

            //----------------
            // DELETE
            //----------------
            string deleteQuery = "DELETE FROM cd WHERE id=1";
            MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);

            deleteCmd.ExecuteNonQuery();
            Console.WriteLine("CD eliminato");
        }
    }
}