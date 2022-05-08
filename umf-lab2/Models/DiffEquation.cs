namespace umf_lab2.Models;

/// <summary>
/// Параметры диф уравнения, которое нам дано. Уравнение одномерное
/// </summary>
public class DiffEquation
{
    /// <summary>
    /// Параметр лямбда. TODO: Сделать ее зависящей от функции решения 
    /// </summary>
    public string Lambda { get; init; } = string.Empty;
    
    /// <summary>
    /// Параметр Гамма. В моем варианте является константой
    /// </summary>
    public string Gamma { get; init; } = string.Empty;

    /// <summary>
    /// Функция правой части. Является нелинейной компонентой, будет аппроксимирована
    /// </summary>
    public string FuncOfRightPart { get; init; } = string.Empty;

    /// <summary>
    /// Функция истинного решения, к которому мы стремимся
    /// </summary>
    public string UStar { get; init; } = string.Empty;


}