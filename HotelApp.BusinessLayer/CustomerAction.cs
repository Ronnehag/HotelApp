using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.DataModule;

namespace HotelApp.BusinessLayer
{
    public class CustomerAction
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerAction()
        {
            _customerRepository = new CustomerRepository();
        }

        public bool DeleteCustomer(int customerId)
        {
            var customer = _customerRepository.GetCustomer(customerId);

            if (customer?.Bookings != null)
            {
                if (customer.Bookings.Count == 0)
                {
                    _customerRepository.DeleteCustomer(customer.CustomerId);
                    return true;
                }

            }
            return false;
        }

        public bool UpdateCustomer(int customerId, string firstName, string lastName, string address,
            string city, string country, string email)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            var customer = _customerRepository.GetCustomer(customerId);
            if (customer != null)
            {
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.Address = address;
                customer.City = city;
                customer.Country = country;
                customer.Email = email;
            }
            _customerRepository.UpdateCustomer(customer);
            return true;
        }

        public bool NewCustomer(string firstName, string lastName, string address, string city, string country, string email, string postalCode)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                PostalCode =  postalCode,
                City = city,
                Country = country,
                Email = email,
                Bookings = null
            };
            _customerRepository.SaveCustomer(customer);
            return true;
        }
    }
}
