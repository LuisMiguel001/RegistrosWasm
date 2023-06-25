using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrosWasm.Shared.Models;

public class Clientes
{
    [Key]

    [Required(ErrorMessage = "El campo (Id) es obligatorio")]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo (ClienteId) es obligatorio")]
    public int ClienteId { get; set; }
    
    [Required(ErrorMessage = "El campo (SistemaId) es obligatorio")]
    public int SistemaId { get; set; }

    [Required(ErrorMessage = "El campo (TerminalesPermitidas) es obligatorio")]
    public int TerminalesPermitidas { get; set; }

    public string Emisor { get; set; } = "";

    public string Mensaje { get; set; } = "";
}

