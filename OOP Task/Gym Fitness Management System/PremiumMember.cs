using System;
class Premium_Member_Class : Member_Class
{
    public double Personal_Trainer_Fee = 0;
    public double Diet_Plan_Fee = 0;
    public Premium_Member_Class(string Name, int Age, double Personal_Trainer_Fee, double Diet_Plan_Fee)
    {
        this.Personal_Trainer_Fee = Personal_Trainer_Fee;
        this.Diet_Plan_Fee = Diet_Plan_Fee;
        this.Name = Name;
        this.Age = Age;
        this.Member_ID = NumberOfMembers;
        NumberOfMembers++;
        Console.WriteLine("Created New Member " + Name + " With ID " + this.Member_ID);


    }
    public override double Calculate_Monthly_Fee()
    {
        return 100 + Personal_Trainer_Fee + Diet_Plan_Fee;
    }
    public override void Display_Details()
    {
        Console.WriteLine("---\nMember Details \n---");
        Console.WriteLine("ID : " + this.Get_ID());
        Console.WriteLine("Name : " + this.Name);
        Console.WriteLine("Age : " + this.Age);
        Console.WriteLine("Monthly Fee = " + this.Calculate_Monthly_Fee());
        Console.WriteLine("---");



    }
    public void Set_Personal_Trainer_Fee(double temp)
    {
        Personal_Trainer_Fee = temp;
    }
    public void Set_Diet_Plan_fee(double k)
    {
        Diet_Plan_Fee = k;
    }

}