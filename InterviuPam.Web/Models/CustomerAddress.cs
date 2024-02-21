using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviuPam.Web.Models;

[Table("CustomerAddress", Schema = "SalesLT")]
public class CustomerAddress
{
    [Key, Column(Order = 0)]
    public int CustomerID { get; set; }
    [Key, Column(Order = 1)]
    public int AddressID { get; set; }
    public string AddressType { get; set; }
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("CustomerID")]
    public Customer Customer { get; set; }
    [ForeignKey("AddressID")]
    public Address Address { get; set; }
}
