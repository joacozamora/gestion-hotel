﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Shared.DTO
{
	public class PersonaDTO
	{
		public int Dni { get; set; }
		public string? Nombres { get; set; }
		public string? Apellidos { get; set; }
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string? Correo { get; set; }
		public string? Telefono { get; set; }
		public string? NumTarjeta { get; set; }
        public int NumHab { get; set; }
    }
}
