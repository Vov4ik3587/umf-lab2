namespace umf_lab2.Models;

public class Constants
{
    private double Lambda { get; init; }
    private double Gamma { get; init; }
    public Constants(double lambda, double gamma)
    {
        Lambda = lambda;
        Gamma = gamma;
    }
    
}