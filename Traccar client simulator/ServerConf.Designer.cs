namespace TraccarClientSimulator
{
    partial class ServerConf
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
            this.textBox_ServeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // textBox_ServeName
            // 
            this.textBox_ServeName.Location = new System.Drawing.Point(88, 13);
            this.textBox_ServeName.Name = "textBox_ServeName";
            this.textBox_ServeName.Size = new System.Drawing.Size(165, 20);
            this.textBox_ServeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server Port";
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.Location = new System.Drawing.Point(88, 49);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.Size = new System.Drawing.Size(165, 20);
            this.textBox_ServerPort.TabIndex = 1;
            // 
            // button_Save
            // 
            this.button_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Save.Location = new System.Drawing.Point(88, 94);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(178, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ServerConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_ServerPort);
            this.Controls.Add(this.textBox_ServeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ServerConf";
            this.Text = "Server configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ServeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button2;
    }
}