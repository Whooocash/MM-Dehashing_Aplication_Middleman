namespace MM.Data
{
    public class User
    {
        public int Id { get; set; }             // Unikalny identyfikator użytkownika
        public string UserName { get; set; }    // Nazwa użytkownika
        public string PasswordHash { get; set; } // Zaszyfrowane hasło użytkownika (w zależności od potrzeb)
    }
}
