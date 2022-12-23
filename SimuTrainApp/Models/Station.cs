namespace SimuTrainApp.Models;

public class Station
{
    #region "Properties Station"

    public string Name { get; set; }
    public string Place { get; set; }
    public List<Person> Passengers { get; set; }
    public List<Parcel> Parcels { get; set; }
    public List<Train> TrainsInStation { get; set; }

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