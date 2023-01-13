using SimuTrainApp.Models;
using Route = SimuTrainApp.Models.Route;

namespace SimuTrainApp.ViewModels
{
    public class Transit
    {
        public static Train TransitTrain { get; set; }
        public static Route TransitRoute { get; set; }
        public static Station TransitStation { get; set; }
    }
}