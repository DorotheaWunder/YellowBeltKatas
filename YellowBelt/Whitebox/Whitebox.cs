using System.Diagnostics;

namespace ExamKata;

public class GameFlow
{
    private string _name;
    private FakeNpc _npc;

    public GameFlow(string name, FakeNpc npc)
    {
        _name = name;
        _npc = npc;
    }

    public void RunGame()
    {
        _npc.Execute();
    }
    

    public void PrintName()
    {
        Console.WriteLine(_name);
    }
}

public class FakeNpc
{
    private GameFlow _gameFlowReference;

    public FakeNpc(GameFlow gameflowRef)
    {
        _gameFlowReference = gameflowRef;
    }

    public void Execute()
    {
        _gameFlowReference.PrintName();
    }
}

public class IntegerHolder
{
    private int _myInt;

    public IntegerHolder(int intToStore)
    {
        _myInt = intToStore;
    }

    public void AddOneToMyInt()
    {
        _myInt = _myInt + 1;
    }

    public int GetMyValue()
    {
        return _myInt;
    }
}

public class Whitebox
{
    public static void Main()
    {
        FakeNpc npc = new FakeNpc(new GameFlow("null", null));
        
        GameFlow gameFlow = new GameFlow("Doro", npc);
        gameFlow.RunGame();
        // FakeNpc npc = new FakeNpc(gameFlow);
        // npc.Execute();

        // int intValue = 5;
        // IntegerHolder integerHolder = new IntegerHolder(intValue);
        //
        // Add1ToIntegerAndPrint(intValue, integerHolder);
        // Add1ToIntegerAndPrint(intValue, integerHolder);
    }

    // public static void Add1ToIntegerAndPrint(int intValue, IntegerHolder integerHolder)
    // {
    //     intValue = intValue + 1;
    //     integerHolder.AddOneToMyInt();
    //     
    //     Console.WriteLine("IntValue: " + intValue);
    //     Console.WriteLine("IntegerHolder: " + integerHolder.GetMyValue());
    // }
}