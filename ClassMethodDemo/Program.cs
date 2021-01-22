using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            CustomerManager customerManager = new CustomerManager();
            int choise;
            
            Console.WriteLine("hesap numaranızı giriniz");
            customer1.bank_account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("adınızı ve soyadınızı giriniz");
            customer1.name_surname = Console.ReadLine();

            Console.WriteLine("şifrenizi giriniz");
            customer1.password = Convert.ToInt32(Console.ReadLine());

            Customer customer2 = new Customer();
            Console.WriteLine("hesap numaranızı giriniz");
            customer2.bank_account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("adınızı ve soyadınızı giriniz");
            customer2.name_surname = Console.ReadLine();

            Console.WriteLine("şifrenizi giriniz");
            customer2.password = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("1)hesap ekle 2)hesap sil 3)listele 0)çıkış ");
            choise= Convert.ToInt32(Console.ReadLine());
            while (choise!=0)
            {
                switch (choise)
                {
                    case 1:
                        
                        customerManager.add(customer1);
                        customerManager.add(customer2);
                        break;
                    case 2:
                        Console.WriteLine("hangi hesabı silmek istiyorsanız banka hesap nu girin");
                        int hesap_nu= Convert.ToInt32(Console.ReadLine());
                        if(hesap_nu==customer1.bank_account)
                        customerManager.delete(customer1);
                        else
                        customerManager.delete(customer2);

                        break;
                    case 3:
                        customerManager.lists();
                        break;
                    default:
                        Console.WriteLine("YANLIŞ BİR ELEMANA BASTINIZ");
                        break;
                }
                Console.WriteLine("1)hesap ekle 2)hesap sil 3)listele 0)çıkış ");
                choise = Convert.ToInt32(Console.ReadLine());

            }
            
                

        }

       
    }
}
