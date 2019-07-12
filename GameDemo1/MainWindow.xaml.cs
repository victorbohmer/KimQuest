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
        Combat combat;
        GameMode gameMode = GameMode.Map;
        public MainWindow()
        {
            InitializeComponent();
            CreateMap();
            DrawMap();
            combat = new Combat(Log);

            UpdateKimStats();
            
            Enemy.Source = (ImageSource)FindResource("NoEnemy");
            
        }

        private void UpdateKimStats()
        {
            KimHP.Text = $"HP: {Player.Health}";
            KimXP.Text = $"XP: {Player.Experience} / {Player.ExperinceToLevelUp}";
            KimLevel.Text = $"Level: {Player.Level}";
        }

        private void InputReceived(object sender, KeyEventArgs e)
        {
            var keyDown = e.Key;

            switch (gameMode)
            {
                case GameMode.Map:
                    map.TryToMove(KeyParser.Direction(keyDown));
                    DrawMap();
                    RollForEncounter();
                    break;
                case GameMode.Combat:
                    CombatRound(keyDown);
                    break;
                case GameMode.PlayerLost:
                    break;
                default:
                    break;
            }


        }

        private void RollForEncounter()
        {
            Random random = new Random();
            if (random.Next(6) == 0)
            {
                combat.NewMonster();
                Enemy.Source = (ImageSource)FindResource(combat.attackingMonster.Name);
                Log.Text += $"\nDu blev anfallen av en {combat.attackingMonster.Name.ToLower()}!";
                EnemyHP.Text = $"{combat.attackingMonster.Name} HP: {combat.attackingMonster.Health}";
                gameMode = GameMode.Combat;
            }
                
        }

        private void CombatRound(Key keyDown)
        {
            
            CombatOutcome outcome = combat.CombatRound();
            UpdateKimStats();
            EnemyHP.Text = $"Enemy HP: {combat.attackingMonster.Health}";

            switch (outcome)
            {
                case CombatOutcome.NewRound:
                    break;
                case CombatOutcome.PlayerLost:
                    kimpan.Source = (ImageSource)FindResource("KimpanDöd");
                    kimpan_BIG.Source = (ImageSource)FindResource("KimpanDöd");
                    gameMode = GameMode.PlayerLost;
                    break;
                case CombatOutcome.PlayerWon:
                    EnemyHP.Text = "";
                    Enemy.Source = (ImageSource)FindResource("NoEnemy");
                    gameMode = GameMode.Map;
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
