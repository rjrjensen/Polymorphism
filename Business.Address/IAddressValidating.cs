namespace Polymorphism
{
	interface IAddressValidating
	{
		string ValidateAddress1(string address1);
		string ValidateAddress2(string address2);
		string ValidateCity(string city);
		string ValidateState(string state);
		string ValidateZipCode(string zipCode);
		string ValidateCountryCode(string countryCode);
	}


}
