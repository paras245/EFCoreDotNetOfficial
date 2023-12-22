using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDotNetOfficial.Models
{
    //Access Modifer Class Keyword ClassName
    public class Product
    {
        //Class Members
        public int Id { get; set; }
        public string Name { get; set; } = null;

        //Data-Annotations
        [Column(TypeName ="decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
