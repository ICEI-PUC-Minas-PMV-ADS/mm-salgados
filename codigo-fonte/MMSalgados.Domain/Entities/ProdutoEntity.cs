using System;

namespace MMSalgados.Domain.Entities
{
    public class ProdutoEntity : Entity
    {
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Image { get; set; }
        public bool Ativo { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
