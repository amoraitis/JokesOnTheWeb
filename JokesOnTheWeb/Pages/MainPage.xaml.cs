using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JokesOnTheWeb.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            Joke.Text = GetJoke();
		}

        public string GetJoke()
        {
            string jsonResponse = string.Empty;
            Uri joke = new Uri("http://api.icndb.com/jokes/random");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(joke);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                jsonResponse = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Models.Joke>(jsonResponse).value.joke;
            }

        }

	}
}