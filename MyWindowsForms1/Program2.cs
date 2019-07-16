using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyWindowsForms1
{
    public class Player : IComparable<Player>, IComparer<Player>
    {
        public short points;
        public short rebounds;
        public string name;
        private string[] players = new string[8]
        {
        "Veronika","Nik","Nastya","Nikita","Lera","Liza","Marie","Viktor"
        };

        public Player()
        {
            Random random_points = new Random();
            Thread.Sleep(500);
            Random random_rebounds = new Random();
            Thread.Sleep(500);
            Random random_assists = new Random();
            this.points = (short)random_points.Next(20, 40);
            this.rebounds = (short)random_rebounds.Next(5, 15);
            this.name = players[random_assists.Next(0, 8)];

        }
        public int Compare(Player s1, Player s2)
        {
            return 1.CompareTo(2);
        }
        public int CompareTo(Player player)
        {
            if (player == null)
            {
                return 1;
            }
            else
            {
                if (this.points > player.points)
                {
                    return 1;
                }
                else if (this.points < player.points)
                {
                    return -1;
                }
                else
                {
                    if (this.rebounds > player.rebounds)
                    {
                        return 1;
                    }
                    else if (this.rebounds < player.rebounds)
                    {
                        return -1;
                    }
                    else
                    {
                        return this.name.CompareTo(player.name);
                    }
                }
            }
        }
    }
}
