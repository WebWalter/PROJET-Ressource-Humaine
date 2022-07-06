
namespace PROJET_Ressource_Humaine
{
    partial class Cons_demandes
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
            this.cbTout = new System.Windows.Forms.CheckBox();
            this.cbbReponse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 267);
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
            this.dataGridView1.Size = new System.Drawing.Size(929, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Salaire",
            "Formation",
            "Congé"});
            this.cbbType.Location = new System.Drawing.Point(12, 84);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(154, 21);
            this.cbbType.TabIndex = 2;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Par type";
            // 
            // cbTout
            // 
            this.cbTout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTout.AutoSize = true;
            this.cbTout.Location = new System.Drawing.Point(118, 64);
            this.cbTout.Name = "cbTout";
            this.cbTout.Size = new System.Drawing.Size(48, 17);
            this.cbTout.TabIndex = 6;
            this.cbTout.Text = "Tout";
            this.cbTout.UseVisualStyleBackColor = true;
            this.cbTout.CheckedChanged += new System.EventHandler(this.cbTout_CheckedChanged);
            // 
            // cbbReponse
            // 
            this.cbbReponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbReponse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReponse.FormattingEnabled = true;
            this.cbbReponse.Items.AddRange(new object[] {
            "Accepter",
            "Refuser"});
            this.cbbReponse.Location = new System.Drawing.Point(172, 84);
            this.cbbReponse.Name = "cbbReponse";
            this.cbbReponse.Size = new System.Drawing.Size(154, 21);
            this.cbbReponse.TabIndex = 7;
            this.cbbReponse.SelectedIndexChanged += new System.EventHandler(this.cbbReponse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Par reponse";
            // 
            // Cons_demandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbReponse);
            this.Controls.Add(this.cbTout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.panel1);
            this.Name = "Cons_demandes";
            this.Text = "Consulter les demandes";
            this.Load += new System.EventHandler(this.Cons_demandes_Load);
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
        private System.Windows.Forms.CheckBox cbTout;
        private System.Windows.Forms.ComboBox cbbReponse;
        private System.Windows.Forms.Label label2;
    }
}