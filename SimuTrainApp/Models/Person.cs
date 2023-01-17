using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimuTrainApp.Models
{
    public class Person
    {
        #region "Properties"
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("IdStation")]
        [Display(Name = "Station")]
        public virtual Station? CurrentStation { get; set; }

        [ForeignKey("IdTrain")]
        [Display(Name = "Train")]
        public virtual Train? CurrentTrain { get; set; }
        #endregion

        public Person()
        {

        }

        public Person(
            string Name)
        {

            this.Name = Name;   

        }


    }
}
