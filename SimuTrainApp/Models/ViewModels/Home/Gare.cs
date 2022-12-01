namespace SimuTrainApp.Models.ViewModels.Home
{
    public class Gares
    {
        #region "Properties gare"
        public string Name { get; set; }
        public string Place { get; set; }
        public int NBParcels { get; set; }
        public int NBPassenger { get; set; }
        #endregion

        #region "Method gare"
        public Gares(
            string Name,
            string Place,
            int NBParcels,
            int NBPassenger)
        {
            this.Name = Name;
            this.Place = Place;
            this.NBParcels = NBParcels;
            this.NBPassenger = NBPassenger;
        }
        #endregion
    }
}
