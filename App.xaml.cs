﻿namespace DemoProject7
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
