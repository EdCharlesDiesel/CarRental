namespace CarRental.Client.Entities
{
    public class Car 
    {
        private int _CarId;
        string _Description;
        int _Year;
        string _Color;
        decimal _RentalPrice;
        bool _CurrentlyRented;

        public int CarId
        {
            get { return _CarId; }
            set { _CarId = value; }
        }        

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public decimal RentalPrice
        {
            get { return _RentalPrice; }
            set { _RentalPrice = value; }
        }

        public bool CurrentlyRented
        {
            get { return _CurrentlyRented; }
            set { _CurrentlyRented = value; }
        }


    }
}
