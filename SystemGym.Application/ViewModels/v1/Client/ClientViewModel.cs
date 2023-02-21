namespace SystemGym.Application.ViewModels.v1.Client
{
    public class ClientViewModel
    {
        public ClientViewModel(string name, int age, string phone, bool active, string document)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Active = active;
            Document = document;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string Document { get; set; }
    }
}
