using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SimuTrainApp.Models
{
    public class Parcel
    {
        #region "Properties"

        public enum TypeOfParcel
        {
            suitcase,
            boxes,
            bag
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "TypeOfParcel")]
        [Required]
        public TypeOfParcel Type { get; set; }

        [Display(Name ="IdTrain")]
        public int IdTrain { get; set; }

        [ForeignKey("IdStation")]
        [Display(Name = "Station")]
        public virtual Station? CurrentStation { get; set; }

        [ForeignKey("IdTrain")]
        [Display(Name = "Train")]
        public virtual Train? CurrentTrain { get; set; }



        #endregion

        public Parcel()
        {

        }

        public Parcel(
            TypeOfParcel type)
        {
            this.Type = type;

        }   
    }
}
