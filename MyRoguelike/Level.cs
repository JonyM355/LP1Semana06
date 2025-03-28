using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

namespace MyRoguelike
{
    public class Level
    {
        private Toughness toughness;
        private float rooms;
        private float enemies;
        private string[] roomList;

        public Level(float rooms, Toughness toughness)
        {
            this.rooms = rooms;
            this.toughness = toughness;
            enemies = 0;
            roomList = new string[2];
        }
    
        public string[] SetEnemyInRoom(float room, Enemy enemy)
        {
            roomList[0] = room.ToString();
            roomList[1] = enemy.ToString();

            return roomList;
        }

        public void PrintEnemies()
        {
            Console.Write($"{int.Parse(roomList[0]).ToOrdinalWords()}: ");
            Console.WriteLine($"{roomList[1]}");
        }


        public Toughness GetToughness()
        {
            return toughness;
        }

        public float GetNumRooms()
        {
            return rooms;
        }

        public float GetNumEnemies()
        {
            return enemies;
        }
    }
}