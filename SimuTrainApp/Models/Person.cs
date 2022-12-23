namespace SimuTrainApp.Models
{
    public class Person
    {
        #region "Properties"
        private static int NextId = 1;

        public int? ID { get; set; }
        public string Name { get; set; }
        #endregion

        public Person()
        {

        }

        public Person(
            string Name)
        {
            this.ID= NextId;
            this.Name = Name;   

            NextId++;
        }


    }
}
