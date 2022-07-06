
namespace PROJET_Ressource_Humaine
{
    partial class Cons_employes
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
            this.btnChercherID = new System.Windows.Forms.Button();
            this.cbChercherTout = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 210);
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
            this.dataGridView1.Size = new System.Drawing.Size(929, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Ressources Humaine",
            "PDG",
            "Simple Utilisateur"});
            this.cbbType.Location = new System.Drawing.Point(12, 138);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(154, 21);
            this.cbbType.TabIndex = 4;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Par Poste";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatricule.Location = new System.Drawing.Point(190, 139);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(157, 20);
            this.txtMatricule.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Par Matricule";
            // 
            // btnChercherID
            // 
            this.btnChercherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChercherID.Location = new System.Drawing.Point(378, 139);
            this.btnChercherID.Name = "btnChercherID";
            this.btnChercherID.Size = new System.Drawing.Size(98, 23);
            this.btnChercherID.TabIndex = 8;
            this.btnChercherID.Text = "Chercher";
            this.btnChercherID.UseVisualStyleBackColor = true;
            this.btnChercherID.Click += new System.EventHandler(this.btnChercherID_Click);
            // 
            // cbChercherTout
            // 
            this.cbChercherTout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbChercherTout.AutoSize = true;
            this.cbChercherTout.Location = new System.Drawing.Point(299, 116);
            this.cbChercherTout.Name = "cbChercherTout";
            this.cbChercherTout.Size = new System.Drawing.Size(48, 17);
            this.cbChercherTout.TabIndex = 9;
            this.cbChercherTout.Text = "Tout";
            this.cbChercherTout.UseVisualStyleBackColor = true;
            this.cbChercherTout.CheckedChanged += new System.EventHandler(this.cbChercherTout_CheckedChanged);
            // 
            // Cons_employes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.cbChercherTout);
            this.Controls.Add(this.btnChercherID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.panel1);
            this.Name = "Cons_employes";
            this.Text = "Consulter les Employé(e)s";
            this.Load += new System.EventHandler(this.Cons_employes_Load);
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
        private System.Windows.Forms.Button btnChercherID;
        private System.Windows.Forms.CheckBox cbChercherTout;
    }
}