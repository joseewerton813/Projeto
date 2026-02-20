using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Atletas
{
    public class Atleta
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Nacionalidade { get; set; }
        public string Modalidade { get; set; }
        public MedicalInfo InformacoesMedicas { get; set; }

        public Atleta()
      {
            InformacoesMedicas = new MedicalInfo();
      }
    }
}
