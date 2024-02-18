namespace VotingWorkshop.Services
{
    using System.Threading.Tasks;
    using Google.Cloud.Firestore;

    public class CandidateService
    {
        private readonly FirestoreDb _firestoreDb;

        public CandidateService(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }


        //reads the description of the candidate from firestore
        public async Task<string> GetCandidateLongDescriptionAsync(string candidateId)
        {
            DocumentReference docRef = _firestoreDb.Collection("candidates").Document(candidateId);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.GetValue<string>("LongDesc");
            }
            else
            {
                return null;
            }
        }



    }

}

