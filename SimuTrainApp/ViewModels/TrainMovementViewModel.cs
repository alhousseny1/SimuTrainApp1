using SimuTrainApp.Models;
using Route = SimuTrainApp.Models.Route;


namespace SimuTrainApp.ViewModels
{
    public class TrainMovementViewModel
    {
        public Train Train { get; set; }
        public Route Route { get; set; }
        public string DepartureStationName { get; set; }
        public string ArrivalStationName { get; set; }
    }

}
