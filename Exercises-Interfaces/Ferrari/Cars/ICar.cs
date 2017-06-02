namespace Ferrari.Cars
{
    public interface ICar
    {
        string NameOfDriver { get; }

        string Model { get; }

        string UseBrakes();

        string PushTheGasPedal();


    }
}
