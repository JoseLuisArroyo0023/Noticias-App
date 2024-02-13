using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Android.Content.Res;

namespace Noticias
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NoticiasPrincipal : ContentPage
	{
		public NoticiasPrincipal ()
		{
			InitializeComponent ();
		}

        public class _1536x1536
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class _2048x2048
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class About
        {
            public string href { get; set; }
        }

        public class Author
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string description { get; set; }
            public string link { get; set; }
            public string slug { get; set; }
            public AvatarUrls avatar_urls { get; set; }
            public SimpleLocalAvatar simple_local_avatar { get; set; }
            public Links _links { get; set; }
            public bool embeddable { get; set; }
            public string href { get; set; }
        }

        public class AvatarUrls
        {
            [JsonProperty("24")]
            public string _24 { get; set; }

            [JsonProperty("48")]
            public string _48 { get; set; }

            [JsonProperty("96")]
            public string _96 { get; set; }
        }

        public class Caption
        {
            public string rendered { get; set; }
        }

        public class Collection
        {
            public string href { get; set; }
        }

        public class Content
        {
            public string rendered { get; set; }
            public bool @protected { get; set; }
        }

        public class Cury
        {
            public string name { get; set; }
            public string href { get; set; }
            public bool templated { get; set; }
        }

        public class Embedded
        {
            public List<Author> author { get; set; }

            [JsonProperty("wp:featuredmedia")]
            public List<WpFeaturedmedium> wpfeaturedmedia { get; set; }

            [JsonProperty("wp:term")]
            public List<List<Author>> wpterm { get; set; }
        }

        public class Excerpt
        {
            public string rendered { get; set; }
            public bool @protected { get; set; }
        }

        public class Full
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class Guid
        {
            public string rendered { get; set; }
        }

        public class ImageMeta
        {
            public string aperture { get; set; }
            public string credit { get; set; }
            public string camera { get; set; }
            public string caption { get; set; }
            public string created_timestamp { get; set; }
            public string copyright { get; set; }
            public string focal_length { get; set; }
            public string iso { get; set; }
            public string shutter_speed { get; set; }
            public string title { get; set; }
            public string orientation { get; set; }
            public List<object> keywords { get; set; }
        }

        public class Large
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class Links
        {
            public List<Self> self { get; set; }
            public List<Collection> collection { get; set; }
            public List<About> about { get; set; }
            public List<Author> author { get; set; }
            public List<Reply> replies { get; set; }

            [JsonProperty("version-history")]
            public List<VersionHistory> versionhistory { get; set; }

            [JsonProperty("predecessor-version")]
            public List<PredecessorVersion> predecessorversion { get; set; }

            [JsonProperty("wp:featuredmedia")]
            public List<WpFeaturedmedium> wpfeaturedmedia { get; set; }

            [JsonProperty("wp:attachment")]
            public List<WpAttachment> wpattachment { get; set; }

            [JsonProperty("wp:term")]
            public List<WpTerm> wpterm { get; set; }
            public List<Cury> curies { get; set; }
        }

        public class MediaDetails
        {
            public int width { get; set; }
            public int height { get; set; }
            public string file { get; set; }
            public int filesize { get; set; }
            public Sizes sizes { get; set; }
            public ImageMeta image_meta { get; set; }
            public string original_image { get; set; }
        }

        public class Medium
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class MediumLarge
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class PredecessorVersion
        {
            public int id { get; set; }
            public string href { get; set; }
        }

        public class Reply
        {
            public bool embeddable { get; set; }
            public string href { get; set; }
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
            public Guid guid { get; set; }
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

        public class Self
        {
            public string href { get; set; }
        }

        public class SimpleLocalAvatar
        {
            [JsonProperty("18")]
            public string _18 { get; set; }

            [JsonProperty("24")]
            public string _24 { get; set; }

            [JsonProperty("26")]
            public string _26 { get; set; }

            [JsonProperty("32")]
            public string _32 { get; set; }

            [JsonProperty("36")]
            public string _36 { get; set; }

            [JsonProperty("48")]
            public string _48 { get; set; }

            [JsonProperty("52")]
            public string _52 { get; set; }

            [JsonProperty("64")]
            public string _64 { get; set; }

            [JsonProperty("90")]
            public string _90 { get; set; }

            [JsonProperty("96")]
            public string _96 { get; set; }

            [JsonProperty("128")]
            public string _128 { get; set; }

            [JsonProperty("180")]
            public string _180 { get; set; }

            [JsonProperty("192")]
            public string _192 { get; set; }

            [JsonProperty("220")]
            public string _220 { get; set; }

            [JsonProperty("250")]
            public string _250 { get; set; }

            [JsonProperty("440")]
            public string _440 { get; set; }

            [JsonProperty("500")]
            public string _500 { get; set; }
            public int media_id { get; set; }
            public string full { get; set; }
            public int blog_id { get; set; }
        }

        public class Sizes
        {
            public Medium medium { get; set; }
            public Large large { get; set; }
            public Thumbnail thumbnail { get; set; }
            public MediumLarge medium_large { get; set; }

            [JsonProperty("1536x1536")]
            public _1536x1536 _1536x1536 { get; set; }

            [JsonProperty("2048x2048")]
            public _2048x2048 _2048x2048 { get; set; }
            public Full full { get; set; }
        }

        public class Thumbnail
        {
            public string file { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string mime_type { get; set; }
            public string source_url { get; set; }
        }

        public class Title
        {
            public string rendered { get; set; }
        }

        public class UserMeta
        {
            public string facebook { get; set; }
            public string instagram { get; set; }
            public string twitter { get; set; }
            public string whatsapp { get; set; }
        }

        public class VersionHistory
        {
            public int count { get; set; }
            public string href { get; set; }
        }

        public class WpAttachment
        {
            public string href { get; set; }
        }

        public class WpFeaturedmedium
        {
            public int id { get; set; }
            public DateTime date { get; set; }
            public string slug { get; set; }
            public string type { get; set; }
            public string link { get; set; }
            public Title title { get; set; }
            public int author { get; set; }
            public Caption caption { get; set; }
            public string alt_text { get; set; }
            public string media_type { get; set; }
            public string mime_type { get; set; }
            public MediaDetails media_details { get; set; }
            public string source_url { get; set; }
            public Links _links { get; set; }
            public bool embeddable { get; set; }
            public string href { get; set; }
        }

        public class WpTerm
        {
            public string taxonomy { get; set; }
            public bool embeddable { get; set; }
            public string href { get; set; }
        }


        public class Noticia
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Image { get; set; }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://notigram.com/wp-json/wp/v2/posts?per_page=10&status=publish&page=1&_embed");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string contect = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Root>>(contect);

                var Noticia = resultado.Select(rt => new Noticia
                {
                     Id = rt.id,
                     Name = rt._embedded.author[0].name,
                     Title = rt.title.rendered,
                     Image = rt._embedded.wpfeaturedmedia[0].source_url
                }).ToList();

                ListaNoticias.ItemsSource = Noticia;

            }

        }

        private async void Button_Clickeded(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = (int)button.CommandParameter;

            // Ahora puedes navegar a otra página y pasar el ID como parámetro
            await Navigation.PushAsync(new DetalleNoticia(id));
        }
    }
}