using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Within_Form
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm CH = new ChildForm();
            CH.MdiParent = this;
            CH.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ChildForm newMDIChild = new ChildForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            
            toolStripMenuItem14.Enabled = textBox1.SelectionLength > 0;
        }
        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

            //Paste.Enabled = textBox1.Click();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            getTextFromTextBox();
        }

        public void getTextFromTextBox()
        {
            textBox1.Copy();
            string s = Clipboard.GetText();
            textBox2.Text = s;
        }
            private void button3_Click(object sender, EventArgs e)
        {
            getTextFromTextBox();
    

           
        }
            

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void q(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //(if e.)
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point currentMousePosition = Cursor.Position;
                textBox1.Text = currentMousePosition.ToString();
                contextMenuStrip1.Show();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Paste.Enabled = (textBox1.SelectionLength == textBox1.TextLength);
            getTextFromTextBox();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            
            getTextFromTextBox();
            Clipboard.Clear();
        }

        private void contextMenuStrip3_Opening_1(object sender, CancelEventArgs e)
        {
            Paste.Enabled = (textBox1.SelectionLength > 0);
        }

        
            
    }
}
