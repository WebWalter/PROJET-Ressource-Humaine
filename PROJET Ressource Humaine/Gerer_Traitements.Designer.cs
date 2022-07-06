
namespace PROJET_Ressource_Humaine
{
    partial class Gerer_Traitements
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAccepter = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnRefuser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dateTimeFinDemandes = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDebutDemande = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDemandes = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(475, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 378);
            this.panel1.TabIndex = 0;
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
            this.dataGridView1.Size = new System.Drawing.Size(454, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAccepter
            // 
            this.btnAccepter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccepter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAccepter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccepter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccepter.Location = new System.Drawing.Point(221, 287);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(75, 34);
            this.btnAccepter.TabIndex = 5;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = false;
            this.btnAccepter.Click += new System.EventHandler(this.btnAccepter_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemplir.Location = new System.Drawing.Point(274, 258);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(75, 23);
            this.btnRemplir.TabIndex = 6;
            this.btnRemplir.Text = "Remplir";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnRefuser
            // 
            this.btnRefuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefuser.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRefuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefuser.Location = new System.Drawing.Point(322, 287);
            this.btnRefuser.Name = "btnRefuser";
            this.btnRefuser.Size = new System.Drawing.Size(75, 34);
            this.btnRefuser.TabIndex = 7;
            this.btnRefuser.Text = "Refuser";
            this.btnRefuser.UseVisualStyleBackColor = false;
            this.btnRefuser.Click += new System.EventHandler(this.btnRefuser_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Motif";
            // 
            // txtMotif
            // 
            this.txtMotif.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMotif.Enabled = false;
            this.txtMotif.Location = new System.Drawing.Point(149, 215);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(147, 20);
            this.txtMotif.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Montant";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Date de la demande";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date début";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date fin";
            // 
            // txtMontant
            // 
            this.txtMontant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMontant.Enabled = false;
            this.txtMontant.Location = new System.Drawing.Point(149, 85);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(147, 20);
            this.txtMontant.TabIndex = 24;
            // 
            // dateTimeFinDemandes
            // 
            this.dateTimeFinDemandes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeFinDemandes.CustomFormat = "yyyy-MM-dd";
            this.dateTimeFinDemandes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFinDemandes.Location = new System.Drawing.Point(322, 149);
            this.dateTimeFinDemandes.Name = "dateTimeFinDemandes";
            this.dateTimeFinDemandes.Size = new System.Drawing.Size(147, 20);
            this.dateTimeFinDemandes.TabIndex = 23;
            // 
            // dateTimeDebutDemande
            // 
            this.dateTimeDebutDemande.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeDebutDemande.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDebutDemande.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDebutDemande.Location = new System.Drawing.Point(149, 149);
            this.dateTimeDebutDemande.Name = "dateTimeDebutDemande";
            this.dateTimeDebutDemande.Size = new System.Drawing.Size(147, 20);
            this.dateTimeDebutDemande.TabIndex = 22;
            // 
            // dateTimeDemandes
            // 
            this.dateTimeDemandes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeDemandes.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDemandes.Enabled = false;
            this.dateTimeDemandes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDemandes.Location = new System.Drawing.Point(322, 85);
            this.dateTimeDemandes.Name = "dateTimeDemandes";
            this.dateTimeDemandes.Size = new System.Drawing.Size(147, 20);
            this.dateTimeDemandes.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(322, 22);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(147, 20);
            this.txtMatricule.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type";
            // 
            // cbbType
            // 
            this.cbbType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Salaire",
            "Congé",
            "Formation"});
            this.cbbType.Location = new System.Drawing.Point(149, 22);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(147, 21);
            this.cbbType.TabIndex = 17;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(322, 215);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 33;
            // 
            // Gerer_Traitements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.dateTimeFinDemandes);
            this.Controls.Add(this.dateTimeDebutDemande);
            this.Controls.Add(this.dateTimeDemandes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnRefuser);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.panel1);
            this.Name = "Gerer_Traitements";
            this.Text = "Traitement des demandes";
            this.Load += new System.EventHandler(this.Gerer_Traitements_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAccepter;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnRefuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DateTimePicker dateTimeFinDemandes;
        private System.Windows.Forms.DateTimePicker dateTimeDebutDemande;
        private System.Windows.Forms.DateTimePicker dateTimeDemandes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.TextBox txtID;
    }
}