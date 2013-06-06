using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XMLReader;
using System.IO;
using System.Xml;

namespace NoteCards
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CardNum.Visible = false;
            CardTotal.Visible = false;
            toolStripStatusLabel1.Visible = false;
            CardNum.Text = "0";
            CardTotal.Text = "0";
        }

        private void ContentCard_Click(object sender, EventArgs e)
        {
            // Nothing for now.
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app was created by Matthew Gross with the intent to mimic Microsoft's CardFile app. "
                            + "All rights reserved. Copyright 2012, Matthew Gross.\nFor more information, contact "
                            + "Matthew at mattkgross@gmail.com", "Note Cards Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
        }

        private void cardFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.CheckPathExists = true;
            dialog.DefaultExt = ".xml";
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.OverwritePrompt = true;
            dialog.Title = "Save New CardFile As...";
            dialog.Filter = "XML File|*.xml";
            dialog.ShowDialog();

            Functionalities.newCardFile(dialog.FileName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
