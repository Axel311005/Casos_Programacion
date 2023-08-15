namespace caso4
{
    partial class caso4
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
            txtSocio1 = new TextBox();
            txtSocio2 = new TextBox();
            txtSocio3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            txtPorcentaje1 = new TextBox();
            txtPorcentaje2 = new TextBox();
            txtPorcentaje3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnResult = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtSocio1
            // 
            txtSocio1.BackColor = Color.White;
            txtSocio1.Location = new Point(74, 123);
            txtSocio1.Name = "txtSocio1";
            txtSocio1.Size = new Size(200, 39);
            txtSocio1.TabIndex = 0;
            // 
            // txtSocio2
            // 
            txtSocio2.BackColor = Color.White;
            txtSocio2.Location = new Point(339, 123);
            txtSocio2.Name = "txtSocio2";
            txtSocio2.Size = new Size(200, 39);
            txtSocio2.TabIndex = 1;
            // 
            // txtSocio3
            // 
            txtSocio3.BackColor = Color.White;
            txtSocio3.Location = new Point(619, 123);
            txtSocio3.Name = "txtSocio3";
            txtSocio3.Size = new Size(200, 39);
            txtSocio3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 53);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 3;
            label1.Text = "Socio 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(393, 53);
            label2.Name = "label2";
            label2.Size = new Size(100, 33);
            label2.TabIndex = 4;
            label2.Text = "Socio 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(675, 53);
            label3.Name = "label3";
            label3.Size = new Size(100, 33);
            label3.TabIndex = 5;
            label3.Text = "Socio 3";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(339, 364);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.Size = new Size(200, 50);
            txtTotal.TabIndex = 6;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPorcentaje1
            // 
            txtPorcentaje1.BackColor = SystemColors.ButtonShadow;
            txtPorcentaje1.Location = new Point(62, 641);
            txtPorcentaje1.Name = "txtPorcentaje1";
            txtPorcentaje1.ReadOnly = true;
            txtPorcentaje1.Size = new Size(200, 39);
            txtPorcentaje1.TabIndex = 7;
            // 
            // txtPorcentaje2
            // 
            txtPorcentaje2.BackColor = SystemColors.ButtonShadow;
            txtPorcentaje2.Location = new Point(339, 641);
            txtPorcentaje2.Name = "txtPorcentaje2";
            txtPorcentaje2.ReadOnly = true;
            txtPorcentaje2.Size = new Size(200, 39);
            txtPorcentaje2.TabIndex = 8;
            // 
            // txtPorcentaje3
            // 
            txtPorcentaje3.BackColor = SystemColors.ButtonShadow;
            txtPorcentaje3.Location = new Point(619, 641);
            txtPorcentaje3.Name = "txtPorcentaje3";
            txtPorcentaje3.ReadOnly = true;
            txtPorcentaje3.Size = new Size(200, 39);
            txtPorcentaje3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(363, 312);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 10;
            label4.Text = "Capital Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(284, 477);
            label5.Name = "label5";
            label5.Size = new Size(304, 23);
            label5.TabIndex = 11;
            label5.Text = "Porcentaje Aportado por los Socios";
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.Location = new Point(339, 211);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(211, 46);
            btnResult.TabIndex = 12;
            btnResult.Text = "Calcular Capital";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(130, 556);
            label6.Name = "label6";
            label6.Size = new Size(100, 33);
            label6.TabIndex = 13;
            label6.Text = "Socio 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(393, 556);
            label7.Name = "label7";
            label7.Size = new Size(100, 33);
            label7.TabIndex = 14;
            label7.Text = "Socio 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(675, 556);
            label8.Name = "label8";
            label8.Size = new Size(100, 33);
            label8.TabIndex = 15;
            label8.Text = "Socio 3";
            // 
            // caso4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(892, 772);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPorcentaje3);
            Controls.Add(txtPorcentaje2);
            Controls.Add(txtPorcentaje1);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSocio3);
            Controls.Add(txtSocio2);
            Controls.Add(txtSocio1);
            Name = "caso4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "caso4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSocio1;
        private TextBox txtSocio2;
        private TextBox txtSocio3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTotal;
        private TextBox txtPorcentaje1;
        private TextBox txtPorcentaje2;
        private TextBox txtPorcentaje3;
        private Label label4;
        private Label label5;
        private Button btnResult;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}