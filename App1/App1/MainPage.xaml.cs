using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CallWebApiAsync();
        }

        async Task CallWebApiAsync()
        {
            try {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://qveys.azurewebsites.net/api/forecast");
                String json = await response.Content.ReadAsStringAsync();

                var forecasts = Newtonsoft.Json.JsonConvert.DeserializeObject<Forecast[]>(json);
                ForeCastListView.ItemsSource = forecasts;
            }
            catch (Exception e)
            {
                MessageDialog msgDialog = new MessageDialog("Une erreur s'est produite lors de la récupération des prévisions météo", "Oooops...");
                await msgDialog.ShowAsync();
            }
        }
    }
}
