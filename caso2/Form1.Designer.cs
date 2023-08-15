namespace caso2
{
    partial class caso2
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
            txtPromedio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnCalcular = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(226, 99);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(277, 39);
            txtPromedio.TabIndex = 0;
            txtPromedio.Text = "0";
            txtPromedio.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 216);
            label1.Name = "label1";
            label1.Size = new Size(91, 33);
            label1.TabIndex = 1;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 309);
            label2.Name = "label2";
            label2.Size = new Size(91, 33);
            label2.TabIndex = 2;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 399);
            label3.Name = "label3";
            label3.Size = new Size(91, 33);
            label3.TabIndex = 3;
            label3.Text = "Nota 3";
            // 
            // txtNota1
            // 
            txtNota1.BackColor = Color.Bisque;
            txtNota1.Location = new Point(263, 213);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(200, 39);
            txtNota1.TabIndex = 4;
            txtNota1.Text = "0";
            txtNota1.TextAlign = HorizontalAlignment.Center;
            txtNota1.TextChanged += txtNota1_TextChanged;
            // 
            // txtNota2
            // 
            txtNota2.BackColor = Color.Bisque;
            txtNota2.Location = new Point(263, 309);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(200, 39);
            txtNota2.TabIndex = 5;
            txtNota2.Text = "0";
            txtNota2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNota3
            // 
            txtNota3.BackColor = Color.Bisque;
            txtNota3.Location = new Point(263, 392);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(200, 39);
            txtNota3.TabIndex = 6;
            txtNota3.Text = "0";
            txtNota3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(285, 470);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(178, 64);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(240, 23);
            label4.Name = "label4";
            label4.Size = new Size(254, 31);
            label4.TabIndex = 8;
            label4.Text = "Promedio de las notas";
            label4.Click += label4_Click;
            // 
            // caso2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            CancelButton = btnCalcular;
            ClientSize = new Size(703, 565);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPromedio);
            Name = "caso2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPromedio;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnCalcular;
        private Label label4;
    }
}