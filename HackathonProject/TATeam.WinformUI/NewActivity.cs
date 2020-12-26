using System;
using System.Windows.Forms;
using TATeam.Code.Models;

namespace TATeam.WinformUI
{
    public partial class NewActivity : Form
    {
        public event EventHandler<VideoSumitedEventArgs> VideoSubmited;
        public NewActivity()
        {
            InitializeComponent();
        }

        protected virtual void OnVideoSubmited(VideoSumitedEventArgs e)
        {
            EventHandler<VideoSumitedEventArgs> handler = VideoSubmited;
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

        private void label2_Click(object sender, EventArgs e)
        {
            BrowseQuiz();
        }

        private void BrowseQuiz()
        {

        }
    }

    public class VideoSumitedEventArgs : EventArgs
    {
        public VideoActivity Video { get; set; }
    }
}
