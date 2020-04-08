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

namespace OpenDag
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int keuze = 0;
        public bool eerstevraag = true;
        public bool keuzeCheck = false;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //Business: 1
            //Infrastructure: 2
            //Media: 3
            //Software: 4
            //Technology: 5
            if (keuzeCheck == true && eerstevraag == true)
            {
                switch (keuze)
                {

                    case 1:
                        Grid.SetColumn(imgCar, 4);
                        break;
                    case 2:
                        Grid.SetColumn(imgCar, 0);
                        break;
                    case 3:
                        Grid.SetColumn(imgCar, 4);
                        break;
                    case 4:
                        Grid.SetColumn(imgCar, 0);
                        break;
                    case 5:
                        Grid.SetColumn(imgCar, 0);
                        break;
                    default:
                        Console.WriteLine("Je hebt geen keuze gemaakt");
                        break;
                }
            }
            else if (keuzeCheck == false && eerstevraag == true)
            {

                switch (keuze)
                {

                    case 1:
                        //Grid.Row="2" Grid.Column="4""
                        Grid.SetRow(imgCar, 2);
                        Grid.SetColumn(imgCar, 3);
                        eerstevraag = false;
                        break;
                    case 2:
                        //Grid.Row="0" Grid.Column="0""
                        Grid.SetRow(imgCar, 0);
                        Grid.SetColumn(imgCar, 1);
                        eerstevraag = false;
                        break;
                    case 3:
                        //Grid.Row="0" Grid.Column="4""
                        Grid.SetRow(imgCar, 0);
                        Grid.SetColumn(imgCar, 3);
                        eerstevraag = false;
                        break;
                    case 4:
                        //Grid.Row="1" Grid.Column="0""
                        Grid.SetRow(imgCar, 1);
                        Grid.SetColumn(imgCar, 1);
                        eerstevraag = false;
                        break;
                    case 5:
                        //Grid.Row="2" Grid.Column="0""
                        Grid.SetRow(imgCar, 2);
                        Grid.SetColumn(imgCar, 1);
                        eerstevraag = false;
                        break;
                    default:
                        Console.WriteLine("Je hebt geen keuze gemaakt");
                        break;
                }
            }
            else if (keuzeCheck == false && eerstevraag == false)
            {
                Grid.SetRow(imgCar, 1);
                Grid.SetColumn(imgCar, 2);
            }
            

        }

        private void imgCar_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (keuze == 0)
            {
                QuestionWindow questionWindow = new QuestionWindow(this, eerstevraag);
                questionWindow.Show();
                this.Hide();
            }
            else
            {
                QuestionWindow questionWindow = new QuestionWindow(this, eerstevraag);
                questionWindow.Show();
                this.Hide();
            }
            
        }
    }
}
