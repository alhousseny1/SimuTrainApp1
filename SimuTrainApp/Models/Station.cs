using System.ComponentModel.DataAnnotations;
using SimuTrainApp.ViewModels;

namespace SimuTrainApp.Models;

public class Station
{
    #region "Properties Station"
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Place { get; set; }
    public int? NBParcels { get; set; }
    public int? NBPassenger { get; set; }
    public Train? TrainInStation { get; set; }

    #endregion

    #region "Constructor STation"
    public Station()
    {

    }
    public Station(
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

    #region "Methods"

    #endregion
}