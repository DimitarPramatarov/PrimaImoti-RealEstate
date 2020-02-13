namespace PrimaImoti.DataModels.Contact
{
    public class EstateOwner : Person
    {
        public EstateOwner(string firstName, string lastName, string email, string phone)
            : base(firstName, lastName, email)
        {
            this.Phone = phone;
        }


        public string Phone { get; set; }
    }
}
