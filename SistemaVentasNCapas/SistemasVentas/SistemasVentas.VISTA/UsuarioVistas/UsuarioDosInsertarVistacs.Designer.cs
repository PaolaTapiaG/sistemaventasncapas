﻿namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioDosInsertarVistacs
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 102);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(412, 102);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 2;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 167);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE USUARIO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 233);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "PASSWORD";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 230);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(352, 27);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 297);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 7;
            label4.Text = "FECHA REGISTRO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 292);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(352, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(63, 384);
            button2.Name = "button2";
            button2.Size = new Size(166, 29);
            button2.TabIndex = 9;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(326, 384);
            button3.Name = "button3";
            button3.Size = new Size(163, 29);
            button3.TabIndex = 10;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // UsuarioDosInsertarVistacs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 460);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UsuarioDosInsertarVistacs";
            Text = "UsuarioDosInsertarVistacs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
    }
}