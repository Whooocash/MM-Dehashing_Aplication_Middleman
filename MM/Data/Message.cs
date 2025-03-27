namespace MM.Data
{
    public class Message
    {
        public int Id { get; set; }            // Unikalny identyfikator wiadomości
        public string Sender { get; set; }     // Nazwa użytkownika wysyłającego wiadomość
        public string Receiver { get; set; }   // Nazwa użytkownika odbierającego wiadomość
        public string Content { get; set; }    // Treść wiadomości
        public DateTime Timestamp { get; set; } // Data i godzina wysłania wiadomości
    }
}
