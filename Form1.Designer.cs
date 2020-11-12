namespace Traningapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.PathButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.CRICR = new System.Windows.Forms.Label();
            this.CRA = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.CA = new System.Windows.Forms.Label();
            this.Nextb = new System.Windows.Forms.Button();
            this.againb = new System.Windows.Forms.Button();
            this.newt = new System.Windows.Forms.Button();
            this.rb = new System.Windows.Forms.RadioButton();
            this.alb = new System.Windows.Forms.RadioButton();
            this.fab = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(12, 12);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(75, 23);
            this.PathButton.TabIndex = 1;
            this.PathButton.Text = "Path";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(12, 17);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(49, 13);
            this.Question.TabIndex = 2;
            this.Question.Text = "Question";
            this.Question.Visible = false;
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(12, 41);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(504, 20);
            this.AnswerText.TabIndex = 3;
            this.AnswerText.Visible = false;
            this.AnswerText.TextChanged += new System.EventHandler(this.AnswerText_TextChanged);
            // 
            // CRICR
            // 
            this.CRICR.AutoSize = true;
            this.CRICR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CRICR.Location = new System.Drawing.Point(12, 72);
            this.CRICR.Name = "CRICR";
            this.CRICR.Size = new System.Drawing.Size(88, 13);
            this.CRICR.TabIndex = 4;
            this.CRICR.Text = "Correct/Incorrect";
            this.CRICR.Visible = false;
            // 
            // CRA
            // 
            this.CRA.AutoSize = true;
            this.CRA.ForeColor = System.Drawing.Color.ForestGreen;
            this.CRA.Location = new System.Drawing.Point(204, 72);
            this.CRA.Name = "CRA";
            this.CRA.Size = new System.Drawing.Size(79, 13);
            this.CRA.TabIndex = 5;
            this.CRA.Text = "Correct Answer";
            this.CRA.Visible = false;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(12, 67);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 6;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Visible = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.ForeColor = System.Drawing.Color.ForestGreen;
            this.CA.Location = new System.Drawing.Point(116, 72);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(82, 13);
            this.CA.TabIndex = 7;
            this.CA.Text = "Correct Answer:";
            this.CA.Visible = false;
            // 
            // Nextb
            // 
            this.Nextb.Location = new System.Drawing.Point(12, 96);
            this.Nextb.Name = "Nextb";
            this.Nextb.Size = new System.Drawing.Size(75, 23);
            this.Nextb.TabIndex = 8;
            this.Nextb.Text = "Next";
            this.Nextb.UseVisualStyleBackColor = true;
            this.Nextb.Visible = false;
            this.Nextb.Click += new System.EventHandler(this.button1_Click);
            // 
            // againb
            // 
            this.againb.Location = new System.Drawing.Point(359, 12);
            this.againb.Name = "againb";
            this.againb.Size = new System.Drawing.Size(75, 23);
            this.againb.TabIndex = 9;
            this.againb.Text = "Restart";
            this.againb.UseVisualStyleBackColor = true;
            this.againb.Visible = false;
            this.againb.Click += new System.EventHandler(this.againb_Click);
            // 
            // newt
            // 
            this.newt.Location = new System.Drawing.Point(440, 12);
            this.newt.Name = "newt";
            this.newt.Size = new System.Drawing.Size(75, 23);
            this.newt.TabIndex = 10;
            this.newt.Text = "New Test";
            this.newt.UseVisualStyleBackColor = true;
            this.newt.Visible = false;
            this.newt.Click += new System.EventHandler(this.newt_Click);
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Location = new System.Drawing.Point(430, 68);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(65, 17);
            this.rb.TabIndex = 11;
            this.rb.Text = "Random";
            this.rb.UseVisualStyleBackColor = true;
            this.rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // alb
            // 
            this.alb.AutoSize = true;
            this.alb.Location = new System.Drawing.Point(430, 91);
            this.alb.Name = "alb";
            this.alb.Size = new System.Drawing.Size(66, 17);
            this.alb.TabIndex = 12;
            this.alb.TabStop = true;
            this.alb.Text = "After List";
            this.alb.UseVisualStyleBackColor = true;
            // 
            // fab
            // 
            this.fab.AutoSize = true;
            this.fab.Location = new System.Drawing.Point(431, 114);
            this.fab.Name = "fab";
            this.fab.Size = new System.Drawing.Size(84, 17);
            this.fab.TabIndex = 13;
            this.fab.TabStop = true;
            this.fab.Text = "Flip Answers";
            this.fab.UseVisualStyleBackColor = true;
            this.fab.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 161);
            this.Controls.Add(this.fab);
            this.Controls.Add(this.alb);
            this.Controls.Add(this.rb);
            this.Controls.Add(this.newt);
            this.Controls.Add(this.againb);
            this.Controls.Add(this.Nextb);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.CRA);
            this.Controls.Add(this.CRICR);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.PathButton);
            this.Name = "Form1";
            this.Text = "Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Label CRICR;
        private System.Windows.Forms.Label CRA;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Button Nextb;
        private System.Windows.Forms.Button againb;
        private System.Windows.Forms.Button newt;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.RadioButton alb;
        private System.Windows.Forms.RadioButton fab;
    }
}

