using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VotingWorkshop.Models;

namespace VotingWorkshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Candidate candidate;
        Votes votes;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async void calcVotes()
        {
            VotesController votesController = new VotesController();
            votes = await votesController.getVotes();
        }

        public IActionResult Index()
        {

            calcVotes();

            //force page to wait until data has been fetched
            while (votes == null)
            {
                continue;
            }

            return View(votes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async void setCandidate(String DocID)
        {

            CandidateController candidateController = new CandidateController();
            candidate =  await candidateController.getCandidate(DocID);

        }
        public IActionResult Candidates(String id)
        {
            setCandidate(id);

            //force page to wait until data has been fetched
            while (candidate == null) {
                continue;               
            }

            return View(candidate);
        }

        public async void incVotes(String party)
        {            
            VotesController votesController = new VotesController();
            votesController.AddVote(party);
        }

        public IActionResult ThankYou(String party)
        {
            incVotes(party);
            return View();
        }

        public IActionResult Vote()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

 
    }
}
