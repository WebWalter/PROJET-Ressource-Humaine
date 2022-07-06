using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROJET_Ressource_Humaine
{
    class AjoutEmployer
    {
        //connection à la base de donnée
        MyBDD db = new MyBDD();

        public bool AjoutEmploy(int matricule, string prenom, string nom, string mdp, string sexe, int tel, string poste, string email, int salaire, string statut, string photo)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `employes`(`Matricule`,`Prenom`, `Nom`, `Mdp`, `Sexe`, `numTel`, `Poste`, `Email`, `Salaire`, `Statut_Actuel`, `Photo`) VALUES (@matricule,@prenom,@nom,@mdp,@sexe,@numTel,@poste,@email,@salaire, @statut, @photo)", db.GetConnection);

            //@matricule,@prenom,@nom,@mdp,@sexe,@nomTel,@poste,@email,@salaire
            cmd.Parameters.Add("@matricule",MySqlDbType.Int32).Value = matricule;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = mdp;
            cmd.Parameters.Add("@sexe", MySqlDbType.VarChar).Value = sexe;
            cmd.Parameters.Add("@numTel", MySqlDbType.Int32).Value = tel;
            cmd.Parameters.Add("@poste", MySqlDbType.VarChar).Value = poste;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@salaire", MySqlDbType.Int32).Value = salaire;
            cmd.Parameters.Add("@statut", MySqlDbType.VarChar).Value = statut;
            cmd.Parameters.Add("@photo", MySqlDbType.VarChar).Value = photo;


            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return  true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }

        public bool verifAjout(string prenom, string nom)
        {
            string requete = ("SELECT * FROM `employes` WHERE `Prenom` LIKE '"+prenom+"' AND `Nom` LIKE '"+nom+"'");
            MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
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
