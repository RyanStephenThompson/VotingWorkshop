using FirebaseAdmin.Auth;
using FirebaseAdmin;
using Microsoft.AspNetCore.Mvc;
using VotingWorkshop.Models;
using System.Diagnostics;


namespace VotingWorkshop.Controllers
{
    public class VoterController : Controller
    {
       
        FirebaseApp app;
        FirebaseAuth auth;
        UserRecordArgs userRecordArgs;


        public VoterController()
        {
            app = FirebaseApp.Create();
            auth = FirebaseAuth.GetAuth(app);
            userRecordArgs = new UserRecordArgs();
        }



        //register a new user into firebase auth
        [HttpPost]
        public IActionResult Register(Voter voter)
        {
            Debug.WriteLine("adding "+voter.Email);

            userRecordArgs.Email = voter.Email;
            userRecordArgs.DisplayName = voter.Name;
            userRecordArgs.Password = voter.Password;

            createFirebaseUser(userRecordArgs,auth);

            Debug.WriteLine("success");
            return Content("Registration successful!");

        }


        // async helper function to create a user in firebase auth
        public async void createFirebaseUser(UserRecordArgs userRecordArgs, FirebaseAuth auth)
        {
            await auth.CreateUserAsync(userRecordArgs);
        }


    }
}

