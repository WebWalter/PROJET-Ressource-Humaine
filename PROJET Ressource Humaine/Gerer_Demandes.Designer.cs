
namespace PROJET_Ressource_Humaine
{
    partial class Gerer_Demandes
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
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.dateTimeDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeDemande = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(711, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 378);
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
            this.dataGridView1.Size = new System.Drawing.Size(503, 378);
            this.dataGridView1.TabIndex = 0;
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
            this.cbbType.Location = new System.Drawing.Point(280, 21);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(147, 21);
            this.cbbType.TabIndex = 1;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(453, 21);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(147, 20);
            this.txtMatricule.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricule";
            // 
            // txtMontant
            // 
            this.txtMontant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMontant.Location = new System.Drawing.Point(280, 72);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(147, 20);
            this.txtMontant.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Montant";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Motif";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAjouter.Location = new System.Drawing.Point(280, 221);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemplir.Location = new System.Drawing.Point(395, 221);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(75, 23);
            this.btnRemplir.TabIndex = 18;
            this.btnRemplir.Text = "Remplir";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModifier.Location = new System.Drawing.Point(525, 221);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtMotif
            // 
            this.txtMotif.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMotif.Location = new System.Drawing.Point(280, 179);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(147, 20);
            this.txtMotif.TabIndex = 13;
            // 
            // dateTimeDebut
            // 
            this.dateTimeDebut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeDebut.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDebut.Location = new System.Drawing.Point(280, 123);
            this.dateTimeDebut.Name = "dateTimeDebut";
            this.dateTimeDebut.Size = new System.Drawing.Size(147, 20);
            this.dateTimeDebut.TabIndex = 20;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeFin.CustomFormat = "yyyy-MM-dd";
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFin.Location = new System.Drawing.Point(453, 123);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(147, 20);
            this.dateTimeFin.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "A partir du";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Au";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // dateTimeDemande
            // 
            this.dateTimeDemande.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeDemande.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDemande.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDemande.Location = new System.Drawing.Point(453, 72);
            this.dateTimeDemande.Name = "dateTimeDemande";
            this.dateTimeDemande.Size = new System.Drawing.Size(147, 20);
            this.dateTimeDemande.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date de la demande";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(453, 179);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 27;
            // 
            // Gerer_Demandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 378);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimeDemande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeDebut);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.panel1);
            this.Name = "Gerer_Demandes";
            this.Text = "Faire une demande";
            this.Load += new System.EventHandler(this.Gerer_Demandes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.DateTimePicker dateTimeDebut;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeDemande;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
    }
}