using SimuTrainApp.Models;

namespace SimuTrainApp.ViewModels
{
    public class ListRouteVM
    {
        
        public string Title { get; set; }
        public List<Station> MyDashBoardstations { get; set; } = new List<Station>();
        public List<RouteOfTrain> routes { get; set; } = new List<RouteOfTrain>();
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
            
            

            routes.Add(new RouteOfTrain(MyDashBoardstations[0], TimeOnly.Parse("13:30"), TimeOnly.Parse("14:45"), 60, MyDashBoardstations[1],Horaire));
            routes.Add(new RouteOfTrain(MyDashBoardstations[1], TimeOnly.Parse("13:30"), TimeOnly.Parse("14:37"), 60, MyDashBoardstations[2],Horaire));


        }
    }
}
