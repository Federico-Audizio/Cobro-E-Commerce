namespace E_Commerce_Cobro_Interfaz
{
    partial class Tarjeta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cobro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNroTarjeta = new System.Windows.Forms.TextBox();
            this.textNombreApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCodigoSegurirdad = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.comboCuotas = new System.Windows.Forms.ComboBox();
            this.buttonPagarFin = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Size = new System.Drawing.Size(424, 70);
            this.panel1.TabIndex = 6;
            // 
            // Cobro
            // 
            this.Cobro.AutoSize = true;
            this.Cobro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cobro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cobro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cobro.Location = new System.Drawing.Point(24, 18);
            this.Cobro.Name = "Cobro";
            this.Cobro.Size = new System.Drawing.Size(330, 33);
            this.Cobro.TabIndex = 5;
            this.Cobro.Text = "Ingrese datos de tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNroTarjeta
            // 
            this.textNroTarjeta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textNroTarjeta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNroTarjeta.ForeColor = System.Drawing.Color.Black;
            this.textNroTarjeta.Location = new System.Drawing.Point(35, 108);
            this.textNroTarjeta.Name = "textNroTarjeta";
            this.textNroTarjeta.PlaceholderText = "Numero de Tarjeta";
            this.textNroTarjeta.Size = new System.Drawing.Size(331, 33);
            this.textNroTarjeta.TabIndex = 10;
            // 
            // textNombreApellido
            // 
            this.textNombreApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textNombreApellido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.textNombreApellido.Location = new System.Drawing.Point(35, 162);
            this.textNombreApellido.Name = "textNombreApellido";
            this.textNombreApellido.PlaceholderText = "Nombre y apllido";
            this.textNombreApellido.Size = new System.Drawing.Size(331, 33);
            this.textNombreApellido.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(31, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de vecimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(231, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo de seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(31, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cuotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(231, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "DNI";
            // 
            // textCodigoSegurirdad
            // 
            this.textCodigoSegurirdad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textCodigoSegurirdad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCodigoSegurirdad.ForeColor = System.Drawing.Color.Black;
            this.textCodigoSegurirdad.Location = new System.Drawing.Point(231, 239);
            this.textCodigoSegurirdad.Name = "textCodigoSegurirdad";
            this.textCodigoSegurirdad.PlaceholderText = "CVV";
            this.textCodigoSegurirdad.Size = new System.Drawing.Size(135, 22);
            this.textCodigoSegurirdad.TabIndex = 16;
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textDNI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDNI.ForeColor = System.Drawing.Color.Black;
            this.textDNI.Location = new System.Drawing.Point(231, 284);
            this.textDNI.Name = "textDNI";
            this.textDNI.PlaceholderText = "Numero";
            this.textDNI.Size = new System.Drawing.Size(135, 22);
            this.textDNI.TabIndex = 17;
            // 
            // comboCuotas
            // 
            this.comboCuotas.FormattingEnabled = true;
            this.comboCuotas.Items.AddRange(new object[] {
            "1 Cuota",
            "3 Cuotas",
            "6 Cuotas",
            "9 Cuotas",
            "12 Cuotas"});
            this.comboCuotas.Location = new System.Drawing.Point(34, 283);
            this.comboCuotas.Name = "comboCuotas";
            this.comboCuotas.Size = new System.Drawing.Size(121, 23);
            this.comboCuotas.TabIndex = 21;
            // 
            // buttonPagarFin
            // 
            this.buttonPagarFin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPagarFin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPagarFin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPagarFin.Location = new System.Drawing.Point(231, 318);
            this.buttonPagarFin.Name = "buttonPagarFin";
            this.buttonPagarFin.Size = new System.Drawing.Size(81, 35);
            this.buttonPagarFin.TabIndex = 22;
            this.buttonPagarFin.Text = "Pagar";
            this.buttonPagarFin.UseVisualStyleBackColor = false;
            this.buttonPagarFin.Click += new System.EventHandler(this.buttonPagarFin_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(34, 317);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(92, 35);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Tarjeta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(424, 411);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonPagarFin);
            this.Controls.Add(this.comboCuotas);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textCodigoSegurirdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreApellido);
            this.Controls.Add(this.textNroTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjeta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Cobro;
        private Label label1;
        private TextBox textNroTarjeta;
        private TextBox textNombreApellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textCodigoSegurirdad;
        private TextBox textDNI;
        private ComboBox comboCuotas;
        private Button buttonPagarFin;
        private Button buttonCancelar;
        private DateTimePicker dateTimePicker1;
    }
}