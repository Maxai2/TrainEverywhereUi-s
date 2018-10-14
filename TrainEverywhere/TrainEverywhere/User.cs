using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEverywhere
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public int? Chest { get; set; }

        public int? Arms { get; set; }

        public int? Shoulders { get; set; }

        public int? Waist { get; set; }

        public int? Calves { get; set; }

        public int? Quads { get; set; }

        public int? Id_Images { get; set; }

        public string Salt { get; set; }

        //public virtual Image Image { get; set; }
    }
}
