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
    public partial class Cons_sanctions : Form
    {
        public Cons_sanctions()
        {
            InitializeComponent();
        }

        MyBDD db = new MyBDD();

        private void Cons_sanctions_Load(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "SELECT * FROM sanctions";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                mda.Fill(ds, "sanctions");
                dataGridView1.DataSource = ds.Tables["sanctions"];
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
            if(cbbType.SelectedItem.Equals("Avertissement ou blâme"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * FROM sanctions WHERE Type = 'Avertissement ou blâme'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "sanctions");
                    dataGridView1.DataSource = ds.Tables["sanctions"];
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
            if (cbbType.SelectedItem.Equals("Mise à pied"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * FROM sanctions WHERE Type = 'Mise à pied'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "sanctions");
                    dataGridView1.DataSource = ds.Tables["sanctions"];
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
            if (cbbType.SelectedItem.Equals("Mutation"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * FROM sanctions WHERE Type = 'Mutation'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "sanctions");
                    dataGridView1.DataSource = ds.Tables["sanctions"];
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
            if (cbbType.SelectedItem.Equals("Rétrogradation"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * FROM sanctions WHERE Type = 'Rétrogradation'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "sanctions");
                    dataGridView1.DataSource = ds.Tables["sanctions"];
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
            if (cbbType.SelectedItem.Equals("Licenciement"))
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * FROM sanctions WHERE Type = 'Licenciement'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "sanctions");
                    dataGridView1.DataSource = ds.Tables["sanctions"];
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

        private void cbChercherTout_CheckedChanged(object sender, EventArgs e)
        {
            if(cbChercherTout.CheckState == CheckState.Checked)
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT * FROM sanctions";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "sanctions");
                    dataGridView1.DataSource = ds.Tables["sanctions"];
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
                string requete = "SELECT * FROM sanctions WHERE Matricule_employe = '"+Convert.ToInt32(txtMatricule.Text)+"'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                mda.Fill(ds, "sanctions");
                dataGridView1.DataSource = ds.Tables["sanctions"];
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
