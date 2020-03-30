namespace PlotterComm
{
    partial class Form1
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
            this.ivTbCommand = new System.Windows.Forms.TextBox();
            this.ivBtnCommand = new System.Windows.Forms.Button();
            this.ivCbPorts = new System.Windows.Forms.ComboBox();
            this.ivBtnConnect = new System.Windows.Forms.Button();
            this.ivBtnDisconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ivBtnCAN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ivTbCommand
            // 
            this.ivTbCommand.Location = new System.Drawing.Point(44, 62);
            this.ivTbCommand.Name = "ivTbCommand";
            this.ivTbCommand.Size = new System.Drawing.Size(442, 22);
            this.ivTbCommand.TabIndex = 0;
            // 
            // ivBtnCommand
            // 
            this.ivBtnCommand.Location = new System.Drawing.Point(529, 61);
            this.ivBtnCommand.Name = "ivBtnCommand";
            this.ivBtnCommand.Size = new System.Drawing.Size(81, 23);
            this.ivBtnCommand.TabIndex = 1;
            this.ivBtnCommand.Text = "Command";
            this.ivBtnCommand.UseVisualStyleBackColor = true;
            this.ivBtnCommand.Click += new System.EventHandler(this.ivBtnCommand_Click);
            // 
            // ivCbPorts
            // 
            this.ivCbPorts.FormattingEnabled = true;
            this.ivCbPorts.Location = new System.Drawing.Point(44, 12);
            this.ivCbPorts.Name = "ivCbPorts";
            this.ivCbPorts.Size = new System.Drawing.Size(121, 24);
            this.ivCbPorts.TabIndex = 2;
            // 
            // ivBtnConnect
            // 
            this.ivBtnConnect.Location = new System.Drawing.Point(189, 13);
            this.ivBtnConnect.Name = "ivBtnConnect";
            this.ivBtnConnect.Size = new System.Drawing.Size(75, 23);
            this.ivBtnConnect.TabIndex = 3;
            this.ivBtnConnect.Text = "Connect";
            this.ivBtnConnect.UseVisualStyleBackColor = true;
            this.ivBtnConnect.Click += new System.EventHandler(this.ivBtnConnect_Click);
            // 
            // ivBtnDisconnect
            // 
            this.ivBtnDisconnect.Location = new System.Drawing.Point(297, 13);
            this.ivBtnDisconnect.Name = "ivBtnDisconnect";
            this.ivBtnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.ivBtnDisconnect.TabIndex = 4;
            this.ivBtnDisconnect.Text = "Disconnect";
            this.ivBtnDisconnect.UseVisualStyleBackColor = true;
            this.ivBtnDisconnect.Click += new System.EventHandler(this.ivBtnDisconnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 172);
            this.textBox1.TabIndex = 5;
            // 
            // ivBtnCAN
            // 
            this.ivBtnCAN.Location = new System.Drawing.Point(529, 101);
            this.ivBtnCAN.Name = "ivBtnCAN";
            this.ivBtnCAN.Size = new System.Drawing.Size(81, 23);
            this.ivBtnCAN.TabIndex = 6;
            this.ivBtnCAN.Text = "CAN";
            this.ivBtnCAN.UseVisualStyleBackColor = true;
            this.ivBtnCAN.Click += new System.EventHandler(this.ivBtnCAN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ivBtnCAN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ivBtnDisconnect);
            this.Controls.Add(this.ivBtnConnect);
            this.Controls.Add(this.ivCbPorts);
            this.Controls.Add(this.ivBtnCommand);
            this.Controls.Add(this.ivTbCommand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ivTbCommand;
        private System.Windows.Forms.Button ivBtnCommand;
        private System.Windows.Forms.ComboBox ivCbPorts;
        private System.Windows.Forms.Button ivBtnConnect;
        private System.Windows.Forms.Button ivBtnDisconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ivBtnCAN;
    }
}

