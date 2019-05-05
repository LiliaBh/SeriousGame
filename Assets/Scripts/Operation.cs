using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Operation{
    protected int a, b;
    public Operation(int a, int b){
        this.a = a;
        this.b = b;
    }
    public abstract string operationSymbol{get;}
    public string formula => this.a.ToString() + " " + this.operationSymbol + " " + this.b.ToString();
    public abstract int Result();
}
public class Sum : Operation{
    public override string operationSymbol => "+";

    public Sum(int a, int b) : base(a, b){}

    public override int Result() => this.a + this.b;

}

public class Substract : Operation
{
    public override string operationSymbol => "-";
    public Substract(int a, int b) : base(a, b){}
    public override int Result() => this.a - this.b;
}
