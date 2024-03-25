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

        public static List<Arrow> Arrows = new List<Arrow>();
        public static void AddArrow(params Arrow[] arrs)
        {
            for (int i = 0; i < arrs.Length; i++) Arrows.Add(arrs[i]);
        }
        public static void DrawArrows()
        {
            foreach(Arrow a in Arrows)
            {
                a.Draw();
            }
        }
        public static void UpdateArrows()
        {
            foreach(Arrow a in Arrows)
            {
                a.Update();
            }
        }
    }
}
