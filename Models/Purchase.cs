
using System;
using System.ComponentModel.DataAnnotations;

namespace GameForge.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }  // Foreign key to the user
        public int GameId { get; set; }  // Foreign key to the game
        public DateTime PurchaseDate { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public Game? Game { get; set; }


    }
}