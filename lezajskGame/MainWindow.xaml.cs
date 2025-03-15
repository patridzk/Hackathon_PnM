using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Windows.Xps.Packaging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lezajskGame;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    bool poziom1_unlocked = true;
    bool poziom1_done = false;

    bool poziom2_unlocked = false;
    bool poziom2_done = false;

    bool poziom3_unlocked = false;
    bool poziom3_done = false;

    bool poziom4_unlocked = false;
    bool poziom4_done = false;

    bool poziom5_unlocked = false;
    bool poziom5_done = false;

    bool poziom6_unlocked = false;
    bool poziom6_done = false;

    bool poziom7_unlocked = false;
    bool poziom7_done = false;

    bool poziom8_unlocked = false;
    bool poziom8_done = false;

    bool tal1_owned = false;
    bool tal2_owned = false;
    bool tal3_owned = false;
    bool tal4_owned = false;
    bool tal5_owned = false;

    int mcHP1 = 100;
    int mcHP2 = 100;
    int mcHP3 = 100;
    int mcHP4 = 100;
    int mcHP5 = 100;
    int mcHP6 = 100;
    int mcHP7 = 100;
    int mcHP8 = 100;
    int opp1HP = 100;
    int opp2HP = 100;
    int opp3HP = 100;
    int opp4HP = 100;
    int opp5HP = 100;
    int opp6HP = 100;
    int opp7HP = 100;
    int opp8HP = 100;
    int scyzorykDMG = 10;
    int nozyczkiDMG = 5;
    private void Rozumiem(object sender, RoutedEventArgs e)
    {
        Disclaimer.Visibility = Visibility.Collapsed;
        MainMenu.Visibility = Visibility.Visible;
    }
    private void Exit(object sender, RoutedEventArgs e)
    {
        Close();
    }
    private void backToMenu(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        MainMenu.Visibility = Visibility.Visible;
    }
    private void start(object sender, RoutedEventArgs e)
    {
        MainMenu.Visibility = Visibility.Collapsed;
        mapa.Visibility = Visibility.Visible;
        poziom1.Background = new SolidColorBrush(Colors.Yellow);
        poziom2.Background = new SolidColorBrush(Colors.Red);
        poziom3.Background = new SolidColorBrush(Colors.Red);
        poziom4.Background = new SolidColorBrush(Colors.Red);
        poziom5.Background = new SolidColorBrush(Colors.Red);
        poziom6.Background = new SolidColorBrush(Colors.Red);
        poziom7.Background = new SolidColorBrush(Colors.Red);
        poziom8.Background = new SolidColorBrush(Colors.Red);
        tal5.Source = new BitmapImage(new Uri("/sosostryKludka.png", UriKind.Relative));
        tal4.Source = new BitmapImage(new Uri("/soslagodnyKludka.png", UriKind.Relative));
        tal3.Source = new BitmapImage(new Uri("/makapakaakatortillaKludka.png", UriKind.Relative));
        tal2.Source = new BitmapImage(new Uri("/kapuchaKludka.png", UriKind.Relative));
        tal1.Source = new BitmapImage(new Uri("/kulaMocyKludka.png", UriKind.Relative));
    }
    private void backToMap()
    {
        lvl1.Visibility = Visibility.Collapsed;
        lvl2.Visibility = Visibility.Collapsed;
        lvl3.Visibility = Visibility.Collapsed;
        lvl4.Visibility = Visibility.Collapsed;
        lvl5.Visibility = Visibility.Collapsed;
        lvl6.Visibility = Visibility.Collapsed;
        lvl7.Visibility = Visibility.Collapsed;
        lvl8.Visibility = Visibility.Collapsed;

        mapa.Visibility = Visibility.Visible;

        if (!poziom1_unlocked)
        {
            poziom1.Background = new SolidColorBrush(Colors.Red);
        }
        else if(poziom1_unlocked && !poziom1_done)
        {
            poziom1.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom1_unlocked && poziom1_done)
        {
            poziom1.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom2_unlocked)
        {
            poziom2.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom2_unlocked && !poziom2_done)
        {
            poziom2.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom2_unlocked && poziom2_done)
        {
            poziom2.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom3_unlocked)
        {
            poziom3.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom3_unlocked && !poziom3_done)
        {
            poziom3.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom3_unlocked && poziom3_done)
        {
            poziom3.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom4_unlocked)
        {
            poziom4.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom4_unlocked && !poziom4_done)
        {
            poziom4.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom4_unlocked && poziom4_done)
        {
            poziom4.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom5_unlocked)
        {
            poziom5.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom5_unlocked && !poziom5_done)
        {
            poziom5.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom5_unlocked && poziom5_done)
        {
            poziom5.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom6_unlocked)
        {
            poziom6.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom6_unlocked && !poziom6_done)
        {
            poziom6.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom6_unlocked && poziom6_done)
        {
            poziom6.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom7_unlocked)
        {
            poziom7.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom7_unlocked && !poziom7_done)
        {
            poziom7.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom7_unlocked && poziom7_done)
        {
            poziom7.Background = new SolidColorBrush(Colors.Green);
        }

        if (!poziom8_unlocked)
        {
            poziom8.Background = new SolidColorBrush(Colors.Red);
        }
        else if (poziom8_unlocked && !poziom8_done)
        {
            poziom8.Background = new SolidColorBrush(Colors.Yellow);
        }
        else if (poziom8_unlocked && poziom8_done)
        {
            poziom8.Background = new SolidColorBrush(Colors.Green);
        }

        if (!tal1_owned)
        {
            tal1.Source = new BitmapImage(new Uri("/kulamocyKludka.png", UriKind.Relative));
        }
        else
        {
            tal1.Source = new BitmapImage(new Uri("/kulamocy.png", UriKind.Relative));
        }

        if (!tal2_owned)
        {
            tal2.Source = new BitmapImage(new Uri("/kapuchaKludka.png", UriKind.Relative));
        }
        else
        {
            tal2.Source = new BitmapImage(new Uri("/kapucha.png", UriKind.Relative));
        }

        if (!tal3_owned)
        {
            tal3.Source = new BitmapImage(new Uri("/makapakaakatortillaKludka.png", UriKind.Relative));
        }
        else
        {
            tal3.Source = new BitmapImage(new Uri("/makapakaakatortilla.png", UriKind.Relative));
        }

        if (!tal4_owned)
        {
            tal4.Source = new BitmapImage(new Uri("/soslagodnyKludka.png", UriKind.Relative));
        }
        else
        {
            tal4.Source = new BitmapImage(new Uri("/soslagodny.png", UriKind.Relative));
        }

        if (!tal5_owned)
        {
            tal5.Source = new BitmapImage(new Uri("/sosostryKludka.png", UriKind.Relative));
        }
        else
        {
            tal5.Source = new BitmapImage(new Uri("/sosostry.png", UriKind.Relative));
        }
    }
    private void poz1(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl1.Visibility = Visibility.Visible;
        hieronimHP1.Text = mcHP1.ToString();
        ochroniarzHP.Text = opp1HP.ToString();
    }
    private void scyzoryk1(object sender, RoutedEventArgs e)
    {
        ochroniarzHP.Text = opp1HP.ToString();
        Random rnd1 = new Random();
        int losScyz1 = rnd1.Next(1, 1000);
        if(losScyz1 <= 700)
        {
            scyzDmgShow1.Visibility = Visibility.Visible;
            opp1HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow1.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp1HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom1_done = true;
                poziom2_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow1.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow1.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg1 = new Random();
        int cygLos1 = cyg1.Next(1, 1000);
        if(cygLos1 <= 300)
        {
            mcHP1 -= 10;
            hieronimHP1.Text = mcHP1.ToString();
        }
            
    }
    private void nozyczki1(object sender, RoutedEventArgs e)
    {
        ochroniarzHP.Text = opp1HP.ToString();
        Random rnd1 = new Random();
        int losnozy1 = rnd1.Next(1, 1000);
        if (losnozy1 <= 900)
        {
            nozyczDmgShow1.Visibility = Visibility.Visible;
            opp1HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow1.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp1HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom1_done = true;
                poziom2_unlocked = true;
                backToMap();
            }
        }
        else
        {
            nozyczMissShow1.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow1.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg1 = new Random();
        int cygLos1 = cyg1.Next(1, 1000);
        if (cygLos1 <= 300)
        {
            mcHP1 -= 10;
        }

    }
    private void poz2(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl2.Visibility = Visibility.Visible;
        hieronimHP2.Text = mcHP2.ToString();
        Turek2HP.Text = opp2HP.ToString();
    }
    private void scyzoryk2(object sender, RoutedEventArgs e)
    {
        Turek1HP.Text = opp2HP.ToString();
        Random rnd2 = new Random();
        int losScyz2 = rnd2.Next(1, 1000);
        if (losScyz2 <= 700)
        {
            scyzDmgShow1.Visibility = Visibility.Visible;
            opp2HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow2.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp2HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom2_done = true;
                poziom3_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow2.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow2.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg2 = new Random();
        int cygLos2 = cyg2.Next(1, 1000);
        if (cygLos2 <= 300)
        {
            mcHP2 -= 10;
        }

    }
    private void nozyczki2(object sender, RoutedEventArgs e)
    {
        Turek1HP.Text = opp2HP.ToString();
        Random rnd2 = new Random();
        int losnozy2 = rnd2.Next(1, 1000);
        if (losnozy2 <= 900)
        {
            opp2HP -= nozyczkiDMG;
            nozyczDmgShow2.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow1.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp2HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom2_done = true;
                poziom3_unlocked = true;
                backToMap();
            }
        }
        else
        {
            nozyczMissShow2.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow2.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg2 = new Random();
        int cygLos2 = cyg2.Next(1, 1000);
        if (cygLos2 <= 300)
        {
            mcHP2 -= 10;
        }
    }
    private void poz3(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl3.Visibility = Visibility.Visible;
        hieronimHP3.Text = mcHP3.ToString();
        ochroniarzHP.Text = opp3HP.ToString();
    }
    private void scyzoryk3(object sender, RoutedEventArgs e)
    {
        Turek2HP.Text = opp3HP.ToString();
        Random rnd3 = new Random();
        int losScyz3 = rnd3.Next(1, 1000);
        if (losScyz3 <= 700)
        {
            scyzDmgShow3.Visibility = Visibility.Visible;
            opp3HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow3.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp3HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom3_done = true;
                poziom4_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow3.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow3.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg3 = new Random();
        int cygLos3 = cyg3.Next(1, 1000);
        if (cygLos3 <= 300)
        {
            mcHP3 -= 10;
        }

    }
    private void nozyczki3(object sender, RoutedEventArgs e)
    {
        Turek2HP.Text = opp3HP.ToString();
        Random rnd3 = new Random();
        int losnozy3 = rnd3.Next(1, 1000);
        if (losnozy3 <= 900)
        {
            nozyczDmgShow3.Visibility = Visibility.Visible;
            opp3HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow3.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp3HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom3_done = true;
                poziom4_unlocked = true;
                backToMap();
            }
        }
        else
        {
            nozyczMissShow3.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow3.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg3 = new Random();
        int cygLos3 = cyg3.Next(1, 1000);
        if (cygLos3 <= 300)
        {
            mcHP3 -= 10;
        }
    }
    private void poz4(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl4.Visibility = Visibility.Visible;
        hieronimHP4.Text = mcHP4.ToString();
        Turek3HP.Text = opp4HP.ToString();
    }
    private void scyzoryk4(object sender, RoutedEventArgs e)
    {
        Turek3HP.Text = opp4HP.ToString();
        Random rnd4 = new Random();
        int losScyz4 = rnd4.Next(1, 1000);
        if (losScyz4 <= 700)
        {
            scyzDmgShow4.Visibility = Visibility.Visible;
            opp4HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow4.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp4HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom4_done = true;
                poziom5_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow4.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow4.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg4 = new Random();
        int cygLos4 = cyg4.Next(1, 1000);
        if (cygLos4 <= 300)
        {
            mcHP4 -= 10;
        }

    }
    private void nozyczki4(object sender, RoutedEventArgs e)
    {
        Turek3HP.Text = opp4HP.ToString();
        Random rnd4 = new Random();
        int losnozy4 = rnd4.Next(1, 1000);
        if (losnozy4 <= 900)
        {
            nozyczDmgShow4.Visibility = Visibility.Visible;
            opp4HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow4.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp4HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom4_done = true;
                poziom5_unlocked = true;
                backToMap();
            }
        }
        else
        {
            nozyczMissShow4.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow4.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg4 = new Random();
        int cygLos4 = cyg4.Next(1, 1000);
        if (cygLos4 <= 300)
        {
            mcHP4 -= 10;
        }
    }
    private void poz5(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl5.Visibility = Visibility.Visible;
        hieronimHP5.Text = mcHP5.ToString();
        Turek4HP.Text = opp5HP.ToString();
    }
    private void scyzoryk5(object sender, RoutedEventArgs e)
    {
        Turek4HP.Text = opp5HP.ToString();
        Random rnd5 = new Random();
        int losScyz5 = rnd5.Next(1, 1000);
        if (losScyz5 <= 700)
        {
            scyzDmgShow5.Visibility = Visibility.Visible;
            opp5HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow5.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp5HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom5_done = true;
                poziom6_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow5.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow5.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg5 = new Random();
        int cygLos5 = cyg5.Next(1, 1000);
        if (cygLos5 <= 300)
        {
            mcHP5 -= 10;
        }

    }
    private void nozyczki5(object sender, RoutedEventArgs e)
    {
        Turek4HP.Text = opp5HP.ToString();
        Random rnd5 = new Random();
        int losnozy5 = rnd5.Next(1, 1000);
        if (losnozy5 <= 900)
        {
            nozyczDmgShow5.Visibility = Visibility.Visible;
            opp5HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow5.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp5HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom5_done = true;
                poziom6_unlocked = true;
                backToMap();
            }
        }
        else
        {
            nozyczMissShow5.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow5.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg5 = new Random();
        int cygLos5 = cyg5.Next(1, 1000);
        if (cygLos5 <= 300)
        {
            mcHP5 -= 10;
        }
    }
    private void poz6(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl6.Visibility = Visibility.Visible;
        hieronimHP6.Text = mcHP6.ToString();
        Turek5HP.Text = opp6HP.ToString();
    }
    private void scyzoryk6(object sender, RoutedEventArgs e)
    {
        Turek5HP.Text = opp6HP.ToString();
        Random rnd6 = new Random();
        int losScyz6 = rnd6.Next(1, 1000);
        if (losScyz6 <= 700)
        {
            scyzDmgShow6.Visibility = Visibility.Visible;
            opp6HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow6.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp6HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom6_done = true;
                poziom7_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow6.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow6.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg6 = new Random();
        int cygLos6 = cyg6.Next(1, 1000);
        if (cygLos6 <= 300)
        {
            mcHP6 -= 10;
        }

    }
    private void nozyczki6(object sender, RoutedEventArgs e)
    {
        Turek5HP.Text = opp6HP.ToString();
        Random rnd6 = new Random();
        int losnozy6 = rnd6.Next(1, 1000);
        if (losnozy6 <= 900)
        {
            nozyczDmgShow6.Visibility = Visibility.Visible;
            opp6HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow6.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp6HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom6_done = true;
                poziom7_unlocked = true;
                backToMap();
            }
        }
        else
        {
            nozyczMissShow6.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow6.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg6 = new Random();
        int cygLos6 = cyg6.Next(1, 1000);
        if (cygLos6 <= 300)
        {
            mcHP6 -= 10;
        }
    }
    private void poz7(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl7.Visibility = Visibility.Visible;
        hieronimHP7.Text = mcHP7.ToString();
        Turek6HP.Text = opp7HP.ToString();
    }
    private void scyzoryk7(object sender, RoutedEventArgs e)
    {
        Turek6HP.Text = opp7HP.ToString();
        Random rnd7 = new Random();
        int losScyz7 = rnd7.Next(1, 1000);
        if (losScyz7 <= 700)
        {
            scyzDmgShow7.Visibility = Visibility.Visible;
            opp7HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow7.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp7HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom7_done = true;
                poziom8_unlocked = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow7.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow7.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg7 = new Random();
        int cygLos7 = cyg7.Next(1, 1000);
        if (cygLos7 <= 300)
        {
            mcHP7 -= 10;
        }

    }
    private void nozyczki7(object sender, RoutedEventArgs e)
    {
        Turek6HP.Text = opp7HP.ToString();
        Random rnd7 = new Random();
        int losnozy7 = rnd7.Next(1, 1000);
        if (losnozy7 <= 900)
        {
            nozyczDmgShow7.Visibility = Visibility.Visible;
            opp7HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow7.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp7HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom7_done = true;
                poziom8_unlocked = true;

            }
        }
        else
        {
            nozyczMissShow7.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow7.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg7 = new Random();
        int cygLos7 = cyg7.Next(1, 1000);
        if (cygLos7 <= 300)
        {
            mcHP7 -= 10;
        }
    }
    private void poz8(object sender, RoutedEventArgs e)
    {
        mapa.Visibility = Visibility.Collapsed;
        lvl8.Visibility = Visibility.Visible;
        hieronimHP8.Text = mcHP8.ToString();
        TurekBossHP.Text = opp8HP.ToString();
    }
    private void scyzoryk8(object sender, RoutedEventArgs e)
    {
        TurekBossHP.Text = opp8HP.ToString();
        Random rnd8 = new Random();
        int losScyz8 = rnd8.Next(1, 1000);
        if (losScyz8 <= 700)
        {
            scyzDmgShow8.Visibility = Visibility.Visible;
            opp8HP -= scyzorykDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzDmgShow8.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp8HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom8_done = true;
                backToMap();
            }
        }
        else
        {
            scyzMissShow8.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                scyzMissShow8.Visibility = Visibility.Collapsed;
            };
            timer.Start();

        }
        Random cyg8 = new Random();
        int cygLos8 = cyg8.Next(1, 1000);
        if (cygLos8 <= 300)
        {
            mcHP8 -= 10;
        }

    }
    private void nozyczki8(object sender, RoutedEventArgs e)
    {
        ochroniarzHP.Text = opp7HP.ToString();
        Random rnd8 = new Random();
        int losnozy8 = rnd8.Next(1, 1000);
        if (losnozy8 <= 900)
        {
            nozyczDmgShow7.Visibility = Visibility.Visible;
            opp7HP -= nozyczkiDMG;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczDmgShow1.Visibility = Visibility.Collapsed;
            };
            timer.Start();
            if (opp8HP <= 0)
            {
                MessageBox.Show("Ochroniarz został pokonany.");
                poziom8_done = true;

            }
        }
        else
        {
            nozyczMissShow7.Visibility = Visibility.Visible;
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, args) =>
            {
                nozyczMissShow7.Visibility = Visibility.Collapsed;
            };
            timer.Start();
        }
        Random cyg8 = new Random();
        int cygLos8 = cyg8.Next(1, 1000);
        if (cygLos8 <= 300)
        {
            mcHP8 -= 10;
        }
    }

}