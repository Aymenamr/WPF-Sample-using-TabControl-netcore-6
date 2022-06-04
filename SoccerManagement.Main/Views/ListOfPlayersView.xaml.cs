using SoccerManagement.Main.ViewModels;
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

namespace SoccerManagement.Main.Views
{
    /// <summary>
    /// Interaction logic for ListOfPlayersView.xaml
    /// </summary>
    public partial class ListOfPlayersView : UserControl
    {
        public ListOfPlayersView()
        {
            InitializeComponent();
            DataContext = new ListOfPlayersViewModel();
        }
    }
}
