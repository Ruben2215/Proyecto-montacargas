namespace Interfaz_Montacargas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Min2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.Min = new FontAwesome.Sharp.IconPictureBox();
            this.iconSubir = new FontAwesome.Sharp.IconPictureBox();
            this.iconBajar = new FontAwesome.Sharp.IconPictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bttStart = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Min2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSubir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBajar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.Min2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.iconPictureBox5);
            this.panel1.Controls.Add(this.Min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Min2
            // 
            this.Min2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Min2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Min2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Min2.IconColor = System.Drawing.SystemColors.ControlText;
            this.Min2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Min2.IconSize = 41;
            this.Min2.Location = new System.Drawing.Point(863, 0);
            this.Min2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Min2.Name = "Min2";
            this.Min2.Size = new System.Drawing.Size(43, 41);
            this.Min2.TabIndex = 3;
            this.Min2.TabStop = false;
            this.Min2.MouseHover += new System.EventHandler(this.Min2_MouseHover);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(905, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 41);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseHover += new System.EventHandler(this.iconPictureBox1_MouseHover);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 41;
            this.iconPictureBox5.Location = new System.Drawing.Point(905, 0);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(43, 41);
            this.iconPictureBox5.TabIndex = 2;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.iconPictureBox5_Click);
            this.iconPictureBox5.MouseLeave += new System.EventHandler(this.iconPictureBox5_MouseLeave);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Min.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.Min.IconColor = System.Drawing.SystemColors.ControlText;
            this.Min.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Min.IconSize = 41;
            this.Min.Location = new System.Drawing.Point(863, 0);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(43, 41);
            this.Min.TabIndex = 1;
            this.Min.TabStop = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            this.Min.MouseLeave += new System.EventHandler(this.Min_MouseLeave);
            // 
            // iconSubir
            // 
            this.iconSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.iconSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSubir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSubir.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconSubir.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSubir.IconSize = 100;
            this.iconSubir.Location = new System.Drawing.Point(308, 69);
            this.iconSubir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconSubir.Name = "iconSubir";
            this.iconSubir.Size = new System.Drawing.Size(100, 100);
            this.iconSubir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconSubir.TabIndex = 1;
            this.iconSubir.TabStop = false;
            this.iconSubir.Click += new System.EventHandler(this.iconSubir_Click);
            // 
            // iconBajar
            // 
            this.iconBajar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.iconBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBajar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconBajar.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.iconBajar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBajar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBajar.IconSize = 100;
            this.iconBajar.Location = new System.Drawing.Point(308, 272);
            this.iconBajar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconBajar.Name = "iconBajar";
            this.iconBajar.Size = new System.Drawing.Size(100, 100);
            this.iconBajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconBajar.TabIndex = 2;
            this.iconBajar.TabStop = false;
            this.iconBajar.Click += new System.EventHandler(this.iconBajar_Click);
            // 
            // bttStart
            // 
            this.bttStart.Location = new System.Drawing.Point(125, 213);
            this.bttStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(100, 28);
            this.bttStart.TabIndex = 20;
            this.bttStart.Text = "Start Port";
            this.bttStart.UseVisualStyleBackColor = true;
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(102, 160);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPorts.TabIndex = 21;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(544, 107);
            this.estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estado.Multiline = true;
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(282, 204);
            this.estado.TabIndex = 23;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 43);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(948, 405);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.bttStart);
            this.Controls.Add(this.iconBajar);
            this.Controls.Add(this.iconSubir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Min2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSubir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox Min;
        private FontAwesome.Sharp.IconPictureBox iconSubir;
        private FontAwesome.Sharp.IconPictureBox iconBajar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox Min2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bttStart;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TextBox estado;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

