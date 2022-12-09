using SimuTrainApp.Models;

namespace SimuTrainApp.ViewModels
{
    public class ListStationVM
    {
        public string Title { get; set; }
        public List<Station> stations { get; set; } = new List<Station>();

        public ListStationVM()
        {
            this.Title = "List Station";
            initialisedata();
        }

        public void initialisedata()
        {
            stations.Add(new Station("Chatelet les Halles", "Cgatelet", 50, 25));
            stations.Add(new Station("Gare du Nord", "Gare du nord", 250, 125));
            stations.Add(new Station("BFM", "Paris", 130, 43));

        }
    }
}
