using System;
using Polymorphism;

namespace Business.Address.AddressManager
{
	public class UnitedStatesAddressManager : IAddressFormatting
	{
		public Models.Address Format(Models.Address address)
		{
			CheckAddress2(address);
			return address;
		}
		public void CheckAddress2(Models.Address address)
		{
			// TODO: Create custom exception for required address line 2.
			if (address.AddressLine2 == null)
				throw new Exception($"{nameof(address.AddressLine2)} is a required field for {address.CountryCode} addresses.");
		}
	}


}
