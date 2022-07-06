using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROJET_Ressource_Humaine
{
    class ModifierEmploy
    {
        MyBDD db = new MyBDD();


        public bool modifEmploye(int matricule, int salaire, string poste)
        {
            string requete = "UPDATE employes SET salaire = '" + salaire + "', Poste = '" + poste + "' WHERE Matricule = '" + matricule + "'";
            MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
            db.openConnection();
            cmd.ExecuteNonQuery();

            if(cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }


        public bool VerifModif(string prenom, string nom)
        {
            string requete = ("SELECT * FROM `employes` WHERE `Prenom` LIKE '"+prenom +"' AND `Nom` LIKE '"+nom+"' ");
            MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

    }
}
