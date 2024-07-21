﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class Ordenes
{
    [Key]
    public int OrdenId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string? ClienteId { get; set; }

    [Required(ErrorMessage = "El Nombre del Cliente es Obligatorio")]
    [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Nombre debe Contener Solo letras.")]
    public string? NombreCliente { get; set; }

    [Required(ErrorMessage = "El Apellido del cliente es obligatorio")]
    [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Apellido debe contener solo letras.")]
    public string? ApellidoCliente { get; set; }

    [ForeignKey("Estados")]
    public int EstadoId { get; set; }

    [Required(ErrorMessage = "La Descripción es obligatoria")]
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "El Teléfono es obligatorio")]
    [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "El número de teléfono debe tener el formato 800-000-0000")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "La Fecha es obligatoria")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [ForeignKey("OrdenesDetalleId")]
    public ICollection<OrdenesDetalle> OrdenesDetalle { get; set; } = new List<OrdenesDetalle>();
}
