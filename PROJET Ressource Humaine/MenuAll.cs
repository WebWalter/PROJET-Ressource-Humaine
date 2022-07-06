using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_Ressource_Humaine
{
    public partial class MenuAll : Form
    {

        //Attributs
        private Form activeForm;
        private Button currentButton;
        private int matricule;

        public MenuAll()
        {
            InitializeComponent();
        }

        public MenuAll(int matricule,string prenom, string nom, string poste, string image)
        {
            InitializeComponent();

            this.matricule = matricule;
            lblPrenom.Text = prenom;
            lblNom.Text = nom;
            lblPoste.Text = poste;
            if (image.Equals("0"))
            {
                using (FileStream fs = new FileStream(@"C:\Users\25377\source\repos\PROJET Ressource Humaine\Images\man(64x64) (1).png", FileMode.Open))
                {
                    imgProfil.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            else if (image.Equals("1"))
            {
                using (FileStream fs = new FileStream(@"C:\Users\25377\source\repos\PROJET Ressource Humaine\Images\woman(64x64).png", FileMode.Open))
                {
                    imgProfil.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            else
            {
                //Afichage d'une image choisi
            }
        }


        


        private void btnGerer_CheckedChanged(object sender, EventArgs e)
        {
            if(lblPoste.Text == "PDG")
            {
                if (btnGerer.CheckState == CheckState.Checked)
                {
                    btnConsulter.Checked = false;
                    btnGerer.Text = "Gerer                  ▲";
                    btnTraitements.Visible = true;
                    btnDemandes.Visible = true;
                }
                else
                {
                    btnGerer.Text = "Gerer                  ▼";
                    btnTraitements.Visible = false;
                    btnDemandes.Visible = false;
                }
            }
            if (lblPoste.Text == "Ressources Humaine")
            {
                if (btnGerer.CheckState == CheckState.Checked)
                {
                    btnConsulter.Checked = false;
                    btnGerer.Text = "Gerer                  ▲";
                    btnEmployes.Visible = true;
                    btnAbsences.Visible = true;
                    btnSanctions.Visible = true;
                    btnDemandes.Visible = true;
                }
                else
                {
                    btnGerer.Text = "Gerer                  ▼";
                    btnEmployes.Visible = false;
                    btnAbsences.Visible = false;
                    btnSanctions.Visible = false;
                    btnDemandes.Visible = false;
                }
            }
            if (lblPoste.Text == "Simple utilisateur")
            {
                if (btnGerer.CheckState == CheckState.Checked)
                {
                    btnConsulter.Checked = false;
                    btnGerer.Text = "Gerer                  ▲";
                    btnDemandes.Visible = true;
                }
                else
                {
                    btnGerer.Text = "Gerer                  ▼";
                    btnDemandes.Visible = false;
                }
            }
        }

        private void btnConsulter_CheckedChanged(object sender, EventArgs e)
        {
            if (lblPoste.Text == "PDG")
            {
                if (btnConsulter.CheckState == CheckState.Checked)
                {
                    btnGerer.Checked = false;
                    btnConsulter.Text = "Consulter            ▲";
                    btnConsEmployes.Visible = true;
                    btnConsAbsences.Visible = true;
                    btnConsSalaires.Visible = true;
                    btnConsSanctions.Visible = true;
                    btnConsDemandes.Visible = true;
                }
                else
                {
                    btnConsulter.Text = "Consulter            ▼";
                    btnConsEmployes.Visible = false;
                    btnConsAbsences.Visible = false;
                    btnConsSalaires.Visible = false;
                    btnConsSanctions.Visible = false;
                    btnConsDemandes.Visible = false;
                }
            }
            if (lblPoste.Text == "Ressources Humaine")
            {
                if (btnConsulter.CheckState == CheckState.Checked)
                {
                    btnGerer.Checked = false;
                    btnConsulter.Text = "Consulter            ▲";
                    btnConsEmployes.Visible = true;
                    btnConsAbsences.Visible = true;
                    btnConsSalaires.Visible = true;
                    btnConsSanctions.Visible = true;
                    btnConsDemandes.Visible = true;
                }
                else
                {
                    btnConsulter.Text = "Consulter            ▼";
                    btnConsEmployes.Visible = false;
                    btnConsAbsences.Visible = false;
                    btnConsSalaires.Visible = false;
                    btnConsSanctions.Visible = false;
                    btnConsDemandes.Visible = false;
                }
            }
            if (lblPoste.Text == "Simple utilisateur")
            {
                if (btnConsulter.CheckState == CheckState.Checked)
                {
                    btnGerer.Checked = false;
                    btnConsulter.Text = "Consulter            ▲";
                    btnConsDemandes.Visible = true;
                }
                else
                {
                    btnConsulter.Text = "Consulter            ▼";
                    btnConsDemandes.Visible = false;
                }
            }
        }

        private void MenuAll_Load(object sender, EventArgs e)
        {
            //Menu
            this.Text = this.Text + " "+ lblPoste.Text;

            //Gerer
            btnEmployes.Visible = false;
            btnAbsences.Visible = false;
            btnDemandes.Visible = false;
            btnSanctions.Visible = false;
            btnTraitements.Visible = false;

            //Consulter
            btnConsEmployes.Visible = false;
            btnConsAbsences.Visible = false;
            btnConsSalaires.Visible = false;
            btnConsSanctions.Visible = false;
            btnConsDemandes.Visible = false;
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            ConnexionForm cnn = new ConnexionForm();
            this.Visible = false;
            cnn.Show();
        }

        public void ActivateButton(Object btnSender)
        {
            if (currentButton != (Button)btnSender)
            {
                DisableButton();
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.FromArgb(93, 93, 127);
            }
        }

        public void DisableButton()
        {
            foreach (Control previousBtn in panelForms.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
        }

        private void openFormFille(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitre.Text = childForm.Text;
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            openFormFille(new Atelier_Employer(), sender);
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            openFormFille(new Gerer_Absence(), sender);
        }

        private void btnSanctions_Click(object sender, EventArgs e)
        {
            openFormFille(new Gerer_Sanctions(), sender);
        }

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            openFormFille(new Gerer_Demandes(matricule), sender);
        }

        private void btnTraitements_Click(object sender, EventArgs e)
        {
            openFormFille(new Gerer_Traitements(), sender);
        }

        private void btnConsEmployes_Click(object sender, EventArgs e)
        {
            openFormFille(new Cons_employes(), sender);
        }

        private void btnConsAbsences_Click(object sender, EventArgs e)
        {
            openFormFille(new Cons_absences_heures(), sender);
        }

        private void btnConsSalaires_Click(object sender, EventArgs e)
        {
            openFormFille(new Cons_salaires(), sender);
        }

        private void btnConsSanctions_Click(object sender, EventArgs e)
        {
            openFormFille(new Cons_sanctions(), sender);
        }

        private void btnConsDemandes_Click(object sender, EventArgs e)
        {
            openFormFille(new Cons_demandes(matricule), sender);
        }

        
    }
}
