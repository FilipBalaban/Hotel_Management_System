using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public List<Guest> Guests { get; set; }
        public DateTime ReservationDate = DateTime.Now;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // For data from Views
        public Reservation(int roomID, List<Guest> guests, DateTime reservationDate, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            Guests = guests;
            ReservationDate = reservationDate;
            StartDate = startDate;
            EndDate = endDate;
        }
        // For data from DB
        public Reservation(int id, int roomID, List<Guest> guests, DateTime reservationDate, DateTime startDate, DateTime endDate)
        {
            ID = id;
            RoomID = roomID;
            Guests = guests;
            ReservationDate = reservationDate;
            StartDate = startDate;
            EndDate = endDate;
        }
        public bool IsConflicting(Reservation incomingReservation)
        {
            if(!(incomingReservation.ID == ID))
            {
                return false;
            }

            return incomingReservation.StartDate < EndDate && incomingReservation.EndDate > StartDate;
        }
        public bool HasInvalidDates()
        {
            if(ReservationDate > StartDate)
            {
                return true;
            }
            return StartDate > EndDate;
        }
    }
}
