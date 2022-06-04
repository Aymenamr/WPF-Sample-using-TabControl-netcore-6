using SoccerManagement.DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManagement.DataProvider
{
    public class DataProvider
    {
        private DataProvider()
        {
            _players = new List<Player>();
        }

        private List<Player> _players { get; set; }

        private static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if(_instance == null )
                    _instance= new DataProvider();

                return _instance;
            }
        }
        public List<Team> GetTeams()
        {
            return new List<Team>()
            {
                new Team(){Name="TS",Description="Tinja Sport",Town="Tinja",Country="Tunisia"},
                new Team(){Name="SAMB",Description="Stade Africain Manzel bou Rguiba",Town="Manzel BouRguiba",Country="Tunisia"},
                new Team(){Name="OB",Description="Olympique de Béja",Town="Béja",Country="Tunisia"},
                new Team(){Name="CA",Description="Club Africain",Town="Beb Jedid",Country="Tunisia"},
            };
        }
        public void AddPlayer(Player p)
        {
            _players.Add(p);
        }

        public List<Player> GetPlayers()
        {
            return _players;
        }
    }


}
