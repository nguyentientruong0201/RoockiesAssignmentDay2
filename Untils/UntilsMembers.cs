using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSCFirst.Untils
{
    public class UntilsMembers
    {
        public List<Member> Members;
        public UntilsMembers() {
            Members = InitMembers();

        }
        private List<Member> InitMembers() => new List<Member>{
                new Member{
              FirstName = "Truong",
              LastName = "Nguyen Tien",
              Gender = Gender.Male,
              dateOfBirth = new GetDateOfBirth(2000, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Bac Ninh",
              IsGraduated = false
          },
          new Member{
              FirstName = "Hai",
              LastName = "Nguyen Van",
              Gender = Gender.Male,
              dateOfBirth = new DateTime(2001, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Ha Noi",
              IsGraduated = false
          },
          new Member{
              FirstName = "Nam",
              LastName = "Nguyen Thanh",
              Gender = Gender.Male,
              dateOfBirth = new DateTime(2002, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Bac Giang",
              IsGraduated = false
          },
          new Member{
              FirstName = "Tuan",
              LastName = "Tran Tien",
              Gender = Gender.Male,
              dateOfBirth = new DateTime(2003, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Bac Kan",
              IsGraduated = false
          },
            };
    }
}