
namespace PROJET_Ressource_Humaine
{
    partial class Gerer_Absence
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
            this.panelView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeAbsenceDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAbsenceRetour = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeRetards = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbID = new System.Windows.Forms.ComboBox();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dataGridView1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelView.Location = new System.Drawing.Point(525, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(500, 438);
            this.panelView.TabIndex = 0;
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
            this.dataGridView1.Size = new System.Drawing.Size(500, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbbType
            // 
            this.cbbType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Absences",
            "Retards"});
            this.cbbType.Location = new System.Drawing.Point(97, 46);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(153, 23);
            this.cbbType.TabIndex = 3;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // dateTimeAbsenceDebut
            // 
            this.dateTimeAbsenceDebut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeAbsenceDebut.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAbsenceDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAbsenceDebut.Location = new System.Drawing.Point(97, 174);
            this.dateTimeAbsenceDebut.Name = "dateTimeAbsenceDebut";
            this.dateTimeAbsenceDebut.Size = new System.Drawing.Size(153, 21);
            this.dateTimeAbsenceDebut.TabIndex = 8;
            // 
            // dateTimeAbsenceRetour
            // 
            this.dateTimeAbsenceRetour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeAbsenceRetour.CustomFormat = "yyyy-MM-dd";
            this.dateTimeAbsenceRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAbsenceRetour.Location = new System.Drawing.Point(285, 174);
            this.dateTimeAbsenceRetour.Name = "dateTimeAbsenceRetour";
            this.dateTimeAbsenceRetour.Size = new System.Drawing.Size(153, 21);
            this.dateTimeAbsenceRetour.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date début Absence";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date retour Absence";
            // 
            // txtMotif
            // 
            this.txtMotif.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMotif.Location = new System.Drawing.Point(97, 243);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(153, 21);
            this.txtMotif.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Motif";
            // 
            // txtDuree
            // 
            this.txtDuree.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDuree.Location = new System.Drawing.Point(285, 106);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(153, 21);
            this.txtDuree.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Durée (heures/jours)";
            // 
            // dateTimeRetards
            // 
            this.dateTimeRetards.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimeRetards.CustomFormat = "yyyy-MM-dd";
            this.dateTimeRetards.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRetards.Location = new System.Drawing.Point(97, 106);
            this.dateTimeRetards.Name = "dateTimeRetards";
            this.dateTimeRetards.Size = new System.Drawing.Size(153, 21);
            this.dateTimeRetards.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date retards";
            // 
            // btnAjout
            // 
            this.btnAjout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjout.Location = new System.Drawing.Point(96, 358);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(100, 25);
            this.btnAjout.TabIndex = 18;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemplir.Location = new System.Drawing.Point(224, 358);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(100, 25);
            this.btnRemplir.TabIndex = 19;
            this.btnRemplir.Text = "Remplir";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(349, 358);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 25);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMatricule.Location = new System.Drawing.Point(285, 48);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(153, 21);
            this.txtMatricule.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // cbbID
            // 
            this.cbbID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbID.Enabled = false;
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(285, 241);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(153, 23);
            this.cbbID.TabIndex = 25;
            // 
            // Gerer_Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 438);
            this.Controls.Add(this.cbbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeRetards);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeAbsenceRetour);
            this.Controls.Add(this.dateTimeAbsenceDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.panelView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Gerer_Absence";
            this.Text = "Gerer les absences/retards";
            this.Load += new System.EventHandler(this.Gerer_Absence_Load);
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeAbsenceDebut;
        private System.Windows.Forms.DateTimePicker dateTimeAbsenceRetour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeRetards;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbID;
    }
}