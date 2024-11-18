using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public enum Banks
    {
        Sberbank, AlphaBank, TBank, VTB 
    }
    public class Provider
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public Banks Bank { get; set; }
        public string Account { get; set; }
        public string INN { get; set; }
        
        public Provider(string name, string address, string fullName, string phoneNumber, Banks bank, string account, string iNN)
        {
            Name = name;
            Address = address;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Bank = bank;
            Account = account;
            INN = iNN;
        }
    }
}
