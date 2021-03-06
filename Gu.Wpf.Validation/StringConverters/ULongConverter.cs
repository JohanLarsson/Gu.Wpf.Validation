﻿namespace Gu.Wpf.Validation.StringConverters
{
    using System.Windows.Controls;

    public class ULongConverter : StringConverter<ulong>
    {
        public override string ToFormattedString(ulong value, TextBox textBox)
        {
            var format = textBox.GetStringFormat();
            return value.ToString(format, textBox.GetCulture());
        }

        public override bool TryParse(string s, TextBox textBox, out ulong result)
        {
            return ulong.TryParse(s, textBox.GetNumberStyles(), textBox.GetCulture(), out result);
        }
    }
}