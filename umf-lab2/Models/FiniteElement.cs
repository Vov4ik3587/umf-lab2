namespace umf_lab2.Models;

public class FiniteElement
{
    /// <summary>
    ///  Номер КЭ
    /// </summary>
    private int NumberOfFiniteElement { get; init; }
    
    /// <summary>
    /// Локальный номер левого узла
    /// </summary>
    private int LocalNumberOfLeftNode { get; init; }
    
    /// <summary>
    /// Локальный номер правого узла
    /// </summary>
    private int LocalNumberOfRightNode { get; init; }

    public FiniteElement(Grid grid, int numberOfFiniteElement)
    {
        NumberOfFiniteElement = numberOfFiniteElement;
        LocalNumberOfLeftNode = grid.LocalNumberNode[numberOfFiniteElement - 1];
        LocalNumberOfRightNode = grid.LocalNumberNode[numberOfFiniteElement];
    }
        
}