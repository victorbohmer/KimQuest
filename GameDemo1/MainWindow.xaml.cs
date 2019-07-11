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

namespace GameDemo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Map map = new Map();
        string gameMode = "Map";
        public MainWindow()
        {
            InitializeComponent();
            CreateMap();
            DrawMap();

        }

        private void InputReceived(object sender, KeyEventArgs e)
        {
            var keyDown = e.Key;
            switch (gameMode)
            {
                case "Map":
                    map.TryToMove(KeyParser.Direction(keyDown));
                    DrawMap();
                    break;
                default:
                    break;
            }


        }

        private void CreateMap()
        {
            map.ReadMapFromFile();
        }















        private void DrawMap()
        {
            this.background.Source = (ImageSource)FindResource(map.GetUITileName(3, 3) + "Background");

            this.image_1_1.Source = (ImageSource)FindResource(map.GetUITileName(1, 1));
            this.image_1_2.Source = (ImageSource)FindResource(map.GetUITileName(1, 2));
            this.image_1_3.Source = (ImageSource)FindResource(map.GetUITileName(1, 3));
            this.image_1_4.Source = (ImageSource)FindResource(map.GetUITileName(1, 4));
            this.image_1_5.Source = (ImageSource)FindResource(map.GetUITileName(1, 5));
            this.image_2_1.Source = (ImageSource)FindResource(map.GetUITileName(2, 1));
            this.image_2_2.Source = (ImageSource)FindResource(map.GetUITileName(2, 2));
            this.image_2_3.Source = (ImageSource)FindResource(map.GetUITileName(2, 3));
            this.image_2_4.Source = (ImageSource)FindResource(map.GetUITileName(2, 4));
            this.image_2_5.Source = (ImageSource)FindResource(map.GetUITileName(2, 5));
            this.image_3_1.Source = (ImageSource)FindResource(map.GetUITileName(3, 1));
            this.image_3_2.Source = (ImageSource)FindResource(map.GetUITileName(3, 2));
            this.image_3_3.Source = (ImageSource)FindResource(map.GetUITileName(3, 3));
            this.image_3_4.Source = (ImageSource)FindResource(map.GetUITileName(3, 4));
            this.image_3_5.Source = (ImageSource)FindResource(map.GetUITileName(3, 5));
            this.image_4_1.Source = (ImageSource)FindResource(map.GetUITileName(4, 1));
            this.image_4_2.Source = (ImageSource)FindResource(map.GetUITileName(4, 2));
            this.image_4_3.Source = (ImageSource)FindResource(map.GetUITileName(4, 3));
            this.image_4_4.Source = (ImageSource)FindResource(map.GetUITileName(4, 4));
            this.image_4_5.Source = (ImageSource)FindResource(map.GetUITileName(4, 5));
            this.image_5_1.Source = (ImageSource)FindResource(map.GetUITileName(5, 1));
            this.image_5_2.Source = (ImageSource)FindResource(map.GetUITileName(5, 2));
            this.image_5_3.Source = (ImageSource)FindResource(map.GetUITileName(5, 3));
            this.image_5_4.Source = (ImageSource)FindResource(map.GetUITileName(5, 4));
            this.image_5_5.Source = (ImageSource)FindResource(map.GetUITileName(5, 5));



        }
    }
}
