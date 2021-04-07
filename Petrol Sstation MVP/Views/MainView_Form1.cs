using Petrol_Station_MVP.Models;
using Petrol_Station_MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Station_MVP
{
    public partial class MainView_Form1 : Form, IMainView
    {
        public MainView_Form1()
        {
            InitializeComponent();
        }

        public string GasolineText { get => Gasolineguna2ComboBox1.Text; set => Gasolineguna2ComboBox1.Text=value; }
        public string PriceText { get => Priceguna2TextBox1.Text; set => Priceguna2TextBox1.Text = value; }
        public string ByGallonText { get => ByGallonguna2TextBox1.Text; set => ByGallonguna2TextBox1.Text = value; }
        public string ByCashText { get => ByCashguna2TextBox2.Text; set => ByCashguna2TextBox2.Text = value; }
        public string ResultPrice { get => Result1guna2HtmlLabel1.Text; set => Result1guna2HtmlLabel1.Text =value; }
  




        public List<PetrolStation> PetrolStations { set 
            
            {

                datalistBox1.DataSource = null;
                datalistBox1.DataSource = value;


            }
        
        }


        public EventHandler<EventArgs> CalculateButtonClicked { get; set; }

        decimal r = 0;
        decimal g = 0;
        decimal a = 0;


        private void Calculate()
        {

            if (ByGallonguna2CustomRadioButton2.Enabled == true)
            {
                if (Gasolineguna2ComboBox1.Text == "A-92")
                {

                    if (ByGallonguna2CustomRadioButton2.Checked == true)
                    {

                        guna2HtmlLabel1.Show();
                        guna2HtmlLabel2.Hide();

                        if (ByGallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(ByGallonguna2TextBox1.Text);

                            r = g * 0.7m;
                        }
                        else
                        {
                            r = 0;
                        }

                    }


                }

                if (Gasolineguna2ComboBox1.Text == "A-95")
                {


                    if (ByGallonguna2CustomRadioButton2.Checked == true)
                    {
                        guna2HtmlLabel1.Show();
                        guna2HtmlLabel2.Hide();

                        if (ByGallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(ByGallonguna2TextBox1.Text);

                            r = g * 0.9m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }



                }

                if (Gasolineguna2ComboBox1.Text == "A-98")
                {


                    if (ByGallonguna2CustomRadioButton2.Checked == true)
                    {
                        guna2HtmlLabel1.Show();
                        guna2HtmlLabel2.Hide();

                        if (ByGallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(ByGallonguna2TextBox1.Text);

                            r = g * 1m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Diesel")
                {


                    if (ByGallonguna2CustomRadioButton2.Checked == true)
                    {
                        guna2HtmlLabel1.Show();
                        guna2HtmlLabel2.Hide();

                        if (ByGallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(ByGallonguna2TextBox1.Text);

                            r = g * 0.8m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Gas")
                {


                    if (ByGallonguna2CustomRadioButton2.Checked == true)
                    {
                        guna2HtmlLabel1.Show();
                        guna2HtmlLabel2.Hide();

                        if (ByGallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(ByGallonguna2TextBox1.Text);

                            r = g * 0.5m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }
                Result1guna2HtmlLabel1.Text = $"{r}";
            }

            if (ByCashguna2CustomRadioButton1.Enabled == true)
            {
                if (Gasolineguna2ComboBox1.Text == "A-92")
                {

                    if (ByCashguna2CustomRadioButton1.Checked == true)
                    {
                        guna2HtmlLabel1.Hide();
                        guna2HtmlLabel2.Show();
                        if (ByCashguna2TextBox2.Text != "")
                        {
                            a = decimal.Parse(ByCashguna2TextBox2.Text);

                            r = a / 0.7m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "A-95")
                {

                    if (ByCashguna2CustomRadioButton1.Checked == true)
                    {
                        guna2HtmlLabel1.Hide();
                        guna2HtmlLabel2.Show();
                        if (ByCashguna2TextBox2.Text != "")
                        {
                            a = decimal.Parse(ByCashguna2TextBox2.Text);

                            r = a / 0.9m;
                        }
                        else
                        {
                            r = 0;
                        }

                    }


                }

                if (Gasolineguna2ComboBox1.Text == "A-98")
                {

                    if (ByCashguna2CustomRadioButton1.Checked == true)
                    {
                        guna2HtmlLabel1.Hide();
                        guna2HtmlLabel2.Show();
                        if (ByCashguna2TextBox2.Text != "")
                        {
                            a = decimal.Parse(ByCashguna2TextBox2.Text);

                            r = a / 1m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Diesel")
                {

                    if (ByCashguna2CustomRadioButton1.Checked == true)
                    {
                        guna2HtmlLabel1.Hide();
                        guna2HtmlLabel2.Show();
                        if (ByCashguna2TextBox2.Text != "")
                        {
                            a = decimal.Parse(ByCashguna2TextBox2.Text);

                            r = a / 0.8m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Gas")
                {

                    if (ByCashguna2CustomRadioButton1.Checked == true)
                    {
                        guna2HtmlLabel1.Hide();
                        guna2HtmlLabel2.Show();
                        if (ByCashguna2TextBox2.Text != "")
                        {
                            a = decimal.Parse(ByCashguna2TextBox2.Text);

                            r = a / 0.5m;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

            }


            r = (decimal)Math.Round(r, 2);

            Result1guna2HtmlLabel1.Text = r.ToString();
        }


        private void Calculateguna2CircleButton1_Click(object sender, EventArgs e)
        {

            Calculate();

            

            CalculateButtonClicked.Invoke(sender, e);


        }

        decimal A92price = 0.7M;
        decimal A95price = 0.9M;
        decimal A98price = 1.0M;
        decimal Diesel = 0.8M;
        decimal Gas = 0.5M;

        private void Gasolineguna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Gasolineguna2ComboBox1.Text == "A-92")
            {

                Priceguna2TextBox1.Text = $" {A92price} €";
                ByCashguna2CustomRadioButton1.Enabled = true;
                ByGallonguna2CustomRadioButton2.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "A-95")
            {

                Priceguna2TextBox1.Text = $" {A95price} €";
                ByCashguna2CustomRadioButton1.Enabled = true;
                ByGallonguna2CustomRadioButton2.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "A-98")
            {

                Priceguna2TextBox1.Text = $" {A98price} €";
                ByCashguna2CustomRadioButton1.Enabled = true;
                ByGallonguna2CustomRadioButton2.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "Diesel")
            {

                Priceguna2TextBox1.Text = $" {Diesel} €";
                ByCashguna2CustomRadioButton1.Enabled = true;
                ByGallonguna2CustomRadioButton2.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "Gas")
            {

                Priceguna2TextBox1.Text = $" {Gas} €";
                ByCashguna2CustomRadioButton1.Enabled = true;
                ByGallonguna2CustomRadioButton2.Enabled = true;
            }
        }

        private void ByGallonguna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void ByCashguna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }



    
        private void ByGallonguna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ByGallonguna2CustomRadioButton2.Checked)
            {
                ByCashguna2TextBox2.Enabled = false;
                if (ByCashguna2CustomRadioButton1.Checked == false)
                {
                    ByGallonguna2TextBox1.Enabled = true;
                    if (ByCashguna2TextBox2.Text != "")
                    {
                        ByCashguna2TextBox2.Clear();
      
                    }
                }
            }

            if (ByCashguna2CustomRadioButton1.Checked)
            {
                ByGallonguna2TextBox1.Enabled = false;
                if (ByGallonguna2CustomRadioButton2.Checked == false)
                {
                    ByCashguna2TextBox2.Enabled = true;
                    if (ByGallonguna2TextBox1.Text != "")
                    {
                        ByGallonguna2TextBox1.Clear();
                     
                    }
                }
            }
        }

        private void MainView_Form1_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Hide();
        }
    }
}
