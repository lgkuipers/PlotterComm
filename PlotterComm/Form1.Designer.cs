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
            this.ivBtnCommand.Size = new System.Drawing.Size(75, 23);
            this.ivBtnCommand.TabIndex = 1;
            this.ivBtnCommand.Text = "Command";
            this.ivBtnCommand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

