
namespace interfaz
{
    partial class PermisoSalir
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nreloj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EnviarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HsCB = new System.Windows.Forms.ComboBox();
            this.HrCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Aceptado1CB = new System.Windows.Forms.CheckBox();
            this.Aceptado2CB = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CorreroTB = new System.Windows.Forms.TextBox();
            this.RegresoCB = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de reloj";
            // 
            // Nreloj
            // 
            this.Nreloj.Location = new System.Drawing.Point(99, 6);
            this.Nreloj.Name = "Nreloj";
            this.Nreloj.Size = new System.Drawing.Size(100, 20);
            this.Nreloj.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motivo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 114);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 174);
            this.textBox2.TabIndex = 5;
            // 
            // EnviarButton
            // 
            this.EnviarButton.Enabled = false;
            this.EnviarButton.Location = new System.Drawing.Point(222, 233);
            this.EnviarButton.Name = "EnviarButton";
            this.EnviarButton.Size = new System.Drawing.Size(121, 55);
            this.EnviarButton.TabIndex = 6;
            this.EnviarButton.Text = "Enviar";
            this.EnviarButton.UseVisualStyleBackColor = true;
            this.EnviarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora de regreso";
            // 
            // HsCB
            // 
            this.HsCB.FormattingEnabled = true;
            this.HsCB.Items.AddRange(new object[] {
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00",
            "",
            ""});
            this.HsCB.Location = new System.Drawing.Point(222, 40);
            this.HsCB.Name = "HsCB";
            this.HsCB.Size = new System.Drawing.Size(121, 21);
            this.HsCB.TabIndex = 9;
            // 
            // HrCB
            // 
            this.HrCB.Enabled = false;
            this.HrCB.FormattingEnabled = true;
            this.HrCB.Items.AddRange(new object[] {
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.HrCB.Location = new System.Drawing.Point(222, 102);
            this.HrCB.Name = "HrCB";
            this.HrCB.Size = new System.Drawing.Size(121, 21);
            this.HrCB.TabIndex = 10;
            this.HrCB.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Autorizacion 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Autorizacion 2";
            // 
            // Aceptado1CB
            // 
            this.Aceptado1CB.AutoSize = true;
            this.Aceptado1CB.Enabled = false;
            this.Aceptado1CB.Location = new System.Drawing.Point(222, 158);
            this.Aceptado1CB.Name = "Aceptado1CB";
            this.Aceptado1CB.Size = new System.Drawing.Size(72, 17);
            this.Aceptado1CB.TabIndex = 13;
            this.Aceptado1CB.Text = "Aceptado";
            this.Aceptado1CB.UseVisualStyleBackColor = true;
            this.Aceptado1CB.CheckedChanged += new System.EventHandler(this.Aceptado1CB_CheckedChanged);
            // 
            // Aceptado2CB
            // 
            this.Aceptado2CB.AutoSize = true;
            this.Aceptado2CB.Enabled = false;
            this.Aceptado2CB.Location = new System.Drawing.Point(222, 210);
            this.Aceptado2CB.Name = "Aceptado2CB";
            this.Aceptado2CB.Size = new System.Drawing.Size(72, 17);
            this.Aceptado2CB.TabIndex = 14;
            this.Aceptado2CB.Text = "Aceptado";
            this.Aceptado2CB.UseVisualStyleBackColor = true;
            this.Aceptado2CB.CheckedChanged += new System.EventHandler(this.Aceptado2CB_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Correo";
            // 
            // CorreroTB
            // 
            this.CorreroTB.Location = new System.Drawing.Point(61, 299);
            this.CorreroTB.Name = "CorreroTB";
            this.CorreroTB.Size = new System.Drawing.Size(280, 20);
            this.CorreroTB.TabIndex = 16;
            // 
            // RegresoCB
            // 
            this.RegresoCB.AutoSize = true;
            this.RegresoCB.Location = new System.Drawing.Point(308, 74);
            this.RegresoCB.Name = "RegresoCB";
            this.RegresoCB.Size = new System.Drawing.Size(15, 14);
            this.RegresoCB.TabIndex = 17;
            this.RegresoCB.UseVisualStyleBackColor = true;
            this.RegresoCB.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 55);
            this.button2.TabIndex = 18;
            this.button2.Text = "Solicitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PermisoSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(612, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RegresoCB);
            this.Controls.Add(this.CorreroTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Aceptado2CB);
            this.Controls.Add(this.Aceptado1CB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HrCB);
            this.Controls.Add(this.HsCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnviarButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nreloj);
            this.Controls.Add(this.label1);
            this.Name = "PermisoSalir";
            this.Text = "Solicitar retirada";
            this.Load += new System.EventHandler(this.PermisoSalir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nreloj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button EnviarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HsCB;
        private System.Windows.Forms.ComboBox HrCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Aceptado1CB;
        private System.Windows.Forms.CheckBox Aceptado2CB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CorreroTB;
        private System.Windows.Forms.CheckBox RegresoCB;
        private System.Windows.Forms.Button button2;
    }
}