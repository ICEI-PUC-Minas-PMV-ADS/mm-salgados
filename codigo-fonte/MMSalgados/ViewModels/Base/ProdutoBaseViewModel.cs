﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.ViewModels.Base
{
    public class ProdutoBaseViewModel : BaseViewModel
    {
        [Required]
        public decimal? Preco { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int Quantidade { get; set; }
        public string Marca { get; set; }
        public string Image { get; set; }
        public string Processador { get; set; }
        public string Memoria { get; set; }
        public string Camera { get; set; }
        public string RAM { get; set; }
    }
}
