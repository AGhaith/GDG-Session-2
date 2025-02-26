using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
class Gym_Class : IGymManagement
{
    public String Gym_Name;
    public Gym_Class(string name)
    {
        this.Gym_Name = name;
    }
    public List<Member_Class> Member_list = new List<Member_Class>();

    public void Add_Member(Member_Class member)
    {
        Member_list.Add(member);
        Console.WriteLine("Member Number : " + member.Get_ID() + "Was Successfully Added.");
    }
    public void Display_All_Members()
    {
        foreach (Member_Class member in Member_list)
        {
            member.Display_Details();
        }
    }


}