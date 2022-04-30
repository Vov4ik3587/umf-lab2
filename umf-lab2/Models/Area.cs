
namespace umf_lab2.Models;

/// <summary>
/// Организация расчетной области, по которой будет строиться сетка.
/// Область одномерная
/// </summary>
public class Area
{
    /// <summary>
    /// Левая граница области
    /// </summary>
    public double LeftBorder { get; init; }
    
    /// <summary>
    /// Правая граница области
    /// </summary>
    public double RightBorder { get; init; }

    /// <summary>
    /// Коэффициент разрядки - отношение длины следующего элемента области к предыдущему
    /// </summary>
    public double DischargeCoefficient { get; init; }
    
    /// <summary>
    /// Количество узлов в области, включая левую и правую границы\
    /// </summary>
    public int AmountNodes { get; init; }

    // public Area(double a, double b, double dischargeCoefficient, int amountNodes)
    // {
    //     LeftBorder = a;
    //     RightBorder = b;
    //     DischargeCoefficient = dischargeCoefficient;
    //     AmountNodes = amountNodes;
    // }

    public static int MakeGrid(Area? area)
    {
        return 0;
    }
}