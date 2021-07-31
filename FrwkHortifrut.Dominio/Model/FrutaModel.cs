using System;
using System.Collections.Generic;
using System.Text;

namespace FrwkHortifrut.Dominio.Model
{
    public  class FrutaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Int64 Foto{ get; set; }
        public int QuantidadeEstoque { get; set; }
        public double Valor { get; set; }
    }
}
