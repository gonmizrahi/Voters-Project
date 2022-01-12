using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL.Databases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace VotetsProject.Controllers
{
    [EnableCors("pol1")]
    [Route("api")]
    [ApiController]
    public class VotersController : ControllerBase
    {
        VotersData votersData;

        public VotersController(VotersData _voters)
        {
            votersData = _voters;
        }
        /// <summary>
        /// get all voters from DB
        /// </summary>
        /// <returns>list of voters</returns>
        // get voters 
        [HttpGet]
        [Route("getvoters")]  //// https://localhost:44397/api/getvoters ***

        public IActionResult GetVoters()
        {
            

            return Ok(votersData.GetVoters());

        }

        /// <summary>
        /// get id from the client and send back specific voter
        /// </summary>
        /// <param name="id">from client</param>
        /// <returns>voter</returns>
        // get VoterById 
        [HttpGet]
        [Route("getvotersById/{id}")]  //// https://localhost:44397/api/getvotersById/id ***

        public IActionResult GetVotersById(int id)
        {

            return Ok(votersData.GetVoterById(id).ToList());

        }
        /// <summary>
        /// get city from the client and send back specific voter
        /// </summary>
        /// <param name="city">from client</param>
        /// <returns>voter list by city</returns>
        // getvotersByCity 
        [HttpGet]
        [Route("getvotersByCity/{city}")]  //// https://localhost:44397/api/getvotersByCity/ ***

        public IActionResult GetVotersByCity(string city)
        {
            
            

            return Ok(votersData.GetVotersByCity(city).ToList());

        }
        /// <summary>
        /// get party from the client and send back voters list
        /// </summary>
        /// <param name="party">from client</param>
        /// <returns>voter list by party</returns>
        // get voters by party
        [HttpGet]
        [Route("GetVotersByParty/{party}")]  //// https://localhost:44397/api/GetVotersByParty/ ***

        public IActionResult GetVotersByParty(string party)
        {

            return Ok(votersData.GetVotersByParty(party).ToList());

        }
        /// <summary>
        /// get login information from client and check if exists
        /// </summary>
        /// <param name="voter"></param>
        /// <returns>voter</returns>
        //Voter login
        [HttpPost]
        [Route("login")]  //// https://localhost:44397/api/login ***

        public IActionResult Login([FromBody] Voter voter) {

            var voterLogin = votersData.VoterLogin(voter);

            if (voterLogin == null)
            {
                return NotFound(null);
            }

            return Ok(voterLogin);


        }
        /// <summary>
        /// get vote request from client and update vote in the db
        /// </summary>
        /// <param name="voter">from client</param>
   
        /// <returns>voter</returns>
        //Voter UpDateVoter
        [HttpPost]
        [Route("vote")]  ////https://localhost:44397/api/vote ***
       
        public IActionResult vote([FromBody] Voter voter)
        {

            var voterUpDate = votersData.UpdateVoter(voter);

            if (voterUpDate == null)
            {
                return NotFound();
            }

            return Ok(voterUpDate);


        }


     




    }
}
