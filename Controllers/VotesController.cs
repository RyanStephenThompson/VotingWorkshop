using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using VotingWorkshop.Data;
using VotingWorkshop.Models;

namespace VotingWorkshop.Controllers
{
    public class VotesController : Controller
    {
        FirestoreDB db;

        public VotesController()
        {
            db = new FirestoreDB("votes");
        }

        public void AddVote(String party)
        {
            try
            {
                db.incVotes(party);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public async Task<Votes> getVotes()
        {

            try
            {
                DocumentSnapshot documentSnapshot = await db.readDocument("bKtITbJlO5TmlbPTnlok");


                if (documentSnapshot == null)
                {
                    return null;
                }
                else
                {

                    Votes votes = documentSnapshot.ConvertTo<Votes>();



                    return votes;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }            
        }
    }
}
