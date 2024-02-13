namespace VotingWorkshop
{
    using FirebaseAdmin;
    using Google.Apis.Auth.OAuth2;
    using Microsoft.AspNetCore.Builder.Extensions;

    public class FirebaseService
    {
        public static void Initialize()
        {
            FirebaseApp.Create(new AppOptions
            {
                Credential = GoogleCredential.FromFile("voting - workshop - fc2cc - firebase - adminsdk - q7o57 - 87b90ffd00.json")
            });
        }

        // Add additional methods to interact with Firebase services as needed
    }

}
