using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PR11
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Nekrasov Zahar PKS-30K, horoshiy den chtobi v  chas nochi sidet izuchat xamarinforms" }
                }
            };
        }
    }
}