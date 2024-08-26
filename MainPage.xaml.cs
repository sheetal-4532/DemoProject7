﻿using Plugin.Firebase.CloudMessaging;

namespace DemoProject7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
                var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();
                Console.WriteLine($"FCM token: {token}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving FCM token: {ex.Message}"); 
            }
        }
    }

}
