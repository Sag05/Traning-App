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
            
 

        }

        private void LoadNext()
        {
            alb.Visible = true;
            rb.Visible = true;
            fab.Visible = true;

            //checks if next line is empty
            if (Words[qnr * 2] == "") 
            {
                againb.Visible = true;
                newt.Visible = true;
            }

            if (fab.Checked)
            {
                //Question.Text = Words[qnr * 2];
            }

            if (rb.Checked)
            {
                rand = random.Next(Words.Length);
                Question.Text = Words[rand];
            }

            else
            {
                Question.Text = Words[qnr * 2];
            }

        }

        private void AnswerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            CRICR.Visible = true;
            AnswerText.Enabled = false;
            Check.Visible = false;
            Nextb.Visible = true;
            alb.Visible = false;
            rb.Visible = false;
            fab.Visible = false;


            //checks if it should be using the same order as in txt file
            if (alb.Checked)
            {
                CRA.Text = Words[qnr * 2 + 1];
                if (AnswerText.Text.ToLower() == Words[qnr * 2 + 1].ToLower())
                {
                    CRICR.Text = "Correct!";
                }

                else
                {
                    CA.Visible = true;
                    CRA.Visible = true;
                    CRICR.Text = "Incorrect";
                }

                qnr++;

            }
            
            //checks if it should be in a reandom order 
            if (rb.Checked)
            {
                if (rand % 2 == 0)
                {
                    CRA.Text = Words[rand + 1];
                    if (AnswerText.Text.ToLower() == Words[rand + 1].ToLower())
                    {
                        CRICR.Text = "Correct!";
                    }

                    else
                    {
                        CA.Visible = true;
                        CRA.Visible = true;
                        CRICR.Text = "Incorrect";
                    }
                }

                else
                {
                    if (AnswerText.Text.ToLower() == Words[rand - 1].ToLower())
                    {
                        CRA.Text = Words[rand - 1];
                        CRICR.Text = "Correct!";
                    }

                    else
                    {
                        CA.Visible = true;
                        CRA.Visible = true;
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
