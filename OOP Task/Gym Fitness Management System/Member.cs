using System;
abstract class Member_Class
{
    protected int Member_ID = 0;
    protected static int NumberOfMembers = 1;
    protected string Name = "";
    protected int Age;
    public abstract double Calculate_Monthly_Fee();
    public abstract void Display_Details();
    public Member_Class()
    {
        Name = "";
        Age = 0;
    }
    public int Get_ID()
    {
        return this.Member_ID;
    }

}