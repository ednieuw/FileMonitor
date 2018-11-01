namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MyWatcher = new System.IO.FileSystemWatcher();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WatchedFolder = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.led8 = new WindowsFormsApplication1.Led();
            this.led7 = new WindowsFormsApplication1.Led();
            this.led6 = new WindowsFormsApplication1.Led();
            this.led5 = new WindowsFormsApplication1.Led();
            this.led4 = new WindowsFormsApplication1.Led();
            this.led3 = new WindowsFormsApplication1.Led();
            this.led2 = new WindowsFormsApplication1.Led();
            this.led1 = new WindowsFormsApplication1.Led();
            ((System.ComponentModel.ISupportInitialize)(this.MyWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Added";
            // 
            // MyWatcher
            // 
            this.MyWatcher.EnableRaisingEvents = true;
            this.MyWatcher.IncludeSubdirectories = true;
            this.MyWatcher.Path = "C:\\Windows";
            this.MyWatcher.SynchronizingObject = this;
            this.MyWatcher.Changed += new System.IO.FileSystemEventHandler(this.MyWatcher_Changed);
            this.MyWatcher.Created += new System.IO.FileSystemEventHandler(this.MyWatcher_Created);
            this.MyWatcher.Deleted += new System.IO.FileSystemEventHandler(this.MyWatcher_Deleted);
            this.MyWatcher.Renamed += new System.IO.RenamedEventHandler(this.MyWatcher_Renamed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deleted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Renamed";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(25, 574);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(899, 65);
            this.textBox1.TabIndex = 4;
            // 
            // WatchedFolder
            // 
            this.WatchedFolder.AutoSize = true;
            this.WatchedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchedFolder.Location = new System.Drawing.Point(12, 9);
            this.WatchedFolder.Name = "WatchedFolder";
            this.WatchedFolder.Size = new System.Drawing.Size(76, 13);
            this.WatchedFolder.TabIndex = 5;
            this.WatchedFolder.Text = "Watchfolder";
            this.WatchedFolder.Click += new System.EventHandler(this.WatchedFolder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(899, 412);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar1.Location = new System.Drawing.Point(26, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(899, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // led8
            // 
            this.led8.BackColor = System.Drawing.Color.Transparent;
            this.led8.ColorOff = System.Drawing.SystemColors.Control;
            this.led8.ColorOn = System.Drawing.Color.Red;
            this.led8.Location = new System.Drawing.Point(545, 125);
            this.led8.Name = "led8";
            this.led8.Size = new System.Drawing.Size(17, 17);
            this.led8.TabIndex = 16;
            this.led8.Text = "led8";
            // 
            // led7
            // 
            this.led7.BackColor = System.Drawing.Color.Transparent;
            this.led7.ColorOff = System.Drawing.SystemColors.Control;
            this.led7.ColorOn = System.Drawing.Color.Red;
            this.led7.Location = new System.Drawing.Point(521, 125);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(17, 17);
            this.led7.TabIndex = 15;
            this.led7.Text = "led7";
            // 
            // led6
            // 
            this.led6.BackColor = System.Drawing.Color.Transparent;
            this.led6.ColorOff = System.Drawing.SystemColors.Control;
            this.led6.ColorOn = System.Drawing.Color.Red;
            this.led6.Location = new System.Drawing.Point(497, 125);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(17, 17);
            this.led6.TabIndex = 14;
            this.led6.Text = "led6";
            // 
            // led5
            // 
            this.led5.BackColor = System.Drawing.Color.Transparent;
            this.led5.ColorOff = System.Drawing.SystemColors.Control;
            this.led5.ColorOn = System.Drawing.Color.Red;
            this.led5.Location = new System.Drawing.Point(473, 125);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(17, 17);
            this.led5.TabIndex = 13;
            this.led5.Text = "led5";
            // 
            // led4
            // 
            this.led4.BackColor = System.Drawing.Color.Transparent;
            this.led4.ColorOff = System.Drawing.SystemColors.Control;
            this.led4.ColorOn = System.Drawing.Color.Red;
            this.led4.Location = new System.Drawing.Point(449, 125);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(17, 17);
            this.led4.TabIndex = 12;
            this.led4.Text = "led4";
            // 
            // led3
            // 
            this.led3.BackColor = System.Drawing.Color.Transparent;
            this.led3.ColorOff = System.Drawing.SystemColors.Control;
            this.led3.ColorOn = System.Drawing.Color.Red;
            this.led3.Location = new System.Drawing.Point(425, 125);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(17, 17);
            this.led3.TabIndex = 11;
            this.led3.Text = "led3";
            // 
            // led2
            // 
            this.led2.BackColor = System.Drawing.Color.Transparent;
            this.led2.ColorOff = System.Drawing.SystemColors.Control;
            this.led2.ColorOn = System.Drawing.Color.Red;
            this.led2.Location = new System.Drawing.Point(401, 125);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(17, 17);
            this.led2.TabIndex = 10;
            this.led2.Text = "led2";
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Transparent;
            this.led1.ColorOff = System.Drawing.SystemColors.Control;
            this.led1.ColorOn = System.Drawing.Color.Red;
            this.led1.Location = new System.Drawing.Point(377, 125);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(17, 17);
            this.led1.TabIndex = 9;
            this.led1.Text = "led1";
            this.led1.Click += new System.EventHandler(this.Led1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(936, 643);
            this.Controls.Add(this.led8);
            this.Controls.Add(this.led7);
            this.Controls.Add(this.led6);
            this.Controls.Add(this.led5);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.WatchedFolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MonitorFolder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher MyWatcher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WatchedFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Led led8;
        private Led led7;
        private Led led6;
        private Led led5;
        private Led led4;
        private Led led3;
        private Led led2;
        private Led led1;
    }
}

