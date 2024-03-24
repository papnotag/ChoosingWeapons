using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingWeapons
{
    internal class Entities
    {
        public static int PlayerCounter = 0;
        public static List<Player> Players = new List<Player>();
        public static void AddPlayer(params Player[] player)
        {
            for (int i = 0; i < player.Length; i++) Players.Add(player[i]);
        }
        public static void DrawPlayers()
        {
            foreach (Player player in Players)
            {
                player.Draw();
            }
        }
    }
}
