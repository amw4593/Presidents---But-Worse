using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {

            InitializeComponent();

            this.radioButton1.Click += new EventHandler(RadioButton1__Click);
            this.radioButton2.Click += new EventHandler(RadioButton2__Click);
            this.radioButton3.Click += new EventHandler(RadioButton3__Click);
            this.radioButton4.Click += new EventHandler(RadioButton4__Click);
            this.radioButton5.Click += new EventHandler(RadioButton5__Click);
            this.radioButton6.Click += new EventHandler(RadioButton6__Click);
            this.radioButton7.Click += new EventHandler(RadioButton7__Click);
            this.radioButton8.Click += new EventHandler(RadioButton8__Click);
            this.radioButton9.Click += new EventHandler(RadioButton9__Click);
            this.radioButton10.Click += new EventHandler(RadioButton10__Click);
            this.radioButton11.Click += new EventHandler(RadioButton11__Click);
            this.radioButton12.Click += new EventHandler(RadioButton12__Click);
            this.radioButton13.Click += new EventHandler(RadioButton13__Click);
            this.radioButton14.Click += new EventHandler(RadioButton14__Click);
            this.radioButton15.Click += new EventHandler(RadioButton15__Click);
            this.radioButton16.Click += new EventHandler(RadioButton16__Click);
            this.radioButton17.Click += new EventHandler(RadioButton17__Click);
            this.radioButton18.Click += new EventHandler(RadioButton18__Click);
            this.radioButton19.Click += new EventHandler(RadioButton19__Click);
            this.radioButton20.Click += new EventHandler(RadioButton20__Click);
            this.radioButton21.Click += new EventHandler(RadioButton21__Click);


            this.button1.Click += new EventHandler(Button1__Click);

            this.timer1.Tick += new EventHandler(Timer1__Tick);

            timer1.Interval = 500;
            this.toolStripProgressBar1.Value = 100;

        }
        private void RadioButton1__Click(object sender, EventArgs e)
        {

            timer1.Start();

            string wikiUrl = "https://en.wikipedia.org/wiki/Benjamin_Harrison";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.BenjaminHarrison;
            pictureBox1.Visible = true;
        }

        private void RadioButton2__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Franklin_D._Roosevelt";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.FranklinDRoosevelt;
            pictureBox1.Visible = true;
        }

        private void RadioButton3__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/William_J._Clinton";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.WilliamJClinton;
            pictureBox1.Visible = true;
        }

        private void RadioButton4__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/James_Buchanan";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.JamesBuchanan;
            pictureBox1.Visible = true;
        }

        private void RadioButton5__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Franklin_Pierce";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.FranklinPierce;
            pictureBox1.Visible = true;

           Form newForm = new Form2();
            newForm.Show();
        }

        private void RadioButton6__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Geroge_W._Bush";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.GeorgeWBush;
            pictureBox1.Visible = true;
        }

        private void RadioButton7__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Barack_Obama";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.BarackObama;
            pictureBox1.Visible = true;
        }

        private void RadioButton8__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Barack_Obama";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.JohnFKennedy;
            pictureBox1.Visible = true;
        }

        private void RadioButton9__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/William_McKinley";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.GeorgeWashington;
            pictureBox1.Visible = true;
        }

        private void RadioButton10__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/John_F._Kennedy";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.WilliamMcKinley;
            pictureBox1.Visible = true;
        }

        private void RadioButton11__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Dwight_D._Eisenhower";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.DwightDEisenhower;
            pictureBox1.Visible = true;
        }

        private void RadioButton12__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Martin_VanBuren";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.MartinVanBuren;
            pictureBox1.Visible = true;
        }

        private void RadioButton13__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Geroge_Washington";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.GeorgeWashington;
            pictureBox1.Visible = true;
        }

        private void RadioButton14__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/George_Washington";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.GeorgeWashington;
            pictureBox1.Visible = true;
        }

        private void RadioButton15__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Thomas_Jefferson";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.JohnAdams;
            pictureBox1.Visible = true;
        }

        private void RadioButton16__Click(object sender, EventArgs e)
        {
            string wikiUrl = "https://en.wikipedia.org/wiki/Theodore_Jefferson";
            webBrowser1.Navigate(wikiUrl);
            pictureBox1.Image = Properties.Resources.ThomasJefferson;
            pictureBox1.Visible = true;
        }

        private void RadioButton17__Click(object sender, EventArgs e)
        {
            List<RadioButton> buttonsToHide = new List<RadioButton>()
            {
    };
            foreach (RadioButton button in this.Controls.OfType<RadioButton>())
            {
                if (buttonsToHide.Contains(button))
                {
                    button.Visible = false;
                }
                else
                {
                    button.Visible = true;
                }
            }
        }


        private void RadioButton18__Click(object sender, EventArgs e)
        {
            List<RadioButton> buttonsToHide = new List<RadioButton>()
            {
        radioButton1,
        radioButton6,
        radioButton7,
        radioButton8,
        radioButton12
    };
            foreach (RadioButton button in this.Controls.OfType<RadioButton>())
            {
                if (buttonsToHide.Contains(button))
                {
                    button.Visible = false;
                }
                else
                {
                    button.Visible = true;
                }
            }
        }
        private void RadioButton19__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RadioButton20__Click(object sender, EventArgs e)
        {
            Form newForm2 = new Form3();
            newForm2.Show();
            List<RadioButton> buttonsToHide = new List<RadioButton>()
            {
        radioButton1,
        radioButton2,
        radioButton3,
        radioButton4,
        radioButton5,
        radioButton6,
        radioButton7,
        radioButton8,
        radioButton9,
        radioButton10,
        radioButton11,
        radioButton12,
        radioButton13,
        radioButton14,
        radioButton15, 
        radioButton16
    };
            foreach (RadioButton button in this.Controls.OfType<RadioButton>())
            {
                if (buttonsToHide.Contains(button))
                {
                    button.Visible = false;
                }
                else
                {
                    button.Visible = true;
                }
            }
        }

    private void RadioButton21__Click(object sender, EventArgs e)
        {
            List<RadioButton> buttonsToHide = new List<RadioButton>()
    {
        radioButton1,
        radioButton2,
        radioButton3,
        radioButton4,
        radioButton5,
        radioButton6,
        radioButton7,
        radioButton8,
        radioButton9,
        radioButton10,
        radioButton11,
        radioButton12,
        radioButton15,
        radioButton16
    };

            foreach (RadioButton button in this.Controls.OfType<RadioButton>())
            {
                if (buttonsToHide.Contains(button))
                {
                    button.Visible = false;
                }
                else
                {
                    button.Visible = true;
                }
            }
        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Value = 100;
            --this.toolStripProgressBar1.Value;

            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer1.Stop();
                Application.Exit();
            }
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
