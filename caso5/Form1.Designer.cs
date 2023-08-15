namespace caso5
{
    partial class Form1
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
            label5 = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtTotalxunidad = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(126, 87);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 0;
            label1.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 186);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(126, 284);
            label3.Name = "label3";
            label3.Size = new Size(196, 31);
            label3.TabIndex = 2;
            label3.Text = "Total por unidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(126, 383);
            label4.Name = "label4";
            label4.Size = new Size(248, 31);
            label4.TabIndex = 3;
            label4.Text = "Total Descuento 11%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(126, 478);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(371, 87);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 39);
            txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(371, 186);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 39);
            txtCantidad.TabIndex = 6;
            // 
            // txtTotalxunidad
            // 
            txtTotalxunidad.Location = new Point(371, 281);
            txtTotalxunidad.Name = "txtTotalxunidad";
            txtTotalxunidad.ReadOnly = true;
            txtTotalxunidad.Size = new Size(200, 39);
            txtTotalxunidad.TabIndex = 7;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(371, 376);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(200, 39);
            txtDescuento.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(371, 471);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(200, 39);
            txtTotal.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.RosyBrown;
            btnCalcular.Location = new Point(253, 599);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(666, 697);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtTotalxunidad);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "caso5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtTotalxunidad;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private Button btnCalcular;
    }
}