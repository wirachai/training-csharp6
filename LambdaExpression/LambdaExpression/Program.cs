using LambdaExpression.SampleDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicDelegate basic = new BasicDelegate();
            basic.TestDelegate();
            basic.TestAnonymousFunction();

            Button button = new Button();
            button.Text = "Click me";
            button.Click += new EventHandler(OnClicked);
            button.Click += new EventHandler((object sender, EventArgs e) => { Console.WriteLine("Test"); });

            Form form = new Form();
            form.AutoSize = true;
            form.Controls.Add(button);
            Application.Run(form);

            Console.Read();
        }

        static void OnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }
    }
}
