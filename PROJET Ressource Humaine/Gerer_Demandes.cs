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
    public partial class Gerer_Demandes : Form
    {
        private int mat;

        public Gerer_Demandes(int id)
        {
            InitializeComponent();
            this.mat = id;
        }

        MyBDD db = new MyBDD();


        public void refresh(int mat)
        {
            string requete = "Select * FROM demandes WHERE matricule_employe = '" + mat + "' AND Type_demande = '"+cbbType.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "demandes");

            dataGridView1.DataSource = ds.Tables["demandes"];
        }

        public string Datedemande(int mat, int id)
        {
            string dateDemande="";
            
                string requete = "SELECT Date_demande FROM demandes WHERE Matricule_employe = '" + mat + "' and ID_demande = '"+id+"'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dateDemande = dr.GetValue(0).ToString();
                }
                else
                {
                    dateDemande = DateTime.Now.ToString("yyyy-MM-dd");
                }
                dr.Close();
            
            
            return dateDemande;
        }

        private void Gerer_Demandes_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
            txtMatricule.Text = mat.ToString();
            

            try
            {
                db.openConnection();

                string requete = "Select * FROM demandes WHERE matricule_employe = '" + mat + "'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "demandes");

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Equals(""))
            {
                txtID.Text = 0.ToString();
            }

            int id = Convert.ToInt32(txtID.Text);

            try
            {
                MySqlCommand cmd;

                if (cbbType.SelectedItem.Equals("Salaire"))
                {
                    db.openConnection();
                    string requete = "INSERT INTO `demandes`(`Type_demande`, `Date_demande`, `Montant`, `Motif_demande`, `Matricule_employe`) VALUES (@type, @date, @motif, @montant, @matricule)";
                    cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = cbbType.SelectedItem.ToString();
                    cmd.Parameters.Add("@date", MySqlDbType.Date).Value = Datedemande(mat, id);
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@montant", MySqlDbType.Int32).Value = Convert.ToInt32(txtMontant.Text);
                    cmd.Parameters.Add("@matricule", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        label5.Visible = true;
                        label5.Text = "Demande effectué";
                        refresh(mat);
                    }
                }

                if (cbbType.SelectedItem.Equals("Formation"))
                {
                    db.openConnection();
                    string requete = "INSERT INTO `demandes`(`Type_demande`, `Date_demande`, `Motif_demande`, `Matricule_employe`) VALUES (@type, @date, @motif, @matricule)";
                    cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = cbbType.SelectedItem.ToString();
                    cmd.Parameters.Add("@date", MySqlDbType.Date).Value = Datedemande(mat,id);
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matricule", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        label5.Visible = true;
                        label5.Text = "Demande effectué";
                        refresh(mat);
                    }
                }

                if (cbbType.SelectedItem.Equals("Congé"))
                {
                    db.openConnection();
                    string requete = "INSERT INTO `demandes`(`Type_demande`, `Date_demande`, `Date_debut`, `Date_fin`, `Motif_demande`, `Matricule_employe`) VALUES (@type, @date, @dateDebut, @dateFin, @motif, @matricule)";
                    cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = cbbType.SelectedItem.ToString();
                    cmd.Parameters.Add("@date", MySqlDbType.Date).Value = Datedemande(mat, id);
                    cmd.Parameters.Add("@dateDebut", MySqlDbType.Date).Value = dateTimeDebut.Text;
                    cmd.Parameters.Add("@dateFin", MySqlDbType.Date).Value = dateTimeFin.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matricule", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);
                    if(cmd.ExecuteNonQuery() == 1)
                    {
                        label5.Visible = true;
                        label5.Text = "Demande effectué";
                        refresh(mat);
                    }
                    
                }



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

        private void btnRemplir_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ID_demande"].Value.ToString();
            dateTimeDemande.Text = dataGridView1.CurrentRow.Cells["Date_demande"].Value.ToString();
            txtMotif.Text = dataGridView1.CurrentRow.Cells["Motif_demande"].Value.ToString();

            try
            {
                if (cbbType.SelectedItem.Equals("Congé"))
                {
                    dateTimeDebut.Text = dataGridView1.CurrentRow.Cells["Date_debut"].Value.ToString();
                    dateTimeFin.Text = dataGridView1.CurrentRow.Cells["Date_fin"].Value.ToString();
                }
                if (cbbType.SelectedItem.Equals("Salaire"))
                {
                    txtMontant.Text = dataGridView1.CurrentRow.Cells["Montant"].Value.ToString();
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();

                if (cbbType.SelectedItem.Equals("Salaire"))
                {
                    string requete = "UPDATE demandes SET Montant = @montant, Motif_demande = @motif WHERE Matricule_employe = '"+Convert.ToInt32(txtMatricule.Text)+ "' AND ID_demande = '" + Convert.ToInt32(txtID.Text) + "' AND Reponse_demande is NULL";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@montant", MySqlDbType.Int32).Value = Convert.ToInt32(txtMontant.Text);
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    if(cmd.ExecuteNonQuery() == 1)
                    {
                        label5.Visible = true;
                        label5.Text = "Modification effectué";
                        refresh(mat);
                    }
                }
                if (cbbType.SelectedItem.Equals("Formation"))
                {
                    string requete = "UPDATE demandes SET Motif_demande = @motif WHERE Matricule_employe = '" + Convert.ToInt32(txtMatricule.Text) + "' AND ID_demande = '"+Convert.ToInt32(txtID.Text)+ "' AND Reponse_demande IS NULL";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        label5.Visible = true;
                        label5.Text = "Modification effectué";
                        refresh(mat);
                    }
                }
                if (cbbType.SelectedItem.Equals("Congé"))
                {
                    string requete = "UPDATE demandes SET Motif_demande = @motif, `Date_debut`= @dateDebut, Date_fin = @dateFin WHERE Matricule_employe = '" + Convert.ToInt32(txtMatricule.Text) + "' AND ID_demande = '" + Convert.ToInt32(txtID.Text) + "' AND Reponse_demande IS NULL";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@dateDebut", MySqlDbType.Date).Value = dateTimeDebut.Text;
                    cmd.Parameters.Add("@dateFin", MySqlDbType.Date).Value = dateTimeFin.Text;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        label5.Visible = true;
                        label5.Text = "Modification effectué";
                        refresh(mat);
                    }
                }
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

            //bloque-debloque les box en fonction du type de la demande
            if (cbbType.SelectedItem.Equals("Salaire"))
            {
                txtMontant.Enabled = true;
                dateTimeDebut.Enabled = false;
                dateTimeFin.Enabled = false;
            }
            if (cbbType.SelectedItem.Equals("Formation"))
            {
                txtMontant.Enabled = false;
                dateTimeDebut.Enabled = false;
                dateTimeFin.Enabled = false;
            }
            if (cbbType.SelectedItem.Equals("Congé"))
            {
                txtMontant.Enabled = false;
                dateTimeDebut.Enabled = true;
                dateTimeFin.Enabled = true;
            }



            //Affiche les information relative au type de la demande dans le datagridview
            try
            {
                db.openConnection();
                if (cbbType.SelectedItem.Equals("Salaire"))
                {
                    string requete = "Select ID_demande, Nom, Date_demande, Montant, Motif_demande FROM employes, demandes WHERE Matricule_employe = '" + mat + "' AND Matricule = Matricule_employe AND Type_demande = 'Salaire'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "salaire");
                    dataGridView1.DataSource = ds.Tables["salaire"];
                }
                if (cbbType.SelectedItem.Equals("Formation"))
                {
                    string requete = "Select ID_demande, Nom, Date_demande, Date_debut, Date_fin, Motif_demande FROM employes, demandes WHERE Matricule_employe = '" + mat + "' AND Matricule = Matricule_employe AND Type_demande = 'Formation'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    mda.Fill(ds, "Formation");
                    dataGridView1.DataSource = ds.Tables["Formation"];
                }
                if (cbbType.SelectedItem.Equals("Congé"))
                {
                    string requete = "Select ID_demande, Nom, Date_demande, Date_debut, Date_fin, Motif_demande FROM employes, demandes WHERE Matricule_employe = '"+mat+"' AND Matricule = Matricule_employe AND Type_demande = 'Congé'";
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
