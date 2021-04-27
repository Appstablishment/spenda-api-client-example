using Spenda.SDK.Models;
using System.Collections.Generic;

namespace Spenda.SDK.Tests.Mocks
{
    public static class Customer
    {
        public static SaveRequestOfCustomerT GetCustomerObject(int? Id = null, string refNumber = null)
        {
            var newCustomer = new SaveRequestOfCustomerT
            {
                _Object = new CustomerT
                {
                    Contacts = new List<ContactT> {
                        new ContactT {
                            IsPrimaryContact = true,
                            FirstName = "Bruce",
                            LastName = "Wayne",
                            IsActive = true
                        }
                    },
                    CompanyName = "Wayne Industries",
                    IsActive = true,
                    IsIndividual = false,
                    ID = Id,
                    RefNumber = refNumber,
                    Locations = new List<LocationT> {
                        new LocationT {
                            IsActive = true,
                            UtcOffset = 480,
                            IsDefaultLocation = true,
                            TimeZoneName = "Australia/Perth",
                            Addresses = new List<AddressT>{
                                new AddressT {
                                    City = "Perth",
                                    FullAddress = "123 fake Address",
                                    State = "WA",
                                    PostCode = "6004",
                                    Country = "Australia",
                                    IsDefaultBilling = true,
                                    IsDefaultDeliverTo = true,
                                    IsPostalAddress = false,
                                    IsActive =true,
                                }
                            }
                        }
                    }
                }
            };

            return newCustomer;
        }

    }
}
