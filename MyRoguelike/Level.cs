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
    }
}