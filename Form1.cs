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
            AnswerText.Visible = true;
            Check.Visible = true;
            Question.Visible = true;

        }

        private void LoadNext()
        {
            Question.Text = Words[qnr * 2];
            if (Words[qnr * 2] == "") ;
            {
                againb.Visible = true;
                newt.Visible = true;

            }
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
            CA.Visible = true;
            Nextb.Visible = true;
            CRA.Text = Words[qnr *2 + 1];

            if (AnswerText.Text.ToLower() == Words[qnr *2 + 1].ToLower())
            {
                CRICR.Text = "Correct!";
            }

            else
            {
                CRICR.Text = "Incorrect";
            }
            qnr++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nextb.Visible = false;
            CRA.Visible = false;
            CRICR.Visible = false;
            AnswerText.Enabled = true;
            AnswerText.ResetText();
            CA.Visible = false;
            Check.Visible = true;
            LoadNext();
        }

        private void againb_Click(object sender, EventArgs e)
        {
            qnr = 0;
            LoadNext();
        }

        private void newt_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            Words = File.ReadAllLines(openFile.FileName);

            qnr = 0;
            LoadNext();
            PathButton.Visible = false;
            AnswerText.Visible = true;
            Check.Visible = true;
            Question.Visible = true; 
        }
    }
}
