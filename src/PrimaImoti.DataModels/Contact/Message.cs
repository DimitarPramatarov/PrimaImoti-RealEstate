namespace PrimaImoti.DataModels
{
    public class Message
    {

        public Message(string title, string newMessage)
        {
            this.Title = title;
            this.NewMessage = newMessage;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string NewMessage { get; set; }
    }
}
