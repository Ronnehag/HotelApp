using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HotelApp.DataModule
{
    public class CustomerRepository
    {
        public void SaveCustomer(Customer customer)
        {
            using (var db = new HotelEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public Customer GetCustomer(int customerId)
        {
            using (var db = new HotelEntities())
            {
                return db.Customers
                    .Include("Bookings")
                    .SingleOrDefault(c => c.CustomerId == customerId);
            }
        }

        public List<Customer> GetCustomers()
        {
            using (var db = new HotelEntities())
            {
                return db.Customers.ToList();
            }
        }


        public void UpdateCustomer(Customer customer)
        {
            using (var db = new HotelEntities())
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            using (var db = new HotelEntities())
            {
                var result = db.Customers.SingleOrDefault(c => c.CustomerId == customerId);
                if (result != null)
                {
                    db.Customers.Remove(result);
                    db.SaveChanges();
                }
                //TODO
            }
        }

    }
}
