using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuStrip
{
    internal class Cads_Usuario
    {
        public int codigo { get; set;}
        public string nome { get; set; }
        public string departamento { get; set; }

        public static List<Cads_Usuario> lista()
        {
            var lista = new List<Cads_Usuario>();

            var user1 = new Cads_Usuario();
            var user2 = new Cads_Usuario();
            var user3 = new Cads_Usuario();

            user1.codigo = 1;
            user1.nome = "Cirlene Camilo";
            user1.departamento = "Desenvolvedora";

            user1.codigo = 2;
            user1.nome = "Juliana Camilo";
            user1.departamento = "Produtora";

            user1.codigo = 1;
            user1.nome = "Gabriela Camilo";
            user1.departamento = "Publicitária";

            lista.Add(user1); 
            lista.Add(user2);
            lista.Add(user3);

            return lista;
        }
    }
}
