using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Szokitalalo
{
    internal class Betuk : Button
    {
        private static String[] abc = {
            "_", "A", "Á", "B", "C", "D", "E", "É", "F", "G", "H", "I", "Í", "J",
            "K", "L", "M", "N", "O", "Ó", "Ö", "Ő", "P", "Q", "R", "S",
            "T", "U", "Ú", "Ü", "Ű", "V", "W", "X", "Y", "Z"
        };
        private string betu_feladvany { get; set; }
        private int index { get; set; }
        private string feladvany { get; set; }


        public Betuk(string betu, string feladvany)
        {
            betu_feladvany = betu;
            this.feladvany = feladvany;
            this.Width = 100;
            this.Height = 100;
            this.Margin = new System.Windows.Thickness(10);
            this.FontSize = 50;
            this.Content = "_";
        }
        protected override void OnClick()
        {
            index++;
            if (index>=abc.Length)
            {
                index = 1;
            }
            Content = abc[index];
            szinez();
            base.OnClick();
        }

        protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
        {
            index--;
            if (index < 1)
            {
                index = abc.Length - 1;
            }
            Content = abc[index];
            szinez();
            base.OnMouseRightButtonUp(e);
        }

        private void szinez()
        {
            if (abc[index] == betu_feladvany)
                this.Background = System.Windows.Media.Brushes.LightGreen;
            else if (feladvany.Contains(abc[index]))
                this.Background = System.Windows.Media.Brushes.LightYellow;
            else
                this.Background = System.Windows.Media.Brushes.LightGray;
        }

        public bool jo()
        {
            if (abc[index] == betu_feladvany)
                return true;
            else
                return false;
        }
    }
}
