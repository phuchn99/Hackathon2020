using System.Windows.Forms;

namespace TATeam.Services.Models
{
    public interface IActivity
    {
        FlowLayoutPanel Render(int maxWidth);
    }
}
