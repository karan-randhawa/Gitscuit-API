using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json.Nodes;

namespace GitscuitAPI.Services
{
    public class AppService
    {
        public IConfiguration Configuration { get; private set; }

        public AppService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string Connect()
        {
            var connectionstring = Configuration.GetConnectionString("Gitscuit-Cluster");    

            var settings = MongoClientSettings.FromConnectionString(connectionstring);

            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));

                return "Pinged your deployment. You have successfully connected to MongoDB!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
