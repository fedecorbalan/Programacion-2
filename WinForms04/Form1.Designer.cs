namespace WinForms04
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
            textBox1 = new TextBox();
            lblImporte = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 31);
            textBox1.TabIndex = 0;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblImporte.Location = new Point(33, 70);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(342, 32);
            lblImporte.TabIndex = 3;
            lblImporte.Text = "Ingrese el importe a cobrar: ";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(148, 153);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(233, 32);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuento recibido: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(203, 228);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(178, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a pagar: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(207, 358);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(125, 58);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(lblImporte);
            groupBox1.Controls.Add(lblDescuento);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Location = new Point(90, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 293);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 31);
            textBox2.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(477, 358);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 58);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblImporte;
        private Label lblDescuento;
        private Label lblTotal;
        private Button btnAceptar;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnLimpiar;
    }
}