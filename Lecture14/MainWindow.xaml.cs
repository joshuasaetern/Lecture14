using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;
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

namespace Lecture14
{
    //Joshua Saetern
    //Computer Programming II
    //06.11.2024
    //Lecture 14 - Enumerables and Images

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();

            imgDisplay.Source = ConvertToImage("C:\\Users\\tehso\\source\\repos\\Lecture14\\Lecture14\\Images\\cheetah.jpg");
        }
        public void FillComboBox()
        {
            Art nighthawks = new Art("Nighthawks", Art.STYLES.Impressionism);

            runDisplay.Text = nighthawks.ToString();

            cmbStyles.ItemsSource = Enum.GetValues(typeof(Art.STYLES)).Cast<Art.STYLES>().ToList();
        }
        public BitmapImage ConvertToImage(String filePath)
        {
            String imgPath = @filePath;

            //Uniform Resource Identifier
            Uri convertPath = new Uri(imgPath);
            BitmapImage bitmap = new BitmapImage(convertPath);

            return bitmap;
        }
        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            //Step 1
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Filter
            //What is displayed in drop down box
            String displayFilter = "Image files (*.png;*.jpeg;*.jpg;)";
            //Filter results in file explorer
            String filterBy = "*.png;*.jpeg;*.jpg;";
            //Full string which uses pipe to seperate display and filter
            String fullFilter = $"{displayFilter}|{filterBy}";

            openFileDialog.Filter = fullFilter;
            
            //Opens dialog and returns true if image is selected
            if (openFileDialog.ShowDialog() == true)
            {
                String returnedFiledPath = openFileDialog.FileName;
                imgDisplay.Source = ConvertToImage(returnedFiledPath);
            }
        }
    }
}