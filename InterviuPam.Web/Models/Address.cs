using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviuPam.Web.Models;

[Table("Address", Schema = "SalesLT")]
public class Address
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int AddressID { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string CountryRegion { get; set; }
    public string StateProvince { get; set; }
    public DateTime ModifiedDate { get; set; }
    [ForeignKey("AddressID")]
    public ICollection<CustomerAddress> CustomerAddresses { get; set; }

}