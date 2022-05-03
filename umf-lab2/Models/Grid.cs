namespace umf_lab2.Models;

/// <summary>
/// Класс, задающий локальную нумерацию узлов сетки и координаты узлов
/// </summary>
public class Grid
{
    public double[] LocalNumberNode;
    public double[] XValueNode;
    public readonly int AmountOfElements;

    public Grid(Area area)
    {
        AmountOfElements = area.AmountNodes - 1;

        LocalNumberNode = new double[area.AmountNodes];
        XValueNode = new double[area.AmountNodes];
        
        var lengthOfArea = area.RightBorder - area.LeftBorder;
        var initStep = lengthOfArea / AmountOfElements;
        var xCurrentDot = area.LeftBorder;
        
        //Вынес первую итерацию цикла for
        LocalNumberNode[0] = 1;
        XValueNode[0] = area.LeftBorder;
        xCurrentDot = xCurrentDot + initStep;
        
        
        for (int i = 1; i < AmountOfElements ; i++)
        {
            var step = initStep * area.DischargeCoefficient;
            LocalNumberNode[i] = i + 1;
            XValueNode[i] = xCurrentDot;
            xCurrentDot += step;
        }

        XValueNode[area.AmountNodes - 1] = area.RightBorder;
        LocalNumberNode[area.AmountNodes - 1] = area.AmountNodes;
    }

    public void PrintGrid()
    {
        Console.WriteLine("Список локальных номеров сетки:");
        foreach (var item in LocalNumberNode)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Список значений x в узлах сетки");
        foreach (var item in this.XValueNode)
        {
            Console.WriteLine(item);
        }
    }
}