namespace BlogApi.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; // Başlık
        public string Content { get; set; } = string.Empty; // İçerik
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Oluşturulma Tarihi
        public int UserId { get; set; } // Yazarın Id'si
    }
}