namespace ConsoleAppDatabase
{
    public class Student
    {
        public int StudentID { get; set; }
        public string MobilNr { get; set; }
        public string Navn { get; set; }

        public Student(int studentid, string mobilnr, string navn)
        {
            StudentID = StudentID;
            MobilNr = mobilnr;
            Navn = navn;
        }
    }
}