Shape s1 = new Shape { H = 10, W = 5 };
//reference variable   //object type
s1.Draw();
Console.WriteLine(s1.CalculateArea());

Rectangle r1 = new Rectangle { H = 10, W = 5 };
r1.Draw();
Console.WriteLine(r1.CalculateArea());

Triangle t1 = new Triangle { H = 10, W = 5 };
t1.Draw();
Console.WriteLine(t1.CalculateArea());

Shape s2 = new Rectangle(); 
//valid only when it is a child class of base class
//Base class reference variable can hold derived type object.
class Shape
{
    public int W { get; set; }
    public int H { get; set; }

    public virtual void Draw()  //non polymorphic i.e; static polymorphic compiler takes decision on executing this.
    {
        Console.WriteLine("Drawing Shape..");
    }
    public virtual int CalculateArea()
    {
        return W * H;
    }
}

class Rectangle:Shape  
//Inheritance ( is a relationship ) Generalization  go for only reralisation
//class inherits from interface is realization.
//instead of extend use :
{
    override public void Draw() //it will hide the inherited member and it will execute.
        //to oveercome this put new near public.
    {
        Console.WriteLine("Drawing Rectangle.."); //when change needed reimplmemt the method
    }
    
}
class Triangle : Shape
{
    override public void Draw() //use override instead of new 
    {
        Console.WriteLine("Drawing Triangle..");
    }
    override public int CalculateArea()
    {
        int area = H * W;
        return area / 2; //need to call baseclass method from child class.
    }
}