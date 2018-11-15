using Business.Address.Models;

namespace Polymorphism
{
	interface IAddressFormatting
	{
		Address Format(Address address);
	}


}
