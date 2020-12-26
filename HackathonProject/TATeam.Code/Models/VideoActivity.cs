using System.Windows.Forms;
using TATeam.Services.Models;

namespace TATeam.Code.Models
{
    public class VideoActivity : IActivity
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public FlowLayoutPanel Render(int maxWidth)
        {
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.FlowDirection = FlowDirection.TopDown;
            pnl.AutoSize = true;
            Label title = new Label
            {
                Text = Title,
                Font = new System.Drawing.Font("Times New Roman", 20, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            pnl.Controls.Add(title);

            var player = new AxWMPLib.AxWindowsMediaPlayer();

            ((System.ComponentModel.ISupportInitialize)(player)).BeginInit();
            player.Width = 300;
            player.Height = 300;
            player.Enabled = true;
            pnl.Controls.Add(player);
            player.Margin = new Padding(250, 3, 3, 3);
            ((System.ComponentModel.ISupportInitialize)(player)).EndInit();

            player.URL = Url;
            return pnl;
        }

    }
}



