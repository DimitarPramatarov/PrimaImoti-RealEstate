namespace PrimaImoti.DataModels
{
    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Created {get; set;}

        public  Person Sender {get; set;}
    }
}
