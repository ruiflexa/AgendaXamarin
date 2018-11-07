using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Agenda
{
	public partial class App : Application
	{
        public static AgendaBanco BancoDeDados { get; private set; }
        public App(string path)
        {
			InitializeComponent();
            BancoDeDados = new AgendaBanco(path);
            //MainPage = new MainPage();
            MainPage = new Principal();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
