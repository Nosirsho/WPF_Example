using Reservoom.Commands;
using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservoom.ViewModels {
	public class ReservationListingViewModel : ViewModelBase {
		private readonly ObservableCollection<ReservationViewModel> _reservations;

		public IEnumerable<ReservationViewModel> Reservations => _reservations;

		public ICommand MakeReservationCommand { get; }
		
		public ReservationListingViewModel() {
			_reservations = new ObservableCollection<ReservationViewModel>();

			MakeReservationCommand = new NavigationCommand();

			_reservations.Add(new ReservationViewModel(new Reservation(new RoomId(1, 2), "M.Nigmatulin", DateTime.Now, DateTime.Now)));
			_reservations.Add(new ReservationViewModel(new Reservation(new RoomId(3, 4), "Lincoln", DateTime.Now, DateTime.Now)));
			_reservations.Add(new ReservationViewModel(new Reservation(new RoomId(5, 6), "Scofild", DateTime.Now, DateTime.Now)));
		}
	}
}
