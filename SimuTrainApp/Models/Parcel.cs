using System.ComponentModel.DataAnnotations;
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
        public TypeOfParcel Type { get; set; }
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
