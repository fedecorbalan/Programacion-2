namespace WinForms03
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            label2 = new Label();
            lblError = new Label();
            lblCodSeg = new Label();
            lblColFav = new Label();
            this.lblNacimiento = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            gbxInfoExtra = new GroupBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            gbxSexo = new GroupBox();
            checkFemenino = new CheckBox();
            checkNoBinario = new CheckBox();
            checkMasculino = new CheckBox();
            gbxVarios = new GroupBox();
            this.checkTrabaja = new CheckBox();
            this.checkEstudia = new CheckBox();
            checkMayor = new CheckBox();
            this.btnRegistro = new Button();
            btnHardcode = new Button();
            button3 = new Button();
            gbxDatos = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            gbxInfoExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gbxSexo.SuspendLayout();
            gbxVarios.SuspendLayout();
            gbxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(129, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(13, 176);
            lblError.Name = "lblError";
            lblError.Size = new Size(68, 25);
            lblError.TabIndex = 2;
            lblError.Text = "ERROR";
            // 
            // lblCodSeg
            // 
            lblCodSeg.AutoSize = true;
            lblCodSeg.Location = new Point(18, 37);
            lblCodSeg.Name = "lblCodSeg";
            lblCodSeg.Size = new Size(88, 25);
            lblCodSeg.TabIndex = 3;
            lblCodSeg.Text = "Cod. Seg.";
            // 
            // lblColFav
            // 
            lblColFav.AutoSize = true;
            lblColFav.Location = new Point(201, 37);
            lblColFav.Name = "lblColFav";
            lblColFav.Size = new Size(124, 25);
            lblColFav.TabIndex = 4;
            lblColFav.Text = "Color Favorito";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new Point(22, 267);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new Size(177, 25);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(478, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(478, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(478, 31);
            textBox4.TabIndex = 9;
            // 
            // gbxInfoExtra
            // 
            gbxInfoExtra.Controls.Add(dateTimePicker1);
            gbxInfoExtra.Controls.Add(comboBox1);
            gbxInfoExtra.Controls.Add(numericUpDown1);
            gbxInfoExtra.Controls.Add(lblCodSeg);
            gbxInfoExtra.Controls.Add(gbxSexo);
            gbxInfoExtra.Controls.Add(gbxVarios);
            gbxInfoExtra.Controls.Add(this.lblNacimiento);
            gbxInfoExtra.Controls.Add(lblColFav);
            gbxInfoExtra.Location = new Point(35, 262);
            gbxInfoExtra.Name = "gbxInfoExtra";
            gbxInfoExtra.Size = new Size(517, 352);
            gbxInfoExtra.TabIndex = 10;
            gbxInfoExtra.TabStop = false;
            gbxInfoExtra.Text = "Informacion Extra";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(201, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(303, 33);
            comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(18, 65);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(165, 31);
            numericUpDown1.TabIndex = 12;
            // 
            // gbxSexo
            // 
            gbxSexo.Controls.Add(checkFemenino);
            gbxSexo.Controls.Add(checkNoBinario);
            gbxSexo.Controls.Add(checkMasculino);
            gbxSexo.Location = new Point(18, 114);
            gbxSexo.Name = "gbxSexo";
            gbxSexo.Size = new Size(165, 141);
            gbxSexo.TabIndex = 11;
            gbxSexo.TabStop = false;
            gbxSexo.Text = "Sexo";
            // 
            // checkFemenino
            // 
            checkFemenino.AutoSize = true;
            checkFemenino.Location = new Point(6, 65);
            checkFemenino.Name = "checkFemenino";
            checkFemenino.Size = new Size(116, 29);
            checkFemenino.TabIndex = 3;
            checkFemenino.Text = "Femenino";
            checkFemenino.UseVisualStyleBackColor = true;
            // 
            // checkNoBinario
            // 
            checkNoBinario.AutoSize = true;
            checkNoBinario.Location = new Point(6, 100);
            checkNoBinario.Name = "checkNoBinario";
            checkNoBinario.Size = new Size(121, 29);
            checkNoBinario.TabIndex = 2;
            checkNoBinario.Text = "No Binario";
            checkNoBinario.UseVisualStyleBackColor = true;
            // 
            // checkMasculino
            // 
            checkMasculino.AutoSize = true;
            checkMasculino.Location = new Point(6, 30);
            checkMasculino.Name = "checkMasculino";
            checkMasculino.Size = new Size(118, 29);
            checkMasculino.TabIndex = 1;
            checkMasculino.Text = "Masculino";
            checkMasculino.UseVisualStyleBackColor = true;
            // 
            // gbxVarios
            // 
            gbxVarios.Controls.Add(this.checkTrabaja);
            gbxVarios.Controls.Add(this.checkEstudia);
            gbxVarios.Controls.Add(checkMayor);
            gbxVarios.Location = new Point(201, 114);
            gbxVarios.Name = "gbxVarios";
            gbxVarios.Size = new Size(303, 141);
            gbxVarios.TabIndex = 11;
            gbxVarios.TabStop = false;
            gbxVarios.Text = "Varios";
            // 
            // checkTrabaja
            // 
            this.checkTrabaja.AutoSize = true;
            this.checkTrabaja.Location = new Point(6, 99);
            this.checkTrabaja.Name = "checkTrabaja";
            this.checkTrabaja.Size = new Size(93, 29);
            this.checkTrabaja.TabIndex = 2;
            this.checkTrabaja.Text = "Trabaja";
            this.checkTrabaja.UseVisualStyleBackColor = true;
            // 
            // checkEstudia
            // 
            this.checkEstudia.AutoSize = true;
            this.checkEstudia.Location = new Point(6, 64);
            this.checkEstudia.Name = "checkEstudia";
            this.checkEstudia.Size = new Size(95, 29);
            this.checkEstudia.TabIndex = 1;
            this.checkEstudia.Text = "Estudia";
            this.checkEstudia.UseVisualStyleBackColor = true;
            // 
            // checkMayor
            // 
            checkMayor.AutoSize = true;
            checkMayor.Location = new Point(6, 30);
            checkMayor.Name = "checkMayor";
            checkMayor.Size = new Size(159, 29);
            checkMayor.TabIndex = 0;
            checkMayor.Text = "Mayor de edad";
            checkMayor.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = Color.FromArgb(128, 255, 128);
            this.btnRegistro.Location = new Point(35, 632);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new Size(504, 66);
            this.btnRegistro.TabIndex = 11;
            this.btnRegistro.Text = "REGISTRAR";
            this.btnRegistro.UseVisualStyleBackColor = false;
            // 
            // btnHardcode
            // 
            btnHardcode.Location = new Point(35, 704);
            btnHardcode.Name = "btnHardcode";
            btnHardcode.Size = new Size(239, 66);
            btnHardcode.TabIndex = 12;
            btnHardcode.Text = "button2";
            btnHardcode.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(300, 704);
            button3.Name = "button3";
            button3.Size = new Size(239, 66);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(textBox4);
            gbxDatos.Controls.Add(textBox3);
            gbxDatos.Controls.Add(textBox2);
            gbxDatos.Controls.Add(lblError);
            gbxDatos.Controls.Add(textBox1);
            gbxDatos.Location = new Point(35, 52);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(517, 204);
            gbxDatos.TabIndex = 14;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(486, 31);
            dateTimePicker1.TabIndex = 13;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 778);
            Controls.Add(button3);
            Controls.Add(btnHardcode);
            Controls.Add(this.btnRegistro);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(gbxInfoExtra);
            Controls.Add(gbxDatos);
            Name = "Registro";
            Text = "Registro";
            gbxInfoExtra.ResumeLayout(false);
            gbxInfoExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gbxSexo.ResumeLayout(false);
            gbxSexo.PerformLayout();
            gbxVarios.ResumeLayout(false);
            gbxVarios.PerformLayout();
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label2;
        private Label lblError;
        private Label lblCodSeg;
        private Label lblColFav;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox gbxInfoExtra;
        private NumericUpDown numericUpDown1;
        private GroupBox gbxSexo;
        private GroupBox gbxVarios;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private CheckBox checkFemenino;
        private CheckBox checkNoBinario;
        private CheckBox checkMasculino;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkMayor;
        private Button button1;
        private Button btnHardcode;
        private Button button3;
        private GroupBox gbxDatos;
        private DateTimePicker dateTimePicker1;
    }
}