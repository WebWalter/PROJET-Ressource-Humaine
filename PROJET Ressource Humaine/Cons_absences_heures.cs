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
    public partial class Cons_absences_heures : Form
    {
        public Cons_absences_heures()
        {
            InitializeComponent();
        }

        MyBDD db = new MyBDD();

        private void Cons_absences_heures_Load(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "select * from absences_retards";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                mda.Fill(ds, "absences_retards");
                dataGridView1.DataSource = ds.Tables["absences_retards"];
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
            try
            {
                db.openConnection();
                if (cbbType.SelectedItem.Equals("Retards"))
                {
                    string requete = "SELECT Matricule_employe as Matricule, ID, Nom, Date_retard, Duree, Motif FROM employes, absences_retards WHERE employes.Matricule = absences_retards.Matricule_employe and type = 'Retards'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "Retards");
                    dataGridView1.DataSource = ds.Tables["Retards"];
                }
                if (cbbType.SelectedItem.Equals("Absences"))
                {
                    string requete = "SELECT Matricule_employe as Matricule, ID, Nom, Duree, Date_debut_absence as Date_Debut, Date_retour_absence as Date_retour, Motif as Motif FROM employes, absences_retards where employes.Matricule = absences_retards.Matricule_employe and type = 'Absences'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "Absences");
                    dataGridView1.DataSource = ds.Tables["Absences"];
                }
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

        private void cbTout_CheckedChanged(object sender, EventArgs e)
        {

            if(cbTout.CheckState == CheckState.Checked)
            {
                try
                {
                    db.openConnection();
                    string requete = "select * from absences_retards";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "absences_retards");
                    dataGridView1.DataSource = ds.Tables["absences_retards"];
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

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "Select * From absences_retards WHERE Matricule_employe = '"+Convert.ToInt32(txtMatricule.Text)+"'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "Absences_Retards_ID");

                dataGridView1.DataSource = ds.Tables["Absences_Retards_ID"];

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
