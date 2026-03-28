using System;
using System.Drawing;
using System.Windows.Forms;

namespace Animations
{
    public class clsAnimation
    {

        static bool IsOnOrignalSize = false;

        public static void AnimationOnHover(object sender, EventArgs e, byte Size = 20)
        {
            if (!IsOnOrignalSize)
            {
                if (sender is Control cont)
                {
                    cont.Size = new Size(cont.Width + Size, cont.Height + Size);
                    cont.Location = new Point(cont.Location.X - (Size / 2), cont.Location.Y - (Size / 2));
                }
                IsOnOrignalSize = true;
            }

        }
        public static void AnimationOnUnHover(object sender, EventArgs e, byte Size = 20)
        {
            if (IsOnOrignalSize)
            {
                if (sender is Control cont)
                {
                    cont.Size = new Size(cont.Width - Size, cont.Height - Size);
                    cont.Location = new Point(cont.Location.X + (Size / 2), cont.Location.Y + (Size / 2));
                }
                IsOnOrignalSize = false;
            }


        }

        public static void ChangeForceColor(object sender, EventArgs e, Color color)
        {
            Control ctr = (Control)sender;
            ctr.ForeColor = color;
        }
        public static void ChangeBackColor(object sender, EventArgs e, Color color)
        {
            Control ctr = (Control)sender;
            ctr.BackColor = color;
        }

        public static void ChangeColorAndOnHovAnimation(object sender, EventArgs e, Color color, byte Size = 20)
        {
            AnimationOnHover(sender, e, Size);
            ChangeForceColor(sender, e, color);
        }
        public static void ChangeColorAndOnUnHovAnimation(object sender, EventArgs e, Color color, byte Size = 20)
        {
            AnimationOnUnHover(sender, e, Size);
            ChangeForceColor(sender, e, color);
        }

        public static void ChangeFontsSizeUp(object sender, EventArgs e, byte Size = 5)
        {
            if (!IsOnOrignalSize)
            {
                if (sender is Control cont)
                {
                    cont.Font = new Font(cont.Font.FontFamily,cont.Font.Size + Size, cont.Font.Style);
                    cont.Location = new Point(cont.Location.X - (Size / 2), cont.Location.Y - (Size / 2));
                }
                IsOnOrignalSize = true;
            }

        }
        public static void ChangeFontsSizeDown(object sender, EventArgs e, byte Size = 5)
        {
            if (IsOnOrignalSize)
            {
                if (sender is Control cont)
                {
                    cont.Font = new Font(cont.Font.FontFamily, cont.Font.Size - Size, cont.Font.Style);
                    cont.Location = new Point(cont.Location.X + (Size / 2), cont.Location.Y + (Size / 2));
                }
                IsOnOrignalSize = false;
            }


        }


        public static void Transparent(Control LepelElemnt, Control Parent)
        {
            int x = LepelElemnt.Location.X - Parent.Location.X;
            int y = LepelElemnt.Location.Y - Parent.Location.Y;
            LepelElemnt.Parent = Parent;
            LepelElemnt.BackColor = Color.Transparent;
            LepelElemnt.Location = new Point(x, y);
        }




    }
}
