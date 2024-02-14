namespace VotingWorkshop
{
    using FirebaseAdmin;
    using Google.Apis.Auth.OAuth2;
    using Google.Cloud.Firestore;

public class FirestoreInitializer
    {
        public FirestoreDb InitializeFirestore()
        {

            // Path to your service account key JSON file
            string pathToServiceAccountKey = "D:\\Desktop\\uni\\VotingWorkshop\\VotingWorkshop\\votingfirestore-firebase-adminsdk-4v0w1-e3173c3afe.json";
            try
            {
                // Create credentials from the service account key file
                GoogleCredential credential = GoogleCredential.FromFile(pathToServiceAccountKey);

                // Initialize FirebaseApp with credentials
                FirebaseApp.Create(new AppOptions
                {
                    Credential = credential
                });

                // Initialize FirestoreDb with the default project ID
                FirestoreDb firestoreDb = FirestoreDb.Create("votingfirestore");


                return firestoreDb;
            }
            catch
            {
                return null;
            }

        }
    }

}
