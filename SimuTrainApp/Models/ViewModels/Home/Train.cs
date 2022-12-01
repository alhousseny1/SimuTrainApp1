namespace SimuTrainApp.Models.ViewModels.Home
{
    public class Train
    {
        #region "Properties train"
        public string Matricule { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int Capacity { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public int NBPassenger { get; set; }
        public int NBParcels { get; set; }
        #endregion

        #region "Method train"
        public Train(
            string Matricule,
            string DepartureTime,
            string ArrivalTime,
            int Capacity,
            string DepartureStation,
            string ArrivalStation,
            int NBPassenger,
            int NBParcels)
        {
            this.Matricule = Matricule;
            this.DepartureTime = DepartureTime;
            this.ArrivalTime = ArrivalTime;
            this.Capacity = Capacity;
            this.DepartureStation = DepartureStation;
            this.ArrivalStation = ArrivalStation;
            this.NBPassenger = NBPassenger;
            this.NBParcels = NBParcels;
        }

        #endregion

    }
}
