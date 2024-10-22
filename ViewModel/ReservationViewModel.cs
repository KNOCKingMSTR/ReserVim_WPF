using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    class ReservationViewModel: ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomId => _reservation.RoomID.ToString();

        public string UserName => _reservation.UserName.ToString();

        public DateTime StartTime => _reservation.StartTime;

        public DateTime Endtime => _reservation.EndTime;



        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }

}
