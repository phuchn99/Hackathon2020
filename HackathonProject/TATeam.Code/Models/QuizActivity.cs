using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TATeam.Services.Models;

namespace TATeam.Code.Models
{
    public class QuizActivity : IActivity
    {
        public List<Question> Questions { get; set; } = new List<Question>();

        public void Import(string filePath)
        {
            StreamReader srd = new StreamReader(filePath);
            while (!srd.EndOfStream)
            {
                Question question = new Question();
                question.Title = srd.ReadLine();
                question.Answers = new Dictionary<string, string>();
                string t = srd.ReadLine();
                while (!t.Contains("ANSWER"))
                {
                    question.Answers.Add(t[0].ToString(), t.Substring(t.IndexOf(')') + 1));
                    t = srd.ReadLine();
                }
                question.TrueAnswer = t.Substring(t.IndexOf(':') + 1).Trim();
                Questions.Add(question);
            }
            srd.Close();
        }

        public FlowLayoutPanel Render(int maxWidth)
        {
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.FlowDirection = FlowDirection.TopDown;
            pnl.AutoSize = true;

            foreach (Question question in Questions)
            {
                Label title = new Label
                {
                    Text = Questions.IndexOf(question) + 1 + ". " + question.Title,
                    Font = new System.Drawing.Font("Times New Roman", 20, System.Drawing.FontStyle.Bold),
                    AutoSize = true
                };
                pnl.Controls.Add(title);
                
                foreach (KeyValuePair<string, string> pairs in question.Answers)
                {
                    RadioButton rbtn = new RadioButton()
                    {
                        Text = pairs.Key + ") " + pairs.Value,
                        Font = new System.Drawing.Font("Times New Roman", 20),
                        AutoSize = true
                    };
                    pnl.Controls.Add(rbtn);
                }    
            }

            return pnl;
        }
    }

    public class Question
    {
        public string Title { get; set; }
        public Dictionary<string, string> Answers { get; set; }
        public string TrueAnswer { get; set; }
    }
}
