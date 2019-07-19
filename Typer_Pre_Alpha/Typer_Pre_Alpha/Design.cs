using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer_Pre_Alpha
{
    public partial class Design:Form
    {

        private Label WordT;
        private TextBox AnswerT;
        private Timer ansTime;
        private IContainer components;
        private Label timerL;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button stop_Button;
        private Label label1;
        private Label label2;
        private Label ScoreT;
        private Button test_button;

        public Design()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.test_button = new System.Windows.Forms.Button();
            this.WordT = new System.Windows.Forms.Label();
            this.AnswerT = new System.Windows.Forms.TextBox();
            this.ansTime = new System.Windows.Forms.Timer(this.components);
            this.timerL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stop_Button = new System.Windows.Forms.Button();
            this.ScoreT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // test_button
            // 
            this.test_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.test_button.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_button.Location = new System.Drawing.Point(195, 12);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(153, 41);
            this.test_button.TabIndex = 0;
            this.test_button.Text = "START!";
            this.test_button.UseVisualStyleBackColor = false;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // WordT
            // 
            this.WordT.AutoSize = true;
            this.WordT.Font = new System.Drawing.Font("OfficinaSerifCTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordT.ForeColor = System.Drawing.Color.SteelBlue;
            this.WordT.Location = new System.Drawing.Point(3, 10);
            this.WordT.Name = "WordT";
            this.WordT.Size = new System.Drawing.Size(0, 31);
            this.WordT.TabIndex = 1;
            // 
            // AnswerT
            // 
            this.AnswerT.Font = new System.Drawing.Font("OfficinaSerifCTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerT.Location = new System.Drawing.Point(12, 165);
            this.AnswerT.Name = "AnswerT";
            this.AnswerT.Size = new System.Drawing.Size(660, 39);
            this.AnswerT.TabIndex = 2;
            // 
            // ansTime
            // 
            this.ansTime.Tick += new System.EventHandler(this.ansTime_Tick);
            // 
            // timerL
            // 
            this.timerL.AutoSize = true;
            this.timerL.Font = new System.Drawing.Font("Motorwerk", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timerL.Location = new System.Drawing.Point(185, 9);
            this.timerL.Name = "timerL";
            this.timerL.Size = new System.Drawing.Size(54, 49);
            this.timerL.TabIndex = 3;
            this.timerL.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.WordT);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(1, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ScoreT);
            this.panel3.Controls.Add(this.timerL);
            this.panel3.Location = new System.Drawing.Point(12, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 240);
            this.panel3.TabIndex = 6;
            // 
            // stop_Button
            // 
            this.stop_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stop_Button.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_Button.Location = new System.Drawing.Point(354, 12);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(153, 41);
            this.stop_Button.TabIndex = 7;
            this.stop_Button.Text = "STOP!";
            this.stop_Button.UseVisualStyleBackColor = false;
            this.stop_Button.Click += new System.EventHandler(this.stop_Button_Click);
            // 
            // ScoreT
            // 
            this.ScoreT.AutoSize = true;
            this.ScoreT.Font = new System.Drawing.Font("Motorwerk", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreT.Location = new System.Drawing.Point(565, 9);
            this.ScoreT.Name = "ScoreT";
            this.ScoreT.Size = new System.Drawing.Size(54, 49);
            this.ScoreT.TabIndex = 8;
            this.ScoreT.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Motorwerk", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "TIME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Motorwerk", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "SCORE";
            // 
            // Design
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.stop_Button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnswerT);
            this.Controls.Add(this.test_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Design";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void test_button_Click(object sender, EventArgs e)
        {
            AnswerT.Text = "";
            WordT.Text = "";
            timerL.Text = "0";
            Control.gm = new Gameplay();
            Control.Play();
        }
        
        public void Shows(string word,int score)
        {
            ScoreT.Text = score.ToString();
            WordT.Text = word;
            AnswerT.Text = "";
            ansTime.Start();
        }

        private void ansTime_Tick(object sender, EventArgs e)
        {
            if(Control.ChangeColor())
            {
                WordT.ForeColor = Color.SteelBlue;
            }
            else
            {
                if(int.Parse(timerL.Text) == 0)
                WordT.ForeColor = Color.Maroon;
            }
            if (Control.Answer(AnswerT.Text) == false)
            {
                timerL.Text = ((Control.gm.timer)/10).ToString();
                ansTime.Stop();
            }
            timerL.Text = ((Control.gm.timer) / 10).ToString();
        }

        private void stop_Button_Click(object sender, EventArgs e)
        {
            Control.Stop();
        }


    }
}
