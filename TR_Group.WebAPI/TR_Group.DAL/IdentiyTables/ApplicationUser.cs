
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Identity;
/* 
* using Microsoft.AspNetCore.Identity;
* This Namespace is use by 
* IdentityUser
* 
*/

namespace TR_Group.DAL.IdentiyTables
{
    public class ApplicationUser : IdentityUser
    {
        //  [Column(TypeName = "varchar(20)")]
# nullable disable
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

       // [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
      //  public string RoleType { get; set; }
      //  //public string? UserId { get; set; }
      //  public bool IsLogInSocialNetworking { get; set; }
      //  public string? OTP { set; get; }
      //  public DateTime OTPCreatedDate { set; get; }
      //  //public DateTime ModifyDate { get; set; }
      //  public string Gender { get; set; }
      //  public string Address { get; set; }
      ////  [Column(TypeName = "varchar(Max)")]
      //  public string ImageFile { get; set; }
      //  public double Latitude { get; set; }
      //  public double Longitude { get; set; }
      //  public bool IsActive { get; set; }
      //  public int VenderRating { get; set; }
      //  public string CompnyName { get; set; }
      //  public bool? IsApproved { get; set; }
      //  public string? ApprovedBy { set; get; }
      //  public DateTime? ApproveDate { set; get; }
      //  public string zipcode { set; get; }
        //public bool? IsActive { get; set; }
    }
}
