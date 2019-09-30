using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BendriniaiDuomenys
{
    public partial class Form1 : Form
    {
        private Dictionary<TabPage, string> TextBoxContainer;

        public Form1()
        {
            InitializeComponent();
            TextBoxContainer = new Dictionary<TabPage, string>();
            TextBoxContainer.Add(tabPage1, "Vienas");
            TextBoxContainer.Add(tabPage2, "Du");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextData.Text = TextBoxContainer[tabControl1.SelectedTab];
            Label label = new Label();
            label.Location = new Point(20, 20);
            label.Text = "Labas Pasaulis";
            tabPage1.Controls.Add(label);
            TextBox textbox = new TextBox();
            textbox.Location = new Point(40, 40);
            textbox.Text = "Sveiki visi";
            tabPage1.Controls.Add(textbox);
        }
    }
}