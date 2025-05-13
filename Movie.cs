namespace BlazorAppMediaRating;

using System.ComponentModel.DataAnnotations;



public class Movie
{
    public int Id { get; set; }
    
    [Required]
    public string? Title { get; set; }
    
    public string? Description { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
    
    public float? Rate { get; set; }
    public int? RateCount { get; set; }
    
    public string? ImageUrl { get; set; }
    
    // Dodatkowe pole dla funkcjonalności dodatkowej
    public string? TrailerUrl { get; set; } // Do osadzania filmów z YouTube
}