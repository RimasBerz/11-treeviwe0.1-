using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{

    public partial class Form1 : Form
    {
        ToolStripMenuItem child;
        public static int check = 1;
        public int Check { get; set; }
        public void CheckRemove()
        {
            check++;
        }
        public Form1()
        {
            InitializeComponent();
            child = new ToolStripMenuItem();
            child.ShowDropDown(); 
            CheckRemove();
            child.Visible = true;
            Select();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var b = new Button() { Parent = this, Text = Convert.ToString(check)};
            Button s = sender as Button;
            b.Text = Convert.ToString(check);
            Select();
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            CheckRemove();
            string check1 = check.ToString();
            toolStrip1.Items.Add(child);
            child = new ToolStripMenuItem();
            child.Text = check1;
        }
        private void Select(object sender, EventArgs e)
        {
            CheckRemove();
            string check1 = check.ToString();
            child = new ToolStripMenuItem();
            toolStrip1.Items.Add(child);
            child.Text = check1;
        }
    }
    public partial class child : Form1
    {
        ToolStripMenuItem child2;

        public child()
        {
            child2 = new ToolStripMenuItem();
            child2.ShowDropDown();
            CheckRemove();
            child2.Visible = true;
            Select();
        }
       
    }
}



