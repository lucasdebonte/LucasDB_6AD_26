namespace LucasDB_lopen
{
    partial class FrmStart
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
            this.Btnbewerken = new System.Windows.Forms.Button();
            this.Btnafsluiten = new System.Windows.Forms.Button();
            this.Btnopzoeken = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnbewerken
            // 
            this.Btnbewerken.Location = new System.Drawing.Point(12, 56);
            this.Btnbewerken.Name = "Btnbewerken";
            this.Btnbewerken.Size = new System.Drawing.Size(183, 38);
            this.Btnbewerken.TabIndex = 0;
            this.Btnbewerken.Text = "Bewerken ";
            this.Btnbewerken.UseVisualStyleBackColor = true;
            this.Btnbewerken.Click += new System.EventHandler(this.Btnbewerken_Click);
            // 
            // Btnafsluiten
            // 
            this.Btnafsluiten.Location = new System.Drawing.Point(12, 144);
            this.Btnafsluiten.Name = "Btnafsluiten";
            this.Btnafsluiten.Size = new System.Drawing.Size(183, 38);
            this.Btnafsluiten.TabIndex = 1;
            this.Btnafsluiten.Text = "Afsluiten ";
            this.Btnafsluiten.UseVisualStyleBackColor = true;
            this.Btnafsluiten.Click += new System.EventHandler(this.Btnafsluiten_Click);
            // 
            // Btnopzoeken
            // 
            this.Btnopzoeken.Location = new System.Drawing.Point(12, 100);
            this.Btnopzoeken.Name = "Btnopzoeken";
            this.Btnopzoeken.Size = new System.Drawing.Size(183, 38);
            this.Btnopzoeken.TabIndex = 2;
            this.Btnopzoeken.Text = "Opzoeken ";
            this.Btnopzoeken.UseVisualStyleBackColor = true;
            this.Btnopzoeken.Click += new System.EventHandler(this.Btnopzoeken_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "inschrijven";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 205);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btnopzoeken);
            this.Controls.Add(this.Btnafsluiten);
            this.Controls.Add(this.Btnbewerken);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnbewerken;
        private System.Windows.Forms.Button Btnafsluiten;
        private System.Windows.Forms.Button Btnopzoeken;
        private System.Windows.Forms.Button button3;
    }
}

