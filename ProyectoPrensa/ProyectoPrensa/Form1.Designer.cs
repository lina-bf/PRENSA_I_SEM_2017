namespace ProyectoPrensa
{
    partial class Eje
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
            this.components = new System.ComponentModel.Container();
            this.Inicio = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.P1 = new System.Windows.Forms.Button();
            this.Boton6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(12, 12);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(115, 35);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(33, 79);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(75, 23);
            this.P1.TabIndex = 1;
            this.P1.Text = "Prueba";
            this.P1.UseVisualStyleBackColor = true;
            this.P1.Click += new System.EventHandler(this.P1_Click);
            // 
            // Boton6
            // 
            this.Boton6.Location = new System.Drawing.Point(389, 133);
            this.Boton6.Name = "Boton6";
            this.Boton6.Size = new System.Drawing.Size(75, 23);
            this.Boton6.TabIndex = 2;
            this.Boton6.Text = "button1";
            this.Boton6.UseVisualStyleBackColor = true;
            this.Boton6.Click += new System.EventHandler(this.Boton6_Click);
            // 
            // Eje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(560, 432);
            this.Controls.Add(this.Boton6);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Inicio);
            this.Name = "Eje";
            this.Text = "Ejecucion Prensa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inicio;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button P1;
        private System.Windows.Forms.Button Boton6;
    }
}

