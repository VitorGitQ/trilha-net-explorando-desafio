namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Erro: Número de hóspedes apresentado é maior que a capacidade da suíte.");
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int amount = Hospedes.Count;

            return amount;
        }

        public decimal CalcularValorDiaria()
        {
             
            decimal valor = DiasReservados * Suite.ValorDiaria;

           
            if (DiasReservados >= 10)
            {
                valor -= (valor * 10) / 100;
            }

            return valor;
        }
    }
}