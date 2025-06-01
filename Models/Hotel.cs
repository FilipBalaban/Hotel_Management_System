using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
        public void AddReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
        public void RemoveReservation(Reservation reservation)
        {
            _reservationBook.RemoveReservation(reservation);
        }
        public void UpdateReservation(Reservation reservation)
        {
            _reservationBook.UpdateReservation(reservation);
        }
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetReservations();
        }
    }
}
