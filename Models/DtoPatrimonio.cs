namespace SysPatrimonio.Models
{
    public class DtoPatrimonio
    {
        public int id { get; set; }
        public string numeroetiqueta { get; set; }
        public string nomepatrimonio { get; set; }
        public string descricaopatrimonio { get; set; }
        public string valorpatrimonio { get; set; }
        public string marcamodelo { get; set; }
        public DateTime dataaquisicao { get; set; }
        public DateTime databaixa { get; set; }
        public int numnf { get; set; }
        public string numserie { get; set; }
        public int situacao { get; set; }


    }
}
