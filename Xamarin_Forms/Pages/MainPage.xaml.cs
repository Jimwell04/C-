using System;
using System.IO;
using Xamarin.Forms;

namespace Xamarin_Forms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			
			Slider.Value = 0.5;
			
			if (Device.OS == TargetPlatform.iOS) {
				Padding = new Thickness(0,20,0,0);
			} else if (Device.OS == TargetPlatform.Android) {
				Padding = new Thickness(10,20,0,0);
			} else if (Device.OS == TargetPlatform.WinPhone) {
				Padding = new Thickness(30,20,0,0);
			}
			
			Padding = Device.OnPlatform(
				
				iOS: new Thickness(0,20,0,0),
				Android: new Thickness(10,20,0,0),
				WinPhone: new Thickness(30,20,0,0)
				
				);
			
		}
		
		void Handle_Clicked(object sender, System.EventArgs e) {
			
			DisplayAlert("Alert","This is alert box", "Ok");
			
		}
		
		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e) {
			
			Label.Text = String.Format("Value is {0:F2}", e.NewValue);
			
		}
		
	}
}