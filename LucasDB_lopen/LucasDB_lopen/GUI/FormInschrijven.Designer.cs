namespace LucasDB_lopen
{
    partial class FormInschrijven
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAfstand = new System.Windows.Forms.Label();
            this.grbBetaald = new System.Windows.Forms.GroupBox();
            this.rbNietbetaald = new System.Windows.Forms.RadioButton();
            this.rbBetaald = new System.Windows.Forms.RadioButton();
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.btnAnuleren = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.cmbAfstand = new System.Windows.Forms.ComboBox();
            this.grbBetaald.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(88, 66);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(125, 29);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Uw naam: ";
            this.lblNaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAfstand
            // 
            this.lblAfstand.AutoSize = true;
            this.lblAfstand.Location = new System.Drawing.Point(88, 118);
            this.lblAfstand.Name = "lblAfstand";
            this.lblAfstand.Size = new System.Drawing.Size(156, 29);
            this.lblAfstand.TabIndex = 1;
            this.lblAfstand.Text = "Kies afstand: ";
            this.lblAfstand.Click += new System.EventHandler(this.label2_Click);
            // 
            // grbBetaald
            // 
            this.grbBetaald.Controls.Add(this.rbNietbetaald);
            this.grbBetaald.Controls.Add(this.rbBetaald);
            this.grbBetaald.Location = new System.Drawing.Point(93, 203);
            this.grbBetaald.Name = "grbBetaald";
            this.grbBetaald.Size = new System.Drawing.Size(358, 100);
            this.grbBetaald.TabIndex = 2;
            this.grbBetaald.TabStop = false;
            this.grbBetaald.Text = "Heeft de persoon betaald ?";
            this.grbBetaald.Enter += new System.EventHandler(this.grbBetaald_Enter);
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
            this.rbNietbetaald.CheckedChanged += new System.EventHandler(this.rbNietbetaald_CheckedChanged);
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
            this.rbBetaald.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(93, 325);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(170, 45);
            this.btnInschrijven.TabIndex = 3;
            this.btnInschrijven.Text = "Inschijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            this.btnInschrijven.Click += new System.EventHandler(this.btnInschrijven_Click);
            // 
            // btnAnuleren
            // 
            this.btnAnuleren.Location = new System.Drawing.Point(273, 325);
            this.btnAnuleren.Name = "btnAnuleren";
            this.btnAnuleren.Size = new System.Drawing.Size(178, 45);
            this.btnAnuleren.TabIndex = 4;
            this.btnAnuleren.Text = "Anuleren";
            this.btnAnuleren.UseVisualStyleBackColor = true;
            this.btnAnuleren.Click += new System.EventHandler(this.btnAnuleren_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(317, 66);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 34);
            this.txtNaam.TabIndex = 5;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // cmbAfstand
            // 
            this.cmbAfstand.FormattingEnabled = true;
            this.cmbAfstand.Items.AddRange(new object[] {
            " 5 km",
            "10 km",
            "20 km"});
            this.cmbAfstand.Location = new System.Drawing.Point(317, 118);
            this.cmbAfstand.Name = "cmbAfstand";
            this.cmbAfstand.Size = new System.Drawing.Size(121, 37);
            this.cmbAfstand.TabIndex = 6;
            this.cmbAfstand.SelectedIndexChanged += new System.EventHandler(this.cmbAfstand_SelectedIndexChanged);
            // 
            // FormInschrijven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 381);
            this.ControlBox = false;
            this.Controls.Add(this.cmbAfstand);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnAnuleren);
            this.Controls.Add(this.btnInschrijven);
            this.Controls.Add(this.grbBetaald);
            this.Controls.Add(this.lblAfstand);
            this.Controls.Add(this.lblNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormInschrijven";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inschrijven: ";
            this.grbBetaald.ResumeLayout(false);
            this.grbBetaald.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAfstand;
        private System.Windows.Forms.GroupBox grbBetaald;
        private System.Windows.Forms.RadioButton rbNietbetaald;
        private System.Windows.Forms.RadioButton rbBetaald;
        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.Button btnAnuleren;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.ComboBox cmbAfstand;
    }
}