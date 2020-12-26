using System;
using System.Windows.Forms;
using TATeam.Code.Models;

namespace TATeam.WinformUI
{
    public partial class NewActivity : Form
    {
        public event EventHandler<VideoSumitedEventArgs> VideoSubmited;
        public event EventHandler<QuizSumitedEventArgs> QuizSubmited;
        public NewActivity()
        {
            InitializeComponent();
        }

        protected virtual void OnVideoSubmited(VideoSumitedEventArgs e)
        {
            EventHandler<VideoSumitedEventArgs> handler = VideoSubmited;
            handler?.Invoke(this, e);
        }

        protected virtual void OnQuizSubmited(QuizSumitedEventArgs e)
        {
            EventHandler<QuizSumitedEventArgs> handler = QuizSubmited;
            handler?.Invoke(this, e);
        }

        private void btnSubmitVideo_Click(object sender, EventArgs e)
        {
            VideoSumitedEventArgs args = new VideoSumitedEventArgs
            {
                Video = new VideoActivity
                {
                    Title = txtVideoTitle.Text,
                    Url = lblVideoUrl.Text
                }
            };
            OnVideoSubmited(args);
            Close();
        }

        private void btnBrowseVideo_Click(object sender, EventArgs e)
        {
            BrowseVideo();
        }

        private void lblVideoUrl_Click(object sender, EventArgs e)
        {
            BrowseVideo();
        }

        private void BrowseVideo()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            var result = fileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                lblVideoUrl.Text = fileDialog.FileName;
            }
        }

        private void btnBrowseQuiz_Click(object sender, EventArgs e)
        {
            BrowseQuiz();
        }

        private void lblBrowseQuiz_Click(object sender, EventArgs e)
        {
            BrowseQuiz();
        }

        private void BrowseQuiz()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblBrowseQuiz.Text = fileDialog.FileName;
            }
        }

        private void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            QuizSumitedEventArgs args = new QuizSumitedEventArgs()
            {
                Quiz = new QuizActivity()
            };
            args.Quiz.Import(lblBrowseQuiz.Text);
            OnQuizSubmited(args);
            Close();
        }
    }

    public class QuizSumitedEventArgs : EventArgs
    {
        public QuizActivity Quiz { get; set; }
    }

    public class VideoSumitedEventArgs : EventArgs
    {
        public VideoActivity Video { get; set; }
    }
}
