using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Exceptions
{
    public class InvalidReservationDatesException : Exception
    {
        public Reservation Reservation { get; }
        public InvalidReservationDatesException(Reservation reservation)
        {
            Reservation = reservation;
        }

        public InvalidReservationDatesException(string? message, Reservation reservation) : base(message)
        {
            Reservation = reservation;
        }

        public InvalidReservationDatesException(string? message, Exception? innerException, Reservation reservation) : base(message, innerException)
        {
            Reservation = reservation;
        }

        protected InvalidReservationDatesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
