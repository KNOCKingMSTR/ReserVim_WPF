using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class RoomId
    {
        public int FloorNumber { get; }

        public int RoomNumber { get; }

        public RoomId (int floorNumber, int roomNumber) 
        { }

        public override bool Equals(object? obj)
        {
            return obj is RoomId roomId &&  
                FloorNumber == roomId.FloorNumber &&
                RoomNumber ==  roomId.RoomNumber;
        }

        public override int GetHashCode() 
        { 
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        public static bool operator ==(RoomId roomID1, RoomId roomID2) 
        {
            if (roomID1 is null && roomID2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomId roomID1, RoomId roomID2)
        {
            return !(roomID1==roomID2);
        }
    }
}
 