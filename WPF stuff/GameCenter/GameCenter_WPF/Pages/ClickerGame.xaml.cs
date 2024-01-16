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
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace GameCenter_WPF.Pages
{
    /// <summary>
    /// Interaction logic for ClickerGame.xaml
    /// </summary>
    public partial class ClickerGame : Page
    {
        private MainWindow GoTo { get; }
        private int _score = 0;
        private int _totalClicks;
        private int _clickPower = 1;

        private int _increase = 1;
        private int _Increased_amount = 0;
        private int _increase_Price = 10;
        private double _increase_CostIncrease = 1.2;

        private int _moreIncrease;
        private int _more_amount = 0;
        private int _more_Price = 50;
        private double _More_CostIncrease = 1.3;

        public ClickerGame(MainWindow window)
        {
            GoTo = window;

            InitializeComponent();
            ScoreLabel.Content = _score;
            TotalClicksLabel.Content = _totalClicks;
            IncreasePrice.Content = _increase_Price;
            MoreCost.Content = _more_Price;


        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            GoTo.PageSelector("menu");
        }

        private void Update()
        {
            _totalClicks++;
            ScoreLabel.Content = _score;
            TotalClicksLabel.Content = _totalClicks;

            IncreaseAmount.Content = _Increased_amount;
            IncreasePrice.Content = _increase_Price;

            moreincrease.Content = _more_amount;
            MoreCost.Content = _more_Price;
        }
        private void OnPageClick(object sender, MouseButtonEventArgs e)
        {
            _score += _clickPower;
            Update();
        }

        private void Buy_increase(object sender, RoutedEventArgs e)
        {
            if (_score >= _increase_Price)
            {
                _score -= _increase_Price;
                _clickPower += _increase;
                _increase_Price = IncreaseCost(1);
                _Increased_amount++;
            }
            Update();
        }

        private void Upgrade_increase(object sender, RoutedEventArgs e)
        {
            if (_score >= _more_Price)
            {
                _score -= _more_Price;
                _increase++;
                _more_Price = IncreaseCost(2);
                _more_amount++;
            }
            Update();
        }

        private int IncreaseCost(int choice)
        {
            if (choice == 1)
            {
                return (int)Math.Ceiling(_increase_Price * _increase_CostIncrease);
            }
            if (choice == 2)
            {
                return (int)Math.Ceiling(_more_Price * _More_CostIncrease);
            }
            
            return 1;
        }

    }
}
