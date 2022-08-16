namespace MongoDbNet6.Models
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {
        public string StudentDbCollectionName {get;set;}
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
