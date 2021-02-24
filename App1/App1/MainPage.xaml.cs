using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label label = new Label //объявление лейбла
            {
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Tap to count ++",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            TapGestureRecognizer tapGesture = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1
            };

            int count = 0;  // счетчик нажатий
            tapGesture.Tapped += (s, e) =>
            {
                count++;
                if (count % 2 == 0)//если пользователь делает четное прикосновение
                {
                    //цвет фона меняется на черный
                    label.BackgroundColor = Color.Black;
                    label.TextColor = Color.White;
                }

                else 
                {
                    //изначально цвет фона lavender
                    label.TextColor = Color.Black;
                    label.BackgroundColor = Color.Lavender;
                }
                label.Text = $"Count of students : {count}";
            };

            label.GestureRecognizers.Add(tapGesture);

            Content = label;

        }
            
    }
}


    
