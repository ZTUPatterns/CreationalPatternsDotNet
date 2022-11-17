// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using ClassLibrary.AbstractFactory;
using ClassLibrary.AbstractFactory.File;
using (var factory = new FileAbstractFactory("input.txt", "output.txt"))
{
    DataManipulator dataManipulator = new DataManipulator(factory);
    dataManipulator.DoCalculation();
}

