namespace TraccarClientSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGPXFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Latitudine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitudine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox_s1 = new System.Windows.Forms.CheckBox();
            this.checkBox_s2 = new System.Windows.Forms.CheckBox();
            this.checkBox_s3 = new System.Windows.Forms.CheckBox();
            this.checkBox_s4 = new System.Windows.Forms.CheckBox();
            this.textBox_p1 = new System.Windows.Forms.TextBox();
            this.textBox_p2 = new System.Windows.Forms.TextBox();
            this.textBox_p3 = new System.Windows.Forms.TextBox();
            this.textBox_p4 = new System.Windows.Forms.TextBox();
            this.textBox_v1 = new System.Windows.Forms.TextBox();
            this.textBox_v2 = new System.Windows.Forms.TextBox();
            this.textBox_v3 = new System.Windows.Forms.TextBox();
            this.textBox_v4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.timer_invio = new System.Windows.Forms.Timer(this.components);
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGPXFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openGPXFileToolStripMenuItem
            // 
            this.openGPXFileToolStripMenuItem.Name = "openGPXFileToolStripMenuItem";
            this.openGPXFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openGPXFileToolStripMenuItem.Text = "Open GPX file...";
            this.openGPXFileToolStripMenuItem.Click += new System.EventHandler(this.openGPXFileToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverParametersToolStripMenuItem,
            this.clientParametersToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.serverToolStripMenuItem.Text = "Settings";
            // 
            // serverParametersToolStripMenuItem
            // 
            this.serverParametersToolStripMenuItem.Name = "serverParametersToolStripMenuItem";
            this.serverParametersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.serverParametersToolStripMenuItem.Text = "Server parameters";
            this.serverParametersToolStripMenuItem.Click += new System.EventHandler(this.serverParametersToolStripMenuItem_Click);
            // 
            // clientParametersToolStripMenuItem
            // 
            this.clientParametersToolStripMenuItem.Name = "clientParametersToolStripMenuItem";
            this.clientParametersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clientParametersToolStripMenuItem.Text = "Client parameters";
            this.clientParametersToolStripMenuItem.Click += new System.EventHandler(this.clientParametersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Latitudine,
            this.Longitudine});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 420);
            this.dataGridView1.TabIndex = 10;
            // 
            // Latitudine
            // 
            this.Latitudine.HeaderText = "Latitudine";
            this.Latitudine.Name = "Latitudine";
            this.Latitudine.ReadOnly = true;
            // 
            // Longitudine
            // 
            this.Longitudine.HeaderText = "Longitudine";
            this.Longitudine.Name = "Longitudine";
            this.Longitudine.ReadOnly = true;
            // 
            // checkBox_s1
            // 
            this.checkBox_s1.AutoSize = true;
            this.checkBox_s1.Checked = true;
            this.checkBox_s1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_s1.Location = new System.Drawing.Point(281, 68);
            this.checkBox_s1.Name = "checkBox_s1";
            this.checkBox_s1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_s1.TabIndex = 5;
            this.checkBox_s1.UseVisualStyleBackColor = true;
            // 
            // checkBox_s2
            // 
            this.checkBox_s2.AutoSize = true;
            this.checkBox_s2.Checked = true;
            this.checkBox_s2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_s2.Location = new System.Drawing.Point(281, 100);
            this.checkBox_s2.Name = "checkBox_s2";
            this.checkBox_s2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_s2.TabIndex = 5;
            this.checkBox_s2.UseVisualStyleBackColor = true;
            // 
            // checkBox_s3
            // 
            this.checkBox_s3.AutoSize = true;
            this.checkBox_s3.Checked = true;
            this.checkBox_s3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_s3.Location = new System.Drawing.Point(281, 135);
            this.checkBox_s3.Name = "checkBox_s3";
            this.checkBox_s3.Size = new System.Drawing.Size(15, 14);
            this.checkBox_s3.TabIndex = 5;
            this.checkBox_s3.UseVisualStyleBackColor = true;
            // 
            // checkBox_s4
            // 
            this.checkBox_s4.AutoSize = true;
            this.checkBox_s4.Checked = true;
            this.checkBox_s4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_s4.Location = new System.Drawing.Point(281, 173);
            this.checkBox_s4.Name = "checkBox_s4";
            this.checkBox_s4.Size = new System.Drawing.Size(15, 14);
            this.checkBox_s4.TabIndex = 5;
            this.checkBox_s4.UseVisualStyleBackColor = true;
            // 
            // textBox_p1
            // 
            this.textBox_p1.Location = new System.Drawing.Point(320, 65);
            this.textBox_p1.Name = "textBox_p1";
            this.textBox_p1.Size = new System.Drawing.Size(100, 20);
            this.textBox_p1.TabIndex = 6;
            this.textBox_p1.Text = "distance";
            // 
            // textBox_p2
            // 
            this.textBox_p2.Location = new System.Drawing.Point(320, 97);
            this.textBox_p2.Name = "textBox_p2";
            this.textBox_p2.Size = new System.Drawing.Size(100, 20);
            this.textBox_p2.TabIndex = 6;
            this.textBox_p2.Text = "speed";
            // 
            // textBox_p3
            // 
            this.textBox_p3.Location = new System.Drawing.Point(320, 132);
            this.textBox_p3.Name = "textBox_p3";
            this.textBox_p3.Size = new System.Drawing.Size(100, 20);
            this.textBox_p3.TabIndex = 6;
            this.textBox_p3.Text = "hdop";
            // 
            // textBox_p4
            // 
            this.textBox_p4.Location = new System.Drawing.Point(320, 170);
            this.textBox_p4.Name = "textBox_p4";
            this.textBox_p4.Size = new System.Drawing.Size(100, 20);
            this.textBox_p4.TabIndex = 6;
            this.textBox_p4.Text = "batt";
            // 
            // textBox_v1
            // 
            this.textBox_v1.Location = new System.Drawing.Point(426, 63);
            this.textBox_v1.Name = "textBox_v1";
            this.textBox_v1.Size = new System.Drawing.Size(100, 20);
            this.textBox_v1.TabIndex = 6;
            this.textBox_v1.Text = "200";
            // 
            // textBox_v2
            // 
            this.textBox_v2.Location = new System.Drawing.Point(426, 95);
            this.textBox_v2.Name = "textBox_v2";
            this.textBox_v2.Size = new System.Drawing.Size(100, 20);
            this.textBox_v2.TabIndex = 6;
            this.textBox_v2.Text = "33.33";
            // 
            // textBox_v3
            // 
            this.textBox_v3.Location = new System.Drawing.Point(426, 130);
            this.textBox_v3.Name = "textBox_v3";
            this.textBox_v3.Size = new System.Drawing.Size(100, 20);
            this.textBox_v3.TabIndex = 6;
            this.textBox_v3.Text = "3";
            // 
            // textBox_v4
            // 
            this.textBox_v4.Location = new System.Drawing.Point(426, 168);
            this.textBox_v4.Name = "textBox_v4";
            this.textBox_v4.Size = new System.Drawing.Size(100, 20);
            this.textBox_v4.TabIndex = 6;
            this.textBox_v4.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parameter name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parameter  value";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(366, 404);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(160, 53);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer_invio
            // 
            this.timer_invio.Tick += new System.EventHandler(this.timer_invio_Tick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directSendToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // directSendToolStripMenuItem
            // 
            this.directSendToolStripMenuItem.Name = "directSendToolStripMenuItem";
            this.directSendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.directSendToolStripMenuItem.Text = "Manual send";
            this.directSendToolStripMenuItem.Click += new System.EventHandler(this.directSendToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 471);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_v4);
            this.Controls.Add(this.textBox_v3);
            this.Controls.Add(this.textBox_v2);
            this.Controls.Add(this.textBox_v1);
            this.Controls.Add(this.textBox_p4);
            this.Controls.Add(this.textBox_p3);
            this.Controls.Add(this.textBox_p2);
            this.Controls.Add(this.textBox_p1);
            this.Controls.Add(this.checkBox_s4);
            this.Controls.Add(this.checkBox_s3);
            this.Controls.Add(this.checkBox_s2);
            this.Controls.Add(this.checkBox_s1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "REST Traccar client simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openGPXFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitudine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitudine;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientParametersToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_s1;
        private System.Windows.Forms.CheckBox checkBox_s2;
        private System.Windows.Forms.CheckBox checkBox_s3;
        private System.Windows.Forms.CheckBox checkBox_s4;
        private System.Windows.Forms.TextBox textBox_p1;
        private System.Windows.Forms.TextBox textBox_p2;
        private System.Windows.Forms.TextBox textBox_p3;
        private System.Windows.Forms.TextBox textBox_p4;
        private System.Windows.Forms.TextBox textBox_v1;
        private System.Windows.Forms.TextBox textBox_v2;
        private System.Windows.Forms.TextBox textBox_v3;
        private System.Windows.Forms.TextBox textBox_v4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer_invio;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directSendToolStripMenuItem;
    }
}

