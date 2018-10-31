using System;
using System.IO.Compression;

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

	interface IAddressFormatting
	{
		Address Format(Address address);
	}

	interface IAddressValidating
	{
		string ValidateAddress1(string address1);
		string ValidateAddress2(string address2);
		string ValidateCity(string city);
		string ValidateState(string state);
		string ValidateZipCode(string zipCode);
		string ValidateCountryCode(string countryCode);
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

	class Address
	{
		public string Address1 { get; set; }
		public string AddressLine2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string CountryCode { get; set; }
	}

	class UnitedStatesAddressManager : IAddressFormatting
	{
		public Address Format(Address address)
		{
			CheckAddress2(address);
			return address;
		}
		public void CheckAddress2(Address address)
		{
			// TODO: Create custom exception for required address line 2.
			if (address.AddressLine2 == null)
				throw new Exception($"{nameof(address.AddressLine2)} is a required field for {address.CountryCode} addresses.");
		}
	}

	class GermanyAddressManager : IAddressFormatting
	{
		public Address Format(Address address)
		{
			CheckAddress2(address);
			return address;
		}
		public void CheckAddress2(Address address)
		{
			// TODO: Create custom exception for required address line 2.
			if (address.AddressLine2 != null)
				if (address.CountryCode.Equals("DE"))
					if (address.AddressLine2.Length < 20)
						throw new Exception("GERMAN ADDRESSES NEED LONG");

			throw new Exception($"{nameof(address.AddressLine2)} is a required field for {address.CountryCode} addresses.");
		}
	}

	class CanadaAddressManager : IAddressFormatting
	{
		public Address Format(Address address)
		{
			CheckAddress2(address);
			return address;
		}

		public void CheckAddress2(Address address)
		{
			// TODO: Create custom exception for required address line 2.
			if(address.AddressLine2.Length > 0)
				if(!address.AddressLine2.Contains("Apt"))
					throw new Exception($"{nameof(address.AddressLine2)} needs to have Apt if anything.");
		}
	}


}
