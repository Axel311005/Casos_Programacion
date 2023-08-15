namespace caso1
{
    partial class caso1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtResult = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 228);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el precio del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 274);
            label2.Name = "label2";
            label2.Size = new Size(116, 42);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Times New Roman", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 383);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 2;
            label3.Text = "Ingrese la cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 426);
            label4.Name = "label4";
            label4.Size = new Size(168, 42);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(241, 277);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 39);
            txtPrecio.TabIndex = 4;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(241, 431);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 39);
            txtCantidad.TabIndex = 5;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.Desktop;
            txtResult.Enabled = false;
            txtResult.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.ForeColor = SystemColors.ControlLightLight;
            txtResult.Location = new Point(12, 46);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(663, 57);
            txtResult.TabIndex = 6;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.MenuHighlight;
            btnCalcular.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(284, 502);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(191, 63);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.BottomCenter;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // caso1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(699, 587);
            Controls.Add(btnCalcular);
            Controls.Add(txtResult);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "caso1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtResult;
        private Button btnCalcular;
    }
}