//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_EXPERT_SA_WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class HABILIDADES
    {
        public string cedulaEmpleadoPK { get; set; }
        [Display(Name = "Habilidades")]
        public string habilidadPK { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        public List<HABILIDADES> listaHabilidades { get; set; }

        public HABILIDADES modeloHabilidades { get; set; }

    }
}
