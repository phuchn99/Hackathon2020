using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            newActivity.ShowDialog();
            
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
