using System;
using System.Windows.Forms;

namespace TATeam.WinformUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            NewActivity newActivity = new NewActivity();
            newActivity.VideoSubmited += NewActivity_VideoSubmited;
            newActivity.QuizSubmited += NewActivity_QuizSubmited;
            newActivity.ShowDialog();
        }

        private void NewActivity_QuizSubmited(object sender, QuizSumitedEventArgs e)
        {
            pnlContent.Controls.Add(e.Quiz.Render(pnlContent.Width));
        }

        private void NewActivity_VideoSubmited(object sender, VideoSumitedEventArgs e)
        {
            pnlContent.Controls.Add(e.Video.Render(pnlContent.Width));
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
