using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LedCube
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        SerialPort port;
        bool running, elindult, init = false;
        public byte eleje = 0;
        public bool irany = true;
        public static byte loe = 8;
        RGB_Led[,,] Cube = new RGB_Led[loe, loe, loe];
        Random rnd = new Random();
        byte[] buffer = new byte[loe * loe * loe * 3 + 1];
        byte sor = 0;
        byte kr = 50;
        int ah = 0;
        int fh = 7;
        byte r1, g1, b1 = 0;
        string Szoveg = "#SZIA!GYEREAKANDOBA!#KOD:0 0 6 0 ";
        int szovegpoz = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            int algo = 5;
            int b = 1;
            if (algo == 5)
            {
                byte red = 0;
                byte green = 0;
                byte blue = 255;
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        for (int z = 0; z < 8; z++)
                        {
                            if (x>=3 && x<=4&&y>=3 && y<=4&&z>=3 &&z<=4)
                                Cube[loe - x - 1, loe - y - 1, z].Led.Fill = new SolidColorBrush(Color.FromArgb(160, red, green, blue));
                        }
                    }
                }
            }
            if (algo == 1)
            {
                int k = 0;
                if (irany) eleje++; else eleje--;
                byte oszto = 1;
                for (int y = 0; y < loe; y++)
                {
                    for (int x = 0; x < loe; x++)
                    {
                        for (int z = 0; z < loe; z++)
                        {
                            byte red, green, blue = 0;
                            red = Convert.ToByte(k / 2 / oszto);
                            if (red == 1) red = 2;
                            green = Convert.ToByte((255 - eleje) / oszto);
                            if (green == 1) green = 2;
                            if (Convert.ToByte(k / 2) + eleje <= 255)
                                blue = Convert.ToByte(eleje / oszto);
                            else
                                blue = Convert.ToByte(Math.Abs((255 - (k / 2 + eleje)) / oszto));
                            if (blue == 1) blue = 2;
                            if (x % 2 == 0)
                            {
                                Cube[loe - x - 1, loe - y - 1, z].Led.Fill = new SolidColorBrush(Color.FromArgb(160, red, green, blue));
                                Cube[loe - x - 1, loe - y - 1, z].Led.Width = 35;
                            }
                            else
                            {
                                Cube[loe - x - 1, loe - y - 1, loe - z - 1].Led.Fill = new SolidColorBrush(Color.FromArgb(160, red, green, blue));
                                Cube[loe - x - 1, loe - y - 1, z].Led.Height = 35;
                            }

                            RGB_Colors rgb_colors = new RGB_Colors(red, green, blue);
                            Cube[z, x, y].RGBcolors = rgb_colors;
                            buffer[b++] = red;
                            buffer[b++] = green;
                            buffer[b++] = blue;
                            k++;
                        }
                    }
                }
                int ledszam = loe * loe * loe * 3 + 1;
                //port.Write(buffer, 0, ledszam);
                szorzat.Text = ledszam.ToString();
                if (eleje == 255) irany = false;
                if (eleje == 0) irany = true;
            }
            if (algo == 2)
            {
                for (int y = 0; y < loe; y++)
                {
                    byte red2 = Convert.ToByte(rnd.Next(0, 1));
                    byte green2 = Convert.ToByte(rnd.Next(0, 1));
                    byte blue2 = Convert.ToByte(rnd.Next(0, 1));
                    for (int z = 0; z < loe; z++)
                    {
                        for (int x = 0; x < loe; x++)
                        {
                            byte red = Convert.ToByte(0 + kr);
                            byte green = Convert.ToByte(0);
                            byte blue = Convert.ToByte(0);
                            if (y == sor)
                            {
                                Cube[loe - x - 1, loe - y - 1, z].Led.Fill = new SolidColorBrush(Color.FromArgb(160, red, green, blue));
                                buffer[b++] = red;
                                buffer[b++] = green;
                                buffer[b++] = blue;
                            }
                            else
                            {
                                Cube[loe - x - 1, loe - y - 1, z].Led.Fill = new SolidColorBrush(Color.FromArgb(160, red2, green2, blue2));
                                buffer[b++] = red2;
                                buffer[b++] = green2;
                                buffer[b++] = blue2;
                            }
                        }
                    }
                }
                int ledszam = loe * loe * loe * 3 + 1;
                //port.Write(buffer, 0, ledszam);
                if (sor == loe - 1 || sor == 0) { irany = !irany; kr++; }
                if (irany) sor--; else sor++;
                System.Threading.Thread.Sleep(50);
            }
            if (algo == 3)
            {
                ah = 0 + sor;
                fh = 7 - sor;
                for (int y = 0; y < loe; y++)
                {
                    byte red = r1;
                    byte green = g1;
                    byte blue = b1;
                    for (int z = 0; z < loe; z++)
                    {
                        for (int x = 0; x < loe; x++)
                        {
                            //if ((x >= ah && x <= fh) && (y >= ah && y <= fh) && (z >= ah && z <= fh))
                            if ((x == ah || x == fh) && (y >= ah && y <= fh) && (z >= ah && z <= fh) || (x >= ah && x <= fh) && (y == ah || y == fh) && (z >= ah && z <= fh) || (x >= ah && x <= fh) && (y >= ah && y <= fh) && (z == ah || z == fh))
                            {
                                Cube[loe - x - 1, loe - y - 1, z].Led.Fill = new SolidColorBrush(Color.FromArgb(160, red, green, blue));
                                buffer[b++] = red;
                                buffer[b++] = green;
                                buffer[b++] = blue;
                            }
                            else
                            {
                                Cube[loe - x - 1, loe - y - 1, z].Led.Fill = new SolidColorBrush(Color.FromArgb(10, 0, 0, 0));
                                buffer[b++] = 0;
                                buffer[b++] = 0;
                                buffer[b++] = 0;
                            }
                        }
                    }
                }
                int ledszam = loe * loe * loe * 3 + 1;
                //port.Write(buffer, 0, ledszam);
                if (sor == 4 || sor == 0)
                {
                    irany = !irany;
                    if (irany)
                    {
                        r1 = Convert.ToByte(rnd.Next(0, 256));
                        g1 = Convert.ToByte(rnd.Next(0, 256));
                        b1 = Convert.ToByte(rnd.Next(0, 256));
                    }
                }
                if (irany)
                {
                    sor--;
                }
                else
                {
                    sor++;
                }
                System.Threading.Thread.Sleep(100);
            }
            if (algo == 4)
            {
                Szoveg = "$$$KELLEMES KAR[CSONYI ]NNEPEKET!$";
                byte red = Convert.ToByte(rnd.Next(100, 200));
                byte green = Convert.ToByte(rnd.Next(100, 200));
                byte blue = Convert.ToByte(rnd.Next(100, 200));
                int y, z, poz = 0;
                int sleepTime = 20;
                if (Szoveg[szovegpoz] == 32)
                {
                    sleepTime = 5;
                }
                if (Szoveg[szovegpoz] == 35)
                {
                    red = 244;
                    green = 98;
                    blue = 98;
                    sleepTime = 5;
                }
                if (Szoveg[szovegpoz] == 36)
                {
                    red = 98;
                    green = 254;
                    blue = 98;
                    sleepTime = 5;
                }
                byte[,] kMatrix = Karakterek.karakterToMatrix(Szoveg[szovegpoz]);
                for (int x = 0; x < 8; x++)
                {
                    for (int m = 0; m < 8; m++)
                    {
                        for (int n = 0; n < 8; n++)
                        {
                            //z = (7 - x) * 64;
                            //y = (m) * 8;
                            z = (7 - m) * 64;
                            y = (x) * 8;
                            if (x % 2 == 1) poz = z + y + 7 - n; else poz = z + y + n;
                            if (x == sor && kMatrix[m, n] == '1')
                            {
                                if (Szoveg[szovegpoz] == 36 && m == 0)
                                {
                                    Cube[n, m, 7 - x].Led.Fill = new SolidColorBrush(Color.FromArgb(255, 254, 0, 0));
                                    buffer[(poz) * 3 + 1] = Convert.ToByte(44);
                                    buffer[(poz) * 3 + 2] = Convert.ToByte(0);
                                    buffer[(poz) * 3 + 3] = Convert.ToByte(0);
                                }
                                else
                                {
                                    Cube[n, m, 7 - x].Led.Fill = new SolidColorBrush(Color.FromArgb(255, red, green, blue));
                                    buffer[(poz) * 3 + 1] = Convert.ToByte(red - 95);
                                    buffer[(poz) * 3 + 2] = Convert.ToByte(green - 95);
                                    buffer[(poz) * 3 + 3] = Convert.ToByte(blue - 95);
                                }
                            }
                            else
                            {
                                if (true)
                                {
                                    Cube[n, m, 7 - x].Led.Fill = new SolidColorBrush(Color.FromArgb(12, 0, 0, 0));
                                    buffer[(poz) * 3 + 1] = 0;
                                    buffer[(poz) * 3 + 2] = 0;
                                    buffer[(poz) * 3 + 3] = 0;
                                }
                            }
                        }
                    }
                }
                if (sor == 7 || sor == 0)
                {
                    irany = !irany;
                }
                if (sor == 0) szovegpoz++;

                if (szovegpoz == Szoveg.Length) szovegpoz = 0;

                if (irany) sor--; else sor++;
                int ledszam = loe * loe * loe * 3 + 1;
                //port.Write(buffer, 0, ledszam);
                System.Threading.Thread.Sleep(sleepTime);
            }
        }

        public MainWindow()
        {
            int[] portSpeed = new int[4] { 115200, 250000, 500000, 1000000 };
            buffer[0] = 1;
            InitializeComponent();
            PortName.ItemsSource = SerialPort.GetPortNames();
            Speed.ItemsSource = portSpeed;
            Speed.SelectedIndex = 2;
            if (PortName.Items.Count > 0)
            {
                PortName.SelectedIndex = 0;
            }
            init = true;
            int k = 0;
            buffer[0] = 1;
            for (int x = 0; x < loe; x++)
            {
                for (int y = 0; y < loe; y++)
                {
                    for (int z = 0; z < loe; z++)
                    {
                        Cube[x, y, z] = new RGB_Led(255, 255, 255);
                        Canvas.SetLeft(Cube[x, y, z].Led, 120 + x * 50 - z * 20);
                        Canvas.SetTop(Cube[x, y, z].Led, 10 + y * 50 + z * 20);
                        canvas1.Children.Add(Cube[x, y, z].Led);
                        k++;
                        buffer[x * 7 + y * 7 + z * 7 + 1] = 0;
                    }
                }
            }
            //port.Write(buffer, 0, loe * loe * loe * 3 + 1);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
        }

        private void portSettings(string portnev, int sebesseg)
        {
            if (elindult || init) port.Close();
            port = new SerialPort(portnev, sebesseg);
            //port.Open();
        }

        private void PortName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            portSettings(PortName.SelectedItem.ToString(), Convert.ToInt32(Speed.SelectedItem.ToString()));
        }

        private void Speed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (init) portSettings(PortName.SelectedItem.ToString(), Convert.ToInt32(Speed.SelectedItem.ToString()));
        }

        private void Start_Stop_Click(object sender, RoutedEventArgs e)
        {
            elindult = true;
            if (running)
            {
                timer.Stop();
                Start_Stop.Content = "Start";
            }
            else
            {
                timer.Start();
                Start_Stop.Content = "Stop";
            }
            running = !running;
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Math.Pow(loe, 3) * 3; i++)
            {
                buffer[i + 1] = 0;
            }
            //port.Write(buffer, 0, 1537);
            System.Threading.Thread.Sleep(100);
            port.Close();
            this.Close();
        }
    }
}
