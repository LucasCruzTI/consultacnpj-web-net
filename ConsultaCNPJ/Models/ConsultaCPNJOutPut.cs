using Newtonsoft.Json;

namespace ConsultaCNPJ.Models
{
    public class ConsultaCPNJOutPut
    {
        public ConsultaCPNJOutPut()
        {
            this.Bairro = string.Empty;
            this.CapitalSocial = 0;
            this.Cep = string.Empty;
            this.CnaeFiscal = 0;
            this.CnaeFiscalDescricao = string.Empty;
            this.CnaesSecundarios = new List<CnaeSecundario>();
            this.Cnpj = string.Empty;
            this.CodigoMunicipio = 0;
            this.CodigoMunicipioIbge = 0;
            this.CodigoNaturezaJuridica = 0;
            this.CodigoPais = new object();
            this.CodigoPorte = 0;
            this.Complemento = string.Empty;
            this.DataExclusaoDoMei = new object();
            this.DataExclusaoDoSimples = new object();
            this.DataInicioAtividade = new DateTime();
            this.DataOpcaoPeloMei = new object();
            this.DataOpcaoPeloSimples = new object();
            this.DataSituacaoCadastral = new DateTime();
            this.DataSituacaoEspecial = new object();
            this.DddFax = string.Empty;
            this.DddTelefone1 = string.Empty;
            this.DddTelefone2 = string.Empty;
            this.DescricaoIdentificadorMatrizFilial = string.Empty;
            this.DescricaoMotivoSituacaoCadastral = string.Empty;
            this.DescricaoPorte = string.Empty;
            this.DescricaoSituacaoCadastral = string.Empty;
            this.DescricaoTipoDeLogradouro = string.Empty;
            this.Email = new object();
            this.EnteFederativoResponsavel = string.Empty;
            this.IdentificadorMatrizFilial = 0;
            this.Logradouro = string.Empty;
            this.MotivoSituacaoCadastral = 0;
            this.Municipio = string.Empty;
            this.NaturezaJuridica = string.Empty;
            this.NomeCidadeNoExterior = string.Empty;
            this.NomeFantasia = string.Empty;
            this.Numero = string.Empty;
            this.OpcaoPeloMei = new object();
            this.OpcaoPeloSimples = new object();
            this.Pais = new object();
            this.Porte = string.Empty;
            this.Qsa = new List<Qsa>();
            this.QualificacaoDoResponsavel = 0;
            this.RazaoSocial = string.Empty;
            this.SituacaoCadastral = 0;
            this.SituacaoEspecial = string.Empty;
            this.Uf = string.Empty;
        }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("capitalSocial")]
        public long CapitalSocial { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("cnaeFiscal")]
        public long CnaeFiscal { get; set; }

        [JsonProperty("cnae_fiscal_descricao")]
        public string CnaeFiscalDescricao { get; set; }

        [JsonProperty("cnaesSecundarios")]
        public List<CnaeSecundario> CnaesSecundarios { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("codigoMunicipio")]
        public int CodigoMunicipio { get; set; }

        [JsonProperty("codigoMunicipioIbge")]
        public int CodigoMunicipioIbge { get; set; }

        [JsonProperty("codigoNaturezaJuridica")]
        public int CodigoNaturezaJuridica { get; set; }

        [JsonProperty("codigoPais")]
        public object CodigoPais { get; set; }

        [JsonProperty("codigoPorte")]
        public int CodigoPorte { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("dataExclusaoDoMei")]
        public object DataExclusaoDoMei { get; set; }

        [JsonProperty("dataExclusaoDoSimples")]
        public object DataExclusaoDoSimples { get; set; }

        [JsonProperty("dataInicioAtividade")]
        public DateTime DataInicioAtividade { get; set; }

        [JsonProperty("dataOpcaoPeloMei")]
        public object DataOpcaoPeloMei { get; set; }

        [JsonProperty("dataOpcaoPeloSimples")]
        public object DataOpcaoPeloSimples { get; set; }

