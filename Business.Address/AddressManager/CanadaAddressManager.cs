using System;
using Polymorphism;

namespace Business.Address.AddressManager
{
	class CanadaAddressManager : IAddressFormatting
	{
		public Models.Address Format(Models.Address address)
		{
			CheckAddress2(address);
			return address;
		}

		public void CheckAddress2(Models.Address address)
		{
			// TODO: Create custom exception for required address line 2.
			if(address.AddressLine2.Length > 0)
				if(!address.AddressLine2.Contains("Apt"))
					throw new Exception($"{nameof(address.AddressLine2)} needs to have Apt if anything.");
		}
	}


}
