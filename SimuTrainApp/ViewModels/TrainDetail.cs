using SimuTrainApp.Models;

namespace SimuTrainApp.ViewModels
{
    public class TrainDetailVM
    {
        // view properties
        public string Title { get; set; }
        public string? ErrorMessage { get; set; }


        // model data properties
        public Train CurrentTrain { get; set; }


        // constructor
        public TrainDetailVM(
            Train? CurrentTrain = null,
            string? ErrorMessage = null)
        {
            if (CurrentTrain != null)
            {
                this.CurrentTrain = CurrentTrain;
                Title = $"Détail du Trajet ";
            }
            this.ErrorMessage = ErrorMessage;
        }

    }
}
