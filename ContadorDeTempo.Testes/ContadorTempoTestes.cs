using ContadorDeTempo.Domain;

namespace ContadorDeTempo.Testes
{
    [TestClass]
    public class ContadorTempoTestes
    {
        ContadorTempo contadorTempo;
        public ContadorTempoTestes()
        {
            contadorTempo = new ContadorTempo();
        }

        [TestMethod]
        public void Deve_retornar_30_segundos()
        {
            var dataCalcular = DateTime.Now.AddSeconds(-30);

            string tempoCalculado = contadorTempo.ObterTempoEmString(dataCalcular);

            Assert.AreEqual($"O teste foi realizado a 30 segundos", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_cinco_minutos()
        {
            var dataCalcular = DateTime.Now.AddMinutes(-5);

            string tempoCalculado = contadorTempo.ObterTempoEmString(dataCalcular);

            Assert.AreEqual($"O teste foi realizado a 5 minutos", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_cinco_dias()
        {
            var dataCalcular = DateTime.Now.AddDays(-5);

            string tempoCalculado = contadorTempo.ObterTempoEmString(dataCalcular);

            Assert.AreEqual($"O teste foi realizado a 5 dias", tempoCalculado);

        }


        [TestMethod]
        public void Deve_retornar_3_semanas()
        {
            var dataCalcular = DateTime.Now.AddDays(-21);

            string tempoCalculado = contadorTempo.ObterTempoEmString(dataCalcular);

            Assert.AreEqual($"O teste foi realizado a 3 semanas", tempoCalculado);

        }


        [TestMethod]
        public void Deve_retornar_seis_meses()
        {
            var dataCalcular = DateTime.Now.AddDays(-5);

            string tempoCalculado = contadorTempo.ObterTempoEmString(dataCalcular);

            Assert.AreEqual($"O teste foi realizado a 5 dias", tempoCalculado);

        }
    }
}