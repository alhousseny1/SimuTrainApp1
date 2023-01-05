using SimuTrainApp.Models;
using System.Collections.Immutable;

namespace SimuTrainApp.ViewModels
{
    public class ListTrainVM
    {
        public string Title { get; set; }
        public List<Train> trains { get; set; } = new List<Train>();
        public List<RouteOfTrain> ListRoute { get; set; } = new List<RouteOfTrain>();

        public ListTrainVM()
        {
            this.Title = "Liste de Trains";
            initialisedata();
        }

        public void initialisedata()
        {
            ListRouteVM lR = new ListRouteVM();
            ListRoute = lR.routes;
            trains.Add(new Train("TerSample1", 100, 50, 25, 60, ListRoute[0]));
            trains.Add(new Train("TerSample2", 100, 50, 50,60, ListRoute[0]));
            trains.Add(new Train("TerSample3", 100, 30, 45,60, ListRoute[1]));
            trains.Add(new Train("TerSample3", 100, 100, 0,60, ListRoute[1]));
            trains.Add(new Train("TerSample4", 100, 0, 100,60, ListRoute[1]));
        }
    }
}