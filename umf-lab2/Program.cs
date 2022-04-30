using System.Text.Json;

namespace umf_lab2;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Решение нелинейной краевой задачи");
        
        // Считываем данные с json
        var area = JsonSerializer.Deserialize<Models.Area>(File.ReadAllText("input-data/area.json"));
        var funcs = JsonSerializer.Deserialize<Models.Func>(File.ReadAllText("input-data/func.json"));
        var boundaryConditions =
            JsonSerializer.Deserialize<Models.BoundaryConditions>(
                File.ReadAllText("input-data/boundaryConditions.json"));
        var accuracy = 
            JsonSerializer.Deserialize<Models.Accuracy>(File.ReadAllText("input-data/accuracy.json"));
        var grid = Models.Area.MakeGrid(area);
    }
}