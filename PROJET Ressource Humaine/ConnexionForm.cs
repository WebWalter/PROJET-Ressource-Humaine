using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_Ressource_Humaine
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
        }

        /***** Les objets de classe *****/

        MyBDD db = new MyBDD();

        /********************************/

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnView_CheckedChanged(object sender, EventArgs e)
        {
            if(btnView.Checked == true)
            {
                txtMotdepasse.UseSystemPasswordChar = false;
            }
            if(btnView.Checked == false)
            {
                txtMotdepasse.UseSystemPasswordChar = true;
            }
        }

        private void txtMotdepasse_TextChanged(object sender, EventArgs e)
        {
            txtMotdepasse.UseSystemPasswordChar = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MenuAll RHMF;
            try
            {
                db.openConnection();
                string requete = "Select * From employes Where Prenom = '" + txtPrenom.Text + "' AND Mdp = '" + txtMotdepasse.Text + "'";
                MySqlCommand command = new MySqlCommand(requete, db.GetConnection);
                MySqlDataReader mda = command.ExecuteReader();
                if (mda.Read())
                {
                    if (mda["Poste"].ToString().Equals("Simple utilisateur"))
                    {
                        if (mda["Sexe"].ToString().Equals("Masculin"))
                        {
                            RHMF = new MenuAll(Convert.ToInt32(mda[0].ToString()),mda[1].ToString(), mda[2].ToString(), mda[6].ToString(), mda["Photo"].ToString());
                            RHMF.Show();
                        }
                        else
                        {
                            RHMF = new MenuAll(Convert.ToInt32(mda[0].ToString()), mda[1].ToString(), mda[2].ToString(), mda[6].ToString(), mda["Photo"].ToString());
                            RHMF.Show();
                        }
                    }
                    if (mda[6].ToString().Equals("PDG"))
                    {
                        RHMF = new MenuAll(Convert.ToInt32(mda[0].ToString()), mda[1].ToString(), mda[2].ToString(), mda[6].ToString(), mda["Photo"].ToString());
                        RHMF.Show();
                    }
                    if (mda[6].ToString().Equals("Ressources Humaine"))
                    {
                        RHMF = new MenuAll(Convert.ToInt32(mda[0].ToString()), mda[1].ToString(), mda[2].ToString(), mda[6].ToString(), mda["Photo"].ToString());
                        RHMF.Show();
                    }
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
            
        }

    }
}
