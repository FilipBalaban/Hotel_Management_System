using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Room
    {
        public int ID { get; set; }
        public int RoomNum { get; set; }
        public int FloorNum { get; set; }
        // For data from Views
        public Room(int roomNum, int floorNum)
        {
            RoomNum = roomNum;
            FloorNum = floorNum;
        }
        // For data from DB
        public Room(int id, int roomNum, int floorNum)
        {
            ID = id;
            RoomNum = roomNum;
            FloorNum = floorNum;
        }
    }
}
