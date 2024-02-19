using Google.Cloud.Firestore;
using Google.Apis.Auth.OAuth2;

namespace VotingWorkshop.Data
{
    public class FirestoreDB
    {
        FirestoreDb db;
        String collection;

        public FirestoreDB(string collection)
        {
            try
            {
                db = FirestoreDb.Create("votingfirestore");
                Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "votingfirestore");
            }
            catch(Exception ex) { Console.WriteLine(ex); }


            this.collection = collection;
        }

        public async void AddToDB(String ID,Object obj)
        {
            try
            {
                await db.Collection(collection).Document(ID).SetAsync(obj);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public async Task<DocumentSnapshot> readDocument(String docID)
        {
            DocumentSnapshot documentSnapshot = null;
            try
            {
                documentSnapshot = await db.Collection(collection).Document(docID).GetSnapshotAsync();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return documentSnapshot;
        }

        public async void incVotes(String party)
        {                        
            DocumentReference docRef = db.Collection(collection).Document("bKtITbJlO5TmlbPTnlok");
            await docRef.UpdateAsync(party, FieldValue.Increment(1));
            await docRef.UpdateAsync("Total", FieldValue.Increment(1));
        }
    }
}
