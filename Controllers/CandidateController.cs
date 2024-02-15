using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingWorkshop.Services;

namespace VotingWorkshop.Controllers
{
    public class CandidateController : Controller

    {
        private readonly CandidateService _candidateService;

        

        public CandidateController(CandidateService candidateService)
        {
            Console.WriteLine("candid");
            _candidateService = candidateService;
        }

        // Get the details of the candidate 
        public async Task<IActionResult> Details(string id)
        {
            Console.WriteLine("details");
            string longDescription = await _candidateService.GetCandidateLongDescriptionAsync(id);
            
            ViewBag.LongDescription = longDescription;
            Console.WriteLine(longDescription);
            return View();
        }

    }
}
