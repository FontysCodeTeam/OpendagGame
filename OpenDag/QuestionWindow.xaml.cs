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
using System.Windows.Shapes;

namespace OpenDag
{
    /// <summary>
    /// Interaction logic for QuestionWindow.xaml
    /// </summary>
    public partial class QuestionWindow : Window
    {
        MainWindow mainWindow;
        bool eersteVraag;
        public QuestionWindow(MainWindow mainWindow, bool eersteVraag)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.eersteVraag = eersteVraag;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.keuze = 0;
            mainWindow.Show();
            this.Hide();
        }

        private void imgBusiness_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.keuze = 1;
            mainWindow.Show();
            this.Hide();
        }

        private void imgInfrastructure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.keuze = 2;
            mainWindow.Show();
            this.Hide();
        }

        private void imgMedia_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.keuze = 3;
            mainWindow.Show();
            this.Hide();
        }

        private void imgSoftware_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.keuze = 4;
            mainWindow.Show();
            this.Hide();
        }

        private void imgTechnology_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.keuze = 5;
            mainWindow.Show();
            this.Hide();
        }


        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (eersteVraag == true)
            {
                imgBusiness.Visibility = Visibility.Visible;
                imgInfrastructure.Visibility = Visibility.Visible;
                imgMedia.Visibility = Visibility.Visible;
                imgSoftware.Visibility = Visibility.Visible;
                imgTechnology.Visibility = Visibility.Visible;
                tbQuestion.Visibility = Visibility.Visible;

                tbQuestionTwo.Visibility = Visibility.Hidden;
                btnJa.Visibility = Visibility.Hidden;
                btnNee.Visibility = Visibility.Hidden;
            }
            else
            {
                imgBusiness.Visibility = Visibility.Hidden;
                imgInfrastructure.Visibility = Visibility.Hidden;
                imgMedia.Visibility = Visibility.Hidden;
                imgSoftware.Visibility = Visibility.Hidden;
                imgTechnology.Visibility = Visibility.Hidden;
                tbQuestion.Visibility = Visibility.Hidden;

                tbQuestionTwo.Visibility = Visibility.Visible;
                btnJa.Visibility = Visibility.Visible;
                btnNee.Visibility = Visibility.Visible;

                //Business: 1
                //Infrastructure: 2
                //Media: 3
                //Software: 4
                //Technology: 5
                //Vind je ...... interessant?

                if (mainWindow.keuze == 1)
                {
                    tbQuestionTwo.Text = "Lijkt je business interessant?";
                }
                if (mainWindow.keuze == 2)
                {
                    tbQuestionTwo.Text = "Lijkt je infrastructure interessant?";
                }
                if (mainWindow.keuze == 3)
                {
                    tbQuestionTwo.Text = "Lijkt je media interessant?";
                }
                if (mainWindow.keuze == 4)
                {
                    tbQuestionTwo.Text = "Lijkt je software interessant?";
                }
                if (mainWindow.keuze == 5)
                {
                    tbQuestionTwo.Text = "Lijkt je technology interessant?";
                }
            }
        }

        private void btnNee_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.keuzeCheck = false;
            mainWindow.Show();
            this.Hide();
        }

        private void btnJa_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.keuzeCheck = true;
            mainWindow.eerstevraag = true;
            mainWindow.Show();
            this.Hide();
        }
    }
}
