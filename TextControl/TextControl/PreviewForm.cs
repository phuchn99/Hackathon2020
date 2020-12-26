using System.Windows.Forms;

namespace LiveSwitch.TextControl
{
    public partial class PreviewForm : Form
    {


        public PreviewForm(string html)
        {
            InitializeComponent();
            webBrowser1.DocumentText = html;
        }
    }
}
