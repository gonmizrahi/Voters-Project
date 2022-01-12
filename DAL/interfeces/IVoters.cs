using DAL.Databases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
     public interface IVoters
    {
        List<Voter> GetVoters() ;

        List<Voter> GetVoterById(int id);

        List<Voter> GetVotersByParty(string party);

        List<Voter> GetVotersByCity(string voter);

        Voter UpdateVoter(Voter voter);

        Voter VoterLogin(Voter voter);

        
    }
}
