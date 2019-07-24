using EHire.Core.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EHire.Core.Domain.Entities
{
    public class Admin /*: BaseEntity*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual IEnumerable<Region> Regions { get; set; }
        public virtual IEnumerable<FuelType> FuelTypes { get; set; }
        public virtual IEnumerable<HiringActivity> HiringActivities { get; set; }
        public virtual IEnumerable<MaintenanceType> MaintenanceTypes { get; set; }
        public virtual IEnumerable<PaymentOptions> PaymentOptions { get; set; }
        public virtual IEnumerable<Reason> Reasons { get; set; }
        public virtual IEnumerable<ReasonType> ReasonTypes { get; set; }
        public virtual IEnumerable<PasswordDictionary> PasswordDictionaries { get; set; }
        public virtual IEnumerable<Role> Roles { get; set; }
        public virtual IEnumerable<Town> Towns { get; set; }
        public virtual IEnumerable<GearTransmission> GearTransmissions { get; set; }
        public virtual IEnumerable<UserTypes> UserTypes { get; set; }
        public virtual IEnumerable<VehicleBrand> VehicleBrands { get; set; }
        public virtual IEnumerable<VehicleModel> VehicleModels { get; set; }
        public virtual IEnumerable<VehicleType> VehicleTypes { get; set; }
    }
}
