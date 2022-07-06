
namespace PROJET_Ressource_Humaine
{
    partial class Cons_salaires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_salaires));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbChercherTout = new System.Windows.Forms.CheckBox();
            this.btnChercherID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtMontantMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontantMin = new System.Windows.Forms.TextBox();
            this.cbMontantMax = new System.Windows.Forms.CheckBox();
            this.cbMontantMin = new System.Windows.Forms.CheckBox();
            this.Imprimer = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 255);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbChercherTout
            // 
            this.cbChercherTout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbChercherTout.AutoSize = true;
            this.cbChercherTout.Location = new System.Drawing.Point(121, 78);
            this.cbChercherTout.Name = "cbChercherTout";
            this.cbChercherTout.Size = new System.Drawing.Size(48, 17);
            this.cbChercherTout.TabIndex = 21;
            this.cbChercherTout.Text = "Tout";
            this.cbChercherTout.UseVisualStyleBackColor = true;
            this.cbChercherTout.CheckedChanged += new System.EventHandler(this.cbChercherTout_CheckedChanged);
            // 
            // btnChercherID
            // 
            this.btnChercherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChercherID.Location = new System.Drawing.Point(175, 94);
            this.btnChercherID.Name = "btnChercherID";
            this.btnChercherID.Size = new System.Drawing.Size(98, 23);
            this.btnChercherID.TabIndex = 20;
            this.btnChercherID.Text = "Chercher";
            this.btnChercherID.UseVisualStyleBackColor = true;
            this.btnChercherID.Click += new System.EventHandler(this.btnChercherID_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Par Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatricule.Location = new System.Drawing.Point(12, 96);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(157, 20);
            this.txtMatricule.TabIndex = 18;
            // 
            // txtMontantMax
            // 
            this.txtMontantMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontantMax.Location = new System.Drawing.Point(290, 97);
            this.txtMontantMax.Name = "txtMontantMax";
            this.txtMontantMax.Size = new System.Drawing.Size(144, 20);
            this.txtMontantMax.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Montant Max";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Montant Min";
            // 
            // txtMontantMin
            // 
            this.txtMontantMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontantMin.Location = new System.Drawing.Point(462, 97);
            this.txtMontantMin.Name = "txtMontantMin";
            this.txtMontantMin.Size = new System.Drawing.Size(144, 20);
            this.txtMontantMin.TabIndex = 24;
            // 
            // cbMontantMax
            // 
            this.cbMontantMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMontantMax.AutoSize = true;
            this.cbMontantMax.Location = new System.Drawing.Point(375, 81);
            this.cbMontantMax.Name = "cbMontantMax";
            this.cbMontantMax.Size = new System.Drawing.Size(15, 14);
            this.cbMontantMax.TabIndex = 26;
            this.cbMontantMax.UseVisualStyleBackColor = true;
            this.cbMontantMax.CheckedChanged += new System.EventHandler(this.cbMontantMax_CheckedChanged);
            // 
            // cbMontantMin
            // 
            this.cbMontantMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMontantMin.AutoSize = true;
            this.cbMontantMin.Location = new System.Drawing.Point(545, 78);
            this.cbMontantMin.Name = "cbMontantMin";
            this.cbMontantMin.Size = new System.Drawing.Size(15, 14);
            this.cbMontantMin.TabIndex = 27;
            this.cbMontantMin.UseVisualStyleBackColor = true;
            this.cbMontantMin.CheckedChanged += new System.EventHandler(this.cbMontantMin_CheckedChanged);
            // 
            // Imprimer
            // 
            this.Imprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Imprimer.Location = new System.Drawing.Point(842, 96);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Imprimer.TabIndex = 28;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = true;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Cons_salaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.cbMontantMin);
            this.Controls.Add(this.cbMontantMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontantMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontantMax);
            this.Controls.Add(this.cbChercherTout);
            this.Controls.Add(this.btnChercherID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.panel1);
            this.Name = "Cons_salaires";
            this.Text = "Consulter Salaire";
            this.Load += new System.EventHandler(this.Cons_salaires_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbChercherTout;
        private System.Windows.Forms.Button btnChercherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtMontantMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontantMin;
        private System.Windows.Forms.CheckBox cbMontantMax;
        private System.Windows.Forms.CheckBox cbMontantMin;
        private System.Windows.Forms.Button Imprimer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}