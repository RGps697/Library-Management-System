using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace UserInterfaceLibrary
{
    public static class UIColors
    {
        public static Color MainMenuButtonColor { get; private set; } = Color.FromArgb(12, 0, 137);
        public static Color MainMenuButtonColorSelected { get; private set; } = Color.FromArgb(65, 217, 126); 
        public static Color MainMenuButtonBorderColor { get; private set; } = Color.FromArgb(12, 0, 137);
        public static Color MainMenuButtonBorderColorSelected { get; private set; } = Color.FromArgb(0, 124, 50);

        public static Color ToolMenuButtonColor { get; private set; } = Color.FromArgb(101, 117, 219);
        public static Color ToolMenuButtonColorSelected { get; private set; } = Color.FromArgb(21, 214, 99);
        public static Color ToolMenuButtonBorderColor { get; private set; } = Color.FromArgb(12, 0, 137);
        public static Color ToolMenuButtonBorderColorSelected { get; private set; } = Color.FromArgb(0, 208, 84);

        public static Color SelectableItemPanelListColor { get; private set; } = SystemColors.Control;

        public static Color SelectableItemColor { get; private set; } = SystemColors.Control;
        public static Color SelectableItemSelectedColor { get; private set; } = Color.FromArgb(21, 214, 99);
        public static Color SelectableItemHoverColor { get; private set; } = Color.FromArgb(86, 100, 187);

        public static Color AnswerCreatorControlColor { get; private set; } = SystemColors.Control;
        public static Color AnswerCreatorControlSelectedColor { get; private set; } = Color.FromArgb(21, 214, 99);
        public static Color AnswerCreatorControlHoverColor { get; private set; } = Color.FromArgb(86, 100, 187);

        public static Color OverdueBorrowingColor { get; private set; } = Color.FromArgb(206, 0, 31);
        public static Color OverdueBorrowingSelectedColor { get; private set; } = Color.FromArgb(196, 0, 31);
        public static Color OverdueBorrowingHoverColor { get; private set; } = Color.FromArgb(235, 0, 32);
    }
}
