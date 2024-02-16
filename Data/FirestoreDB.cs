using Google.Cloud.Firestore;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        public async void AddToDB(Object obj)
        {
            try
            {
                await db.Collection(collection).AddAsync(obj);
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
    }
}
