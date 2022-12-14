using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorInputFile;

namespace ARCHSYS.CORE;

public class Document
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string ShortDiscription { get; set; } = string.Empty;
    public string Abstract { get; set; } = string.Empty;
    [Required]
    public DateTime? DatePublished { get; set; }
    [Required]
    public List<Author> Authors { get; set; } = new List<Author>();

    public List<Topic> Topics { get; set; } = new List<Topic>();
    public string? File { get; set; }
    public int AcademicProgramId { get; set; }
    public bool IsActive { get; set; }
    

}
