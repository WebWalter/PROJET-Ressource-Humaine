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
    public partial class Cons_employes : Form
    {
        public Cons_employes()
        {
            InitializeComponent();
        }

        MyBDD db = new MyBDD();

        private void Cons_employes_Load(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "Select * From employes";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "Employes");

                dataGridView1.DataSource = ds.Tables["Employes"];

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedItem.Equals("Ressources Humaine"))
            {
                try
                {
                    db.openConnection();
                    string requete = "Select * From employes WHERE Poste = 'Ressources Humaine'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "Employes");

                    dataGridView1.DataSource = ds.Tables["Employes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
            if (cbbType.SelectedItem.Equals("PDG"))
            {
                try
                {
                    db.openConnection();
                    string requete = "Select * From employes WHERE Poste = 'PDG'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "Employes");

                    dataGridView1.DataSource = ds.Tables["Employes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
            if (cbbType.SelectedItem.Equals("Simple utilisateur"))
            {
                try
                {
                    db.openConnection();
                    string requete = "Select * From employes WHERE Poste = 'Simple utilisateur'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "Employes");

                    dataGridView1.DataSource = ds.Tables["Employes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }

        private void btnChercherID_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "Select * From employes WHERE Matricule = '"+Convert.ToInt32(txtMatricule.Text)+"'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "Employes");

                dataGridView1.DataSource = ds.Tables["Employes"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void cbChercherTout_CheckedChanged(object sender, EventArgs e)
        {
            if(cbChercherTout.CheckState == CheckState.Checked)
            {
                try
                {
                    db.openConnection();
                    string requete = "Select * From employes";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "Employes");

                    dataGridView1.DataSource = ds.Tables["Employes"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }
    }
}
