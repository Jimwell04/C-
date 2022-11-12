using System;
using System.IO;
using Xamarin.Forms;

namespace Quote
{
	public partial class MainPage : ContentPage
	{
		
		String[] Quotes;
		int i;
		
		public MainPage()
		{
			InitializeComponent();
			
			Padding = Device.OnPlatform(
				
				iOS: new Thickness(0,20,0,0),
				Android: new Thickness(10,20,0,0),
				WinPhone: new Thickness(30,20,0,0)
				
				);
			
			Quotes = new String[] {
			
			"Life is like riding a bicycle. To keep your balance, you must keep moving.",
			"There are only two ways to live your life. One is as though nothing is a miracle. The other is as though everything is a miracle.",
			"Anyone who has never made a mistake has never tried anything new.",
			"If you can't explain it to a six year old, you don't understand it yourself.",
			"Logic will get you from A to Z; imagination will get you everywhere."
			
		};
		
		i = 0;
		Text.Text = Quotes[i];
			
		}
		
		void Button(object sender, System.EventArgs e) {
			
			if (i == Quotes.Length) {
				i = 0;
			}
			
			Text.Text = Quotes[i];
			i++;
			
		}
		
		void Slider(object sender, Xamarin.Forms.ValueChangedEventArgs e) {
			
			Value.Text = String.Format("Font Size: {0}", (int) e.NewValue);
			Text.FontSize = (int) e.NewValue;
			
		}
		
	}
}