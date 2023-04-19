﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjemploOracle.vistas.Models
{
    public class CategoriaDTO
    {
        [JsonPropertyName("id")]
        public decimal Id { get; set; }
        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }
    }
}