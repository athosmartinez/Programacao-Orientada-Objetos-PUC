namespace Questao4
{
    internal class Socios
    {
        public int NumeroCota { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateOnly DataAssociacao { get; set; }

        public List<DepedenteSocio> Depedentes { get; set; } = new List<DepedenteSocio>();

        public Socios(int numeroCota, string nome, DateOnly dataNascimento, DateOnly dataAssociacao)
        {
            NumeroCota = numeroCota;
            Nome = nome;
            DataNascimento = dataNascimento;
            DataAssociacao = dataAssociacao;
        }

        public static void AdicionarSocio(Socios[] socios, int n)
        {
            Console.WriteLine("Digite o nome do sócio: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do sócio, no formato DD/MM/YYYY: ");
            string DataNascimentoString = Console.ReadLine();
            Console.WriteLine("Digite a data de associação do sócio, no formato DD/MM/YYYY: ");
            string DataAssociacaoString = Console.ReadLine();
            if (DateOnly.TryParseExact(DataNascimentoString, "dd/MM/yyyy", out DateOnly DataNascimento) && DateOnly.TryParseExact(DataAssociacaoString, "dd/MM/yyyy", out DateOnly DataAssociacao))
            {
                Random random = new Random();
                int NumeroCota = random.Next(1000000, 9999999);
                Console.WriteLine("O número da cota do sócio é: " + NumeroCota);
                socios[n] = new Socios(NumeroCota, Nome, DataNascimento, DataAssociacao);
                DepedenteSocio.AdicionarDependente(socios[n]);
            }
            else
            {
                Console.WriteLine("Data inválida");
            }
        }

        public static void RemoverSocio(int numeroCota, Socios[] socios)
        {
            for (int i = 0; i < socios.Length; i++)
            {
                if (socios[i].NumeroCota == numeroCota)
                {
                    DepedenteSocio.RemoverDependente(numeroCota, socios[i].Depedentes);
                    socios[i].NumeroCota = -1;
                    Console.WriteLine("Socio da " + numeroCota + " apagado com sucesso.");
                    return;
                }
            }
            Console.WriteLine("Nenhum socio com essa cota foi encotrado.");
        }

        public static void ImprimirSociosEDependentes(Socios[] socios)
        {
            foreach (var socio in socios)
            {
                Console.WriteLine($"Sócio - Número da Cota: {socio.NumeroCota}, Nome: {socio.Nome}, Data de Nascimento: {socio.DataNascimento}, Data de Associação: {socio.DataAssociacao}");

                if (socio.Depedentes.Count > 0)
                {
                    Console.WriteLine($"Dependentes do {socio.Nome}: ");
                    foreach (var dependente in socio.Depedentes)
                    {
                        Console.WriteLine($"Dependente - Número da Conta: {dependente.NumeroContaDependente}, Nome: {dependente.Nome}, Data de Nascimento: {dependente.DataNascimento}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum dependente registrado.");
                }
            }
        }
    }
}
