
namespace PROJET_Ressource_Humaine
{
    partial class Gerer_Sanctions
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
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.dateTimeSanction = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeRetourSanction = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(458, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 378);
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
            this.dataGridView1.Size = new System.Drawing.Size(471, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Avertissement ou blâme",
            "Mise à pied",
            "Mutation",
            "Rétrogradation",
            "Licenciement"});
            this.cbbType.Location = new System.Drawing.Point(32, 53);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(145, 21);
            this.cbbType.TabIndex = 1;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(239, 54);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(145, 20);
            this.txtMatricule.TabIndex = 2;
            // 
            // dateTimeSanction
            // 
            this.dateTimeSanction.CustomFormat = "yyyy-MM-dd";
            this.dateTimeSanction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSanction.Location = new System.Drawing.Point(32, 118);
            this.dateTimeSanction.Name = "dateTimeSanction";
            this.dateTimeSanction.Size = new System.Drawing.Size(145, 20);
            this.dateTimeSanction.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type de Sanction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date de la sanction";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(30, 234);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Location = new System.Drawing.Point(166, 234);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(105, 23);
            this.btnRemplir.TabIndex = 10;
            this.btnRemplir.Text = "Remplir";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(306, 234);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(105, 23);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Motif";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(32, 176);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(145, 20);
            this.txtMotif.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date retour de la sanction";
            // 
            // dateTimeRetourSanction
            // 
            this.dateTimeRetourSanction.CustomFormat = "yyyy-MM-dd";
            this.dateTimeRetourSanction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRetourSanction.Location = new System.Drawing.Point(238, 118);
            this.dateTimeRetourSanction.Name = "dateTimeRetourSanction";
            this.dateTimeRetourSanction.Size = new System.Drawing.Size(145, 20);
            this.dateTimeRetourSanction.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(239, 176);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 20);
            this.txtID.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // Gerer_Sanctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeRetourSanction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeSanction);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.panel1);
            this.Name = "Gerer_Sanctions";
            this.Text = "Gerer_Sanctions";
            this.Load += new System.EventHandler(this.Gerer_Sanctions_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.DateTimePicker dateTimeSanction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeRetourSanction;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}