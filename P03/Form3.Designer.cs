namespace P03
{
    partial class Form3
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelCtverec = new System.Windows.Forms.Label();
            this.labelKrychle = new System.Windows.Forms.Label();
            this.labelObdelnik = new System.Windows.Forms.Label();
            this.labelKvadr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b:";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(171, 69);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelCtverec
            // 
            this.labelCtverec.AutoSize = true;
            this.labelCtverec.Location = new System.Drawing.Point(49, 146);
            this.labelCtverec.Name = "labelCtverec";
            this.labelCtverec.Size = new System.Drawing.Size(46, 13);
            this.labelCtverec.TabIndex = 5;
            this.labelCtverec.Text = "čtverec:";
            // 
            // labelKrychle
            // 
            this.labelKrychle.AutoSize = true;
            this.labelKrychle.Location = new System.Drawing.Point(49, 232);
            this.labelKrychle.Name = "labelKrychle";
            this.labelKrychle.Size = new System.Drawing.Size(44, 13);
            this.labelKrychle.TabIndex = 6;
            this.labelKrychle.Text = "krychle:";
            // 
            // labelObdelnik
            // 
            this.labelObdelnik.AutoSize = true;
            this.labelObdelnik.Location = new System.Drawing.Point(209, 146);
            this.labelObdelnik.Name = "labelObdelnik";
            this.labelObdelnik.Size = new System.Drawing.Size(52, 13);
            this.labelObdelnik.TabIndex = 7;
            this.labelObdelnik.Text = "obdélník:";
            // 
            // labelKvadr
            // 
            this.labelKvadr.AutoSize = true;
            this.labelKvadr.Location = new System.Drawing.Point(209, 232);
            this.labelKvadr.Name = "labelKvadr";
            this.labelKvadr.Size = new System.Drawing.Size(37, 13);
            this.labelKvadr.TabIndex = 8;
            this.labelKvadr.Text = "kvádr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "c:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "8";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelKvadr);
            this.Controls.Add(this.labelObdelnik);
            this.Controls.Add(this.labelKrychle);
            this.Controls.Add(this.labelCtverec);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelCtverec;
        private System.Windows.Forms.Label labelKrychle;
        private System.Windows.Forms.Label labelObdelnik;
        private System.Windows.Forms.Label labelKvadr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
    }
}

