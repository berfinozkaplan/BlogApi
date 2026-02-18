namespace BlogApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty; // Yorum içeriği
        public int ArticleId { get; set; } // Hangi makaleye yapıldı?
        public int UserId { get; set; } // Kim yaptı?
    }
}