using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;

namespace News_App
{
    public partial class Form1 : Form
    {

        // API
        private static SpotifyWebAPI _spotify;
        string clientId = "3e3955b65e54416195986bc285a56b41";
        string clientSecret = "d7dc286ccbd2496a96d91f4038f7829e";
        
        public String NewsKey = "db5f8db514fc496696159cb9697d2e87";
        public String SearchNewsURL = "https://newsapi.org/v2/top-headlines?country=ie&apiKey=";

        public int Articles = 0;

        public string RequestNewsKey()
        {
            return NewsKey;
        }

        public string RequestSearchURL()
        {
            return SearchNewsURL;
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        // Form Stuff

        public Form1()
        {
            InitializeComponent();
            Opacity = 1;
            TransparencyKey = Color.DarkGray;
            BackColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Data = Get(RequestSearchURL() + RequestNewsKey());
            dynamic stuff = JObject.Parse(Data);
            
            foreach (var Item in stuff.articles)
            {
                string Title = Item.title;
                string Author = Item.author;
                string Desc = Item.description;
                string Img = Item.urlToImage;
                string Pub = Item.publishedAt;
                NewsPanel Stuff = new NewsPanel(Title, Author, Desc, Img, Pub, Articles, panel2);
                Articles++;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            CredentialsAuth auth = new CredentialsAuth(clientId, clientSecret);
            Token token = await auth.GetToken();
            _spotify = new SpotifyWebAPI()
            {
                AccessToken = token.AccessToken,
                TokenType = token.TokenType
            };

            FullTrack track = _spotify.GetTrack("3Hvu1pq89D4R0lyPBoujSv");
            Console.WriteLine("Current Track: " + track.Name); //Yeay! We just printed a tracks name.
            //string Search = textBox1.Text;
            //SearchItem item = _spotify.SearchItems(Search, SpotifyAPI.Web.Enums.SearchType.Album | SpotifyAPI.Web.Enums.SearchType.Playlist);
            //Console.WriteLine(item.Albums.Total);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
