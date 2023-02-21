namespace SystemGym.Application.InputModels.v1.Client
{
    public class UpdateClientInputModel
    {
        public UpdateClientInputModel(string name, int age, string phone, string document, string email)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Document = document;
            Email = email;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Phone { get; private set; }
        public string Document { get; private set; }
        public string Email { get; set; }
    }
}
