namespace caso3
{
    partial class caso3
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
            txtMedida = new ComboBox();
            txtMetros = new Label();
            label2 = new Label();
            label3 = new Label();
            txtResult = new TextBox();
            btnConvertir = new Button();
            label4 = new Label();
            label5 = new Label();
            txtCant = new TextBox();
            SuspendLayout();
            // 
            // txtMedida
            // 
            txtMedida.FormattingEnabled = true;
            txtMedida.Items.AddRange(new object[] { "Centimetros", "Pies", "Pulgadas", "Yardas" });
            txtMedida.Location = new Point(321, 318);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(242, 40);
            txtMedida.TabIndex = 0;
            // 
            // txtMetros
            // 
            txtMetros.AutoSize = true;
            txtMetros.BackColor = Color.Snow;
            txtMetros.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtMetros.Location = new Point(99, 318);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(91, 31);
            txtMetros.TabIndex = 1;
            txtMetros.Text = "Metros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(111, 246);
            label2.Name = "label2";
            label2.Size = new Size(51, 31);
            label2.TabIndex = 2;
            label2.Text = "De:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleTurquoise;
            label3.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(418, 246);
            label3.Name = "label3";
            label3.Size = new Size(39, 31);
            label3.TabIndex = 3;
            label3.Text = "A:";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(217, 111);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(224, 44);
            txtResult.TabIndex = 4;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.LightCoral;
            btnConvertir.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(231, 527);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(150, 46);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Salmon;
            label4.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(263, 52);
            label4.Name = "label4";
            label4.Size = new Size(124, 31);
            label4.TabIndex = 6;
            label4.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Snow;
            label5.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(87, 428);
            label5.Name = "label5";
            label5.Size = new Size(236, 31);
            label5.TabIndex = 7;
            label5.Text = "Cantidad a convertir";
            // 
            // txtCant
            // 
            txtCant.Location = new Point(363, 425);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(200, 39);
            txtCant.TabIndex = 8;
            // 
            // caso3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(637, 632);
            Controls.Add(txtCant);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnConvertir);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMetros);
            Controls.Add(txtMedida);
            Name = "caso3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtMedida;
        private Label txtMetros;
        private Label label2;
        private Label label3;
        private TextBox txtResult;
        private Button btnConvertir;
        private Label label4;
        private Label label5;
        private TextBox txtCant;
    }
}