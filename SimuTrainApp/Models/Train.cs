namespace SimuTrainApp.Models
{
    public class Train
    {
        #region "Properties Train"
        public string Matricule { get; set; }
        public int Capacity { get; set; }
        public int NBPassenger { get; set; }
        public int NBParcels { get; set; }
        public RouteOfTrain RouteOfTrain { get; set; }
        #endregion

        #region "Constructors Train"
        public Train()
        {

        }
        public Train(
            string Matricule,
            int Capacity,
            int NBPassenger,
            int NBParcels, RouteOfTrain Route)
        {
            this.Matricule = Matricule;
            this.Capacity = Capacity;
            this.NBPassenger = NBPassenger;
            this.NBParcels = NBParcels;
            this.RouteOfTrain = Route;
        }

        #endregion

        #region "Methods Train"

        #endregion

    }
}
