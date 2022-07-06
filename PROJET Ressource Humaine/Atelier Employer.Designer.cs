
namespace PROJET_Ressource_Humaine
{
    partial class Atelier_Employer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPoste = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdMasculin = new System.Windows.Forms.RadioButton();
            this.rdFeminin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.chbMdp = new System.Windows.Forms.CheckBox();
            this.lblReponse = new System.Windows.Forms.Label();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(12, 29);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(348, 20);
            this.txtMatricule.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 80);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(159, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(12, 134);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(159, 20);
            this.txtMdp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(201, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(159, 20);
            this.txtNom.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(201, 134);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(159, 20);
            this.txtTel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // cbPoste
            // 
            this.cbPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoste.FormattingEnabled = true;
            this.cbPoste.Items.AddRange(new object[] {
            "PDG",
            "Ressources Humaine",
            "Simple utilisateur"});
            this.cbPoste.Location = new System.Drawing.Point(13, 188);
            this.cbPoste.Name = "cbPoste";
            this.cbPoste.Size = new System.Drawing.Size(158, 21);
            this.cbPoste.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Poste";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Sexe :";
            // 
            // rdMasculin
            // 
            this.rdMasculin.AutoSize = true;
            this.rdMasculin.Location = new System.Drawing.Point(13, 246);
            this.rdMasculin.Name = "rdMasculin";
            this.rdMasculin.Size = new System.Drawing.Size(67, 17);
            this.rdMasculin.TabIndex = 22;
            this.rdMasculin.TabStop = true;
            this.rdMasculin.Text = "Masculin";
            this.rdMasculin.UseVisualStyleBackColor = true;
            // 
            // rdFeminin
            // 
            this.rdFeminin.AutoSize = true;
            this.rdFeminin.Location = new System.Drawing.Point(101, 246);
            this.rdFeminin.Name = "rdFeminin";
            this.rdFeminin.Size = new System.Drawing.Size(61, 17);
            this.rdFeminin.TabIndex = 23;
            this.rdFeminin.TabStop = true;
            this.rdFeminin.Text = "Féminin";
            this.rdFeminin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(395, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 378);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(41, 298);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 26;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Location = new System.Drawing.Point(141, 298);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(75, 23);
            this.btnRemplir.TabIndex = 27;
            this.btnRemplir.Text = "Remplir";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(241, 298);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // chbMdp
            // 
            this.chbMdp.AutoSize = true;
            this.chbMdp.ForeColor = System.Drawing.Color.Black;
            this.chbMdp.Location = new System.Drawing.Point(95, 117);
            this.chbMdp.Name = "chbMdp";
            this.chbMdp.Size = new System.Drawing.Size(47, 17);
            this.chbMdp.TabIndex = 30;
            this.chbMdp.Text = "Voir ";
            this.chbMdp.UseVisualStyleBackColor = true;
            this.chbMdp.CheckedChanged += new System.EventHandler(this.chbMdp_CheckedChanged);
            // 
            // lblReponse
            // 
            this.lblReponse.AutoSize = true;
            this.lblReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse.ForeColor = System.Drawing.Color.Black;
            this.lblReponse.Location = new System.Drawing.Point(30, 350);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.Size = new System.Drawing.Size(286, 24);
            this.lblReponse.TabIndex = 29;
            this.lblReponse.Text = "Réponse de la base de données";
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(201, 246);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(159, 20);
            this.txtSalaire.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Salaire";
            // 
            // Atelier_Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalaire);
            this.Controls.Add(this.chbMdp);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdMasculin);
            this.Controls.Add(this.rdFeminin);
            this.Controls.Add(this.cbPoste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.label1);
            this.Name = "Atelier_Employer";
            this.Text = "Gérer Employé(e)s";
            this.Load += new System.EventHandler(this.Atelier_Employer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPoste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdMasculin;
        private System.Windows.Forms.RadioButton rdFeminin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.CheckBox chbMdp;
        private System.Windows.Forms.Label lblReponse;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.Label label8;
    }
}