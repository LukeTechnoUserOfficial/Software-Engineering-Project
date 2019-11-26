using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News_App
{
    public partial class Form1 : Form
    {
        private Login Login;
        int NumberOfArticles = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel NextPanel = new Panel();
            NextPanel.Location = new Point(12, 140 + (NumberOfArticles * 106));
            NextPanel.Size = new Size(525, 106);
            NextPanel.BackColor = Color.White;
            NextPanel.Visible = true;

            PictureBox NewsImage = new PictureBox();
            NewsImage.Parent = NextPanel;
            NewsImage.Location = new Point(3, 3);
            NewsImage.Size = new Size(100, 100);
            NewsImage.Visible = true;
            NewsImage.ImageLocation = "https://www.zerohedge.com/s3/files/styles/max_650x650/public/2019-10/Screen-Shot-2019-10-29-at-10.18.57-AM-291x300.jpg?itok=iDK52a1L";

            Label TitleText = new Label();
            TitleText.Parent = NextPanel;
            TitleText.Location = new Point(107, 1);
            TitleText.AutoSize = false;
            TitleText.Size = new Size(300, 28);
            TitleText.BackColor = Color.Transparent;
            TitleText.Font = new Font(TitleText.Font, FontStyle.Bold);
            TitleText.Text = "US-China Relations In The Years Ahead: The Trade War Is A Sideshow";

            Label AuthorText = new Label();
            AuthorText.Parent = NextPanel;
            AuthorText.Location = new Point(109, 27);
            AuthorText.AutoSize = false;
            AuthorText.Size = new Size(154, 13);
            AuthorText.BackColor = Color.Transparent;
            AuthorText.Font = new Font(AuthorText.Font, FontStyle.Regular);
            AuthorText.Text = "Tyler Durden";

            Label DescriptionText = new Label();
            DescriptionText.Parent = NextPanel;
            DescriptionText.Location = new Point(109, 51);
            DescriptionText.AutoSize = false;
            DescriptionText.Size = new Size(408, 52);
            DescriptionText.BackColor = Color.Transparent;
            DescriptionText.Font = new Font(DescriptionText.Font, FontStyle.Regular);
            DescriptionText.Text = "US-China Relations In The Years Ahead: The Trade War Is A Sideshow Authored by Michael Krieger via Liberty Blitzkrieg blog, As President Trump has said many times, we rebuilt China over the past 25 years. No truer words were spoken, but those days are over. T…";

            Label PublishedText = new Label();
            PublishedText.Parent = NextPanel;
            PublishedText.Location = new Point(373, 1);
            PublishedText.AutoSize = false;
            PublishedText.Size = new Size(154, 13);
            PublishedText.BackColor = Color.Transparent;
            PublishedText.Font = new Font(DescriptionText.Font, FontStyle.Regular);
            PublishedText.TextAlign = ContentAlignment.TopRight;
            PublishedText.Text = "2019-10-30T15:25:00Z";

            NextPanel.Show();
            NumberOfArticles++;

            //extPanel.Parent = NextPanel;
        }

        private void f(object sender, EventArgs e)
        {

        }

        private void Acess_Application_Click(object sender, EventArgs e)
        {

        }

        private void Log_in_Click_1(object sender, EventArgs e)
        {
            Login = new Login();
            Login.Show();
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel NextPanel = new Panel();
            NextPanel.Location = new Point(12, 140);
            NextPanel.Size = new Size(525, 106);
            NextPanel.BackColor = Color.White;
            NextPanel.Visible = true;

            PictureBox NewsImage = new PictureBox();
            NewsImage.Parent = NextPanel;
            NewsImage.Location = new Point(3, 3);
            NewsImage.Size = new Size(100, 100);
            NewsImage.Visible = true;
            NewsImage.ImageLocation = "https://www.zerohedge.com/s3/files/styles/max_650x650/public/2019-10/Screen-Shot-2019-10-29-at-10.18.57-AM-291x300.jpg?itok=iDK52a1L";

            Label TitleText = new Label();
            TitleText.Parent = NextPanel;
            TitleText.Location = new Point(107, 1);
            TitleText.AutoSize = false;
            TitleText.Size = new Size(300, 28);
            TitleText.BackColor = Color.Transparent;
            TitleText.Font = new Font(TitleText.Font, FontStyle.Bold);
            TitleText.Text = "US-China Relations In The Years Ahead: The Trade War Is A Sideshow";

            Label AuthorText = new Label();
            AuthorText.Parent = NextPanel;
            AuthorText.Location = new Point(109, 27);
            AuthorText.AutoSize = false;
            AuthorText.Size = new Size(154, 13);
            AuthorText.BackColor = Color.Transparent;
            AuthorText.Font = new Font(AuthorText.Font, FontStyle.Regular);
            AuthorText.Text = "Tyler Durden";

            Label DescriptionText = new Label();
            DescriptionText.Parent = NextPanel;
            DescriptionText.Location = new Point(109, 51);
            DescriptionText.AutoSize = false;
            DescriptionText.Size = new Size(408, 52);
            DescriptionText.BackColor = Color.Transparent;
            DescriptionText.Font = new Font(DescriptionText.Font, FontStyle.Regular);
            DescriptionText.Text = "US-China Relations In The Years Ahead: The Trade War Is A Sideshow Authored by Michael Krieger via Liberty Blitzkrieg blog, As President Trump has said many times, we rebuilt China over the past 25 years. No truer words were spoken, but those days are over. T…";

            Label PublishedText = new Label();
            PublishedText.Parent = NextPanel;
            PublishedText.Location = new Point(373, 1);
            PublishedText.AutoSize = false;
            PublishedText.Size = new Size(154, 13);
            PublishedText.BackColor = Color.Transparent;
            PublishedText.Font = new Font(DescriptionText.Font, FontStyle.Regular);
            PublishedText.TextAlign = ContentAlignment.TopRight;
            PublishedText.Text = "2019-10-30T15:25:00Z";

            this.Controls.Add(NextPanel);
            Console.WriteLine("You should be able to see it");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
