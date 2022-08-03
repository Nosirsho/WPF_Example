using Reservoom.Exceptions;
using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		protected override void OnStartup(StartupEventArgs e) {
			Hotel hotel = new Hotel("SinletonSean Suites");
			try {
				hotel.MakeReservation(new Reservation(
					new RoomId(1, 3),
					"SingletonSean",
					new DateTime(2000, 1, 1),
					new DateTime(2000, 1, 2)));
				
				hotel.MakeReservation(new Reservation(
					new RoomId(1, 3),
					"SingletonSean",
					new DateTime(2000, 1, 3),
					new DateTime(2000, 1, 4)));
			} catch (ReservationConflictException) 
			{

				throw;
			}
			hotel.MakeReservation(new Reservation(
				new RoomId(1,3),
				"SingletonSean",
				new DateTime(2000,1,3),
				new DateTime(2000,1,4)));
			hotel.GetReservationsForUser("SingletonSean");
			base.OnStartup(e);
		}
	}
}
