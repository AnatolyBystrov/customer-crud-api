using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models;

public class Customer
{
    public int CustomerID { get; set; }

    [Required(ErrorMessage = "Customer name is required.")]
    [StringLength(100, ErrorMessage = "Customer name cannot exceed 100 characters.")]
    public string CustomerName { get; set; } = string.Empty;

    [Phone(ErrorMessage = "Phone number is not valid.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Phone(ErrorMessage = "Fax number is not valid.")]
    public string FaxNumber { get; set; } = string.Empty;

    [StringLength(200, ErrorMessage = "Delivery address cannot exceed 200 characters.")]
    public string DeliveryAddressLine1 { get; set; } = string.Empty;

    [Required(ErrorMessage = "City name is required.")]
    [StringLength(50, ErrorMessage = "City name cannot exceed 50 characters.")]
    public string CityName { get; set; } = string.Empty;
}
