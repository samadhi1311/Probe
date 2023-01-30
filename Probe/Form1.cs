using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using RestSharp;
using Probe;

namespace Probe
{
    public partial class MainForm : Form
    {
        public static String browserName = null;
        public string[] mostVisited_titles = new string[10];
        public string[] mostVisited_urls = new string[10];
        public long[] mostVisited_visits = new long[10];
        //public long[] mostVisited_lastVisits = new long[10];
        public Image[] mostVisited_favicons= new Image[10];

        

        public MainForm()
        {
            InitializeComponent();

            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("brave"))
                        {
                            browserName = "Brave";
                            button_selectDefault.Image = imageList_browserLogo.Images[0];

                        }
                        else if (progIdValue.ToString().ToLower().Contains("chrome"))
                        {
                            browserName = "Chrome";
                            button_selectDefault.Image = imageList_browserLogo.Images[1];
                        }
                        else if (progIdValue.ToString().ToLower().Contains("edge"))
                        {
                            browserName = "Edge";
                            button_selectDefault.Image = imageList_browserLogo.Images[2];
                        }
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                        {
                            browserName = "Firefox";
                            button_selectDefault.Image = imageList_browserLogo.Images[3];
                        }
                        else if (progIdValue.ToString().ToLower().Contains("opera"))
                        {
                            browserName = "Opera";
                            button_selectDefault.Image = imageList_browserLogo.Images[4];
                        }
                        else if (progIdValue.ToString().ToLower().Contains("vivaldi"))
                        {
                            browserName = "Vivaldi";
                            button_selectDefault.Image = imageList_browserLogo.Images[5];
                        }
                    }
                }
            }
        }
        public async void loader()
        {
            loading l1 = new loading();
            l1.Show();
            await Task.Delay(3000);
            l1.Close();
        }


        private void mostVisited()
        {
            loader();

            label_mostVisited_result1_title.Text = mostVisited_titles[0];
            linkLabel_mostVisited_result1_url.Text = mostVisited_urls[0];
            label_mostVisited_result1_count.Text = mostVisited_visits[0].ToString();
            //label_mostVisited_result1_lastVisit.Text = mostVisited_lastVisits[0].ToString();
            pictureBox_mostVisited_favicon.ImageLocation = "https://" + mostVisited_titles[0] + "/favicon.ico";
            tabControl_navigation.SelectedIndex = 1;

        }

        private void button_selectDefault_Click(object sender, EventArgs e)
        {
            mostVisited();
        }

        private void button_brave_Click(object sender, EventArgs e)
        {
            mostVisited();

            

            browserName = "brave";
        }

        private void button_chrome_Click(object sender, EventArgs e)
        {
            browserName = "Chrome";

            string historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
            using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC LIMIT 10", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        int i = 0;

                        while (reader.Read())
                        {
                            Uri uri = new Uri(reader.GetString(0));
                            mostVisited_urls[i] = uri.ToString();

                            string host = uri.Host;
                            mostVisited_titles[i] = host.ToString();

                            int visits = (reader.GetInt32(1));
                            mostVisited_visits[i] = visits;

                            /*
                            long lastVisit = (reader.GetInt64(2));
                            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
                            lastVisit = mostVisited_lastVisits[i] - Convert.ToInt64(now);

                            mostVisited_lastVisits[i] = lastVisit;
                            */

                            //favicon
                            /*
                            var client = new RestClient("https://realfavicongenerator.p.rapidapi.com/favicon/icon?site=https%3A%2F%2Fwww.google.com");
                            var request = new RestRequest("Method.Get");
                            request.AddHeader("X-RapidAPI-Key", "0e817dd0e7msh9c994fd322062d6p11bd28jsn3a37d86581fc");
                            request.AddHeader("X-RapidAPI-Host", "realfavicongenerator.p.rapidapi.com");
                            RestResponse response = client.Execute(request);

                            string content = response.Content;

                            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                            {
                                var image = Image.FromStream(ms);
                                mostVisited_favicons[i] = image;
                            }
                            */

                            i++;
                        }
                    }
                }
            }

            mostVisited();
        }

        private void button_edge_Click(object sender, EventArgs e)
        {
            browserName = "edge";

            string historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\History";
            using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC LIMIT 10", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        int i = 0;

                        while (reader.Read())
                        {
                            Uri uri = new Uri(reader.GetString(0));
                            mostVisited_urls[i] = uri.ToString();

                            string host = uri.Host;
                            mostVisited_titles[i] = host.ToString();

                            long visits = (reader.GetInt64(1));
                            mostVisited_visits[i] = visits;

                            i++;
                        }
                    }
                }
            }

            mostVisited();
        }

        private void button_firefox_Click(object sender, EventArgs e)
        {
            browserName = "firefox";
            string defaultProfile = "";

            string profilesIniPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Mozilla\Firefox\profiles.ini";

            using (FileStream fs = File.OpenRead(profilesIniPath))
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.StartsWith("Default=Profiles/"))
                    {
                        defaultProfile = line.Substring(17);
                        break;
                    }
                }
            }

            string historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Mozilla\Firefox\Profiles\" + defaultProfile + @"\places.sqlite";
            //Profiles/gdms3yut.A
            using (var connection = new SQLiteConnection("Data Source=" + historyDbPath + ";Version=3;New=False;Compress=True;"))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT url, count(url) as count FROM moz_places WHERE visit_count > 0 GROUP BY url ORDER BY count DESC LIMIT 10", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        int i = 0;

                        while (reader.Read())
                        {

                            Uri uri = new Uri(reader.GetString(0));
                            mostVisited_urls[i] = uri.ToString();

                            string host = uri.Host;
                            mostVisited_titles[i] = host.ToString();

                            int visits = (reader.GetInt32(1));
                            mostVisited_visits[i] = visits;

                            i++;
                        }
                    }
                }
            }

            mostVisited();
        }

        private void button_opera_Click(object sender, EventArgs e)
        {
            browserName = "opera";

            string historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable\History";
            using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC LIMIT 10", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        int i = 0;

                        while (reader.Read())
                        {

                            Uri uri = new Uri(reader.GetString(0));
                            mostVisited_urls[i] = uri.ToString();

                            string host = uri.Host;
                            mostVisited_titles[i] = host.ToString();

                            int visits = (reader.GetInt32(1));
                            mostVisited_visits[i] = visits;

                            i++;
                        }
                    }
                }
            }

            mostVisited();
        }

        private void button_vivaldi_Click(object sender, EventArgs e)
        {
            browserName = "vivaldi";

            string historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Vivaldi\User Data\Default\History";
            using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC LIMIT 10", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        int i = 0;

                        while (reader.Read())
                        {

                            Uri uri = new Uri(reader.GetString(0));
                            mostVisited_urls[i] = uri.ToString();

                            string host = uri.Host;
                            mostVisited_titles[i] = host.ToString();

                            int visits = (reader.GetInt32(1));
                            mostVisited_visits[i] = visits;

                            i++;
                        }
                    }
                }
            }

            mostVisited();
        }

    }
}
