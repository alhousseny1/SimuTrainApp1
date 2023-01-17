using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SimuTrainApp.Models;

public class Station
{
    #region "Properties Station"
    [Key]
    public int Id { get; set; }
    [Display(Name = "Name Of Station")]
    [MaxLength(50)]
    public string Name { get; set; }
    [Display(Name = "Place")]
    [MaxLength(50)]
    [Required]
    public string Place { get; set; }

    [ForeignKey("IdRoute")]
    [Display(Name = "route")]
    public virtual RouteOfTrain Route { get; set; }
    public virtual List<Person>? Passengers { get; set; }
    public virtual List<Parcel>? Parcels { get; set; }
    public virtual List<Train>? TrainsInStation { get; set; }

    #endregion

    #region "Constructor STation"
    public Station()
    {

    }
    public Station(
        string Name,
        string Place,
        List<Train> trains,
        List<Person> Passengers,
        List<Parcel> Parcels)
    {
        this.Name = Name;
        this.Place = Place;
        this.TrainsInStation = trains;
        this.Parcels = Parcels;
        this.Passengers = Passengers;
    }
    #endregion

    #region "Methods"

    #endregion
}