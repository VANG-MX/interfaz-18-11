namespace interfaz
{
    partial class SolicitarTectnico
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
            this.NRTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SEComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NRTextBox
            // 
            this.NRTextBox.Enabled = false;
            this.NRTextBox.Location = new System.Drawing.Point(66, 55);
            this.NRTextBox.Multiline = true;
            this.NRTextBox.Name = "NRTextBox";
            this.NRTextBox.Size = new System.Drawing.Size(185, 20);
            this.NRTextBox.TabIndex = 0;
            this.NRTextBox.TextChanged += new System.EventHandler(this.NRTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SEComboBox
            // 
            this.SEComboBox.FormattingEnabled = true;
            this.SEComboBox.Items.AddRange(new object[] {
            "Entrada 1",
            "Entrada 2",
            "Salida 1",
            "Salida 2"});
            this.SEComboBox.Location = new System.Drawing.Point(98, 12);
            this.SEComboBox.Name = "SEComboBox";
            this.SEComboBox.Size = new System.Drawing.Size(121, 21);
            this.SEComboBox.TabIndex = 2;
            this.SEComboBox.SelectedIndexChanged += new System.EventHandler(this.SEComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Solicitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolicitarTectnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(338, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SEComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NRTextBox);
            this.Name = "SolicitarTectnico";
            this.Text = "SolicitarTectnico";
            this.Load += new System.EventHandler(this.SolicitarTectnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NRTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SEComboBox;
        private System.Windows.Forms.Button button1;
    }
}