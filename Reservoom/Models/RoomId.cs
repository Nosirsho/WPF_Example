using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models {
	public class RoomId {
		public int FloorNumber { get; set; }
		public int RoomNumber { get; set; }

		public RoomId(int floorNumber, int roomNumber) {
			FloorNumber = floorNumber;
			RoomNumber = roomNumber;
		}

		public override string ToString() {
			return $"{FloorNumber}{RoomNumber}";
		}

		public override bool Equals(object obj) {
			return obj is RoomId roomID &&
				FloorNumber == roomID.FloorNumber &&
				RoomNumber == roomID.RoomNumber;
		}
		public override int GetHashCode() {
			return HashCode.Combine(FloorNumber, RoomNumber);
		}

		public static bool operator == (RoomId roomId1, RoomId roomId2) {
			if (roomId1 is null && roomId2 is null) {
				return true;
			}
			return !(roomId1 is null && roomId1.Equals(roomId2));
		}
		public static bool operator !=(RoomId roomId1, RoomId roomId2) {

			return !(roomId1 == roomId2);
		}
	}
}
	