namespace SimuTrainApp.Models
{
    public class Train
    {
        #region "Properties Train"

        private static int NextId = 1;
        public int? ID { get; set; }
        public string Matricule { get; set; }
        public int Capacity { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public List<Person> Passengers { get; set; }
        public List<Parcel> Parcels { get; set; }
        public RouteOfTrain RouteOfTrain { get; set; }
        #endregion

        #region "Constructors Train"
        public Train()
        {

        }
        public Train(
            string Matricule,
            int Capacity,
            int Speed,
            string Color,
            List<Person> Passengers,
            List<Parcel> Parcels,
            RouteOfTrain Route)
        {

            this.ID = NextId;
            this.Matricule = Matricule;
            this.Capacity = Capacity;
            this.Speed = Speed;
            this.Color = Color;
            this.Passengers = Passengers;
            this.Parcels = Parcels;
            this.RouteOfTrain = Route;

            NextId++;
        }

        #endregion

        #region "Methods Train"

        #endregion

    }
}
