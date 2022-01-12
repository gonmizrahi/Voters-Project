using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Databases
{
    public partial class Voter
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
        public int UserIdDate { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string DidVote { get; set; }
        public string Vote { get; set; }
    }
}
