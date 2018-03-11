using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace gespressing
{
    class Facture
    {
        private string codeFacture;
        private string libelleFacture;
        private DateTime dateFacture;
        private DateTime datedepot;

        private MySqlCommand Cmd = new MySqlCommand();
        private MySqlDataAdapter dr;
        private string Requete;
        private int i;
        public Facture()
        {
            this.codeFacture = "";
            this.libelleFacture  = "";
            this.dateFacture = DateTime.Today;
            this.datedepot = DateTime.Today;
        }
        public Facture(string codeFacture, string libelleFacture, DateTime dateFacture ,DateTime datedepot)
        {
            this.codeFacture = "codeFacture";
            this.libelleFacture = "libelleFacture";
            this.dateFacture = DateTime.Today;
            this.datedepot = DateTime.Today;
        }
        public string CodeFacture
        {
            get { return codeFacture; }
            set { codeFacture = value; }
        }
        public string LibelleFacture
        {
            get { return libelleFacture; }
            set { libelleFacture = value; }
        }
        public DateTime DateFacture
        {
            get { return DateFacture; }
            set { DateFacture = value; }
        }
        public DateTime Datedepot
        {
            get { return datedepot; }
            set { datedepot = value; }
        }

        public string addFacture()
        {
            try
            {
                Cmd.CommandText = "INSERT INTO Facture VALUES(@code,@libelle,@dateFacture,@datedepot);";
                Cmd.Connection = Program.Con;
                Cmd.Parameters.AddWithValue("@code", this.codeFacture);
                Cmd.Parameters.AddWithValue("@libelle", this.libelleFacture);
                Cmd.Parameters.AddWithValue("@dateFacture", this.dateFacture);
                Cmd.Parameters.AddWithValue("@datedepot", this.datedepot);
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
                Cmd.CommandText = "UPDATE INTO Facture VALUES(@code,@libelle,@dateFacture,@datedepot);";
                Cmd.Connection = Program.Con;
                Cmd.Parameters.AddWithValue("@code", this.codeFacture);
                Cmd.Parameters.AddWithValue("@libelle", this.libelleFacture);
                Cmd.Parameters.AddWithValue("@dateFacture", this.dateFacture);
                Cmd.Parameters.AddWithValue("@datedepot", this.datedepot);
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
                Cmd.CommandText = "DELETE FROM Facture WHERE codeFacture=@code;";
                Cmd.Connection = Program.Con;
                Cmd.Parameters.AddWithValue("@code", this.codeFacture);
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



