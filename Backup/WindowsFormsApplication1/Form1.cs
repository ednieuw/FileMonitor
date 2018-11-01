using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            label1.Text = "Changed: " + DateTime.Now + " | " + e.FullPath;
        }

        private void MyWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            label2.Text = "Added: " + DateTime.Now + " | " + e.FullPath;
            textBox1.Text = textBox1.Text + "Added: " + DateTime.Now + " | " + e.FullPath + '\r'+'\n';

        }

        private void MyWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            label3.Text = "Deleted: " + DateTime.Now + " | " + e.FullPath;

        }

        private void MyWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            label4.Text = "Renamed: " + DateTime.Now + " | " + e.FullPath;

        }

    
    }
}
