using System;
namespace PartyInvites.Models
{
	public class GuestResponse
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool? willAttend { get; set; }
	}
}

