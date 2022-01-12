using DAL.Databases;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
   public class VotersFunctions : IVoters
    {
        VotersProjectContext context = new VotersProjectContext();

        /// <summary>
        /// get id from the controller and send back specific voter
        /// </summary>
        /// <param name="id">from controller</param>
        /// <returns>voter</returns>
        public List<Voter> GetVoterById(int id)
        {
            var voterById = context.Voters.Where(X => X.UserId == id).ToList();
            return voterById;
        }

        /// <summary>
        /// get all voters from DB
        /// </summary>
        /// <returns>list of voters</returns>
        // get voters 
        public List<Voter> GetVoters()
        {
            
            var votersList = context.Voters.ToList();
            return votersList;
        }

        /// <summary>
        /// get city from the controller and send back specific voter
        /// </summary>
        /// <param name="city">from controller</param>
        /// <returns>voter list by city</returns>
        public List<Voter> GetVotersByCity(string voter)
        {
            var votersByCity = context.Voters.Where(X => X.City == voter).ToList();
            return votersByCity;
        }

        /// <summary>
        /// get party from the controller and send back voters list
        /// </summary>
        /// <param name="party">from controller</param>
        /// <returns>voter list by party</returns>
        public List<Voter> GetVotersByParty(string party)
        {
            var votersByParty = context.Voters.Where(X => X.Vote == party).ToList();
            return votersByParty;
        }

        /// <summary>
        /// get vote request from controller and update vote in the db 
        /// </summary>
        /// <param name="voter">from controller</param>

        /// <returns>voter</returns>
        public Voter UpdateVoter(Voter voter)
        {
            var voteValidation = context.Voters.FirstOrDefault(X => X.UserId == voter.UserId);

            if (voteValidation.DidVote == "yes")
            {
                return null;
            }

            var upDateVoter = context.Voters.FirstOrDefault(X => X.UserId == voter.UserId);
            upDateVoter.Vote = voter.Vote;
            upDateVoter.DidVote = "yes";

            
            context.SaveChanges();


            return upDateVoter;
        }

        /// <summary>
        /// get login information from controller and check if exists
        /// </summary>
        /// <param name="voter"></param>
        /// <returns>voter</returns>
        public Voter VoterLogin(Voter user)
        {
            var voterLogin = context.Voters.FirstOrDefault(x => x.UserId == user.UserId && x.UserIdDate == user.UserIdDate);

            if (voterLogin != null)
            {
                return voterLogin;
            }
            return null;
        }
    }
}
