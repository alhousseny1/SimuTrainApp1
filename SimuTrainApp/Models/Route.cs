using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;


namespace SimuTrainApp.Models
{
    
    public class Route
    {


        #region "Properties Route"
        [Key]
        public int Id { get; set; }
        public Station? DepartureStation { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public int Distance { get; set; }
        public Station? ArrivalStation { get; set; }

        public TimeSpan? Horaire { get; set; }

        #endregion

        #region "Constructor Route"

        public Route()
        {

        }

        public Route(Station IdDepartureStation, TimeSpan departureTime, TimeSpan arrivalTime, int Distance, Station IdArrivalStation, TimeSpan Horaire)
        {
            this.DepartureStation = IdDepartureStation;
            this.DepartureTime =  departureTime;
            this.ArrivalTime = arrivalTime;
            this.Distance = Distance;
            this.ArrivalStation = IdArrivalStation;
            this.Horaire = arrivalTime - departureTime;
        }


        #endregion

    }
}
