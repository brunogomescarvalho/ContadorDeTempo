namespace ContadorDeTempo.Domain
{
    public class ContadorTempo
    {
        private MedidaTempoEnum medidaTempo;

        private long tempo;

        private Dictionary<MedidaTempoEnum, string> plural;
        private Dictionary<MedidaTempoEnum, string> singular;


        public ContadorTempo()
        {
            InicializarListas();
        }


        public string ObterTempoEmString(DateTime dataParaCalcular)
        {
            CalcularTempo(dataParaCalcular);

            Dictionary<MedidaTempoEnum, string> lista;

            lista = tempo > 0 ? plural : singular;

            string medida = lista[medidaTempo];

            return $"O teste foi realizado a {tempo} {medida}";

        }

        private void CalcularTempo(DateTime dataParaCalcular)
        {
            TimeSpan diferenca = DateTime.Now.Subtract(dataParaCalcular);

            if (diferenca < TimeSpan.FromMinutes(1))
            {
                medidaTempo = MedidaTempoEnum.segundos;
                tempo = diferenca.Seconds;
            }
            else if (diferenca < TimeSpan.FromHours(1))
            {
                medidaTempo = MedidaTempoEnum.minutos;
                tempo = diferenca.Minutes;
            }
            else if (diferenca < TimeSpan.FromDays(1))
            {
                medidaTempo = MedidaTempoEnum.horas;
                tempo = diferenca.Hours;
            }
            else if (diferenca < TimeSpan.FromDays(7))
            {
                medidaTempo = MedidaTempoEnum.dias;
                tempo = diferenca.Days;
            }
            else if (diferenca < TimeSpan.FromDays(30))
            {
                medidaTempo = MedidaTempoEnum.semanas;
                tempo = (long)diferenca.TotalDays / 7;
            }
            else
            {
                medidaTempo = MedidaTempoEnum.meses;
                tempo = (long)diferenca.TotalDays / 30;
            }
        }

        private void InicializarListas()
        {
            plural = new();
            singular = new();

            plural.Add(MedidaTempoEnum.segundos, "segundos");
            plural.Add(MedidaTempoEnum.minutos, "minutos");
            plural.Add(MedidaTempoEnum.horas, "horas");
            plural.Add(MedidaTempoEnum.dias, "dias");
            plural.Add(MedidaTempoEnum.semanas, "semanas");
            plural.Add(MedidaTempoEnum.meses, "meses");

            singular.Add(MedidaTempoEnum.minutos, "minuto");
            singular.Add(MedidaTempoEnum.horas, "hora");
            singular.Add(MedidaTempoEnum.dias, "dia");
            singular.Add(MedidaTempoEnum.semanas, "semana");
            singular.Add(MedidaTempoEnum.meses, "mês");
        }
    }



    public enum MedidaTempoEnum
    {
        segundos,
        minutos,
        horas,
        dias,
        semanas,
        meses
    }

}