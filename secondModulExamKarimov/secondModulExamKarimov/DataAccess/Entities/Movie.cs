using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondModulExamKarimov.DataAccess.Entities;

public interface Movie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public int DurationMinutes { get; set; }
    public double Rating { get; set; }
    public long BoxOfficeEarnings { get; set; }
    public DateTime ReleaseDate { get; set; }

}
