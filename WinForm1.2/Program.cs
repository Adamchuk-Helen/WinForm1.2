using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WinForm1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // На форму додати кнопку.
            // Програма лічить кожне натискання  кнопки та виводить відповідне повідомлення у заголовок форми.
            // Колір кнопки при цьому забарвлюється у випадковий колір.

            My_New_Form();
        }
        private static void My_New_Form()
        {
            var form = new Form();
            form.Height = 400;
            form.Width = 600;


            var button = new Button();
            button.Height = 40;
            button.Width = 60;
            button.Location = new System.Drawing.Point(form.Height / 2, form.Width / 2);
            button.Text = "Click";
            button.Click += Button_Click1;


            form.Controls.Add(button);
            form.ShowDialog();
        }

        static int count = 0;

        private static void Button_Click1(object sender, EventArgs e)
        {
            count++;
            var rand = new Random();
            int r = rand.Next(100, 255);
            int g = rand.Next(100, 255);
            int b = rand.Next(100, 255);
            (sender as Button).BackColor = Color.FromArgb(r, g, b);
        }
    }
}
