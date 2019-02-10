namespace CSDIntegrationApp.API.Models
{
    public class IntegrationRec
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string DateProcessed { get; set; }
        public int RecordsProcessed { get; set; }
        public string DateIndexed { get; set; }
        public int RecordsIndexed { get; set; }
        public string DateInterfaced { get; set; }
        public int RecordsInterfaced { get; set; }
    }
}