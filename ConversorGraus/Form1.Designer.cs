namespace ConversorGraus
{
    partial class fConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConvert));
            gbGraus = new GroupBox();
            lblK = new Label();
            lblF = new Label();
            lblC = new Label();
            txtFa = new TextBox();
            txtF = new TextBox();
            txtC = new TextBox();
            btnCalc = new Button();
            btnLimpa = new Button();
            btnSair = new Button();
            gbGraus.SuspendLayout();
            SuspendLayout();
            // 
            // gbGraus
            // 
            gbGraus.BackColor = SystemColors.Info;
            gbGraus.Controls.Add(lblK);
            gbGraus.Controls.Add(lblF);
            gbGraus.Controls.Add(lblC);
            gbGraus.Controls.Add(txtFa);
            gbGraus.Controls.Add(txtF);
            gbGraus.Controls.Add(txtC);
            gbGraus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbGraus.Location = new Point(12, 12);
            gbGraus.Name = "gbGraus";
            gbGraus.Size = new Size(256, 235);
            gbGraus.TabIndex = 0;
            gbGraus.TabStop = false;
            gbGraus.Text = "Graus";
            gbGraus.Enter += groupBox1_Enter;
            // 
            // lblK
            // 
            lblK.AutoSize = true;
            lblK.BackColor = Color.Yellow;
            lblK.BorderStyle = BorderStyle.FixedSingle;
            lblK.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblK.Location = new Point(15, 167);
            lblK.Name = "lblK";
            lblK.Size = new Size(121, 21);
            lblK.TabIndex = 5;
            lblK.Text = "Kelvin:    ";
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.BackColor = Color.Yellow;
            lblF.BorderStyle = BorderStyle.FixedSingle;
            lblF.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblF.Location = new Point(15, 110);
            lblF.Name = "lblF";
            lblF.Size = new Size(121, 21);
            lblF.TabIndex = 4;
            lblF.Text = "Farehnheit:";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.BackColor = Color.Yellow;
            lblC.BorderStyle = BorderStyle.FixedSingle;
            lblC.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblC.Location = new Point(15, 53);
            lblC.Name = "lblC";
            lblC.Size = new Size(121, 21);
            lblC.TabIndex = 3;
            lblC.Text = "Celsius:   ";
            // 
            // txtFa
            // 
            txtFa.Location = new Point(150, 164);
            txtFa.Name = "txtFa";
            txtFa.Size = new Size(100, 29);
            txtFa.TabIndex = 2;
            // 
            // txtF
            // 
            txtF.Location = new Point(150, 107);
            txtF.Name = "txtF";
            txtF.Size = new Size(100, 29);
            txtF.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(150, 50);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 29);
            txtC.TabIndex = 0;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(12, 258);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(102, 258);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(75, 23);
            btnLimpa.TabIndex = 2;
            btnLimpa.Text = "Limpar";
            btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ControlLightLight;
            btnSair.Location = new Point(193, 258);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // fConvert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(280, 294);
            Controls.Add(btnSair);
            Controls.Add(btnLimpa);
            Controls.Add(btnCalc);
            Controls.Add(gbGraus);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(296, 333);
            MinimizeBox = false;
            MinimumSize = new Size(296, 333);
            Name = "fConvert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobversor de Graus";
            gbGraus.ResumeLayout(false);
            gbGraus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGraus;
        private Button btnCalc;
        private Button btnLimpa;
        private Button btnSair;
        private TextBox txtFa;
        private TextBox txtF;
        private TextBox txtC;
        private Label lblK;
        private Label lblF;
        private Label lblC;
    }
}