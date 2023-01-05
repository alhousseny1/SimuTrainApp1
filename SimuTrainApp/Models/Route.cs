namespace SimuTrainApp.Models
{
    public class RouteOfTrain
    {


        #region "Properties Route"

        public Station DepartureStation { get; set; }
        public TimeOnly DepartureTime { get; set; }
        public TimeOnly ArrivalTime { get; set; }
        public int Distance { get; set; }
        public Station ArrivalStation { get; set; }

        public TimeSpan Horaire { get; set; }

        #endregion

        #region "Constructor Route"

        public RouteOfTrain()
        {

        }

        public RouteOfTrain(Station IdDepartureStation, TimeOnly departureTime, TimeOnly arrivalTime, int Distance, Station IdArrivalStation, TimeSpan Horaire)
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
