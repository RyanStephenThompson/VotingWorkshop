using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using VotingWorkshop.Data;
using VotingWorkshop.Models;


namespace VotingWorkshop.Controllers
{
    public class CandidateController : Controller

    { 

        FirestoreDB db;
    
        public CandidateController()
        {
            db = new FirestoreDB("candidates");           
        }


        public void AddCandidate(Candidate candidate)
        {
            try
            {
                 db.AddToDB(candidate);
            }
            catch (Exception ex){ Console.WriteLine(ex); }
        }

        public async Task<Candidate> getCandidate(String ID)
        {
            try
            {
                DocumentSnapshot documentSnapshot = await db.readDocument(ID);


                if (documentSnapshot == null) 
                { 
                    return   null; 
                }
                else
                {
                    
                    Candidate candidate =  documentSnapshot.ConvertTo<Candidate>();



                    return candidate;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }
        }
    }
}
