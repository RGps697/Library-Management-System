using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    public class MainMenuButton : Button
    {
        public MainMenuButton()
        {
            FlatStyle = FlatStyle.Flat;

            Deselected();
        }

        public void Selected()
        {
            BackColor = UIColors.MainMenuButtonColorSelected;
            FlatAppearance.BorderColor = UIColors.MainMenuButtonBorderColorSelected;
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FlatAppearance.BorderSize = 1;
        }

        public void Deselected()
        {
            BackColor = UIColors.MainMenuButtonColor;
            FlatAppearance.BorderColor = UIColors.MainMenuButtonBorderColor;
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            ForeColor = Color.White;
            FlatAppearance.BorderSize = 0;
        }
    }
}
