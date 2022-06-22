using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Day64DemoAuthentication.Data.Models;

[Table(nameof(Movie), Schema = "bollywood")]
public class Movie
{
    public int Id { get; set; }

    [Required]
    [Unicode(false)]
    [StringLength(250)]
    public string Title { get; set; } = null!;

    public int? ReleaseYear { get; set; }

    public long? Budget { get; set; }
}