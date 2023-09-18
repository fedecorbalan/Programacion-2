namespace WinForms03
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
            btnLimpiar = new Button();
            lstTabla = new ListBox();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(306, 45);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número: ";
            label1.Click += label1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(562, 202);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(213, 103);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 25;
            lstTabla.Location = new Point(32, 99);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(511, 279);
            lstTabla.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(328, 35);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(447, 50);
            txtNumero.TabIndex = 3;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(lstTabla);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLimpiar;
        private ListBox lstTabla;
        private TextBox txtNumero;
    }
}