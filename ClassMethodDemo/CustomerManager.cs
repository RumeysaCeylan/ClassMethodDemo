using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {   
        List<int> customer_id = new List<int>();
        public void add(Customer customer)
        {
            

            customer_id.Add(customer.bank_account);
            Console.WriteLine(customer.bank_account+ " başarıyla eklendi sn " + customer.name_surname);
        }

        public void delete(Customer customer)
        {
            customer_id.Remove(customer.bank_account);
            Console.WriteLine(customer.bank_account + " başarıyla silindi sn " + customer.name_surname);
        }
        public void lists()
        {
            foreach (var item in customer_id)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}
