using System;
using System.Collections.Generic;
using System.Text;

namespace orientacao_objeto
{
    internal class Disciplina
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public int CargaHoraria { get; set; }

        public List<Curso> ? Curso { get; set; }
        public List<Professor> ? Professor { get; set; }
    }
}
