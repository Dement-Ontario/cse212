public class FeatureCollection
{
    public Features[] Features { get; set; }
}

public class Features
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public decimal Mag { get; set; }
}