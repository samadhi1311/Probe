using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Win32;
using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Probe
{
    public partial class MainForm : Form
    {

        //Initializing Variables
        public static String browserName = null;

        int totalVisits = 0;

        public string[] mostVisited_titles = new string[10];
        public string[] mostVisited_urls = new string[10];
        public long[] mostVisited_visits = new long[10];
        public string[] mostVisited_lastVisits = new string[10];

        public string[] socialMedia = { "facebook.com", "youtube.com", "whatsapp.com", "instagram.com", "tiktok.com", "twitter.com", "reddit.com", "pinterest.com", "quora.com", "discord.com" };

        public string[] social_titles = new string[10];
        public string[] social_urls = new string[10];
        public long[] social_visits = new long[10];
        public string[] social_lastVisits = new string[10];



        public MainForm()
        {
            InitializeComponent();

            //Setting background colors of labels that are over GIFs to transparent
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;
            label4.Parent = pictureBox6;
            label4.BackColor = Color.Transparent;

            //Checking System registry to detect default browser set by user
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

        //Method to display loading screen
        public async void loader()
        {
            loading l1 = new loading();
            l1.Show();
            this.Hide();
            await Task.Delay(3000);
            l1.Close();
            this.Show();
        }

        //Add data in the variables to the relavent controls like lables, pictureboxes and piechart
        private void mostVisited()
        {
            loader();

            label_mostVisited_result1_title.Text = mostVisited_titles[0];
            linkLabel_mostVisited_result1_url.Text = mostVisited_urls[0];
            label_mostVisited_result1_count.Text = "Total visits: " + mostVisited_visits[0].ToString();
            label_mostVisited_result1_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[0].ToString();
            pictureBox_mostVisited_result1_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[0] + "&sz=128";

            label_mostVisited_result2_title.Text = mostVisited_titles[1];
            linkLabel_mostVisited_result2_url.Text = mostVisited_urls[1];
            label_mostVisited_result2_count.Text = "Total visits: " + mostVisited_visits[1].ToString();
            label_mostVisited_result3_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[1].ToString();
            pictureBox_mostVisited_result1_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[1] + "&sz=128";

            label_mostVisited_result3_title.Text = mostVisited_titles[2];
            linkLabel_mostVisited_result3_url.Text = mostVisited_urls[2];
            label_mostVisited_result3_count.Text = "Total visits: " + mostVisited_visits[2].ToString();
            label_mostVisited_result3_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[2].ToString();
            pictureBox_mostVisited_result3_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[2] + "&sz=128";

            label_mostVisited_result4_title.Text = mostVisited_titles[3];
            linkLabel_mostVisited_result4_url.Text = mostVisited_urls[3];
            label_mostVisited_result4_count.Text = "Total visits: " + mostVisited_visits[3].ToString();
            label_mostVisited_result4_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[3].ToString();
            pictureBox_mostVisited_result4_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[2] + "&sz=128";

            label_mostVisited_result5_title.Text = mostVisited_titles[4];
            linkLabel_mostVisited_result5_url.Text = mostVisited_urls[4];
            label_mostVisited_result5_count.Text = "Total visits: " + mostVisited_visits[4].ToString();
            label_mostVisited_result5_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[4].ToString();
            pictureBox_mostVisited_result5_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[4] + "&sz=128";

            label_mostVisited_result6_title.Text = mostVisited_titles[5];
            linkLabel_mostVisited_result6_url.Text = mostVisited_urls[5];
            label_mostVisited_result6_count.Text = "Total visits: " + mostVisited_visits[5].ToString();
            label_mostVisited_result6_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[5].ToString();
            pictureBox_mostVisited_result6_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[5] + "&sz=128";

            label_mostVisited_result7_title.Text = mostVisited_titles[6];
            linkLabel_mostVisited_result7_url.Text = mostVisited_urls[6];
            label_mostVisited_result7_count.Text = "Total visits: " + mostVisited_visits[6].ToString();
            label_mostVisited_result7_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[6].ToString();
            pictureBox_mostVisited_result7_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[6] + "&sz=128";

            label_mostVisited_result8_title.Text = mostVisited_titles[7];
            linkLabel_mostVisited_result8_url.Text = mostVisited_urls[7];
            label_mostVisited_result8_count.Text = "Total visits: " + mostVisited_visits[7].ToString();
            label_mostVisited_result8_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[7].ToString();
            pictureBox_mostVisited_result8_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[7] + "&sz=128";

            label_mostVisited_result9_title.Text = mostVisited_titles[8];
            linkLabel_mostVisited_result9_url.Text = mostVisited_urls[8];
            label_mostVisited_result9_count.Text = "Total visits: " + mostVisited_visits[8].ToString();
            label_mostVisited_result9_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[8].ToString();
            pictureBox_mostVisited_result9_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[8] + "&sz=128";

            label_mostVisited_result10_title.Text = mostVisited_titles[9];
            linkLabel_mostVisited_result10_url.Text = mostVisited_urls[9];
            label_mostVisited_result10_count.Text = "Total visits: " + mostVisited_visits[9].ToString();
            label_mostVisited_result10_lastVisit.Text = "Last visit: " + mostVisited_lastVisits[9].ToString();
            pictureBox_mostVisited_result10_favicon.ImageLocation = "https://www.google.com/s2/favicons?domain=" + mostVisited_titles[9] + "&sz=128";

            social_title1.Text = social_titles[0];
            social_url1.Text = social_urls[0];
            social_count1.Text = "Total visits: " + social_visits[0].ToString();
            social_last1.Text = "Last visit: " + social_lastVisits[0];
            social_icon1.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[0] + "&sz=128";

            social_title2.Text = social_titles[1];
            social_url2.Text = social_urls[1];
            social_count2.Text = "Total visits: " + social_visits[1].ToString();
            social_last2.Text = "Last visit: " + social_lastVisits[1];
            social_icon2.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[1] + "&sz=128";

            social_title3.Text = social_titles[2];
            social_url3.Text = social_urls[2];
            social_count3.Text = "Total visits: " + social_visits[2].ToString();
            social_last3.Text = "Last visit: " + social_lastVisits[2];
            social_icon3.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[2] + "&sz=128";

            social_title4.Text = social_titles[3];
            social_url4.Text = social_urls[3];
            social_count4.Text = "Total visits: " + social_visits[3].ToString();
            social_last4.Text = "Last visit: " + social_lastVisits[3];
            social_icon4.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[3] + "&sz=128";

            social_title5.Text = social_titles[4];
            social_url5.Text = social_urls[4];
            social_count5.Text = "Total visits: " + social_visits[4].ToString();
            social_last5.Text = "Last visit: " + social_lastVisits[4];
            social_icon5.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[4] + "&sz=128";

            social_title6.Text = social_titles[5];
            social_url6.Text = social_urls[5];
            social_count6.Text = "Total visits: " + social_visits[5].ToString();
            social_last6.Text = "Last visit: " + social_lastVisits[5];
            social_icon6.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[5] + "&sz=128";

            social_title7.Text = social_titles[6];
            social_url7.Text = social_urls[6];
            social_count7.Text = "Total visits: " + social_visits[6].ToString();
            social_last7.Text = "Last visit: " + social_lastVisits[6];
            social_icon7.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[6] + "&sz=128";

            social_title8.Text = social_titles[7];
            social_url8.Text = social_urls[7];
            social_count8.Text = "Total visits: " + social_visits[7].ToString();
            social_last8.Text = "Last visit: " + social_lastVisits[7];
            social_icon8.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[7] + "&sz=128";

            social_title9.Text = social_titles[8];
            social_url9.Text = social_urls[8];
            social_count9.Text = "Total visits: " + social_visits[8].ToString();
            social_last9.Text = "Last visit: " + social_lastVisits[8];
            social_icon9.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[8] + "&sz=128";

            social_title10.Text = social_titles[9];
            social_url10.Text = social_urls[9];
            social_count10.Text = "Total visits: " + social_visits[9].ToString();
            social_last10.Text = "Last visit: " + social_lastVisits[9];
            social_icon10.ImageLocation = "https://www.google.com/s2/favicons?domain=" + social_titles[9] + "&sz=128";

            long topCount = 0;
            for (int i = 0; i < 0; i++)
            {
                topCount += mostVisited_visits[i];
            }

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{1:P}", chartPoint.Y, chartPoint.Participation);

            // Define a collection of items to display in the chart 
            SeriesCollection piechartData = new SeriesCollection
            {

            };

            // You can add a new item dinamically with the add method of the collection
            // Useful when you define the data dinamically and not statically
            piechartData.Add(
                new PieSeries
                {
                    Title = "1. " + mostVisited_titles[0],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[0]) / totalVisits) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Aqua,
                    PushOut = 20
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "2. " + mostVisited_titles[1],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[1]) / totalVisits) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Beige
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "3. " + mostVisited_titles[2],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[2]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Chocolate
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "4. " + mostVisited_titles[3],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[3]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Coral
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "5. " + mostVisited_titles[4],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[4]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Crimson
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "6. " + mostVisited_titles[5],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[5]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Gainsboro
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "7. " + mostVisited_titles[6],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[6]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.IndianRed
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "8. " + mostVisited_titles[7],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[7]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Lavender
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "9. " + mostVisited_titles[8],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[8]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.LawnGreen
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "10. " + mostVisited_titles[9],
                    Values = new ChartValues<double> { (Convert.ToDouble(mostVisited_visits[9]) / Convert.ToDouble(totalVisits)) * 100 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Lime
                }
            ); piechartData.Add(
                new PieSeries
                {
                    Title = "11. Other",
                    Values = new ChartValues<double> { (Convert.ToDouble(totalVisits) - (Convert.ToDouble(topCount)) / Convert.ToDouble(totalVisits)) },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.SeaGreen
                }
            );

            // Define the collection of Values to display in the Pie Chart
            pieChart1.Series = piechartData;

            // Set the legend location to appear in the Right side of the chart
            pieChart1.LegendLocation = LegendLocation.Right;

            tabControl_navigation.SelectedIndex = 1;

        }

        //If the default button is clicked the methods for relavent browser will be run
        private void button_selectDefault_Click(object sender, EventArgs e)
        {
            if (browserName == "Chrome")
            {
                button_chrome_Click(sender, e);
            }
            else if (browserName == "Edge")
            {
                button_edge_Click(sender, e);
            }
            else if (browserName == "Firefox")
            {
                button_firefox_Click(sender, e);
            }
            else if (browserName == "Opera")
            {
                button_opera_Click(sender, e);
            }
        }

        //Methods for Chrome
        private void button_chrome_Click(object sender, EventArgs e)
        {
            browserName = "Chrome";
            string historyDbPath;

            //Checks if the Hostory database exists. If true, connects to the database. else, displays browser not found error (noBrowser Form)
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History"))
            {

                historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
                using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
                {

                    try
                    {
                        connection.Open();
                        //Sends the query and retrieves the data
                        using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                //Adds most visited data to the variables
                                int i = 0;

                                while (reader.Read() && i < 10)
                                {
                                    Uri uri = new Uri(reader.GetString(0));
                                    string host = uri.Host;
                                    int visits = (reader.GetInt32(1));
                                    bool processed = false;

                                    long timestamp = reader.GetInt64(2);
                                    DateTime lastVisitDate = new DateTime(1601, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp / 1000000);
                                    string lastVisitDateString = lastVisitDate.ToString("dd/MM/yyyy HH:mm tt");

                                    for (int j = 0; j < 10; j++)
                                    {
                                        if (host == mostVisited_titles[j])
                                        {
                                            mostVisited_visits[j] += visits;
                                            processed = true;
                                            break;
                                        }
                                    }

                                    if (!processed)
                                    {
                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (mostVisited_titles[j] == null)
                                            {
                                                mostVisited_urls[j] = uri.ToString();
                                                mostVisited_titles[j] = host.ToString();
                                                mostVisited_visits[j] = visits;
                                                mostVisited_lastVisits[j] = lastVisitDateString;
                                                i++;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Gets social media data
                        using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Uri uri = new Uri(reader.GetString(0));
                                    string host = uri.Host;
                                    int visits = (reader.GetInt32(1));
                                    bool processed = false;

                                    long timestamp = reader.GetInt64(2);
                                    DateTime lastVisitDate = new DateTime(1601, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp / 1000000);
                                    string lastVisitDateString = lastVisitDate.ToString("dd/MM/yyyy HH:mm tt");

                                    foreach (string socialMediaDomain in socialMedia)
                                    {
                                        if (host.Contains(socialMediaDomain))
                                        {
                                            host = socialMediaDomain;
                                            break;
                                        }
                                    }

                                    if (socialMedia.Contains(host))
                                    {
                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (host == social_titles[j])
                                            {
                                                social_visits[j] += visits;
                                                processed = true;
                                                break;
                                            }
                                        }

                                        if (!processed)
                                        {
                                            for (int j = 0; j < 10; j++)
                                            {
                                                if (social_titles[j] == null)
                                                {
                                                    social_urls[j] = uri.ToString();
                                                    social_titles[j] = host.ToString();
                                                    social_visits[j] = visits;
                                                    social_lastVisits[j] = lastVisitDateString;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Gets last visit time and converts it to strings
                        using (var command = new SQLiteCommand("SELECT urls.url, urls.title, visits.visit_time " +
                                                              "FROM urls " +
                                                              "INNER JOIN visits ON urls.id = visits.url", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                long totalTicks = 0;

                                while (reader.Read())
                                {
                                    long timeStamp = Convert.ToInt64(reader["visit_time"]) * 10_000;
                                    totalTicks += timeStamp;
                                }

                                TimeSpan totalTime = new TimeSpan(totalTicks);
                            }


                        }

                        using (var command = new SQLiteCommand("SELECT SUM(visit_count) FROM urls", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    totalVisits += reader.GetInt32(0);
                                }
                            }
                        }

                        long countTemp;
                        string titleTemp;
                        string urlTemp;
                        string lastTemp;

                        for (int j = 0; j < mostVisited_visits.Length; j++)
                        {
                            for (int k = 0; k < mostVisited_visits.Length; k++)
                            {
                                if (mostVisited_visits[j] > mostVisited_visits[k])
                                {
                                    countTemp = mostVisited_visits[j];
                                    mostVisited_visits[j] = mostVisited_visits[k];
                                    mostVisited_visits[k] = countTemp;

                                    titleTemp = mostVisited_titles[j];
                                    mostVisited_titles[j] = mostVisited_titles[k];
                                    mostVisited_titles[k] = titleTemp;

                                    urlTemp = mostVisited_urls[j];
                                    mostVisited_urls[j] = mostVisited_urls[k];
                                    mostVisited_urls[k] = urlTemp;

                                    lastTemp = mostVisited_lastVisits[j];
                                    mostVisited_lastVisits[j] = mostVisited_lastVisits[k];
                                    mostVisited_lastVisits[k] = lastTemp;
                                }
                            }
                        }

                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.Message.Contains("database is locked"))
                        {
                            Form closebrowser = new closeBrowser();
                            closebrowser.Show();
                        }

                    }
                }


                mostVisited();
            }
            else
            {
                Form noBrowser = new noBrowser();
                noBrowser.Show();
            }

        }

        //Methods for Edge
        private void button_edge_Click(object sender, EventArgs e)
        {
            browserName = "edge";
            string historyDbPath;

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\History"))
            {


                Process[] processes = Process.GetProcessesByName("msedge");

                if (processes.Length > 0)
                {
                    Console.WriteLine("Notepad is running.");
                    Form frm = new closeBrowser();
                    frm.Show();
                }
                else
                {
                    historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\History";
                    using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
                    {
                        {
                            connection.Open();

                            using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC", connection))
                            {
                                using (var reader = command.ExecuteReader())
                                {
                                    int i = 0;

                                    while (reader.Read() && i < 10)
                                    {
                                        Uri uri = new Uri(reader.GetString(0));
                                        string host = uri.Host;
                                        int visits = (reader.GetInt32(1));
                                        bool processed = false;

                                        long timestamp = reader.GetInt64(2);
                                        DateTime lastVisitDate = new DateTime(1601, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp / 1000000);
                                        string lastVisitDateString = lastVisitDate.ToString("dd/MM/yyyy HH:mm tt");

                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (host == mostVisited_titles[j])
                                            {
                                                mostVisited_visits[j] += visits;
                                                processed = true;
                                                break;
                                            }
                                        }

                                        if (!processed)
                                        {
                                            for (int j = 0; j < 10; j++)
                                            {
                                                if (mostVisited_titles[j] == null)
                                                {
                                                    mostVisited_urls[j] = uri.ToString();
                                                    mostVisited_titles[j] = host.ToString();
                                                    mostVisited_visits[j] = visits;
                                                    mostVisited_lastVisits[j] = lastVisitDateString;
                                                    i++;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            //socials
                            using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC", connection))
                            {
                                using (var reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Uri uri = new Uri(reader.GetString(0));
                                        string host = uri.Host;
                                        int visits = (reader.GetInt32(1));
                                        bool processed = false;

                                        long timestamp = reader.GetInt64(2);
                                        DateTime lastVisitDate = new DateTime(1601, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp / 1000000);
                                        string lastVisitDateString = lastVisitDate.ToString("dd/MM/yyyy HH:mm tt");

                                        foreach (string socialMediaDomain in socialMedia)
                                        {
                                            if (host.Contains(socialMediaDomain))
                                            {
                                                host = socialMediaDomain;
                                                break;
                                            }
                                        }

                                        if (socialMedia.Contains(host))
                                        {
                                            for (int j = 0; j < 10; j++)
                                            {
                                                if (host == social_titles[j])
                                                {
                                                    social_visits[j] += visits;
                                                    processed = true;
                                                    break;
                                                }
                                            }

                                            if (!processed)
                                            {
                                                for (int j = 0; j < 10; j++)
                                                {
                                                    if (social_titles[j] == null)
                                                    {
                                                        social_urls[j] = uri.ToString();
                                                        social_titles[j] = host.ToString();
                                                        social_visits[j] = visits;
                                                        social_lastVisits[j] = lastVisitDateString;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            using (var command = new SQLiteCommand("SELECT urls.url, urls.title, visits.visit_time " +
                                                                  "FROM urls " +
                                                                  "INNER JOIN visits ON urls.id = visits.url", connection))
                            {
                                using (var reader = command.ExecuteReader())
                                {
                                    long totalTicks = 0;

                                    while (reader.Read())
                                    {
                                        long timeStamp = Convert.ToInt64(reader["visit_time"]) * 10_000;
                                        totalTicks += timeStamp;
                                    }

                                    TimeSpan totalTime = new TimeSpan(totalTicks);
                                }


                            }

                            using (var command = new SQLiteCommand("SELECT SUM(visit_count) FROM urls", connection))
                            {
                                using (var reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        totalVisits += reader.GetInt32(0);
                                    }
                                }
                            }
                            long countTemp;
                            string titleTemp;
                            string urlTemp;
                            string lastTemp;

                            for (int j = 0; j < mostVisited_visits.Length; j++)
                            {
                                for (int k = 0; k < mostVisited_visits.Length; k++)
                                {
                                    if (mostVisited_visits[j] > mostVisited_visits[k])
                                    {
                                        countTemp = mostVisited_visits[j];
                                        mostVisited_visits[j] = mostVisited_visits[k];
                                        mostVisited_visits[k] = countTemp;

                                        titleTemp = mostVisited_titles[j];
                                        mostVisited_titles[j] = mostVisited_titles[k];
                                        mostVisited_titles[k] = titleTemp;

                                        urlTemp = mostVisited_urls[j];
                                        mostVisited_urls[j] = mostVisited_urls[k];
                                        mostVisited_urls[k] = urlTemp;

                                        lastTemp = mostVisited_lastVisits[j];
                                        mostVisited_lastVisits[j] = mostVisited_lastVisits[k];
                                        mostVisited_lastVisits[k] = lastTemp;
                                    }
                                }
                            }

                        }
                        mostVisited();
                    }

                }


            }
            else
            {
                Form noBrowser = new noBrowser();
                noBrowser.Show();
            }
        }

        //Methods for Firefox
        private void button_firefox_Click(object sender, EventArgs e)
        {
            browserName = "firefox";
            string defaultProfile = "";

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\History"))
            {
                Process[] processes = Process.GetProcessesByName("firefox");

                if (processes.Length > 0)
                {
                    Form frm = new closeBrowser();
                    frm.Show();
                }
                else
                {
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
                        using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_date FROM moz_places WHERE visit_count > 0 GROUP BY url ORDER BY visit_count DESC", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                int i = 0;

                                while (reader.Read() && i < 10)
                                {
                                    Uri uri = new Uri(reader.GetString(0));
                                    string host = uri.Host;
                                    int visits = (reader.GetInt32(1));
                                    bool processed = false;

                                    DateTime lastVisit = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Convert.ToInt64(reader["last_visit_date"]) / 1000000);
                                    //DateTime lastVisit = new DateTime(Convert.ToInt64(reader["last_visit_date"]) * TimeSpan.TicksPerSecond);
                                    string lastVisitString = lastVisit.ToString("dd/MM/yyyy HH:mm tt");


                                    for (int j = 0; j < 10; j++)
                                    {
                                        if (host == mostVisited_urls[j])
                                        {
                                            mostVisited_visits[j] += visits;
                                            processed = true;
                                            break;
                                        }
                                    }

                                    if (!processed)
                                    {
                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (mostVisited_titles[j] == null)
                                            {
                                                mostVisited_urls[j] = uri.ToString();
                                                mostVisited_titles[j] = host.ToString();
                                                mostVisited_visits[j] = visits;
                                                mostVisited_lastVisits[j] = lastVisitString;
                                                i++;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        mostVisited();
                    }
                }
            }
        }

        //Methods for Opera
        private void button_opera_Click(object sender, EventArgs e)
        {
            browserName = "opera";
            string historyDbPath;

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable\History"))
            {
                Process[] processes = Process.GetProcessesByName("notepad");

                if (processes.Length > 0)
                {
                    Form frm = new closeBrowser();
                    frm.Show();
                }
                else
                {
                    historyDbPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable\History";
                    using (var connection = new SQLiteConnection("Data Source=" + historyDbPath))
                    {


                        connection.Open();

                        using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                int i = 0;

                                while (reader.Read() && i < 10)
                                {
                                    Uri uri = new Uri(reader.GetString(0));
                                    string host = uri.Host;
                                    int visits = (reader.GetInt32(1));
                                    bool processed = false;

                                    long timestamp = reader.GetInt64(2);
                                    DateTime lastVisitDate = new DateTime(1601, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp / 1000000);
                                    string lastVisitDateString = lastVisitDate.ToString("dd/MM/yyyy HH:mm tt");

                                    for (int j = 0; j < 10; j++)
                                    {
                                        if (host == mostVisited_titles[j])
                                        {
                                            mostVisited_visits[j] += visits;
                                            processed = true;
                                            break;
                                        }
                                    }

                                    if (!processed)
                                    {
                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (mostVisited_titles[j] == null)
                                            {
                                                mostVisited_urls[j] = uri.ToString();
                                                mostVisited_titles[j] = host.ToString();
                                                mostVisited_visits[j] = visits;
                                                mostVisited_lastVisits[j] = lastVisitDateString;
                                                i++;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //socials
                        using (var command = new SQLiteCommand("SELECT url, visit_count, last_visit_time FROM urls ORDER BY visit_count DESC", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Uri uri = new Uri(reader.GetString(0));
                                    string host = uri.Host;
                                    int visits = (reader.GetInt32(1));
                                    bool processed = false;

                                    long timestamp = reader.GetInt64(2);
                                    DateTime lastVisitDate = new DateTime(1601, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp / 1000000);
                                    string lastVisitDateString = lastVisitDate.ToString("dd/MM/yyyy HH:mm tt");

                                    foreach (string socialMediaDomain in socialMedia)
                                    {
                                        if (host.Contains(socialMediaDomain))
                                        {
                                            host = socialMediaDomain;
                                            break;
                                        }
                                    }

                                    if (socialMedia.Contains(host))
                                    {
                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (host == social_titles[j])
                                            {
                                                social_visits[j] += visits;
                                                processed = true;
                                                break;
                                            }
                                        }

                                        if (!processed)
                                        {
                                            for (int j = 0; j < 10; j++)
                                            {
                                                if (social_titles[j] == null)
                                                {
                                                    social_urls[j] = uri.ToString();
                                                    social_titles[j] = host.ToString();
                                                    social_visits[j] = visits;
                                                    social_lastVisits[j] = lastVisitDateString;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        using (var command = new SQLiteCommand("SELECT urls.url, urls.title, visits.visit_time " +
                                                              "FROM urls " +
                                                              "INNER JOIN visits ON urls.id = visits.url", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                long totalTicks = 0;

                                while (reader.Read())
                                {
                                    long timeStamp = Convert.ToInt64(reader["visit_time"]) * 10_000;
                                    totalTicks += timeStamp;
                                }

                                TimeSpan totalTime = new TimeSpan(totalTicks);
                            }


                        }

                        using (var command = new SQLiteCommand("SELECT SUM(visit_count) FROM urls", connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    totalVisits += reader.GetInt32(0);
                                }
                            }
                        }
                        long countTemp;
                        string titleTemp;
                        string urlTemp;
                        string lastTemp;

                        for (int j = 0; j < mostVisited_visits.Length; j++)
                        {
                            for (int k = 0; k < mostVisited_visits.Length; k++)
                            {
                                if (mostVisited_visits[j] > mostVisited_visits[k])
                                {
                                    countTemp = mostVisited_visits[j];
                                    mostVisited_visits[j] = mostVisited_visits[k];
                                    mostVisited_visits[k] = countTemp;

                                    titleTemp = mostVisited_titles[j];
                                    mostVisited_titles[j] = mostVisited_titles[k];
                                    mostVisited_titles[k] = titleTemp;

                                    urlTemp = mostVisited_urls[j];
                                    mostVisited_urls[j] = mostVisited_urls[k];
                                    mostVisited_urls[k] = urlTemp;

                                    lastTemp = mostVisited_lastVisits[j];
                                    mostVisited_lastVisits[j] = mostVisited_lastVisits[k];
                                    mostVisited_lastVisits[k] = lastTemp;
                                }
                            }
                        }
                        mostVisited();
                    }
                }


            }
            else
            {
                Form noBrowser = new noBrowser();
                noBrowser.Show();
            }
            mostVisited();
        }

        //Exits the program
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Navigatable link creation
        #region link
        private void linkLabel_mostVisited_result1_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result1_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[0]);
        }

        private void linkLabel_mostVisited_result2_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result2_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[1]);
        }

        private void linkLabel_mostVisited_result3_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result3_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[2]);
        }

        private void linkLabel_mostVisited_result4_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result4_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[3]);
        }

        private void linkLabel_mostVisited_result5_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result5_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[4]);
        }

        private void linkLabel_mostVisited_result6_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result6_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[5]);
        }

        private void linkLabel_mostVisited_result7_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result7_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[6]);
        }

        private void linkLabel_mostVisited_result8_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result8_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[7]);
        }

        private void linkLabel_mostVisited_result9_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result9_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[8]);
        }

        private void linkLabel_mostVisited_result10_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel_mostVisited_result10_url.LinkVisited = true;
            System.Diagnostics.Process.Start(mostVisited_urls[9]);
        }

        private void social_url1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url1.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[0]);
        }

        private void social_url2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url2.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[1]);
        }

        private void social_url3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url3.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[2]);
        }

        private void social_url4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url4.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[3]);
        }

        private void social_url5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url5.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[4]);
        }

        private void social_url6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url6.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[5]);
        }

        private void social_url7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url7.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[6]);
        }

        private void social_url8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url8.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[7]);
        }

        private void social_url9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url9.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[8]);
        }

        private void social_url10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.social_url10.LinkVisited = true;
            System.Diagnostics.Process.Start(social_urls[9]);
        }
        #endregion

    }
}