using System;

namespace Gym_Fitness_Management_System
{

    class Program
    {
        static void Main(string[] args)
        {
            Gym_Class Sparta_Gym = new Gym_Class("Sparta");
            Regular_Member_Class Ahmed_Ghaith = new Regular_Member_Class("Ahmed", 20, 1000);
            Regular_Member_Class Abdullah_Hassan = new Regular_Member_Class("Abdullah", 20, 500);
            Premium_Member_Class Mohamed_Mohsen = new Premium_Member_Class("Mohmaemd", 30, 1000, 1500);
            Premium_Member_Class Omar_Emad = new Premium_Member_Class("Omar", 35, 10000, 2000);

            Sparta_Gym.Add_Member(Ahmed_Ghaith);
            Sparta_Gym.Add_Member(Abdullah_Hassan);
            Sparta_Gym.Add_Member(Mohamed_Mohsen);
            Sparta_Gym.Add_Member(Omar_Emad);
            Sparta_Gym.Display_All_Members();
        }
    }
}