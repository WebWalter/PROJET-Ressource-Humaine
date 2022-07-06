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
    public partial class Cons_demandes : Form
    {
        private int mat;
        public Cons_demandes(int mat)
        {
            InitializeComponent();
            this.mat = mat;
        }

        MyBDD db = new MyBDD();

        private void Cons_demandes_Load(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "SELECT * From demandes WHERE Matricule_employe = '"+mat+"'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "demandes");

                dataGridView1.DataSource = ds.Tables["demandes"];
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
            if (cbbType.SelectedItem.Equals("Salaire"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * From demandes WHERE Type_demande = 'Salaire' AND Matricule_employe = '"+mat+"'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "demandes");

                    dataGridView1.DataSource = ds.Tables["demandes"];
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
            if (cbbType.SelectedItem.Equals("Formation"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * From demandes WHERE Type_demande = 'Formation' AND Matricule_employe = '"+mat+"'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "demandes");

                    dataGridView1.DataSource = ds.Tables["demandes"];
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
            if (cbbType.SelectedItem.Equals("Congé"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * From demandes WHERE Type_demande = 'Congé' AND Matricule_employe = '"+mat+"'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "demandes");

                    dataGridView1.DataSource = ds.Tables["demandes"];
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

        private void cbTout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTout.CheckState == CheckState.Checked)
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * From demandes";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "demandes");

                    dataGridView1.DataSource = ds.Tables["demandes"];
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

        private void cbbReponse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "SELECT * From demandes WHERE Reponse_demande = '" + cbbReponse.SelectedItem.ToString() + "' AND Matricule_employe = '" + mat + "'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "demandes");

                dataGridView1.DataSource = ds.Tables["demandes"];
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
