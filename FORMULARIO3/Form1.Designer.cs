namespace FORMULARIO3
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
            guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            tbTelefono = new TextBox();
            tbEstatura = new TextBox();
            tbEdad = new TextBox();
            rbHombre = new RadioButton();
            rbMujer = new RadioButton();
            cancelar = new Button();
            SuspendLayout();
            // 
            // guardar
            // 
            guardar.Location = new Point(101, 335);
            guardar.Name = "guardar";
            guardar.Size = new Size(75, 23);
            guardar.TabIndex = 0;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 116);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 158);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Estatura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 198);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 5;
            label5.Text = "Edad";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(114, 33);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 6;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(115, 74);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(100, 23);
            tbApellidos.TabIndex = 7;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(110, 116);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(100, 23);
            tbTelefono.TabIndex = 8;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(107, 158);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(100, 23);
            tbEstatura.TabIndex = 9;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(101, 194);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(100, 23);
            tbEdad.TabIndex = 10;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(47, 275);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(69, 19);
            rbHombre.TabIndex = 11;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(159, 275);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(56, 19);
            rbMujer.TabIndex = 12;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(114, 384);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(75, 23);
            cancelar.TabIndex = 13;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelar);
            Controls.Add(rbMujer);
            Controls.Add(rbHombre);
            Controls.Add(tbEdad);
            Controls.Add(tbEstatura);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbTelefono;
        private TextBox tbEstatura;
        private TextBox tbEdad;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private Button cancelar;
    }
}