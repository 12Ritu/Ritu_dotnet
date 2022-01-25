using System;
namespace ApexRestaurant.Repository.Domain
{
 public class Customer
 {
 public int id { get; set; }
 public string firstname { get; set; }
 public string lastname { get; set; }
 public string address { get; set; }
 public string phoneres { get; set; }
 public string phonemob { get; set; }
 public DateTime enrolldate { get; set; }
 public bool isactive { get; set; }
 public string createdby { get; set; }
 public DateTime createdon { get; set; }
 public string updatedby { get; set; }
 public DateTime updatedon { get; set; }
 }
}