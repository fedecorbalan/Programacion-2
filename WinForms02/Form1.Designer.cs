namespace WinForms02
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
            lblSaludo = new Label();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaludo.Location = new Point(38, 71);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(725, 81);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡¡¡Hola mundo WinForm!!!";
            lblSaludo.Visible = false;
            lblSaludo.Click += label1_Click;
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(212, 265);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(377, 126);
            btnSaludo.TabIndex = 1;
            btnSaludo.Text = "Haga click aqui!";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaludo);
            Controls.Add(lblSaludo);
            Name = "Form1";
            Text = "Saludo desde un Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Button btnSaludo;
    }
}