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
        
        //Вынес первую итерацию цикла for
        LocalNumberNode[0] = 1;
        XValueNode[0] = area.LeftBorder;

        if (Math.Abs(area.DischargeCoefficient - 1) > 1e-10)
        {
            // При неединичном коэф разрядки используем геом прогрессию
            var sumGeomProgress =
                (1 - Math.Pow(area.DischargeCoefficient, AmountOfElements)) / (1 - area.DischargeCoefficient);
            var stepWithDischarge = lengthOfArea / sumGeomProgress;
            
            for (int i = 1; i < AmountOfElements; i++)
            {
                LocalNumberNode[i] = i + 1;
                XValueNode[i] =
                    area.LeftBorder + stepWithDischarge * (1 - Math.Pow(area.DischargeCoefficient, i)) /
                    (1 - area.DischargeCoefficient);
            }
        }
        else
        {
            var stepWithoutDischarge = lengthOfArea / AmountOfElements; // шаг без коэф разрядки

            for (int i = 1; i < AmountOfElements; i++)
            {
                LocalNumberNode[i] = i + 1;
                XValueNode[i] = area.LeftBorder + i * stepWithoutDischarge;
            }
    
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