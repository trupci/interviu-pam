using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviuPam.Web.Models;

[Table("Customer", Schema = "SalesLT")]
public class Customer
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int CustomerID { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string EmailAddress { get; set; }
    public string Phone { get; set; }
    [ForeignKey("CustomerID")]
    public ICollection<CustomerAddress> CustomerAddresses { get; set; }
}