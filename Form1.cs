using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traningapp
{
    public partial class Form1 : Form
    {
        string[] Words;
        int qnr = 0 ;

        public Form1()
        {
            InitializeComponent();
        }



        private void PathButton_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            Words = File.ReadAllLines(openFile.FileName);

            LoadNext();
            PathButton.Visible = false;


        }

        private void LoadNext()
        {
            Question.Text = Words[qnr * 2];
            qnr++;
        }

        private void AnswerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            LoadNext();
            CRICR.Visible = true;
            CRA.Visible = true;
            AnswerText.Enabled = false;
            Check.Visible = false;


            if (AnswerText.Text.ToLower() == Words[qnr * 2 + 1].ToLower())
            {

            }

        }
    }
}
