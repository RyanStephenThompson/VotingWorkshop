using Google.Cloud.Firestore;

namespace VotingWorkshop.Models
{

    [FirestoreData]
    public class Votes
    {
        [FirestoreProperty]
        public int Blue { get; set; }

        [FirestoreProperty]
        public int Red { get; set; }

        [FirestoreProperty]
        public int Green { get; set; }

        [FirestoreProperty]
        public int Total { get; set; }
    }
}
