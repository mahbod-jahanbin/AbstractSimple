using AbstractSimple;

public class MyDerivedClass : SimpleAbstract
{
    public override void MyAbstractMethod()
    {
        throw new NotImplementedException();
    }

    public override string MyMahbodAbstractMethod()
    {
        return "mahbod";
    }
}
