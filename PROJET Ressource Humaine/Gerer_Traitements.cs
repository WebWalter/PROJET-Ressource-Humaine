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
    public partial class Gerer_Traitements : Form
    {
        public Gerer_Traitements()
        {
            InitializeComponent();
        }

        MyBDD db = new MyBDD();

        private void Gerer_Traitements_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        private void btnRemplir_Click(object sender, EventArgs e)
        {
            txtMatricule.Text = dataGridView1.CurrentRow.Cells["Matricule_employe"].Value.ToString();
            dateTimeDemandes.Text = dataGridView1.CurrentRow.Cells["Date"].Value.ToString();
            txtMotif.Text = dataGridView1.CurrentRow.Cells["Motif"].Value.ToString();
            if (cbbType.SelectedItem.Equals("Salaire"))
            {
                txtMontant.Text = dataGridView1.CurrentRow.Cells["Montant"].Value.ToString();
            }
            if (cbbType.SelectedItem.Equals("Congé"))
            {
                dateTimeDebutDemande.Text = dataGridView1.CurrentRow.Cells["Date_debut"].Value.ToString();
                dateTimeFinDemandes.Text = dataGridView1.CurrentRow.Cells["Date_fin"].Value.ToString();
            }
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnAccepter_Click(object sender, EventArgs e)
        {
            dateTimeDemandes.Text = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                db.openConnection();
                if (cbbType.SelectedItem.Equals("Salaire") || cbbType.SelectedItem.Equals("Congé"))
                {
                    string requete = "UPDATE demandes SET Reponse_demande = 'Accepter', Date_reponse = '" + dateTimeDemandes.Text + "' Where ID_demande = '" + txtID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        txtID.Text = "";
                        txtMatricule.Text = "";
                        txtMontant.Text = "";
                        txtMotif.Text = "";
                        dateTimeDemandes.Text = dataGridView1.CurrentRow.Cells["Date_demande"].Value.ToString();
                    }
                }
                if (cbbType.SelectedItem.Equals("Formation"))
                {
                    string requete = "UPDATE demandes SET Date_debut=@dateDebut, Date_fin = @dateFin,Reponse_demande = 'Accepter', Date_reponse = '" + dateTimeDemandes.Text + "' Where ID_demande = '" + txtID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@dateDebut", MySqlDbType.Date).Value = dateTimeDebutDemande.Text;
                    cmd.Parameters.Add("@dateFin", MySqlDbType.Date).Value = dateTimeFinDemandes.Text;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        txtID.Text = "";
                        txtMatricule.Text = "";
                        txtMontant.Text = "";
                        txtMotif.Text = "";
                        dateTimeDemandes.Text = dataGridView1.CurrentRow.Cells["Date_demande"].Value.ToString();
                    }
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

        private void btnRefuser_Click(object sender, EventArgs e)
        {
            dateTimeDemandes.Text = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                db.openConnection();

                string requete = "UPDATE demandes SET Reponse_demande = 'Refuser', Date_reponse = '" + dateTimeDemandes.Text + "' Where ID_demande = '" + txtID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                if(cmd.ExecuteNonQuery() == 1)
                {
                    txtID.Text = "";
                    txtMatricule.Text = "";
                    txtMontant.Text = "";
                    txtMotif.Text = "";
                    dateTimeDemandes.Text = dataGridView1.CurrentRow.Cells["Date_demande"].Value.ToString();
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

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bloque-debloque les box en fonction du type de la demande
            if (cbbType.SelectedItem.Equals("Salaire"))
            {
                txtMontant.Enabled = true;
                dateTimeDebutDemande.Enabled = false;
                dateTimeFinDemandes.Enabled = false;
                txtMontant.Text = "";
                txtMotif.Text = "";
                txtID.Text = "";
                txtMatricule.Text = "";
            }
            if (cbbType.SelectedItem.Equals("Formation"))
            {
                dateTimeDebutDemande.Enabled = true;
                dateTimeFinDemandes.Enabled = true;
                txtMontant.Enabled = false;
                txtMontant.Text = "";
                txtMotif.Text = "";
                txtID.Text = "";
                txtMatricule.Text = "";
            }
            if (cbbType.SelectedItem.Equals("Congé"))
            {
                dateTimeDebutDemande.Enabled = false;
                dateTimeFinDemandes.Enabled = false;
                txtMontant.Enabled = false;
                txtMontant.Text = "";
                txtMotif.Text = "";
                txtID.Text = "";
                txtMatricule.Text = "";
            }



            //Affiche les information relative au type de la demande dans le datagridview
            try
            {
                db.openConnection();
                if (cbbType.SelectedItem.Equals("Salaire"))
                {
                    string requete = "Select ID_demande as ID, Nom, Date_demande as Date, Montant, Motif_demande as Motif, Matricule_employe FROM employes, demandes WHERE Matricule = Matricule_employe AND Type_demande = 'Salaire' AND Reponse_demande IS NULL";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "salaire");
                    dataGridView1.DataSource = ds.Tables["salaire"];
                }
                if (cbbType.SelectedItem.Equals("Formation"))
                {
                    string requete = "Select ID_demande as ID, Nom, Date_demande as Date, Date_debut, Date_fin, Motif_demande as Motif, Matricule_employe FROM employes, demandes WHERE Matricule = Matricule_employe AND Type_demande = 'Formation' AND Reponse_demande IS NULL";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "Formation");
                    dataGridView1.DataSource = ds.Tables["Formation"];
                }
                if (cbbType.SelectedItem.Equals("Congé"))
                {
                    string requete = "Select ID_demande as ID, Nom, Date_demande as Date, Date_debut, Date_fin, Motif_demande as Motif, Matricule_employe FROM employes, demandes WHERE Matricule = Matricule_employe AND Type_demande = 'Congé' AND Reponse_demande IS NULL";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "Conges");
                    dataGridView1.DataSource = ds.Tables["Conges"];
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
    }
}
