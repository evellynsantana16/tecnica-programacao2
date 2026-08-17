using System;
using System.Collections.Generic;
using System.Text;

namespace orientacao_objeto
{
    internal class Matricula
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public Alunos Alunos  { get; set; }
        public Curso Curso { get; set; }
    }
}
