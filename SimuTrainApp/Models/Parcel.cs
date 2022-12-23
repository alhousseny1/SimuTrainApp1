namespace SimuTrainApp.Models
{
    public class Parcel
    {
        #region "Properties"
        private static int NextId = 1;

        public int? ID { get; set; }
        public string Type { get; set; }
        #endregion

        public Parcel()
        {

        }

        public Parcel(
            string type)
        {
            this.ID = NextId;
            this.Type = type;

            NextId++;
        }   
    }
}
