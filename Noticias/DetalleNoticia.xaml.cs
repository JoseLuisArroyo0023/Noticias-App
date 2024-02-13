using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Noticias.NoticiasPrincipal;
using Java.Net;
using static Android.Media.Browse.MediaBrowser;
using static Android.Telephony.CarrierConfigManager;
using static Noticias.DetalleNoticia;
using System.Text.RegularExpressions;

namespace Noticias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleNoticia : ContentPage
    {
        public DetalleNoticia(int id)
        {
            InitializeComponent();
            string apiUrl = $"https://notigram.com/wp-json/wp/v2/posts/{id}?_embed";

           
            ObtenerDatosDesdeApi(apiUrl);

        }
        public class Root
        {
            public Embedded _embedded { get; set; }
            public Links _links { get; set; }
            public int author { get; set; }
            public List<int> categories { get; set; }
            public string comment_status { get; set; }
            public Content content { get; set; }
            public DateTime date { get; set; }
            public DateTime date_gmt { get; set; }
            public List<int> destacado { get; set; }
            public Excerpt excerpt { get; set; }
            public int featured_media { get; set; }
            public string format { get; set; }
            public List<int> geografia { get; set; }
            public List<string> guion_video { get; set; }
            public int id { get; set; }
            public string link { get; set; }
            public List<object> meta { get; set; }
            public DateTime modified { get; set; }
            public DateTime modified_gmt { get; set; }
            public string ping_status { get; set; }
            public string slug { get; set; }
            public string status { get; set; }
            public bool sticky { get; set; }
            public List<int> tags { get; set; }
            public string template { get; set; }
            public Title title { get; set; }
            public string type { get; set; }
            public UserMeta user_meta { get; set; }
            public List<string> video_fb { get; set; }
            public List<object> video_yt { get; set; }
            public List<string> views { get; set; }

            public List<string> wpfeaturemedia { get; set; }
        }

        public class NoticiaDetalle
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Image { get; set; }
            public string contenido { get; set; }

        }

        private async void ObtenerDatosDesdeApi(string apiUrl)
        {
           
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(apiUrl);
                request.Method = HttpMethod.Get;
                request.Headers.Add("Accept", "application/json");
                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string contect = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<Root>(contect);


             var NoticiaDetalle = new NoticiaDetalle
                {
                    Id = resultado.id,
                    Name = resultado._embedded.author[0].name,
                    Title = resultado.title.rendered,
                    Image = resultado._embedded.wpfeaturedmedia[0].source_url,
                    contenido = Regex.Replace(resultado.content.rendered, "<.*?>", String.Empty),

             };

                var listaNoticias = new List<NoticiaDetalle> { NoticiaDetalle };

                DetalleNoticias.ItemsSource = listaNoticias;
            
            }
          
        }

    }
}