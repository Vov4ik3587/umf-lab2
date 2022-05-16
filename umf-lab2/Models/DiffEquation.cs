namespace umf_lab2.Models;

/// <summary>
/// Параметры диф уравнения, которое нам дано. Уравнение одномерное
/// TODO: на каждом КЭ свои значения констант, поэтому нужно придумать чета через массив
/// </summary>
public class DiffEquation
{
    /// <summary>
    /// Лямбда. Пока что коэффициент. TODO: сделать функцией от х
    /// </summary>
    private double Lambda { get; init; } 
    /// <summary>
    ///  Гамма. Всегда будет константой 
    /// </summary>
    private double Gamma { get; init; }
    
    /// <summary>
    /// Функция правой части. Нужна для тестирования работы программы
    /// </summary>
    public readonly Func<double, double> RightPart = x => 2 * x - 3;
    
    /// <summary>
    /// Истинная функция U. Нужна для тестирования работы программы
    /// </summary>
    public readonly Func<double, double> UStar = x => x;
    
    public DiffEquation(double lambda, double gamma)
    {
        Lambda = lambda;
        Gamma = gamma;
    }

    public void Print()
    {
        Console.WriteLine("Options of Diff Equation:");
        Console.WriteLine($"Lambda is: {this.Lambda}");
        Console.WriteLine($"Gamma is: {this.Gamma}");
        Console.WriteLine($"Func of right part is: {this.RightPart}");
        Console.WriteLine($"Func u* is: {this.UStar}");
    }
}