﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimuTrainApp.Models
{
    public class Train
    {
        #region "Properties Train"

        [Key]
        public int Id { get; set; }
        [Display(Name = "Matricule")]
        [MaxLength(50)]
        public string Matricule { get; set; }
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }
        [Display(Name = "Color")]
        [MaxLength(25)]
        public string Color { get; set; }
        [Display(Name = "Speed")]
        public int Speed { get; set; }
        public List<Person>? Passengers { get; set; }
        public List<Parcel>? Parcels { get; set; }
        [ForeignKey("IdRoute")]
        [Display(Name = "RouteOfTrain")]
        public RouteOfTrain RouteOfTrain { get; set; }
        #endregion

        #region "Constructors Train"
        public Train()
        {

        }
        public Train(
            string Matricule,
            int Capacity,
            int Speed,
            string Color,
            List<Person> Passengers,
            List<Parcel> Parcels,
            RouteOfTrain Route)
        {
            this.Matricule = Matricule;
            this.Capacity = Capacity;
            this.Speed = Speed;
            this.Color = Color;
            this.Passengers = Passengers;
            this.Parcels = Parcels;
            this.RouteOfTrain = Route;

        }

        #endregion

        #region "Methods Train"

        #endregion

    }
}
