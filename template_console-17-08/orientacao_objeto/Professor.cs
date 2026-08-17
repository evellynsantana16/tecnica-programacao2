using System;
using System.Collections.Generic;
using System.Text;

namespace orientacao_objeto
{
    internal class Professor
    {
        public int Titulacao { get; set; }

        public List<Disciplina> ? Disciplina { get; set; }
    }
}
