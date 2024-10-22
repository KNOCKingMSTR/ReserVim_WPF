using MVVM.Exceptions;
using MVVM.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Red York");

            try
            {

                hotel.MakeReservation(new Reservation(
                    new RoomId(1, 3),
                    "Red York One",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 5)));

                hotel.MakeReservation(new Reservation(
                    new RoomId(1, 3),
                    "Red York One",
                    new DateTime(2000, 1, 5),
                    new DateTime(2000, 1, 6)));

                hotel.MakeReservation(new Reservation(
                    new RoomId(1, 3),
                    "Red York One",
                    new DateTime(2000, 1, 7),
                    new DateTime(2000, 1, 8)));

            }
            catch (ReservationConflictException ex)
            {
            
            }

            //IEnumerable<Reservation> reservations = hotel.GetReservationForUser("Red York");

            base.OnStartup(e);

        }
    }

}
