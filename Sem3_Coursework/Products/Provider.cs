using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public enum Bank
    {
        Sberbank, AlphaBank, TBank, VTB, None
    }

    public class Director
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public Director(
            string fullname, 
            string phoneNumber) 
        { 
            FullName = fullname;
            PhoneNumber = phoneNumber;
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Director CompanyDirector { get; set; }

        public Company(
            string name, 
            string address, 
            Director companyDirector)
        {
            Name = name;
            Address = address;
            CompanyDirector = companyDirector;
        }
    }

    public class Provider
    {
        public Company ProviderCompany { get; set; }
        public Bank ProviderBank { get; set; }
        public string Account { get; set; }
        public string INN { get; set; }
            
        public Provider(
            Company company, 
            Bank bank, 
            string account, 
            string iNN)
        {
            ProviderCompany = company;
            ProviderBank = bank;
            Account = account;
            INN = iNN;
        }
    }
}
