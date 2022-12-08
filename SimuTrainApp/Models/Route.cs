namespace SimuTrainApp.Models
{
    public class RouteOfTrain
    {


        #region "Properties Route"

        public Station DepartureStation { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public Station ArrivalStation { get; set; }

        #endregion

        #region "Constructor Route"

        public RouteOfTrain()
        {

        }

        public RouteOfTrain(Station IdDepartureStation, String departureTime, string arrivalTime, Station IdArrivalStation)
        {
            this.DepartureStation = IdDepartureStation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            this.ArrivalStation = IdArrivalStation;
        }


        #endregion

    }
}
