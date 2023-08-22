using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Race_Track.Models;

namespace Race_Track.ViewModels;

public class PilotoIndexViewModel{
public List<Piloto> pilotos {get; set; } = new List<Piloto>();

        public String? NameFilter { get; set; }

        public int PilotoId { get; set; }
        [Display(Name = "Nombre")]        

        public string? PilotoNombre {get; set;}
        [Display(Name = "Apellido")]        

        public string? PilotoApellido {get; set;}
        [Display(Name = "DNI")]        

        public int PilotoDni {get; set;}
        // public LicenciaType InstructorTipoLicencia { get; set; }
        [Display(Name = "Registro numero")]        

        [Required(ErrorMessage ="Debe ingresar el Numero de licencia")]
        public int PilotoNumeroLicencia {get; set;}
        [DataType("Date", ErrorMessage="Fecha no valida, debe ser dd/MM/yyyy")]
        [Display(Name = "Fecha de vencimiento")]        

        public DateTime PilotoExpedicion {get;set;}
        [Display(Name = "Es propietario?")]        

        public bool PilotoPropietario {get;set;} = true;       

        public int VehiculoId { get; set; }
        [Display(Name = "Vehiculo")]           

        public virtual Vehiculo? Vehiculo { get; set; }    

}