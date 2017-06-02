namespace Ferrari.Cars
{
   public class Ferrari : ICar
    {
        public Ferrari(string nameOfDriver)
        {
            this.NameOfDriver = nameOfDriver;
            this.Model = "488-Spider";
        }

        public string NameOfDriver { get; private set; }
        public string Model { get; private set; }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }
    }
}
