using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDotNetOfficial.Models
{
    //Access-Modifier class keyword ClassName
    public class Order
    {
        //Class Member
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }

        //If We dont give thisthen too ef core will create it in shadow property
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null;

        //Navigation Property Used For One to ManyRelationship
        public ICollection<OrderDetail> OrderDetails { get; set; } = null;
    }
}
