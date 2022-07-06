using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROJET_Ressource_Humaine
{
    class MyBDD
    {
        //Connexion à la base de données
        MySqlConnection connect = new MySqlConnection("Server=localhost;Database=ressh;Uid=root;Pwd=;");


        //retourne la connexion vers la base de données
        public MySqlConnection GetConnection
        {
            get { return connect; }
        }

        //Ouvre la connexion à la base de données
        public void openConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        //Ferme la connexion à la base de données
        public void closeConnection()
        {
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
