using System.Windows.Forms;

namespace TATeam.Services.Models
{
    public interface IActivity
    {
        Panel Render(int maxWidth);
    }
}
