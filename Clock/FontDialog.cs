using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
    public partial class FontDialog : Form
    {
        public Font Font { get; set; }
        public string Filename {  get; set; }   

        int lastChosenIndex;

        public FontDialog()
        {
            InitializeComponent();
            LoadFonts("*.ttf");
            LoadFonts("*.otf");
            lastChosenIndex = 1;
            comboBoxFont.SelectedIndex = 1;
        }

        public FontDialog(string font_name):this()
        {
            Filename = font_name;
            comboBoxFont.SelectedIndex = comboBoxFont.FindString(font_name);
            if (lastChosenIndex == -1) lastChosenIndex = 2;
            
            comboBoxFont.SelectedIndex = lastChosenIndex;
            SetFont();
            Font = labelExample.Font;
        }

        private void FontDialog_Load(object sender, EventArgs e)
        {
            numericUpDownFontSize.Value = (decimal)Font.Size;
        }
        void LoadFonts(string extension)
        {
            string currentDir = Application.ExecutablePath;
            Directory.SetCurrentDirectory($"{currentDir}\\..\\..\\..\\Fonts");

            //MessageBox.Show
            //    (
            //    this,
            //    //currentDir,
            //    Directory.GetCurrentDirectory(),
            //    "GetCurrentDirectory",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information
            //    );

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), extension);
            //comboBoxFont.Items.AddRange( files );
            //foreach (string file in files)
            //{
            //    comboBoxFont.Items.AddRange(files);
            //}
            for (int i = 0; i < files.Length; i++)
            {
                comboBoxFont.Items.Add(files[i].Split('\\').Last());
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string info = $"Selected:\nindex:\t{comboBoxFont.SelectedItem.ToString()}";
            info += $"\nText:\t{comboBoxFont.SelectedText}";
            info += $"\nValue:\t{comboBoxFont.SelectedValue}";
            info += $"\nItem:\t{comboBoxFont.SelectedItem}";
            SetFont();

            //MessageBox.Show(this,info, "SelectedIndexCHanged",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SetFont()
        {
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..\\Fonts");
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());
            labelExample.Font = new Font(pfc.Families[0], (float)numericUpDownFontSize.Value);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Font = labelExample.Font;
            this.Filename = comboBoxFont.SelectedItem.ToString();
            this.lastChosenIndex = comboBoxFont.SelectedIndex;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            labelExample.Font = this.Font;
            comboBoxFont.SelectedIndex = lastChosenIndex;
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            SetFont();
        }
    }
}