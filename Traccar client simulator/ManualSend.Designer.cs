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
            this.checkBox_timestamp = new System.Windows.Forms.CheckBox();
            this.button_getDevices = new System.Windows.Forms.Button();
            this.dataGridView_Devices = new System.Windows.Forms.DataGridView();
            this.button_GetUsersList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_request
            // 
            this.textBox_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_request.Location = new System.Drawing.Point(15, 21);
            this.textBox_request.Name = "textBox_request";
            this.textBox_request.Size = new System.Drawing.Size(1108, 22);
            this.textBox_request.TabIndex = 4;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(970, 218);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(134, 23);
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
            this.textBox_Response.Size = new System.Drawing.Size(923, 175);
            this.textBox_Response.TabIndex = 6;
            // 
            // checkBox_timestamp
            // 
            this.checkBox_timestamp.AutoSize = true;
            this.checkBox_timestamp.Checked = true;
            this.checkBox_timestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timestamp.Location = new System.Drawing.Point(970, 68);
            this.checkBox_timestamp.Name = "checkBox_timestamp";
            this.checkBox_timestamp.Size = new System.Drawing.Size(117, 17);
            this.checkBox_timestamp.TabIndex = 7;
            this.checkBox_timestamp.Text = "Updated timestamp";
            this.checkBox_timestamp.UseVisualStyleBackColor = true;
            // 
            // button_getDevices
            // 
            this.button_getDevices.Location = new System.Drawing.Point(111, 263);
            this.button_getDevices.Name = "button_getDevices";
            this.button_getDevices.Size = new System.Drawing.Size(115, 23);
            this.button_getDevices.TabIndex = 8;
            this.button_getDevices.Text = "GET devices list";
            this.button_getDevices.UseVisualStyleBackColor = true;
            this.button_getDevices.Click += new System.EventHandler(this.buttonGetDevices_Click);
            // 
            // dataGridView_Devices
            // 
            this.dataGridView_Devices.AllowUserToAddRows = false;
            this.dataGridView_Devices.AllowUserToDeleteRows = false;
            this.dataGridView_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Devices.Location = new System.Drawing.Point(13, 299);
            this.dataGridView_Devices.Name = "dataGridView_Devices";
            this.dataGridView_Devices.ReadOnly = true;
            this.dataGridView_Devices.Size = new System.Drawing.Size(922, 237);
            this.dataGridView_Devices.TabIndex = 9;
            // 
            // button_GetUsersList
            // 
            this.button_GetUsersList.Location = new System.Drawing.Point(232, 263);
            this.button_GetUsersList.Name = "button_GetUsersList";
            this.button_GetUsersList.Size = new System.Drawing.Size(84, 23);
            this.button_GetUsersList.TabIndex = 10;
            this.button_GetUsersList.Text = "GET users list";
            this.button_GetUsersList.UseVisualStyleBackColor = true;
            this.button_GetUsersList.Click += new System.EventHandler(this.button_GetUsersList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sample requests";
            // 
            // ManualSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_GetUsersList);
            this.Controls.Add(this.dataGridView_Devices);
            this.Controls.Add(this.button_getDevices);
            this.Controls.Add(this.checkBox_timestamp);
            this.Controls.Add(this.textBox_Response);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_request);
            this.Name = "ManualSend";
            this.Text = "Manual send";
            this.Load += new System.EventHandler(this.ManualSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Devices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_request;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_Response;
        private System.Windows.Forms.CheckBox checkBox_timestamp;
        private System.Windows.Forms.Button button_getDevices;
        private System.Windows.Forms.DataGridView dataGridView_Devices;
        private System.Windows.Forms.Button button_GetUsersList;
        private System.Windows.Forms.Label label1;
    }
}