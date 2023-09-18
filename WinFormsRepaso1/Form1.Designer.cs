namespace WinFormsRepaso1
{
    partial class Login
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
            btnIngreso = new Button();
            btnSalir = new Button();
            lblLogin = new Label();
            linkRegistro = new LinkLabel();
            lblContrasena = new Label();
            lblCorreo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.PaleGreen;
            btnIngreso.Location = new Point(22, 200);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(536, 69);
            btnIngreso.TabIndex = 0;
            btnIngreso.Text = "INGRESAR";
            btnIngreso.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(287, 275);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(271, 72);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(12, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(102, 38);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(34, 299);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(121, 25);
            linkRegistro.TabIndex = 3;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "REGISTRARSE";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasena.Location = new Point(16, 121);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(108, 25);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.Location = new Point(12, 59);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(69, 25);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(536, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(536, 31);
            textBox2.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 359);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblCorreo);
            Controls.Add(lblContrasena);
            Controls.Add(linkRegistro);
            Controls.Add(lblLogin);
            Controls.Add(btnSalir);
            Controls.Add(btnIngreso);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngreso;
        private Button btnSalir;
        private Label lblLogin;
        private LinkLabel linkRegistro;
        private Label lblContrasena;
        private Label lblCorreo;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}