using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Reservation
    {
        public RoomId RoomID { get;}
    
        public DateTime StartTime { get;}

        public DateTime EndTime { get; }

        public String UserName { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomId roomId, string UserName, DateTime startTime, DateTime endTime)
        {
            RoomID = roomId;
            StartTime = startTime;
            EndTime = endTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID) 
            {
                return false;
            }

            return reservation.StartTime < EndTime &&  reservation.EndTime > StartTime;
        }
    }
}
