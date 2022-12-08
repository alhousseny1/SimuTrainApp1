﻿namespace SimuTrainApp.Models
{
    public class RouteOfTrain
    {


        #region "Properties Route"

        public int IdDepartureStation { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int IdArrivalStation { get; set; }

        #endregion

        #region "Constructor Route"

        public RouteOfTrain()
        {

        }

        public RouteOfTrain(int IdDepartureStation, String departureTime, string arrivalTime, int IdArrivalStation)
        {
            this.IdDepartureStation = IdDepartureStation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            this.IdArrivalStation = IdArrivalStation;
        }


        #endregion

    }
}
