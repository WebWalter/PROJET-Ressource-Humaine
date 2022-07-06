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
    public partial class Cons_salaires : Form
    {
        public Cons_salaires()
        {
            InitializeComponent();
        }

        MyBDD db = new MyBDD();

        private void Cons_salaires_Load(object sender, EventArgs e)
        {
            txtMontantMax.Enabled = false;
            txtMontantMin.Enabled = false;

            try
            {
                db.openConnection();
                string requete = "SELECT Matricule, Prenom, Nom, Poste, Salaire, Duree, Type FROM employes, absences_retards WHERE Matricule_employe = Matricule AND  Statut = 'Injustifié'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "paiements");
                
                dataGridView1.DataSource = ds.Tables["paiements"];
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
            try
            {
                db.openConnection();
                string requete = "SELECT Matricule, Prenom, Nom, Poste, Salaire, Duree, Type FROM employes, absences_retards WHERE Matricule_employe = Matricule AND  Statut = 'Injustifié'";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds, "paiements");

                dataGridView1.DataSource = ds.Tables["paiements"];
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

        private void btnChercherID_Click(object sender, EventArgs e)
        {
            if(cbMontantMax.CheckState == CheckState.Unchecked && cbMontantMin.CheckState == CheckState.Unchecked)
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT Matricule, Prenom, Nom, Poste, Salaire, Duree, Type FROM employes, absences_retards WHERE Matricule_employe = '"+Convert.ToInt32(txtMatricule.Text)+"' AND  Statut = 'Injustifié'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "paiements");

                    dataGridView1.DataSource = ds.Tables["paiements"];
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
            if (cbMontantMax.CheckState == CheckState.Checked && cbMontantMin.CheckState == CheckState.Checked)
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT Matricule, Prenom, Nom, Poste, Salaire, Duree, Type FROM employes, absences_retards WHERE Matricule_employe = Matricule AND  Statut = 'Injustifié' AND Between '"+Convert.ToInt32(txtMontantMax.Text)+"' AND '"+Convert.ToInt32(txtMontantMin.Text)+"' ";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "salaires");

                    dataGridView1.DataSource = ds.Tables["salaires"];
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
            if (cbMontantMax.CheckState == CheckState.Checked && cbMontantMin.CheckState == CheckState.Unchecked)
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT Matricule, Prenom, Nom, Poste, Salaire, Duree, Type FROM employes, absences_retards WHERE Matricule_employe = Matricule AND  Statut = 'Injustifié' AND Salaire <= '"+Convert.ToInt32(txtMontantMax.Text)+"' ";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "salaires");

                    dataGridView1.DataSource = ds.Tables["salaires"];
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
            if (cbMontantMax.CheckState == CheckState.Unchecked && cbMontantMin.CheckState == CheckState.Checked)
            {
                try
                {
                    db.openConnection();
                    string requete = "SELECT Matricule, Prenom, Nom, Poste, Salaire, Duree, Type FROM employes, absences_retards WHERE Matricule_employe = Matricule AND  Statut = 'Injustifié' AND Salaire >= '" + Convert.ToInt32(txtMontantMax.Text) + "' ";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "salaires");

                    dataGridView1.DataSource = ds.Tables["salaires"];
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

        private void cbMontantMax_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMontantMax.CheckState == CheckState.Checked)
            {
                txtMontantMax.Enabled = true;
            }
            else
            {
                txtMontantMax.Enabled = false;
            }
        }

        private void cbMontantMin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMontantMin.CheckState == CheckState.Checked)
            {
                txtMontantMin.Enabled = true;
            }
            else
            {
                txtMontantMin.Enabled = false;
            }
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        public int SalaireEmp(int Matricule)
        {
            int salaire = 0;
            int absences = 0;
            int retards = 0;
            try
            {
                db.openConnection();
                string requeteSalaire = "Select salaire from employes Where Matricule = '" + Matricule + "'";
                string requeteAbsence = "Select Duree from employes,absences_retards Where Matricule = '" + Matricule + "' And Type = 'Absences'";
                string requeteRetard = "Select Duree from employes,absences_retards Where Matricule = '" + Matricule + "' And Type = 'Retards'";
                MySqlCommand cmdSalaire = new MySqlCommand(requeteSalaire, db.GetConnection);
                MySqlCommand cmdAbsence = new MySqlCommand(requeteAbsence, db.GetConnection);
                MySqlCommand cmdRetard = new MySqlCommand(requeteRetard, db.GetConnection);
                DataSet ds = new DataSet();
                MySqlDataReader drS = cmdSalaire.ExecuteReader();
                if (drS.Read())
                {
                    salaire = Convert.ToInt32(drS.GetValue(0).ToString());

                }
                drS.Close();
                MySqlDataReader drA = cmdAbsence.ExecuteReader();
                if (drA.Read())
                {
                    absences = Convert.ToInt32(drA.GetValue(0).ToString());
                }
                drA.Close();
                MySqlDataReader drR = cmdRetard.ExecuteReader();
                if (drR.Read())
                {
                    retards = Convert.ToInt32(drR.GetValue(0).ToString());

                }
                drR.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }

            salaire -= (absences * 1000) + (retards * 100);

            return salaire;
        }


        public int absenceEmp (int Matricule)
        {

            int absences = 0;
            try
            {
                db.openConnection();
                
                string requeteAbsence = "Select Duree from employes,absences_retards Where Matricule = '" + Matricule + "' And Type = 'Absences'";
                
                MySqlCommand cmdAbsence = new MySqlCommand(requeteAbsence, db.GetConnection);
                MySqlDataReader dr = cmdAbsence.ExecuteReader();

                if (dr.Read())
                {
                    absences = Convert.ToInt32(dr.GetValue(0).ToString());
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

            return absences;
        }

        public int retardEmp(int Matricule)
        {

            int retards = 0;
            try
            {
                db.openConnection();

                string requeteAbsence = "Select Duree from employes,absences_retards Where Matricule = '" + Matricule + "' And Type = 'Retards'";

                MySqlCommand cmdRetard = new MySqlCommand(requeteAbsence, db.GetConnection);
                MySqlDataReader dr = cmdRetard.ExecuteReader();

                if (dr.Read())
                {
                    retards = Convert.ToInt32(dr.GetValue(0).ToString());
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

            return retards;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("======= Résumé salaire =======", new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold),Brushes.Red,new Point(180));
            e.Graphics.DrawString("Matricule de l'employé : " + dataGridView1.CurrentRow.Cells["Matricule"].Value.ToString(), new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Nom de l'employé : " + dataGridView1.CurrentRow.Cells["Prenom"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["Nom"].Value.ToString(), new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 120));
            e.Graphics.DrawString("Poste : " + dataGridView1.CurrentRow.Cells["Poste"].Value.ToString() , new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 140));
            e.Graphics.DrawString("Salaire : " + SalaireEmp(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Matricule"].Value.ToString())) + " FDJ" , new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 160));
            e.Graphics.DrawString("Absences : " + absenceEmp(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Matricule"].Value.ToString())) + " Jours", new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 180));
            e.Graphics.DrawString("Retards : " + retardEmp(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Matricule"].Value.ToString())) + " Heures", new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 200));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToString("yyyy-MM-dd"), new Font(FontFamily.GenericMonospace, 18, FontStyle.Regular), Brushes.Blue, new Point(50, 220));

            e.Graphics.DrawString("======= Ressources Humaine =======", new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold), Brushes.Red, new Point(80,300));
        }
    }
}
