using SoccerManagement.Main.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManagement.Main.ViewModels
{
    public class DashboardViewModel : AViewModel
    {
        public int TotalPlayers { get; set; }   
        public int TotalTeams { get; set; }   
        public int TotalGoals { get; set; }   
        public DashboardViewModel()
        {
            TotalPlayers = DataProvider.DataProvider.Instance.GetPlayers().Count();
            TotalTeams   = DataProvider.DataProvider.Instance.GetTeams().Count();
            TotalGoals = DataProvider.DataProvider.Instance.GetPlayers().Select( i=>i.GoalsNumber).Sum();

        }
    }
}
