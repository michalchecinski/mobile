﻿using Xamarin.Forms;

namespace Bit.App.Controls
{
    public class BottomBorderEntry : ExtendedEntry
    {
        public BottomBorderEntry()
        {
            HasBorder = HasOnlyBottomBorder = true;
            BottomBorderColor = Color.FromHex("d2d6de");
        }
    }
}
