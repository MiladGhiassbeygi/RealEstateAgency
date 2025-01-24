using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities.EstateFiling
{
    public class Apartment:BaseEntity
    {
        public string Code { get; set; }
        public string PostCodeMM { get; set; }
        public string PostCodeOldMM { get; set; }
        public string PelakSabti { get; set; }
        public string Farei { get; set; }
        public string Area { get; set; }
        public string ZoneCode { get; set; }
        public string TelStatusCode { get; set; }
        public string TelMM { get; set; }
        public string AddressMM { get; set; }
        public string Imported { get; set; }
        public string Farei1 { get; set; }
        public string Farei2 { get; set; }
        public string HozehSabti { get; set; }
        public string BakhshSabti { get; set; }
        public string MantagheShahrdari { get; set; }
        public string LifeTimeMM { get; set; }
        public string FrameTypeCode { get; set; }
        public string TenementID { get; set; }
        public string ConflictsComment { get; set; }
        public string HasConflict { get; set; }
        public string ZoneID { get; set; }
        public string TelStatusID { get; set; }
        public string SaleSakht { get; set; }
        public string ContradictionCode { get; set; }
        public string ContradictionDescription { get; set; }
        public string IsPostAddress { get; set; }
        public string TenementTelCityCode { get; set; }
        public string PieceRegisterd { get; set; }
        public string ParkingPlakNo { get; set; }
        public string WarehouseNo { get; set; }
        public string SubscriptionRightCode { get; set; }
        public string BedRoomCount { get; set; }
        public string UseModeCode { get; set; }
        public string JointDescription { get; set; }
        public string WarehouseArea { get; set; }
        public string ElectricityBillNo { get; set; }
        public string WaterBillNo { get; set; }
        public string IsGazBillNoVerified { get; set; }
        public string GazKey { get; set; }
        public string IsGazResponse { get; set; }
        public string GazBillId { get; set; }
        public string IsVerifiedMunicipality { get; set; }
        public string IsMunicipalityResponse { get; set; }
        public string MunicipalityNo { get; set; }
        public string GazBillStatusCode { get; set; }
        public string WaterBillStatusCode { get; set; }
        public string ElectricityBillStatusCode { get; set; }
        public string MunicipalityBillStatusCode { get; set; }
        public string ElectricityKey { get; set; }
        public string IsElectricityBillNoVerified { get; set; }
        public string IsElectricityResponse { get; set; }
        public string FloorSideCode { get; set; }
        public string LineCount { get; set; }
        public string ParkingStatus { get; set; }
        public string WarehouseStatus { get; set; }
        public string IsWaterBillNoVerified { get; set; }
        public string IsWaterResponse { get; set; }
        public string WaterKey { get; set; }
        public string AddressMMOld { get; set; }
        public string Naheeh { get; set; }
        public string PelakSabti1 { get; set; }
        public string PelakSabti2 { get; set; }
        public string ElevatorStatus { get; set; }
    }
}
