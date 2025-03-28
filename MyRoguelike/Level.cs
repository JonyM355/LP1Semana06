using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Level
    {
        private Toughness toughness;
        private int rooms;
        private int enemies;

        public Level()
        {
            
        }
    
        public void SetEnemyInRoom(string[] enemy)
        {

        }

        public Toughness GetToughness()
        {
            return toughness;
        }

        public int GetNumRooms()
        {
            return rooms;
        }

        public int GetNumEnemies()
        {
            return enemies;
        }
    }
}