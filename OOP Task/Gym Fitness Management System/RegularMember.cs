using System;
class Regular_Member_Class : Member_Class
{
    public double Workout_Plan_Fee = 0;
    public Regular_Member_Class(string Name, int Age, double Workout_Plan_Fee)
    {
        this.Name = Name;
        this.Age = Age;
        this.Workout_Plan_Fee = Workout_Plan_Fee;
        this.Member_ID = NumberOfMembers;
        NumberOfMembers++;
        Console.WriteLine("Created New Member " + Name + " With ID " + this.Member_ID);
    }
    public void Set_Workout_Plan_Fee(double temp)
    {
        Workout_Plan_Fee = temp;
    }
    public override double Calculate_Monthly_Fee()
    {
        return 50 + Workout_Plan_Fee;
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


}