class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minuites)
    {
        return ExpectedMinutesInOven() - minuites;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int minuites)
    {
        return PreparationTimeInMinutes(layers) + ExpectedMinutesInOven() - RemainingMinutesInOven(minuites);
    }
}
