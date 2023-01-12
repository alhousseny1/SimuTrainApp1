using SimuTrainApp.Models;
using Route = SimuTrainApp.Models.Route;

namespace SimuTrainApp.ViewModels
{
    public class ListRouteVM
    {
        
        public string Title { get; set; }
        public List<Station> MyDashBoardstations { get; set; } = new List<Station>();
        public List<Route> routes { get; set; } = new List<Route>();
        public TimeSpan Horaire { get; private set; }


        public ListRouteVM()
        {
            this.Title = "List Routes";
            initialisedata();
        }

        public void initialisedata()
        {
            ListStationVM lS = new ListStationVM();
            MyDashBoardstations = lS.stations;
            
            

            routes.Add(new Route(MyDashBoardstations[0], TimeSpan.Parse("13:30"), TimeSpan.Parse("14:45"), 60, MyDashBoardstations[1],Horaire));
            routes.Add(new Route(MyDashBoardstations[1], TimeSpan.Parse("13:30"), TimeSpan.Parse("14:37"), 60, MyDashBoardstations[2],Horaire));


        }
    }
}
