using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDotNetOfficial.Models
{
    //Access Modifier Class Keyword ClassName 
    public class Customer
    {
        //Class Members

        //Access-Modifier datatype Getter Setter
        public int Id { get; set; }
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string? Address {  get; set; }
        public string? Phone {  get; set; }

        //Navigation Property Used For One to Many Relationship
        public ICollection<Order> Orders { get; set; } = null;
    }
}
