using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Homm3Selector
{
    public partial class MainWindow : Window
    {
        //Creating the used variables
        Boolean citySelected = false;
        int cityChosen;
        string cityPath = "C:\\Users\\AweSa\\source\\repos\\homm3draft\\Homm3Selector\\images\\Cities\\";

        //Calling the needed constructors
        Cities cities = new Cities();
        Heroes heroes = new Heroes();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void roll_btn_Click(object sender, RoutedEventArgs e)
        {
            //Calling the setCities method and clearing the text boxes and images incase this is not the first roll
            cities.setCities();
            rollOutput_txtbox1.Clear();
            rollOutput_txtbox2.Clear();
            rollOutput_txtbox3.Clear();
            image4.Source = null;
            image5.Source = null;
            image6.Source = null;
            citySelected = false;
            heroBoxClear();

            //highlighting the newly rolled cities
            image1.Opacity = 1;
            image2.Opacity = 1;
            image3.Opacity = 1;

            //Setting the image sources for the cities
            BitmapImage myBitmap1 = new BitmapImage();
            BitmapImage myBitmap2 = new BitmapImage();
            BitmapImage myBitmap3 = new BitmapImage();
            myBitmap1.BeginInit();
            myBitmap2.BeginInit();
            myBitmap3.BeginInit();
            myBitmap1.UriSource = new Uri(cityPath + cities.getCity1() + ".png");
            myBitmap2.UriSource = new Uri(cityPath + cities.getCity2() + ".png");
            myBitmap3.UriSource = new Uri(cityPath + cities.getCity3() + ".png");
            myBitmap1.EndInit();
            myBitmap2.EndInit();
            myBitmap3.EndInit();

            image1.Source = myBitmap1;
            image2.Source = myBitmap2;
            image3.Source = myBitmap3;

            //Printing the city names
            rollOutput_txtbox1.AppendText(cities.getCity1());
            rollOutput_txtbox2.AppendText(cities.getCity2());
            rollOutput_txtbox3.AppendText(cities.getCity3());
        }

        private void Select_btn_Click(object sender, RoutedEventArgs e)
        {
            //Making sure you can only click select if a city has been chosen
            if (citySelected == true)
            {
                //Calling city select to remove the chosen city from the list
                cities.citySelect(cityChosen);
                
                //clear hero text boxes
                heroBoxClear();

                //set the hero images
                setHeroImages(image4, image5, image6);
            }
        }

        //Method to reroll heroes for the selected town
        private void refresh_btnClick(object sender, RoutedEventArgs e)
        {
            if (citySelected == true)
            {
                heroBoxClear();
                heroes.heroes_refresh();
                setHeroImages(image4, image5, image6);
            }
        }
        
        //Method for image generation for the heroes
        private void setHeroImages(System.Windows.Controls.Image image1, System.Windows.Controls.Image image2, System.Windows.Controls.Image image3)
        {
            if (cityChosen == 1) { heroes.generateHeroes(cities.getCity1()); }
            else if (cityChosen == 2) { heroes.generateHeroes(cities.getCity2()); }
            else if (cityChosen == 3) { heroes.generateHeroes(cities.getCity3()); }

            BitmapImage myBitmap1 = new BitmapImage();
            BitmapImage myBitmap2 = new BitmapImage();
            BitmapImage myBitmap3 = new BitmapImage();
            myBitmap1.BeginInit();
            myBitmap2.BeginInit();
            myBitmap3.BeginInit();
            myBitmap1.UriSource = new Uri(@heroes.getHeroPath1());
            myBitmap2.UriSource = new Uri(@heroes.getHeroPath2());
            myBitmap3.UriSource = new Uri(@heroes.getHeroPath3());
            myBitmap1.EndInit();
            myBitmap2.EndInit();
            myBitmap3.EndInit();

            image1.Source = myBitmap1;
            image2.Source = myBitmap2;
            image3.Source = myBitmap3;

            herobox1.AppendText(heroes.getHeroname1());
            herobox2.AppendText(heroes.getHeroname2());
            herobox3.AppendText(heroes.getHeroname3());
        }

        private void image1_clicked(object sender, MouseButtonEventArgs e)
        {
            image1.Opacity = 1;
            image2.Opacity = 0.5;
            image3.Opacity = 0.5;

            citySelected = true;
            cityChosen = 1;
        }

        private void image2_clicked(object sender, MouseButtonEventArgs e)
        {
            image1.Opacity = 0.5;
            image2.Opacity = 1;
            image3.Opacity = 0.5;

            citySelected = true;
            cityChosen = 2;
        }

        private void image3_clicked(object sender, MouseButtonEventArgs e)
        {
            image1.Opacity = 0.5;
            image2.Opacity = 0.5;
            image3.Opacity = 1;

            citySelected = true;
            cityChosen = 3;
        }

        private void heroBoxClear()
        {
            herobox1.Clear();
            herobox2.Clear();
            herobox3.Clear();
        }

        private void image4_clicked(object sender, MouseButtonEventArgs e)
        {

        }

        private void image5_clicked(object sender, MouseButtonEventArgs e)
        {

        }
        private void image6_clicked(object sender, MouseButtonEventArgs e)
        {

        }

        private void rollOutput_txt1(object sender, TextChangedEventArgs e)
        {

        }

        private void rollOutput_txt2(object sender, TextChangedEventArgs e)
        {

        }

        private void rollOutput_txt3(object sender, TextChangedEventArgs e)
        {

        }

        private void Herobox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Herobox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Herobox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}