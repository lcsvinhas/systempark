namespace SystemPark.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public bool NoEstacionamento { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor {  get; set; }
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }
        public decimal? Valor {  get; set; }
    }
}
