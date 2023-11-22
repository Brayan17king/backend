using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
    public class PaisxDepDto
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public List<RegionDto> Departamento {get; set;}
    }
