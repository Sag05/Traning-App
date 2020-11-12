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

        Random random = new Random();
        string[] Words;
        int qnr = 0 ;
        int rand = 0;
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
            
            rand = random.Next(Words.Length);

        }

        private void LoadNext()
        {

            //checks if next line is empty
            if (Words[qnr * 2] == "") 
            {
                againb.Visible = true;
                newt.Visible = true;

            }

            if (alb.Checked)
            {
                Question.Text = Words[qnr * 2];
            }

            if (rb.Checked)
            {
                Question.Text = Words[rand];
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

            //checks if it should be using the same order as in txt file
            if (alb.Checked)
            {

                if (AnswerText.Text.ToLower() == Words[qnr * 2 + 1].ToLower())
                {
                    CRICR.Text = "Correct!";
                }

                else
                {
                    CRICR.Text = "Incorrect";
                }

                qnr++;

            }
            
            //checks if it should be in a reandom order 
            if (rb.Checked)
            {
                if (rand % 2 == 0)
                {
                    if (AnswerText.Text.ToLower() == Words[rand + 1].ToLower())
                    {
                        CRICR.Text = "Correct!";
                    }

                    else
                    {
                        CRICR.Text = "Incorrect";
                    }
                }

                else
                {
                    if (AnswerText.Text.ToLower() == Words[rand - 1].ToLower())
                    {
                        CRICR.Text = "Correct!";
                    }

                    else
                    {
                        CRICR.Text = "Incorrect";
                    }
                }
            }

            //switches place between answer and question (not done)

            if (fab.Checked)
            {

            }
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

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
        
        }
    }
}
