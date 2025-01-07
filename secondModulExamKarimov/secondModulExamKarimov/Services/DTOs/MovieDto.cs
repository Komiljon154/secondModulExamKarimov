using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using secondModulExamKarimov.DataAccess.Entities;

namespace secondModulExamKarimov.Services.DTOs
{
    internal class MovieDto
    {
        public static implicit operator MovieDto(List<MovieDto> v)
        {
            throw new NotImplementedException();
        }
    }
}
