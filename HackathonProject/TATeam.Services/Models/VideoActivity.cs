using System;
using System.Windows.Forms;

namespace TATeam.Services.Models
{
    public class VideoActivity : IActivity
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public Panel Render(int maxWidth)
        {
            Panel pnl = new Panel();
            pnl.Width = maxWidth;
            pnl.Controls.Add(new Label
            {
                Text = Title
            });
            pnl.Controls.Add(AxWMPLib.AxWindowsMediaPlayer)

            return pnl;
        }
    }
}
