using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models {
	public class Hotel {
		private readonly ReservationBook _reservationBook;
		public string Name { get; }
		public Hotel(string name) { 
			_reservationBook = new ReservationBook();
			Name = name;
		}
		/// <summary>
		/// Get revision for a user
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		public IEnumerable<Reservation> GetAllReservations() {
			return _reservationBook.GetReservations();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="reservation"></param>
		/// <exception cref="ReservationConflict"
		public void MakeReservation(Reservation reservation) { 
			_reservationBook.AddReservation(reservation);
		}
	}
}
