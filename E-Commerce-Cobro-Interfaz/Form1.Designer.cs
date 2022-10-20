namespace E_Commerce_Cobro_Interfaz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cobro = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.comboFormaPago = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Cobro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 70);
            this.panel1.TabIndex = 5;
            // 
            // Cobro
            // 
            this.Cobro.AutoSize = true;
            this.Cobro.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cobro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cobro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cobro.Location = new System.Drawing.Point(132, 18);
            this.Cobro.Name = "Cobro";
            this.Cobro.Size = new System.Drawing.Size(127, 42);
            this.Cobro.TabIndex = 5;
            this.Cobro.Text = "Cobro";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(25, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Volver al carrito";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(38, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Forma de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(38, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(79, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 29);
            this.textBox1.TabIndex = 11;
            // 
            // buttonPagar
            // 
            this.buttonPagar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPagar.Location = new System.Drawing.Point(273, 375);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(87, 37);
            this.buttonPagar.TabIndex = 12;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = false;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // comboFormaPago
            // 
            this.comboFormaPago.FormattingEnabled = true;
            this.comboFormaPago.Items.AddRange(new object[] {
            "Tarjeta de credito",
            "Tarjeta de debito"});
            this.comboFormaPago.Location = new System.Drawing.Point(50, 155);
            this.comboFormaPago.Name = "comboFormaPago";
            this.comboFormaPago.Size = new System.Drawing.Size(183, 23);
            this.comboFormaPago.TabIndex = 13;
            this.comboFormaPago.Text = "Seleccionar forma de pago";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.comboFormaPago);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label Cobro;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button buttonPagar;
        private ComboBox comboFormaPago;
    }
}