using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }

        public int CalculaNota(List<int> notas)
        {
            List<int> numerosValidos = [];
            var resultado = 0;

            foreach (var item in notas)
            {
                if(item < 0 || item > 10 || item % 1 != 0)
                {
                    throw new ArgumentException("Nota invalido");
                }

                numerosValidos.Add(item);

            }

            if (numerosValidos.Count == 2)
            {
                resultado = (numerosValidos[0] + numerosValidos[1]) / 2;
            }

            return resultado; 

        }
    }
}