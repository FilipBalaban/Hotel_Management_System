using Hotel_Management_System.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }
        public void AddReservation(Reservation reservation)
        {
            if (reservation.HasInvalidDates())
            {
                throw new InvalidReservationDatesException(reservation);
            }

            foreach(Reservation existingReservation in _reservations)
            {
                if (existingReservation.IsConflicting(reservation))
                {
                    throw new ReservationConflictingException(existingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }
        public void RemoveReservation(Reservation reservation)
        {
            _reservations.Remove(reservation);
        }
        public void UpdateReservation(Reservation reservation)
        {
            for(int i = 0; i < _reservations.Count; i++)
            {
                if (_reservations[i].ID == reservation.ID)
                {
                    _reservations[i] = reservation;
                }
            }
        }
        public IEnumerable<Reservation> GetReservations()
        {
            return _reservations;
        }
    }
}
