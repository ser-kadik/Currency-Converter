using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Конвертор_валют
{
    public partial class Form1 : Form
    {
        bool drag = false;
        int first_currency = 0;
        int second_currency = 0;
        bool first_currency_bool;
        bool second_currency_bool;
        Point StartPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }
        void Convert()
        {
            
            try
            {
                switch (first_currency)
                {
                    case 0:
                        {
                            switch (second_currency)
                            {
                                case 0:
                                    {
                                        result_label.Text = "Неверные валюты";
                                        break;
                                    }

                                case 1:
                                    {
                                        
                                         result_label.Text = int.Parse(Write_Box.Text) * 0.92 + "";
                                        
                                        break;
                                    }

                                case 2:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 7.22 + "";

                                        break;
                                    }

                                case 3:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 90.89 + "";

                                        break;
                                    }

                                case 4:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 3.27 + "";

                                        break;
                                    }

                                case 5:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 444.60 + "";

                                        break;
                                    }
                            }
                        }



                        break;

                    case 1:
                        {
                            switch (second_currency)
                            {
                                case 0:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 1.09 + "";

                                        break;
                                    }

                                case 1:
                                    {

                                        result_label.Text = "Неверные валюты";
                                        break;
                                    }

                                case 2:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 7.85 + "";

                                        break;
                                    }

                                case 3:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 98.82 + "";

                                        break;
                                    }

                                case 4:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 3.48 + "";

                                        break;
                                    }

                                case 5:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 483.39 + "";

                                        break;
                                    }
                            }
                            break;
                        }

                    case 2:
                        {
                            switch (second_currency)
                            {
                                case 0:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.14 + "";

                                        break;
                                    }

                                case 1:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 0.13 + "";

                                        break;
                                    }

                                case 2:
                                    {

                                        result_label.Text = "Неверные валюты";
                                        break;
                                    }

                                case 3:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 12.83 + "";

                                        break;
                                    }

                                case 4:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 0.45 + "";

                                        break;
                                    }

                                case 5:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 61.54 + "";

                                        break;
                                    }
                            }
                            break;
                        }

                    case 3:
                        {
                            switch (second_currency)
                            {
                                case 0:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.011 + "";

                                        break;
                                    }

                                case 1:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 0.010 + "";

                                        break;
                                    }

                                case 2:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.079 + "";

                                        break;

                                    }

                                case 3:
                                    {

                                        result_label.Text = "Неверные валюты";
                                        break;
                                    }

                                case 4:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 0.036 + "";

                                        break;
                                    }

                                case 5:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 4.89 + "";

                                        break;
                                    }
                            }
                            break;
                        }

                    case 4:
                        {
                            switch (second_currency)
                            {
                                case 0:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.31 + "";

                                        break;
                                    }

                                case 1:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 0.28 + "";

                                        break;
                                    }

                                case 2:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 2.21 + "";

                                        break;

                                    }

                                case 3:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 27.78 + "";

                                        break;
                                    }

                                case 4:
                                    {

                                        result_label.Text = "Неверные валюты";
                                        break;
                                    }

                                case 5:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 135.60 + "";

                                        break;
                                    }
                            }
                            break;
                        }

                    case 5:
                        {
                            switch (second_currency)
                            {
                                case 0:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.0022 + "";

                                        break;
                                    }

                                case 1:
                                    {

                                        result_label.Text = int.Parse(Write_Box.Text) * 0.0021 + "";

                                        break;
                                    }

                                case 2:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.016 + "";

                                        break;

                                    }

                                case 3:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.20 + "";

                                        break;
                                    }

                                case 4:
                                    {
                                        result_label.Text = int.Parse(Write_Box.Text) * 0.0074 + "";

                                        break;
                                    }

                                case 5:
                                    {

                                        result_label.Text = "Неверные валюты";
                                        break;
                                    }
                            }
                            break;
                        }


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void ControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void ControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }


        private void ControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void exit_btn_MouseEnter(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Salmon;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.White;
        }

        private void minimize_btn_MouseEnter(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.SteelBlue;
        }

        private void minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.White;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void animation_currency0_Tick(object sender, EventArgs e)
        {
            if (first_currency_bool == false)
            {
                first_panel.Height += 10;
                if (first_panel.Height == first_panel.MaximumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = true;
                    first_btn.Text = "First currency       🡹";
                }
            }

            else if (first_currency == 0)
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "Dollars               USD";
                }
            }

            else if (first_currency == 1)
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "Euro                   EUR";
                }
            }

            else if (first_currency == 2)
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "Yuan                  CNY";
                }
            }

            else if (first_currency == 3)
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "Rubls                 RUB";
                }
            }

            else if (first_currency == 4)
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "Belorusian rubls  BYN";
                }
            }

            else if (first_currency == 5)
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "Tenge                 KZT";
                }
            }

            else
            {
                first_panel.Height -= 10;
                if (first_panel.Height == first_panel.MinimumSize.Height)
                {
                    animation_currency0.Enabled = false;
                    first_currency_bool = false;
                    first_btn.Text = "First currency       🡻";
                }
            }
        }

        private void animation_currency1_Tick(object sender, EventArgs e)
        {
            if (second_currency_bool == false)
            {
                second_panel.Height += 10;
                if (second_panel.Height == second_panel.MaximumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = true;
                    second_btn.Text = "Second currency  🡹";
                }
            }

            else if (second_currency == 0)
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Dollars               USD";
                }
            }

            else if (second_currency == 1)
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Euro                   EUR";
                }
            }

            else if (second_currency == 2)
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Yuan                  CNY";
                }
            }

            else if (second_currency == 3)
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Rubls                 RUB";
                }
            }

            else if (second_currency == 4)
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Belorusian rubls  BYN";
                }
            }

            else if (second_currency == 5)
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Tenge                 KZT";
                }
            }

            else
            {
                second_panel.Height -= 10;
                if (second_panel.Height == second_panel.MinimumSize.Height)
                {
                    animation_currency1.Enabled = false;
                    second_currency_bool = false;
                    second_btn.Text = "Second currency  🡻";
                }
            }
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
        }

        private void second_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
        }

        private void usd_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
            first_currency = 0;
        }

        private void eur_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
            first_currency = 1;
        }

        private void cny_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
            first_currency = 2;
        }

        private void rub_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
            first_currency = 3;
        }

        private void byn_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
            first_currency = 4;
        }

        private void kzt_btn_Click(object sender, EventArgs e)
        {
            animation_currency0.Enabled = true;
            first_currency = 5;
        }

        private void usd1_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
            second_currency = 0;
        }

        private void eur1_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
            second_currency = 1;
        }

        private void cny1_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
            second_currency = 2;
        }

        private void rub1_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
            second_currency = 3;
        }

        private void byn1_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
            second_currency = 4;
        }

        private void kzt1_btn_Click(object sender, EventArgs e)
        {
            animation_currency1.Enabled = true;
            second_currency = 5;
        }
    }
}
