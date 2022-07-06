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
    public partial class Atelier_Employer : Form
    {
        public Atelier_Employer()
        {
            InitializeComponent();
        }

        MyBDD db = new MyBDD();
        AjoutEmployer aje = new AjoutEmployer();

        

        

        

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            int matricule = Convert.ToInt32(txtMatricule.Text);
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            string mdp = txtMdp.Text;
            int salaire = Convert.ToInt32(txtSalaire.Text);
            string sexe = "";
            string statut = "Actif";
            string photo = "";
            if (rdMasculin.Checked)
            {
                sexe = "Masculin";
                photo = "0";
            }
            if (rdFeminin.Checked)
            {
                sexe = "Féminin";
                photo = "1";
            }
            int tel = Convert.ToInt32(txtTel.Text);
            string poste = "";
            if (cbPoste.SelectedItem == "PDG")
            {
                poste = "PDG";
            }
            if (cbPoste.SelectedItem == "Ressources Humaine")
            {
                poste = "Ressources Humaine";
            }
            if (cbPoste.SelectedItem == "Simple utilisateur")
            {
                poste = "Simple utilisateur";
            }
            string email = txtEmail.Text;



            try
            {
                if (!aje.verifAjout(prenom, nom))
                {
                    if (aje.AjoutEmploy(matricule, prenom, nom, mdp, sexe, tel, poste, email, salaire, statut, photo))
                    {
                        txtMatricule.Clear();
                        txtPrenom.Clear();
                        txtNom.Clear();
                        txtPrenom.Clear();
                        txtMdp.Clear();
                        txtTel.Clear();
                        cbPoste.SelectedIndex = 1;
                        rdFeminin.Checked = false;
                        rdMasculin.Checked = false;

                        Atelier_Employer_Load(sender, e);
                    }
                    else
                    {
                        lblReponse.Visible = true;
                        lblReponse.Text = prenom + " " + nom + " n'a pas été ajouté(e) à la base de données !";
                    }
                }
                else
                {
                    lblReponse.Visible = true;
                    lblReponse.Text = prenom + " " + nom + " est déjà inscrit dans la base de données !";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Les differents saisi utilisé pour la modification
            int matricule = Convert.ToInt32(txtMatricule.Text);
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            int salaire = Convert.ToInt32(txtSalaire.Text);
            string email = txtEmail.Text;
            string poste = "";
            if (cbPoste.SelectedItem == "PDG")
            {
                poste = "PDG";
            }
            if (cbPoste.SelectedItem == "Ressource Humaine")
            {
                poste = "Ressource Humaine";
            }
            if (cbPoste.SelectedItem == "Simple utilisateur")
            {
                poste = "Simple utilisateur";
            }



            try
            {
                //modification effectuer
                ModifierEmploy me = new ModifierEmploy();

                if (me.VerifModif(prenom, nom))
                {
                    if (me.modifEmploye(matricule, salaire, poste))
                    {
                        txtEmail.Clear();
                        Atelier_Employer_Load(sender, e);
                    }
                    else
                    {
                        lblReponse.Visible = true;
                        lblReponse.Text = prenom + " " + nom + " n'a pas pu être modifié!";
                    }
                }
                else
                {
                    lblReponse.Visible = true;
                    lblReponse.Text = prenom + " " + nom + " n'est pas dans la base de données!";
                }




                //actualisation des champs utilisés
                txtMatricule.Clear();
                txtPrenom.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtMdp.Clear();
                txtTel.Clear();
                rdFeminin.Checked = false;
                rdMasculin.Checked = false;

                cbPoste.SelectedItem = 2;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void btnRemplir_Click(object sender, EventArgs e)
        {
            txtMatricule.Text = dataGridView1.CurrentRow.Cells["Matricule"].Value.ToString();
            txtPrenom.Text = dataGridView1.CurrentRow.Cells["Prenom"].Value.ToString();
            txtNom.Text = dataGridView1.CurrentRow.Cells["Nom"].Value.ToString();
            txtMdp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["numTel"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtSalaire.Text = dataGridView1.CurrentRow.Cells["Salaire"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Poste"].Value.ToString().Equals("PDG"))
            {
                cbPoste.SelectedIndex = 0;
            }
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals("Ressources Humaine"))
            {
                cbPoste.SelectedIndex = 1;
            }
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals("Simple utilisateur"))
            {
                cbPoste.SelectedIndex = 2;
            }
            string genre = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            if (genre.Equals("Masculin"))
            {
                rdMasculin.Checked = true;
            }
            else
            {
                rdFeminin.Checked = true;
            }
        }

        private void Atelier_Employer_Load(object sender, EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = true;
            lblReponse.Visible = false;
            cbPoste.SelectedIndex = 2;

            string requete = "SELECT Matricule,Prenom,Nom,Mdp,Sexe,numTel,Poste,Email,Statut_Actuel,Salaire FROM `employes`";
            MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            db.openConnection();

            DataSet ds = new DataSet();
            adapter.Fill(ds, requete);

            dataGridView1.DataSource = ds.Tables[requete];
        }

        private void chbMdp_CheckedChanged(object sender, EventArgs e)
        {
            if(chbMdp.CheckState == CheckState.Checked)
            {
                txtMdp.UseSystemPasswordChar = false;
            }
            else
            {
                txtMdp.UseSystemPasswordChar = true;
            }
        }
    }
}
