using System;
using System.IO.Compression;
using Business.Address.AddressManager;

namespace Polymorphism
{
	class Program
    {
        static void Main(string[] args)
        {
	        Address testAddress = new Address()
	        {
				Address1 = "",
				AddressLine2 = "",
				City = "",
				State = "",
				ZipCode = "",
				CountryCode = ""
	        };

	        switch (testAddress.CountryCode)
	        {
		        case "US":
			        IAddressFormatting usFormatting = new UnitedStatesAddressManager();
			        usFormatting.Format(testAddress);
			        break;
		        case "DE":
			        IAddressFormatting geFormatting = new GermanyAddressManager();
			        geFormatting.Format(testAddress);
			        break;
		        case "CA":
			        IAddressFormatting caFormatting = new CanadaAddressManager();
			        caFormatting.Format(testAddress);
			        break;
			}
			Console.WriteLine("Hello World!");
        }
    }

	class AddressManager_Imperative : IAddressFormatting, IAddressValidating
	{
		public Address Format(Address address)
		{
			switch (address.CountryCode)
			{
				case "US":
					CheckAddress2(address);
				case "DE":
					CheckAddress2(address);
				case "CA":
					CheckAddress2(address);
				default:
					throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
			}

			return address;
		}

		public void CheckAddress2(Address address)
		{
			// TODO: Create custom exception for required address line 2.
			if (address.AddressLine2 != null)
				if(address.CountryCode.Equals("DE"))
					if(address.AddressLine2.Length < 20)
						throw new Exception("GERMAN ADDRESSES NEED LONG");

			if (address.CountryCode.Equals("CA"))


			throw new Exception($"{nameof(address.AddressLine2)} is a required field for {address.CountryCode} addresses.");

		}

		public string ValidateAddress1(string address1)
		{
			throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
		}
		public string ValidateAddress2(string address2)
		{
			throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
		}
		public string ValidateCity(string city)
		{
			throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
		}
		public string ValidateState(string state)
		{
			throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
		}
		public string ValidateZipCode(string zipCode)
		{
			throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
		}
		public string ValidateCountryCode(string countryCode)
		{
			throw new NotImplementedException("This is a skeleton code. Please provide implementation for this method.");
		}
	}


}
