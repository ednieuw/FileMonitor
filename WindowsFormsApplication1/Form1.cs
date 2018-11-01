using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Timers;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer(150);
            aTimer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
            aTimer.Enabled = true;
                       
            // While dubugging , the CurrentDeployment object is not available so make sure you wrap the above call with
            if (System.Diagnostics.Debugger.IsAttached == false) 
                  this.Text += "  Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += " EdSoft 2018";
        }
        private void AppendColoredText(System.Windows.Forms.RichTextBox RichTextBox, string Text, System.Drawing.Color Color)
        {
            int MaxLengthTextBox = 1000000; //maximaal aantal chars in textbox

                RichTextBox.AppendText(Text + '\r' + '\n');
                if (Color != Color.Black)
                {   // Geef de tekst een kleur behalve als de tekst zwart is
                    var StartIndex = RichTextBox.TextLength - (Text.Length + 1);
                    var EndIndex = RichTextBox.TextLength;
                    RichTextBox.Select(StartIndex, EndIndex);
                    RichTextBox.SelectionColor = Color;
                }
                if (RichTextBox.Text.Length >= MaxLengthTextBox)   // Zorg dat de tekstbox niet groter dan MaxLengthTextBox wordt
                    RichTextBox.Text = RichTextBox.Text.Substring(MaxLengthTextBox / 4, RichTextBox.TextLength - MaxLengthTextBox / 4);

                RichTextBox.SelectionStart = RichTextBox.TextLength;
                RichTextBox.ScrollToCaret();            // Ga naar de laatste regel
                progressBar1.Value = RichTextBox.Text.Length / (MaxLengthTextBox / 100);
                //    BlinkLeds(); // zit in timer
           
        }

        private void MyWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            
                label1.Text = "Changed: " + DateTime.Now + " |" + e.FullPath;
                AppendColoredText(richTextBox1, label1.Text, Color.Black);

        }  

        private void MyWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {

                label2.Text = "Added: " + DateTime.Now + " |" + e.FullPath;
                AppendColoredText(richTextBox1, label2.Text, Color.DarkGreen);
    
        }

        private void MyWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {

                label3.Text = "Deleted: " + DateTime.Now + " |" + e.FullPath;
                AppendColoredText(richTextBox1, label3.Text, Color.Red);
                if (textBox1.Text.Length > 30000) textBox1.Text = textBox1.Text.Remove(29950);
                textBox1.ForeColor = Color.Gold;
                textBox1.Text = "Deleted: " + DateTime.Now + " |" + e.FullPath + '\r' + '\n' + textBox1.Text;
                textBox1.ForeColor = Color.Black;

        }

        private void MyWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {

                label4.Text = "Renamed: " + DateTime.Now + " |" + e.FullPath;
                AppendColoredText(richTextBox1, label4.Text, Color.DarkBlue);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = System.Environment.GetCommandLineArgs();
            if (args.Length != 2)   MyWatcher.Path = Environment.SystemDirectory.Substring(0,3); //    "C:\\Windows";
            else MyWatcher.Path =args[1];
            WatchedFolder.Text = "Monitored path : " + MyWatcher.Path;
            // Only watch text files.
           // MyWatcher.Filter = "*.txt";
  
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Change the icon. This event handler fires once every second
            // (1000 ms).
            BlinkLeds();
        }
        private void Button_Pressed(object sender, EventArgs e)
        {
                var Vnokok = folderBrowserDialog1.ShowDialog().ToString();
                if (Vnokok == "OK") MyWatcher.Path = folderBrowserDialog1.SelectedPath;
                else MyWatcher.Path = "C:\\Windows";
                WatchedFolder.Text = "Monitored path : " + MyWatcher.Path;
        }

        private void WatchedFolder_Click(object sender, EventArgs e)
        {
            Button_Pressed(sender, e);
        }

        private void BlinkLeds()
        {
            Color KleurEen = Color.Black; // Blue; // AliceBlue;  //OrangeRed;
            Color KleurTwee = Color.RoyalBlue;   //Green;            
            Random rand = new Random();
            byte[] bytes = new byte[8];
            rand.NextBytes(bytes);
            if (bytes[0] > 128) led1.ColorOn = KleurEen; else led1.ColorOn = KleurTwee;
            if (bytes[1] > 128) led2.ColorOn = KleurEen; else led2.ColorOn = KleurTwee;
            if (bytes[2] > 128) led3.ColorOn = KleurEen; else led3.ColorOn = KleurTwee;
            if (bytes[3] > 128) led4.ColorOn = KleurEen; else led4.ColorOn = KleurTwee;
            if (bytes[4] > 128) led5.ColorOn = KleurEen; else led5.ColorOn = KleurTwee;
            if (bytes[5] > 128) led6.ColorOn = KleurEen; else led6.ColorOn = KleurTwee;
            if (bytes[6] > 128) led7.ColorOn = KleurEen; else led7.ColorOn = KleurTwee;
            if (bytes[7] > 128) led8.ColorOn = KleurEen; else led8.ColorOn = KleurTwee;
        }

        private void Led1_Click(object sender, EventArgs e)
        {

        }
    }

    
    
    /// </summary>
    [DesignerCategory("Code")]
    public class Led : System.Windows.Forms.Control
    {

 //      private System.Windows.Forms.Timer tick;

        public Led()
            : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            BackColor = Color.Transparent;
            Width = 17;
            Height = 17;
        }

        #region new properties
        private bool _Active = true;
        [Category("Behavior"),
        DefaultValue(true)]
        public bool Active
        {
            get { return _Active; }
            set
            {
                _Active = value;
                Invalidate();
            }
        }

        private Color _ColorOn = Color.Red;
        [Category("Appearance")]
        public Color ColorOn
        {
            get { return _ColorOn; }
            set
            {
                _ColorOn = value;
                Invalidate();
            }
        }

        private Color _ColorOff = SystemColors.Control;
        [Category("Appearance")]
        public Color ColorOff
        {
            get { return _ColorOff; }
            set
            {
                _ColorOff = value;
                Invalidate();
            }
        }

  
        private string _FlashColors = string.Empty;
        public Color[] flashColors;
        [Category("Appearance"),
        DefaultValue("")]
        public string FlashColors
        {
            get { return _FlashColors; }
            set
            {
                _FlashColors = value;
                if (_FlashColors == string.Empty)
                {
                    flashColors = null;
                }
                else
                {
                    string[] fc = _FlashColors.Split(new char[] { ',', '/', '|', ' ', '\n' });
                    flashColors = new Color[fc.Length];
                    for (int i = 0; i < fc.Length; i++)
                        try
                        {
                            flashColors[i] = (fc[i] != "") ? Color.FromName(fc[i]) : Color.Empty;
                        }
                        catch
                        {
                            flashColors[i] = Color.Empty;
                        }
                }
            }
        }

        #endregion

        #region helper color functions
        public static Color FadeColor(Color c1, Color c2, int i1, int i2)
        {
            int r = (i1 * c1.R + i2 * c2.R) / (i1 + i2);
            int g = (i1 * c1.G + i2 * c2.G) / (i1 + i2);
            int b = (i1 * c1.B + i2 * c2.B) / (i1 + i2);

            return Color.FromArgb(r, g, b);
        }

        public static Color FadeColor(Color c1, Color c2)
        {
            return FadeColor(c1, c2, 1, 1);
        }
        #endregion

        public new event PaintEventHandler Paint;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (null != Paint) Paint(this, e);
            else
            {
                base.OnPaint(e);
                //       e.Graphics.Clear(BackColor);
                if (Enabled)
                {
                    if (Active)
                    {
                        e.Graphics.FillEllipse(new SolidBrush(ColorOn), 1, 1, Width - 3, Height - 3);
                        e.Graphics.DrawArc(new Pen(FadeColor(ColorOn, Color.White, 1, 2), 2), 3, 3, Width - 7, Height - 7, -90.0F, -90.0F);
                        e.Graphics.DrawEllipse(new Pen(FadeColor(ColorOn, Color.White), 1), 1, 1, Width - 3, Height - 3);
                    }
                    else
                    {
                        e.Graphics.FillEllipse(new SolidBrush(ColorOff), 1, 1, Width - 3, Height - 3);
                        e.Graphics.DrawArc(new Pen(FadeColor(ColorOff, Color.Black, 2, 1), 2), 3, 3, Width - 7, Height - 7, 0.0F, 90.0F);
                        e.Graphics.DrawEllipse(new Pen(FadeColor(ColorOff, Color.Black), 1), 1, 1, Width - 3, Height - 3);
                    }
                }
                else e.Graphics.DrawEllipse(new Pen(System.Drawing.SystemColors.ControlDark, 1), 1, 1, Width - 3, Height - 3);
            }
        }
    }  
}
