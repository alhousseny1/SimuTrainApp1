using System.ComponentModel.DataAnnotations;
namespace SimuTrainApp.Models
{
    public class Train
    {
        #region "Properties Train"
        [Key]
        public int Id { get; set; }
        public string Matricule { get; set; }
        public int Capacity { get; set; }
        public int NBPassenger { get; set; }
        public int NBParcels { get; set; }
        public int Speed { get; set; }
        public Route RouteOfTrain { get; set; }
        
        public void StartEngine() { }
        #endregion
        //public virtual int Moving(int km, int speed) { return 1; }
        //public virtual int Moving(TimeSpan time, int speed) { return 0; }
        #region "Constructors Train"
        public Train()
        {

        }
        public Train(
            string Matricule,
            int Capacity,
            int NBPassenger,
            int NBParcels,
            int Speed,
            Route Route)
        {
            this.Matricule = Matricule;
            this.Capacity = Capacity;
            this.NBPassenger = NBPassenger;
            this.NBParcels = NBParcels;
            this.Speed = Speed;
            this.RouteOfTrain = Route;
        }

        #endregion
          //public class TestTrain : Train
          //  {
          //      public override int Moving(int km, int speed)
          //      {
          //          return (int)Math.Round(((double)km) / speed, 0);
          //      }
          //      public double GetTopSpeed()
          //      {
          //          return 100;
          //      }
          //  }

          //  static void Main()
          //  {
          //      TestTrain Tr = new();

          //      Tr.StartEngine();
          //      double speed = Tr.GetTopSpeed();
          //      var travelTime = Tr.Moving(speed: 60, km: 120);
          //      //Console.WriteLine("ma vitesse max est {0}", speed);
          //  }
        #region "Methods Train"

        #endregion
  
    }
}
