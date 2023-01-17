using System.ComponentModel.DataAnnotations;

namespace SimuTrainApp.Models
{
    public class RouteOfTrain
    {


        #region "Properties Route"

        [Key]
        public int  Id { get; set; }
        [Display(Name ="NbRoute")]
        [Required]
        public int NbRoute { get; set; }
        public virtual List<Station>? StopStations { get; set; }

        #endregion

        #region "Constructor Route"

        public RouteOfTrain()
        {

        }


        #endregion

    }
}
