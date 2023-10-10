namespace serialCommunication
{
    partial class FormSerial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOFF);
            this.groupBox1.Controls.Add(this.buttonON);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Controls.Add(this.comboBoxPuerto);
            this.groupBox1.Controls.Add(this.labelBaud);
            this.groupBox1.Controls.Add(this.labelPuerto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Settings";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(73, 34);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(41, 13);
            this.labelPuerto.TabIndex = 0;
            this.labelPuerto.Text = "Puerto:";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(73, 86);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(61, 13);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(154, 31);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPuerto.TabIndex = 2;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(154, 83);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(76, 128);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 4;
            this.buttonON.Text = "Conectar";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(185, 128);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(90, 23);
            this.buttonOFF.TabIndex = 5;
            this.buttonOFF.Text = "Desconectar";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // FormSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 189);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSerial";
            this.Text = "Serial Communication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSerial_FormClosing);
            this.Load += new System.EventHandler(this.FormSerial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPuerto;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPuerto;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

