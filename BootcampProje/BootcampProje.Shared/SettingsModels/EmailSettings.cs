namespace BootcampProje.Shared.SettingsModels
{
    //JSON Dosyasından ayrıntıları tutacak olan model
    public class EmailSettings
    {
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        
    }
}
