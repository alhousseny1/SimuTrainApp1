namespace SimuTrainApp.Models;

public class Station
{
    #region "Properties Station"
    public string Name { get; set; }
    public string Place { get; set; }
    public int NBParcels { get; set; }
    public int NBPassenger { get; set; }
    public int IdTrainInStation { get; set; }

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