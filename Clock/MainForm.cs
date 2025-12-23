using Clock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SetVisibility(false);
        }

        void SetVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            cbShowWeekDay.Visible = visible;
            btnHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);

            if (cbShowDate.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.ToString("MM.dd.yyyy");
            }
            if (cbShowWeekDay.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.DayOfWeek;
            }

            notifyIcon.Text = labelTime.Text;// наводя стрелку на иконку, отображается время в нижнем меню

            string fontFilePath = @"C:\Users\HP\Desktop\С#\WinForms\Clock\BallTack.ttf";
          
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile(fontFilePath);

            if (fontCollection.Families.Length > 0)
            {
                byte[] fontData = File.ReadAllBytes(fontFilePath);
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                fontCollection.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);
            }
            else
            {
                Console.WriteLine("Font installation failed");
            }

            labelTime.Font = new Font(fontCollection.Families[0], 32);
            Controls.Add(labelTime);
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(tsmiShowControls.Checked = false);

        }

        //private void labelTime_MouseHover(object sender, EventArgs e)
        //{
        //    SetVisibility(true);
        //}

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void tsmiTopmost_Click(object sender, EventArgs e)
        {
            this.TopMost = tsmiTopmost.Checked;
        }
        

        private void tsmiShowControls_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility((sender as ToolStripMenuItem).Checked);
            //sender - это отправитель события (Control, который прислал события
            // Если на элемент окна (Control)воздействует пользователь при помощи клавиатуры или мыши,
            // этот Control отправляет событие своему родителю может обрабатывать или не обрабатывать это событие 
        }

        private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) => cbShowDate.Checked = tsmiShowDate.Checked;

        private void cbShowDate_CheckedChanged(object sender, EventArgs e) => tsmiShowDate.Checked = cbShowDate.Checked;

        private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) => cbShowWeekDay.Checked = tsmiShowWeekday.Checked;

        private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e) => tsmiShowWeekday.Checked = cbShowWeekDay.Checked;

        private void tsmiQuit_Click(object sender, EventArgs e) => this.Close();

        private void tsmiForegroundColor_Click(object sender, EventArgs e)
        {           
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelTime.ForeColor = colorDialog.Color;
            }

        }
        private void tsmiBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelTime.BackColor = colorDialog.Color;
            }

        }
       
    }
}
