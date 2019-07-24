using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHire.Core.Domain.Entities
{
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string EngineNumber { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelConsumption { get; set; }
        public int FuelTypeId { get; set; }
        public int InstitutionId { get; set; }
        public int GearTansmissionTypeId { get; set; }
        public int SeatingCapacity { get; set; }
        public int VehicleModelId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public virtual IEnumerable<HireRequest> HireRequests { get; set; }
        public virtual IEnumerable<HiredVehicleSignOff> HiredVehicleSignOffs { get; set; }
        public virtual IEnumerable<HiredVehicle> HiredVehicles { get; set; }
        public virtual IEnumerable<VehicleMaitenance> VehicleMaitenances { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual GearTransmission GearTransmission { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
