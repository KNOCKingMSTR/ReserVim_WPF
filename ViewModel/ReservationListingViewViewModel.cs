using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    internal class ReservationListingViewViewModel : ViewModelBase
    {
        public ICommand MakeReservationCommand { get; }

        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public ObservableCollection<ReservationViewModel> Reservations
        { 
            get { return _reservations; }
        }

        public ReservationListingViewViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomId(001, 001), "Ayush Chauhan", new DateTime(), new DateTime())));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomId(002, 002), "Ayush Chauhan", new DateTime(), new DateTime())));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomId(003, 003), "Ayush Chauhan", new DateTime(), new DateTime())));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomId(004, 004), "Ayush Chauhan", new DateTime(), new DateTime())));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomId(005, 025), "Ayush Chauhan", new DateTime(), new DateTime())));
        }
    }
}
