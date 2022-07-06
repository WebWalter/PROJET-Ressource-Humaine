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
    public partial class Gerer_Absence : Form
    {

        //Objets
        MyBDD db = new MyBDD();


        public Gerer_Absence()
        {
            InitializeComponent();
        }


        

        private void Gerer_Absence_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 1;
            txtMatricule.Text = "";
            txtMotif.Text = "";
            txtDuree.Text = "";
            cbbID.Text = "";
            try
            {
                db.openConnection();
                string requete = "SELECT `ID` FROM `absences_retards`";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "ID");

                cbbID.DataSource = ds.Tables["ID"];
                cbbID.DisplayMember = "ID";
                cbbID.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
            
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //Affichage de la table d'absence si on selectionne --Absences-- dans le combobox
            if (cbbType.SelectedItem.Equals("Absences"))
            {
                string req = "SELECT Matricule_employe as Matricule, ID, Nom, Duree, Date_debut_absence as Date_Debut, Date_retour_absence as Date_retour, Motif as Motif FROM employes, absences_retards where employes.Matricule = absences_retards.Matricule_employe and type = 'Absences'";
                MySqlCommand command = new MySqlCommand(req, db.GetConnection);
                
                MySqlDataAdapter mda2 = new MySqlDataAdapter(command);
                mda2.Fill(ds, "Absence");

                dataGridView1.DataSource = ds.Tables["Absence"];

                if (dateTimeAbsenceDebut.Enabled == false && dateTimeAbsenceRetour.Enabled == false)
                {
                    dateTimeAbsenceDebut.Enabled = true;
                    dateTimeAbsenceRetour.Enabled = true;

                    dateTimeRetards.Enabled = false;
                    
                }
                else
                {
                    dateTimeRetards.Enabled = false;
                }
            }

            //Affichage de la table des retard si on selectionne --Retards-- dans le combobox
            if (cbbType.SelectedItem.Equals("Retards"))
            {
                string req = "SELECT Matricule_employe as Matricule, ID, Nom, Date_retard, Duree, Motif FROM employes, absences_retards where employes.Matricule = absences_retards.Matricule_employe and type = 'Retards'";
                MySqlCommand command = new MySqlCommand(req, db.GetConnection);
                MySqlDataAdapter mda2 = new MySqlDataAdapter(command);
                mda2.Fill(ds, "Retards");
                dataGridView1.DataSource = ds.Tables["Retards"];

                //ouverture des box du retard
                if (dateTimeRetards.Enabled == false)
                {
                    //On active les box essentiel pour enregistrer les retards
                    dateTimeRetards.Enabled = true;

                    //on desactive ceux de l'absence
                    dateTimeAbsenceRetour.Enabled = false;
                    dateTimeAbsenceDebut.Enabled = false;
                }
                else
                {
                    dateTimeAbsenceRetour.Enabled = false;
                    dateTimeAbsenceDebut.Enabled = false;
                }
                
                
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                db.openConnection();
                if (cbbType.SelectedItem.Equals("Retards"))
                {
                    string comboboxType = cbbType.SelectedItem.ToString();
                    string requete = "INSERT INTO `absences_retards`(`Duree`, `Type`, `Date_retard`, `Motif`, `Matricule_employe`) VALUES (@duree,@type,@dateRetard,@motif,@matEmploye)";
                    cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@duree", MySqlDbType.Int32).Value = Convert.ToInt32(txtDuree.Text);
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = comboboxType;
                    cmd.Parameters.Add("@dateRetard", MySqlDbType.Date).Value = dateTimeRetards.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matEmploye", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Gerer_Absence_Load(sender, e);
                    }
                }
                if (cbbType.SelectedItem.Equals("Absences"))
                {
                    string comboboxType = cbbType.SelectedItem.ToString();
                    string requete = "INSERT INTO `absences_retards`(`Duree`, `Type`, `Date_debut_absence`, `Date_retour_absence`, `Motif`, `Matricule_employe`) VALUES (@duree,@type,@dateDebutAbsence,@DateRetourAbsence,@motif,@matEmploye)";
                    cmd = new MySqlCommand(requete, db.GetConnection);
                    //@duree,@type,@dateDebutAbsence,@DateRetourAbsence,@motif,@matEmploye
                    cmd.Parameters.Add("@duree", MySqlDbType.Int32).Value = Convert.ToInt32(txtDuree.Text);
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = comboboxType;
                    cmd.Parameters.Add("@dateDebutAbsence", MySqlDbType.Date).Value = dateTimeAbsenceDebut.Text;
                    cmd.Parameters.Add("@dateRetourAbsence", MySqlDbType.Date).Value = dateTimeAbsenceRetour.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matEmploye", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Gerer_Absence_Load(sender, e);
                    }
                }
                
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void btnRemplir_Click(object sender, EventArgs e)
        {
            try
            {
                string requete = "SELECT * FROM absences_retards";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                db.openConnection();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtDuree.Text = dataGridView1.CurrentRow.Cells["Duree"].Value.ToString();
                    txtMotif.Text = dataGridView1.CurrentRow.Cells["Motif"].Value.ToString();
                    txtMatricule.Text = dataGridView1.CurrentRow.Cells["Matricule"].Value.ToString();
                    cbbID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

                    //si il s'agit d'un retards alors il va remplir les box dédier au retards
                    if (cbbType.SelectedItem.Equals("Retards"))
                    {
                        dateTimeRetards.Text = dataGridView1.CurrentRow.Cells["Date_retard"].Value.ToString();
                    }
                    //si il s'agit d'une absence, alors il va remplir les box dédier aux absences
                    if (cbbType.SelectedItem.Equals("Absences"))
                    {
                        dateTimeAbsenceDebut.Text = dataGridView1.CurrentRow.Cells["Date_Debut"].Value.ToString();
                        dateTimeAbsenceRetour.Text = dataGridView1.CurrentRow.Cells["Date_retour"].Value.ToString();
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

        public void afficherRetard()
        {
            try
            {
                db.openConnection();
                string req = "SELECT Matricule_employe as Matricule, ID, Nom, Date_retard, Duree, Motif FROM employes, absences_retards where employes.Matricule = absences_retards.Matricule_employe and type = 'Retards'";
                MySqlCommand command = new MySqlCommand(req, db.GetConnection);
                DataSet ds = new DataSet();
                MySqlDataAdapter mda2 = new MySqlDataAdapter(command);
                mda2.Fill(ds, "Retards");
                dataGridView1.DataSource = ds.Tables["Retards"];
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

        public void afficherAbsence()
        {
            try
            {
                db.openConnection();
                string req = "SELECT Matricule_employe as Matricule, ID, Nom, Duree, Date_debut_absence as Date_Debut, Date_retour_absence as Date_retour, Motif as Motif FROM employes, absences_retards where employes.Matricule = absences_retards.Matricule_employe and type = 'Absences'";
                MySqlCommand command = new MySqlCommand(req, db.GetConnection);
                DataSet ds = new DataSet();
                MySqlDataAdapter mda2 = new MySqlDataAdapter(command);
                mda2.Fill(ds, "Absence");

                dataGridView1.DataSource = ds.Tables["Absence"];
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
                if (cbbType.SelectedItem.Equals("Absences"))
                {
                    string comboboxType = cbbType.SelectedItem.ToString();
                    string requete = "UPDATE `absences_retards` SET `Duree`= @duree,`Date_debut_absence`= @dateDebutAbsence,`Date_retour_absence`= @dateRetourAbsence,`Motif`= @motif WHERE ID = @id AND Matricule_employe = @matEmploye ";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@duree", MySqlDbType.Int32).Value = Convert.ToInt32(txtDuree.Text);
                    cmd.Parameters.Add("@dateDebutAbsence", MySqlDbType.Date).Value = dateTimeAbsenceDebut.Text;
                    cmd.Parameters.Add("@dateRetourAbsence", MySqlDbType.Date).Value = dateTimeAbsenceRetour.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = comboboxType;
                    cmd.Parameters.Add("@matEmploye", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(cbbID.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        afficherAbsence();
                    }
                }
                if (cbbType.SelectedItem.Equals("Retards"))
                {
                    string requete = "UPDATE `absences_retards` SET `Duree`= @duree,`Date_retard`= @dateRetard, `Motif`= @motif WHERE ID = @id AND Matricule_employe = @matEmploye ";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@duree", MySqlDbType.Int32).Value = Convert.ToInt32(txtDuree.Text);
                    cmd.Parameters.Add("@dateRetard", MySqlDbType.Date).Value = dateTimeRetards.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matEmploye", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(cbbID.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        afficherRetard();
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
    }
}