        [JsonProperty("dataSituacaoCadastral")]
        public DateTime DataSituacaoCadastral { get; set; }

        [JsonProperty("dataSituacaoEspecial")]
        public object DataSituacaoEspecial { get; set; }

        [JsonProperty("dddFax")]
        public string DddFax { get; set; }

        [JsonProperty("ddd_telefone_1")]
        public string DddTelefone1 { get; set; }

        [JsonProperty("dddTelefone2")]
        public string DddTelefone2 { get; set; }

        [JsonProperty("descricaoIdentificadorMatrizFilial")]
        public string DescricaoIdentificadorMatrizFilial { get; set; }

        [JsonProperty("descricaoMotivoSituacaoCadastral")]
        public string DescricaoMotivoSituacaoCadastral { get; set; }

        [JsonProperty("descricaoPorte")]
        public string DescricaoPorte { get; set; }

        [JsonProperty("descricao_situacao_cadastral")]
        public string DescricaoSituacaoCadastral { get; set; }

        [JsonProperty("descricaoTipoDeLogradouro")]
        public string DescricaoTipoDeLogradouro { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("enteFederativoResponsavel")]
        public string EnteFederativoResponsavel { get; set; }

        [JsonProperty("identificadorMatrizFilial")]
        public int IdentificadorMatrizFilial { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("motivoSituacaoCadastral")]
        public int MotivoSituacaoCadastral { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("naturezaJuridica")]
        public string NaturezaJuridica { get; set; }

        [JsonProperty("nomeCidadeNoExterior")]
        public string NomeCidadeNoExterior { get; set; }

        [JsonProperty("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("opcaoPeloMei")]
        public object OpcaoPeloMei { get; set; }

        [JsonProperty("opcaoPeloSimples")]
        public object OpcaoPeloSimples { get; set; }

        [JsonProperty("pais")]
        public object Pais { get; set; }

        [JsonProperty("porte")]
        public string Porte { get; set; }

        [JsonProperty("qsa")]
        public List<Qsa> Qsa { get; set; }

        [JsonProperty("qualificacaoDoResponsavel")]
        public int QualificacaoDoResponsavel { get; set; }

        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonProperty("situacaoCadastral")]
        public int SituacaoCadastral { get; set; }

        [JsonProperty("situacaoEspecial")]
        public string SituacaoEspecial { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }

    public class CnaeSecundario
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }
    }

    public class Qsa
    {
        [JsonProperty("cnpjCpfDoSocio")]
        public string CnpjCpfDoSocio { get; set; }

        [JsonProperty("codigoFaixaEtaria")]
        public int CodigoFaixaEtaria { get; set; }

        [JsonProperty("codigoPais")]
        public object CodigoPais { get; set; }

        [JsonProperty("codigoQualificacaoRepresentanteLegal")]
        public int CodigoQualificacaoRepresentanteLegal { get; set; }

        [JsonProperty("codigoQualificacaoSocio")]
        public int CodigoQualificacaoSocio { get; set; }

        [JsonProperty("cpfRepresentanteLegal")]
        public string CpfRepresentanteLegal { get; set; }

        [JsonProperty("dataEntradaSociedade")]
        public DateTime DataEntradaSociedade { get; set; }

        [JsonProperty("faixaEtaria")]
        public string FaixaEtaria { get; set; }

        [JsonProperty("identificadorDeSocio")]
        public int IdentificadorDeSocio { get; set; }

        [JsonProperty("nomeRepresentanteLegal")]
        public string NomeRepresentanteLegal { get; set; }

        [JsonProperty("nomeSocio")]
        public string NomeSocio { get; set; }
        [JsonProperty("pais")]
        public object Pais { get; set; }
        [JsonProperty("qualificacaoRepresentanteLegal")]
        public string QualificacaoRepresentanteLegal { get; set; }
        [JsonProperty("qualificacaoSocio")]
        public string QualificacaoSocio { get; set; }
    }

}
