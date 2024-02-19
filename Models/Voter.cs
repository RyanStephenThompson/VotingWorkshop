using Google.Cloud.Firestore;

namespace VotingWorkshop.Models
{
    [FirestoreData]
    public class Voter
    {
        [FirestoreProperty]
        public String ID { get; set; }

        [FirestoreProperty]
        public String Email { get; set; }

        [FirestoreProperty]
        public String Name { get; set; }

        [FirestoreProperty]
        public String Password { get; set; }

        [FirestoreProperty]
        public String confirmPassword { get; set; }
    }

}
