using System;
using VSCFirst.Enum;
using VSCFirst.Untils;

namespace VSCFirst
{
    class Program
    {
        static List<Member> members = new List<Member>{
          
        };

        static void Main(string[] args)
        {
            UntilsMembers untilsMembers = new UntilsMembers();
            var femaleMembers = untilsMembers.Members.Where(Gender == Enum.Gender.Female);
            var maleMembers = untilsMembers.Members.Where(Gender == Enum.Gender.Male);
            var otherMembers = untilsMembers.Members.Where(Gender == Enum.Gender.Other);       
        }
        
        static  void PrintData(List<Member> data){
            foreach (var item in data)
            {
                Console.WriteLine((item.LastName) (item.FirstName)  (item.dateOfBirth.toString("dd/MM/yyyy")));
                
            }

        }

        static List<Member> GetMaleMembers()
        {
           var result = new List<Member>{};
           foreach (var member in Members)
           {
               if(member.Gender == "Male")
               {
                   result.Add(member);
               }             
           }
           return result;
           
        }
    }
}
