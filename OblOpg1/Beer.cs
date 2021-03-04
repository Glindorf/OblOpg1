using System;

namespace OblOpg1
{
    public class Beer
    {
        /// <summary>
        /// Initialisering
        /// </summary>

        private string _name;
        private double _price;
        private double _abv;

        /// <summary>
        /// Her er to constructore - den anden af dem (uden parametre) er til brug i opg. 4
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="abv"></param>

        public Beer(int id, string name, double price, double abv)
        {
            Id = id;
            Name = name;
            Price = price;
            Abv = abv;
        }

        public Beer()
        { }

        /// <summary>
        /// Property for Id
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Property for Name. Navnet skal være på mindst fire characters, ellers kastes en Exception.
        /// </summary>

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException();
                _name = value;
            }
        }

        /// <summary>
        /// Property for Price. Prisen skal være højere end 0 kr, ellers kastes en Exception.
        /// </summary>

        public double Price
        {
            get => _price;
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        /// <summary>
        /// Property for Abv (Alcohol by volume). Den skal være mellem 0 og 100, ellers kastes en Exception.
        /// </summary>

        public double Abv
        {
            get => _abv;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException();
                _abv = value;
            }
        }

        public override string ToString()
        {
            return $"Id number {Id}, Name: {Name}. Alcohol by volume is: {Abv} and the price is: {Price}."; 
        }
    }
}
