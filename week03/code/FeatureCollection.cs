public class FeatureCollection
{
    public Feature[] Features { get; set; }
}

public class Feature
{
    public Property Properties { get; set; }
}

public class Property
{
    public float Mag { get; set; }
    public string Place { get; set; }
}