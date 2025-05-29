using System;
using System.Collections.Generic;
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
using System.IO;
using System.Diagnostics;

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Lovo> lovok = new List<Lovo>();
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("lovesek.csv");
            while (!sr.EndOfStream)
            {
                lovok.Add(new Lovo(sr.ReadLine()));
            }
            sr.Close();

            datagrid1.ItemsSource = lovok;
            datagrid1.Items.Refresh();
        }

        private void btn_hozzaAd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (99 >= Convert.ToInt32(txb_1.Text) && 0 <= Convert.ToInt32(txb_1.Text))
                {
                    if (99 >= Convert.ToInt32(txb_2.Text) && 0 <= Convert.ToInt32(txb_2.Text))
                    {
                        if (99 >= Convert.ToInt32(txb_3.Text) && 0 <= Convert.ToInt32(txb_3.Text))
                        {
                            if (99 >= Convert.ToInt32(txb_4.Text) && 0 <= Convert.ToInt32(txb_4.Text))
                            {
                                string hozzaAd = txb_nev.Text + ";" + txb_1.Text + ";" + txb_2.Text + ";" + txb_3.Text + ";" + txb_4.Text;
                                lovok.Add(new Lovo(hozzaAd));

                                datagrid1.ItemsSource = lovok;
                                datagrid1.Items.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Nem megfelelő érték!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nem megfelelő érték!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nem megfelelő érték!");
                    }
                }
                else
                {
                    MessageBox.Show("Nem megfelelő érték!");
                }
            }
            catch
            {
                MessageBox.Show("Üres mező!");
            }

        }

        private void btn_mentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("A mentés sikeresen megtörtént!");
                StreamWriter sw = new StreamWriter("lovesek2.csv");
                foreach (var i in lovok)
                {
                    string kiiras = i.Nev + ";";
                    kiiras += i.ElsoLoves + ";" + i.MasodikLoves + ";" + i.HarmadikLoves + ";" + i.NegyedikLoves;
                    sw.WriteLine(kiiras);
                }
                sw.Close();

                //MessageBox.Show("A mentés sikeresen megtörtént!");

                Process.Start("lovesek2.csv");
            }
            catch
            {
                MessageBox.Show("valami rossz");
            }


        }

        private void btn_mentese_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("A mentés sikeresen megtörtént!");
                StreamWriter sw = new StreamWriter("lovesek2.csv");
                foreach (var i in lovok)
                {
                    string kiiras = i.Nev + ";";
                    kiiras += i.ElsoLoves + ";" + i.MasodikLoves + ";" + i.HarmadikLoves + ";" + i.NegyedikLoves;
                    sw.WriteLine(kiiras);
                }
                sw.Close();

                //MessageBox.Show("A mentés sikeresen megtörtént!");

                Process.Start("lovesek2.csv");
            }
            catch
            {
                MessageBox.Show("valami rossz");
            }



        }

        private void btn_kiiras_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("A mentés sikeresen megtörtént!");
                StreamWriter sw = new StreamWriter("lovesek2.csv");
                foreach (var i in lovok)
                {
                    string kiiras = i.Nev + ";";
                    kiiras += i.ElsoLoves + ";" + i.MasodikLoves + ";" + i.HarmadikLoves + ";" + i.NegyedikLoves;
                    sw.WriteLine(kiiras);
                }
                sw.Close();

                //MessageBox.Show("A mentés sikeresen megtörtént!");

                Process.Start("lovesek2.csv");
            }
            catch
            {
                MessageBox.Show("valami rossz");
            }
        }
    }
}
