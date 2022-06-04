using SoccerManagement.DataProvider.Models;
using SoccerManagement.Main.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManagement.Main.ViewModels
{
    public class ListOfPlayersViewModel : AViewModel
    {
        public List<Player> Players { get; set; }
        public ListOfPlayersViewModel()
        {
            Players = DataProvider.DataProvider.Instance.GetPlayers();
        }
    }
}
