namespace umf_lab2.Models;

/// <summary>
/// Класс, задающий локальную нумерацию узлов сетки и координаты узлов
/// </summary>
public class Grid
{
    public List<double> LocalNumberNode = new List<double>();
    public List<double> XValueNode = new List<double>();
    public readonly int AmountOfElements;

    public Grid(Area area)
    {
        AmountOfElements = area.AmountNodes - 1;
        
        var lengthOfArea = area.RightBorder - area.LeftBorder;
        var initStep = lengthOfArea / AmountOfElements;
        var xCurrentDot = area.LeftBorder;
        
        //Вынес первую итерацию цикла for 
        LocalNumberNode.Add(1);
        XValueNode.Add(xCurrentDot);
        xCurrentDot = xCurrentDot + initStep;
        
        
        for (int i = 1; i < AmountOfElements ; i++)
        {
            var step = initStep * area.DischargeCoefficient;
            LocalNumberNode.Add(i+1);
            XValueNode.Add(xCurrentDot);
            xCurrentDot += step;
        }
        XValueNode.Add(area.RightBorder);
        LocalNumberNode.Add(area.AmountNodes);
    }

    public void PrintGrid()
    {
        Console.WriteLine("Список локальных номеров сетки:");
        foreach (var item in this.LocalNumberNode)
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