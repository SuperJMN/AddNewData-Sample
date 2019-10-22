namespace App2
{
    public class Message
    {
        public Message()
        {
        }

        public Message(string sender, string recipient)
        {
            Sender = sender;
            Recipient = recipient;
        }

        public string Sender { get; set; }
        public string Recipient { get; set; }
    }
}