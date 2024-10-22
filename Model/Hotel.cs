using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    internal class Hotel
    {
        private readonly ReservationBook _reservationBook;
        
        private string Name { get; }
        public Hotel(string name) 
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetReservation();
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);  
        }
 

    }
}
