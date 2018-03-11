using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace gespressing
{
    class Client
    {
        private string codeClient;
        private string nomClient;
        private string prenomCli;
        private int telClient;

        private MySqlCommand Cmd = new MySqlCommand();
        private MySqlDataAdapter dr;
        private string Requete;
        private int i;
        public Client()
        {
           
            this.nomClient = "";
            this.telClient = 0;
            
        }
        public Client(string codeClient, string nomClient, int telClient)
        {
            this.codeClient = codeClient;
            this.nomClient = nomClient;
            this.telClient = telClient;
        }
        public int telclient
        {
            get { return this.telclient; }
            set { this.telClient = value; }
        }
        public string idClient
        {
            get { return this.codeClient; }
            set { this.codeClient = value; }
        }
        public string NomClient
        {
            get { return this.nomClient; }
            set { this.nomClient = value; }
        }
        public string addClient()
        {
            try
            {
                Cmd.CommandText = "INSERT INTO client1 VALUES(@code,@nom,@tel);";
                Cmd.Connection = Program.Con;
                Cmd.Parameters.AddWithValue("@id", this.codeClient);
                Cmd.Parameters.AddWithValue("@nom", this.nomClient);
                Cmd.Parameters.AddWithValue("@tel", this.telClient);
            return Convert.ToString(Cmd.ExecuteNonQuery()); ;
                
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpadateClient()
        {
            try
            {
                Cmd.CommandText = "UPDATE client1 SET nomClient=@nom,telClient=@tel WHERE idClient=@id;";
                Cmd.Connection = Program.Con;
                Cmd.Parameters.AddWithValue("@id", this.idClient);
                Cmd.Parameters.AddWithValue("@nom", this.nomClient);
                Cmd.Parameters.AddWithValue("@tel", this.telClient);
                return Convert.ToString(Cmd.ExecuteNonQuery()); ;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteClient()
        {
            try
            {
                Cmd.CommandText = "DELETE FROM client1 WHERE idCli=@id;";
                Cmd.Connection = Program.Con;
                Cmd.Parameters.AddWithValue("@id", this.idClient);
                return Convert.ToString(Cmd.ExecuteNonQuery()); ;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}
