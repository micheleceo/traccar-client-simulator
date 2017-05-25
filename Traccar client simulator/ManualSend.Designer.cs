namespace TraccarClientSimulator
{
    partial class ManualSend
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
            this.textBox_request = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_Response = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_request
            // 
            this.textBox_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_request.Location = new System.Drawing.Point(12, 21);
            this.textBox_request.Name = "textBox_request";
            this.textBox_request.Size = new System.Drawing.Size(1111, 22);
            this.textBox_request.TabIndex = 4;
            this.textBox_request.Text = "http://localhost:5055/?id=111111&timestamp=1495181394&lat=40.9948996&lon=17.22253" +
    "8900000018&speed=0&bearing=355.43&altitude=111.379&batt=11";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(1048, 66);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_Response
            // 
            this.textBox_Response.Location = new System.Drawing.Point(12, 66);
            this.textBox_Response.Multiline = true;
            this.textBox_Response.Name = "textBox_Response";
            this.textBox_Response.Size = new System.Drawing.Size(1014, 175);
            this.textBox_Response.TabIndex = 6;
            // 
            // ManualSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 288);
            this.Controls.Add(this.textBox_Response);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_request);
            this.Name = "ManualSend";
            this.Text = "Manual send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_request;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_Response;
    }
}