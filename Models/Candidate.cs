using Google.Cloud.Firestore;

namespace VotingWorkshop.Models
{
    [FirestoreData]
    public class Candidate
    {
        [FirestoreProperty]
        public String ID { get; set; }

        [FirestoreProperty]
        public String Name { get; set; }

        [FirestoreProperty]
        public String Description { get; set; }

        [FirestoreProperty]
        public String Party { get; set; }

        [FirestoreProperty]
        public String Image { get; set; }
    }
}
