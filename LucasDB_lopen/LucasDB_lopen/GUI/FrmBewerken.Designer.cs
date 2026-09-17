namespace LucasDB_lopen
{
    partial class FrmBewerken
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
            this.lblKies = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbBetaald = new System.Windows.Forms.GroupBox();
            this.rbNietbetaald = new System.Windows.Forms.RadioButton();
            this.rbBetaald = new System.Windows.Forms.RadioButton();
            this.lblAfstand = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.cmbAfstand = new System.Windows.Forms.ComboBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnAnuleren = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.lblVerwijderen = new System.Windows.Forms.Button();
            this.grbBetaald.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(84, 92);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(193, 29);
            this.lblKies.TabIndex = 0;
            this.lblKies.Text = "Kies Deelnemer:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 37);
            this.comboBox1.TabIndex = 1;
            // 
            // grbBetaald
            // 
            this.grbBetaald.Controls.Add(this.rbNietbetaald);
            this.grbBetaald.Controls.Add(this.rbBetaald);
            this.grbBetaald.Location = new System.Drawing.Point(89, 292);
            this.grbBetaald.Name = "grbBetaald";
            this.grbBetaald.Size = new System.Drawing.Size(358, 100);
            this.grbBetaald.TabIndex = 9;
            this.grbBetaald.TabStop = false;
            this.grbBetaald.Text = "Heeft de persoon betaald ?";
            // 
            // rbNietbetaald
            // 
            this.rbNietbetaald.AutoSize = true;
            this.rbNietbetaald.Location = new System.Drawing.Point(24, 64);
            this.rbNietbetaald.Name = "rbNietbetaald";
            this.rbNietbetaald.Size = new System.Drawing.Size(80, 33);
            this.rbNietbetaald.TabIndex = 4;
            this.rbNietbetaald.TabStop = true;
            this.rbNietbetaald.Text = "Nee";
            this.rbNietbetaald.UseVisualStyleBackColor = true;
            // 
            // rbBetaald
            // 
            this.rbBetaald.AutoSize = true;
            this.rbBetaald.Location = new System.Drawing.Point(24, 33);
            this.rbBetaald.Name = "rbBetaald";
            this.rbBetaald.Size = new System.Drawing.Size(65, 33);
            this.rbBetaald.TabIndex = 3;
            this.rbBetaald.TabStop = true;
            this.rbBetaald.Text = "Ja ";
            this.rbBetaald.UseVisualStyleBackColor = true;
            // 
            // lblAfstand
            // 
            this.lblAfstand.AutoSize = true;
            this.lblAfstand.Location = new System.Drawing.Point(84, 207);
            this.lblAfstand.Name = "lblAfstand";
            this.lblAfstand.Size = new System.Drawing.Size(156, 29);
            this.lblAfstand.TabIndex = 8;
            this.lblAfstand.Text = "Kies afstand: ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(84, 155);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(125, 29);
            this.lblNaam.TabIndex = 7;
            this.lblNaam.Text = "Uw naam: ";
            // 
            // cmbAfstand
            // 
            this.cmbAfstand.FormattingEnabled = true;
            this.cmbAfstand.Items.AddRange(new object[] {
            " 5 km",
            "10 km",
            "20 km"});
            this.cmbAfstand.Location = new System.Drawing.Point(292, 207);
            this.cmbAfstand.Name = "cmbAfstand";
            this.cmbAfstand.Size = new System.Drawing.Size(208, 37);
            this.cmbAfstand.TabIndex = 13;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(292, 152);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(208, 34);
            this.txtNaam.TabIndex = 12;
            // 
            // btnAnuleren
            // 
            this.btnAnuleren.Location = new System.Drawing.Point(208, 478);
            this.btnAnuleren.Name = "btnAnuleren";
            this.btnAnuleren.Size = new System.Drawing.Size(178, 45);
            this.btnAnuleren.TabIndex = 11;
            this.btnAnuleren.Text = "Anuleren";
            this.btnAnuleren.UseVisualStyleBackColor = true;
            this.btnAnuleren.Click += new System.EventHandler(this.btnAnuleren_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(89, 414);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(170, 45);
            this.btnAanpassen.TabIndex = 10;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            // 
            // lblVerwijderen
            // 
            this.lblVerwijderen.Location = new System.Drawing.Point(305, 414);
            this.lblVerwijderen.Name = "lblVerwijderen";
            this.lblVerwijderen.Size = new System.Drawing.Size(170, 45);
            this.lblVerwijderen.TabIndex = 14;
            this.lblVerwijderen.Text = "Verwijderen";
            this.lblVerwijderen.UseVisualStyleBackColor = true;
            // 
            // FrmBewerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.lblVerwijderen);
            this.Controls.Add(this.grbBetaald);
            this.Controls.Add(this.lblAfstand);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cmbAfstand);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnAnuleren);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBewerken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBewerken";
            this.grbBetaald.ResumeLayout(false);
            this.grbBetaald.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grbBetaald;
        private System.Windows.Forms.RadioButton rbNietbetaald;
        private System.Windows.Forms.RadioButton rbBetaald;
        private System.Windows.Forms.Label lblAfstand;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.ComboBox cmbAfstand;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnAnuleren;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button lblVerwijderen;
    }
}