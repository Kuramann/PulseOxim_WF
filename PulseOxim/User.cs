using Google.Cloud.Firestore;

namespace PulseOxim
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string ID { get; set; }
        [FirestoreProperty]
        public string Nume { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public string Puls { get; set; }
        [FirestoreProperty]
        public string SPO2 { get; set; }
        [FirestoreProperty]
        public string Telefon { get; set; }
        [FirestoreProperty]
        public string Temperatura { get; set; }
    }
}
