namespace BMICalculator
{
    partial class FormBMI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbPodaci = new GroupBox();
            btnIzracunaj = new Button();
            tbVisina = new TextBox();
            lblVisina = new Label();
            tbTezina = new TextBox();
            lblTežina = new Label();
            gbRezultat = new GroupBox();
            lblBMITekst = new Label();
            lblBMI = new Label();
            gbPodaci.SuspendLayout();
            gbRezultat.SuspendLayout();
            SuspendLayout();
            // 
            // gbPodaci
            // 
            gbPodaci.Controls.Add(btnIzracunaj);
            gbPodaci.Controls.Add(tbVisina);
            gbPodaci.Controls.Add(lblVisina);
            gbPodaci.Controls.Add(tbTezina);
            gbPodaci.Controls.Add(lblTežina);
            gbPodaci.Location = new Point(12, 12);
            gbPodaci.Name = "gbPodaci";
            gbPodaci.Size = new Size(323, 182);
            gbPodaci.TabIndex = 0;
            gbPodaci.TabStop = false;
            gbPodaci.Text = " Podaci ";
            // 
            // btnIzracunaj
            // 
            btnIzracunaj.Location = new Point(17, 134);
            btnIzracunaj.Name = "btnIzracunaj";
            btnIzracunaj.Size = new Size(290, 30);
            btnIzracunaj.TabIndex = 4;
            btnIzracunaj.Text = "Izračunaj";
            btnIzracunaj.UseVisualStyleBackColor = true;
            btnIzracunaj.Click += btnIzracunaj_Click;
            // 
            // tbVisina
            // 
            tbVisina.Location = new Point(19, 94);
            tbVisina.Name = "tbVisina";
            tbVisina.Size = new Size(288, 23);
            tbVisina.TabIndex = 3;
            // 
            // lblVisina
            // 
            lblVisina.AutoSize = true;
            lblVisina.Location = new Point(19, 76);
            lblVisina.Name = "lblVisina";
            lblVisina.Size = new Size(69, 15);
            lblVisina.TabIndex = 2;
            lblVisina.Text = "Visina (cm):";
            // 
            // tbTezina
            // 
            tbTezina.Location = new Point(19, 43);
            tbTezina.Name = "tbTezina";
            tbTezina.Size = new Size(288, 23);
            tbTezina.TabIndex = 1;
            // 
            // lblTežina
            // 
            lblTežina.AutoSize = true;
            lblTežina.Location = new Point(19, 25);
            lblTežina.Name = "lblTežina";
            lblTežina.Size = new Size(66, 15);
            lblTežina.TabIndex = 0;
            lblTežina.Text = "Težina (kg):";
            // 
            // gbRezultat
            // 
            gbRezultat.Controls.Add(lblBMITekst);
            gbRezultat.Controls.Add(lblBMI);
            gbRezultat.Location = new Point(12, 200);
            gbRezultat.Name = "gbRezultat";
            gbRezultat.Size = new Size(323, 182);
            gbRezultat.TabIndex = 1;
            gbRezultat.TabStop = false;
            gbRezultat.Text = " Rezultat ";
            // 
            // lblBMITekst
            // 
            lblBMITekst.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblBMITekst.Location = new Point(19, 105);
            lblBMITekst.Name = "lblBMITekst";
            lblBMITekst.Size = new Size(288, 63);
            lblBMITekst.TabIndex = 1;
            lblBMITekst.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            lblBMI.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblBMI.Location = new Point(19, 33);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(288, 81);
            lblBMI.TabIndex = 0;
            lblBMI.Text = "Upišite podatke za izračun";
            lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 398);
            Controls.Add(gbRezultat);
            Controls.Add(gbPodaci);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormBMI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator 💪 ";
            gbPodaci.ResumeLayout(false);
            gbPodaci.PerformLayout();
            gbRezultat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPodaci;
        private GroupBox gbRezultat;
        private Label lblBMI;
        private Button btnIzracunaj;
        private TextBox tbVisina;
        private Label lblVisina;
        private TextBox tbTezina;
        private Label lblTežina;
        private Label lblBMITekst;
    }
}
