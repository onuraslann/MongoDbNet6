namespace MongoDbNet6.Models
{
    public interface IStudentStoreDatabaseSettings
    {
        public string StudentDbCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
