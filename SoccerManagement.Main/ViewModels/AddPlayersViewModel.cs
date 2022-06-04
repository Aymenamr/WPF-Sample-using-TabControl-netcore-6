using SoccerManagement.DataProvider.Models;
using SoccerManagement.Main.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SoccerManagement.Main.ViewModels
{
    public class AddPlayersViewModel : AViewModel
    {
        private Player _player;
        public Player Player 
        { get { return _player; } set { _player = value; NotifyPropertyChanged("Player"); } }  
        public List<Player> Players { get; set; }
        public List<Team> Teams { get; set; }
        public ICommand AddPlayerCommand { get; set; }

        public AddPlayersViewModel()
        {
            Players= DataProvider.DataProvider.Instance.GetPlayers();
            Teams= DataProvider.DataProvider.Instance.GetTeams();
            AddPlayerCommand = new DelegateCommand(() => AddPlayer(),()=> CanAddPlayer());
            Player = new Player();
        }

        private void AddPlayer()
        {
            DataProvider.DataProvider.Instance.AddPlayer(Player);
            MessageBox.Show("The Player was added successfully !");
            Player = new Player();

        }

        public bool CanAddPlayer()
        {
            return !string.IsNullOrWhiteSpace(Player.FirstName);
        }
        
    }
}
