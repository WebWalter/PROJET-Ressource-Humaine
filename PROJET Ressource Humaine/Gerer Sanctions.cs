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
    public partial class Gerer_Sanctions : Form
    {

        MyBDD db = new MyBDD();

        public Gerer_Sanctions()
        {
            InitializeComponent();
        }

        private void Gerer_Sanctions_Load(object sender, EventArgs e)
        {
            //Desactive les box inutile
            dateTimeRetourSanction.Enabled = false;

            //Remplir le datagridview des données de la base de donnée
            try
            {
                db.openConnection();
                string requete = "SELECT * FROM sanctions";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                mda.Fill(ds, "sanctions");

                dataGridView1.DataSource = ds.Tables["sanctions"];

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetValue(2).ToString() == DateTime.Now.ToString("yyyy-MM-dd"))
                    {
                        string req = "UPDATE employes SET `Statut_Actuel` = 'ACTIF' WHERE Matricule = '" + Convert.ToInt32(dr.GetValue(6).ToString()) + "'";
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string requete = "INSERT INTO `sanctions`(`Date_sanction`, `Type`, `Motif`, `Matricule_employe`) VALUES (@dateSanction, @type, @motif,  @matricule)";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                cmd.Parameters.Add("@dateSanction", MySqlDbType.Date).Value = dateTimeSanction.Text;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = cbbType.SelectedItem.ToString();
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                cmd.Parameters.Add("@matricule", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);

                if(cmd.ExecuteNonQuery() == 1)
                {
                    if (cbbType.SelectedItem.Equals("Licenciement") || cbbType.SelectedItem.Equals("Mise à pied"))
                    {
                        string rqt = "UPDATE `employes` SET `Statut_Actuel` = 'INACTIF' Where Matricule = '"+Convert.ToInt32(txtMatricule.Text)+"'";
                        MySqlCommand command = new MySqlCommand(requete, db.GetConnection);
                        cmd.ExecuteNonQuery();

                        cbbType.SelectedIndex = 0;
                        txtMatricule.Text = "";
                        txtMotif.Text = "";
                        Gerer_Sanctions_Load(sender, e);
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
            try
            {
                db.openConnection();
                string requete = "SELECT * FROM sanctions";
                MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtMatricule.Text = dataGridView1.CurrentRow.Cells["Matricule_employe"].Value.ToString();
                    txtMotif.Text = dataGridView1.CurrentRow.Cells["Motif"].Value.ToString();
                    dateTimeSanction.Text = dataGridView1.CurrentRow.Cells["Date_Sanction"].Value.ToString();
                    cbbType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
                    txtID.Text = dataGridView1.CurrentRow.Cells["ID_sanction"].Value.ToString();
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                if(cbbType.SelectedItem.Equals("Mise à pied") || cbbType.SelectedItem.Equals("Licenciement"))
                {
                    string requete = "UPDATE `sanctions` SET `Date_retour`= @dateRetour, `Motif`= @motif WHERE Matricule_employe = @matEmploye AND ID_sanction = '"+txtID.Text+"'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@dateRetour", MySqlDbType.Date).Value = dateTimeRetourSanction.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matEmploye", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        cbbType.SelectedIndex = 0;
                        txtMatricule.Text = "";
                        txtMotif.Text = "";
                    }
                }
                else
                {
                    string requete = "UPDATE `sanctions` SET `Motif`= @motif WHERE Matricule_employe = @matEmploye AND ID_sanction ='"+txtID.Text+"'";
                    MySqlCommand cmd = new MySqlCommand(requete, db.GetConnection);
                    cmd.Parameters.Add("@dateRetour", MySqlDbType.Date).Value = dateTimeRetourSanction.Text;
                    cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = txtMotif.Text;
                    cmd.Parameters.Add("@matEmploye", MySqlDbType.Int32).Value = Convert.ToInt32(txtMatricule.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        cbbType.SelectedIndex = 0;
                        txtMatricule.Text = "";
                        txtMotif.Text = "";
                    }
                }
                

                
                Gerer_Sanctions_Load(sender, e);
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
            if(cbbType.SelectedItem.Equals("Licenciement") || cbbType.SelectedItem.Equals("Mise à pied"))
            {
                dateTimeRetourSanction.Enabled = true;
            }
            else
            {
                dateTimeRetourSanction.Enabled = false;
            }
        }
    }
}
