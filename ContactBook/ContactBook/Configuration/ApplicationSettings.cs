namespace ContactBook.Configuration
{
    public class ApplicationSettings
    {
        public string ConnectionString { get; set; }

        public void Init(IConfiguration configuration)
        {
            ConnectionString = configuration[nameof(ConnectionString)];
        }
    }
}
