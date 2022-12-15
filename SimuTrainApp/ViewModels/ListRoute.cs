using SimuTrainApp.Models;

namespace SimuTrainApp.ViewModels
{
    public class ListRouteVM
    {
        public string Title { get; set; }
        public List<Station> MyDashBoardstations { get; set; } = new List<Station>();
        public List<RouteOfTrain> routes { get; set; } = new List<RouteOfTrain>();


        public ListRouteVM()
        {
            this.Title = "List Routes";
            initialisedata();
        }

        public void initialisedata()
        {
            ListStationVM lS = new ListStationVM();
            MyDashBoardstations = lS.stations;

            routes.Add(new RouteOfTrain(MyDashBoardstations[0], "12h30", "13h00", MyDashBoardstations[1]));
            routes.Add(new RouteOfTrain(MyDashBoardstations[1], "13h35", "14h05", MyDashBoardstations[2]));


        }
    }
}
