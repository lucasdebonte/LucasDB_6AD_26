namespace LucasDB_lopen
{
    partial class FrmOpzoeken
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
            this.lbl1Deelnemer = new System.Windows.Forms.Button();
            this.btnAnuleren = new System.Windows.Forms.Button();
            this.btnAlledeeln = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.lblResultaten = new System.Windows.Forms.Label();
            this.txttoon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1Deelnemer
            // 
            this.lbl1Deelnemer.Location = new System.Drawing.Point(249, 32);
            this.lbl1Deelnemer.Name = "lbl1Deelnemer";
            this.lbl1Deelnemer.Size = new System.Drawing.Size(170, 45);
            this.lbl1Deelnemer.TabIndex = 17;
            this.lbl1Deelnemer.Text = "1 deelnemer";
            this.lbl1Deelnemer.UseVisualStyleBackColor = true;
            this.lbl1Deelnemer.Click += new System.EventHandler(this.lblVerwijderen_Click);
            // 
            // btnAnuleren
            // 
            this.btnAnuleren.Location = new System.Drawing.Point(434, 32);
            this.btnAnuleren.Name = "btnAnuleren";
            this.btnAnuleren.Size = new System.Drawing.Size(178, 45);
            this.btnAnuleren.TabIndex = 16;
            this.btnAnuleren.Text = "Anuleren";
            this.btnAnuleren.UseVisualStyleBackColor = true;
            this.btnAnuleren.Click += new System.EventHandler(this.btnAnuleren_Click);
            // 
            // btnAlledeeln
            // 
            this.btnAlledeeln.Location = new System.Drawing.Point(26, 32);
            this.btnAlledeeln.Name = "btnAlledeeln";
            this.btnAlledeeln.Size = new System.Drawing.Size(217, 45);
            this.btnAlledeeln.TabIndex = 15;
            this.btnAlledeeln.Text = "Alle deelnemers";
            this.btnAlledeeln.UseVisualStyleBackColor = true;
            this.btnAlledeeln.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 37);
            this.comboBox1.TabIndex = 19;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(21, 108);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(193, 29);
            this.lblKies.TabIndex = 18;
            this.lblKies.Text = "Kies Deelnemer:";
            // 
            // lblResultaten
            // 
            this.lblResultaten.AutoSize = true;
            this.lblResultaten.Location = new System.Drawing.Point(21, 183);
            this.lblResultaten.Name = "lblResultaten";
            this.lblResultaten.Size = new System.Drawing.Size(167, 29);
            this.lblResultaten.TabIndex = 20;
            this.lblResultaten.Text = "De resultaten: ";
            this.lblResultaten.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttoon
            // 
            this.txttoon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttoon.Location = new System.Drawing.Point(26, 241);
            this.txttoon.Multiline = true;
            this.txttoon.Name = "txttoon";
            this.txttoon.ReadOnly = true;
            this.txttoon.Size = new System.Drawing.Size(661, 267);
            this.txttoon.TabIndex = 21;
            // 
            // FrmOpzoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.txttoon);
            this.Controls.Add(this.lblResultaten);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.lbl1Deelnemer);
            this.Controls.Add(this.btnAnuleren);
            this.Controls.Add(this.btnAlledeeln);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOpzoeken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opzoeken van deelnemers ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbl1Deelnemer;
        private System.Windows.Forms.Button btnAnuleren;
        private System.Windows.Forms.Button btnAlledeeln;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Label lblResultaten;
        private System.Windows.Forms.TextBox txttoon;
    }
}