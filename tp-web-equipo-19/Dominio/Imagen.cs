﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Id { get; set; }
        public int IdCodigoArticulo { get; set; }
        public string ImagenUrl { get; set; }
        public override string ToString()
        {
            return ImagenUrl;
        }

        public Imagen()
        {

        }
        public Imagen(string url)
        {
            ImagenUrl = url;
        }

        public static implicit operator Imagen(string v)
        {
            throw new NotImplementedException();
        }
    }
}