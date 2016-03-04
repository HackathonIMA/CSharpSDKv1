using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ima.Api.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SaudeResponse {
    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* Distrito onde o antendimento foi realizado. */
    [DataMember(Name="distritoVinculo", EmitDefaultValue=false)]
    public string DistritoVinculo { get; set; }

    
    /* Nome do municÃ­pio */
    [DataMember(Name="municipio", EmitDefaultValue=false)]
    public string Municipio { get; set; }

    
    /* IndicaÃ§Ã£o da unidade federal. */
    [DataMember(Name="uf", EmitDefaultValue=false)]
    public string Uf { get; set; }

    
    /* Nome do local onde o atendimento foi feito. */
    [DataMember(Name="localAtendimento", EmitDefaultValue=false)]
    public string LocalAtendimento { get; set; }

    
    /* Indicacao do distrito onde o atendimento ocorreu. */
    [DataMember(Name="distritoAtendimento", EmitDefaultValue=false)]
    public string DistritoAtendimento { get; set; }

    
    /* Data e hora que o atendimento ocorreu. */
    [DataMember(Name="dataAtendimento", EmitDefaultValue=false)]
    public DateTime? DataAtendimento { get; set; }

    
    /* CÃ³digo do tipo de atendimento. */
    [DataMember(Name="codigoTipoAtendimento", EmitDefaultValue=false)]
    public long? CodigoTipoAtendimento { get; set; }

    
    /* Descricao do tipo de atendimento. */
    [DataMember(Name="descricaoTipoAtendimento", EmitDefaultValue=false)]
    public string DescricaoTipoAtendimento { get; set; }

    
    /* DescriÃ§Ã£o do grupo de atendimento. */
    [DataMember(Name="descricaoGrupoAtendimento", EmitDefaultValue=false)]
    public string DescricaoGrupoAtendimento { get; set; }

    
    /* CÃ³digo do grupo de atendimento vinculado ao SUS. */
    [DataMember(Name="codigoGrupoAtendimentoSUS", EmitDefaultValue=false)]
    public int? CodigoGrupoAtendimentoSUS { get; set; }

    
    /* Descricao formal da ocupaÃ§Ã£o do profissional. */
    [DataMember(Name="ocupacaoProfissional", EmitDefaultValue=false)]
    public string OcupacaoProfissional { get; set; }

    
    /* DescriÃ§Ã£o do tipo de vinculo com a Secretaria Municipal de SaÃºde. */
    [DataMember(Name="descricaoTipoVinculoSMS", EmitDefaultValue=false)]
    public string DescricaoTipoVinculoSMS { get; set; }

    
    /* CÃ³digo do procedimento realizado pelo SUS */
    [DataMember(Name="codigoProcedimentoSUS", EmitDefaultValue=false)]
    public long? CodigoProcedimentoSUS { get; set; }

    
    /* Descricao do procedimento. */
    [DataMember(Name="descricaoProcedimento", EmitDefaultValue=false)]
    public string DescricaoProcedimento { get; set; }

    
    /* CÃ³digo do profissional SUS. */
    [DataMember(Name="codigoAtividadeProfissionalSUS", EmitDefaultValue=false)]
    public int? CodigoAtividadeProfissionalSUS { get; set; }

    
    /* IndicaÃ§Ã£o da profissÃ£o do atendente. */
    [DataMember(Name="descricaoAtividadeProfissional", EmitDefaultValue=false)]
    public string DescricaoAtividadeProfissional { get; set; }

    
    /* DescriÃ§Ã£o do sexo. ('MASCULINO' ou 'FEMININO') */
    [DataMember(Name="sexo", EmitDefaultValue=false)]
    public string Sexo { get; set; }

    
    /* IndicaÃ§Ã£o da idade. */
    [DataMember(Name="idade", EmitDefaultValue=false)]
    public string Idade { get; set; }

    
    /* IndicaÃ§Ã£o da hora da ocorrÃªncia. */
    [DataMember(Name="hora", EmitDefaultValue=false)]
    public string Hora { get; set; }

    
    /* Descricao do periodo (Exemplo > MANHA) */
    [DataMember(Name="periodo", EmitDefaultValue=false)]
    public string Periodo { get; set; }

    
    /* Data de nascimento do profissional. */
    [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
    public DateTime? DataNascimento { get; set; }

    
    /* Quantidade de atendimento realizados. */
    [DataMember(Name="quantidadeRealizada", EmitDefaultValue=false)]
    public int? QuantidadeRealizada { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaudeResponse {\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  DistritoVinculo: ").Append(DistritoVinculo).Append("\n");
      
      sb.Append("  Municipio: ").Append(Municipio).Append("\n");
      
      sb.Append("  Uf: ").Append(Uf).Append("\n");
      
      sb.Append("  LocalAtendimento: ").Append(LocalAtendimento).Append("\n");
      
      sb.Append("  DistritoAtendimento: ").Append(DistritoAtendimento).Append("\n");
      
      sb.Append("  DataAtendimento: ").Append(DataAtendimento).Append("\n");
      
      sb.Append("  CodigoTipoAtendimento: ").Append(CodigoTipoAtendimento).Append("\n");
      
      sb.Append("  DescricaoTipoAtendimento: ").Append(DescricaoTipoAtendimento).Append("\n");
      
      sb.Append("  DescricaoGrupoAtendimento: ").Append(DescricaoGrupoAtendimento).Append("\n");
      
      sb.Append("  CodigoGrupoAtendimentoSUS: ").Append(CodigoGrupoAtendimentoSUS).Append("\n");
      
      sb.Append("  OcupacaoProfissional: ").Append(OcupacaoProfissional).Append("\n");
      
      sb.Append("  DescricaoTipoVinculoSMS: ").Append(DescricaoTipoVinculoSMS).Append("\n");
      
      sb.Append("  CodigoProcedimentoSUS: ").Append(CodigoProcedimentoSUS).Append("\n");
      
      sb.Append("  DescricaoProcedimento: ").Append(DescricaoProcedimento).Append("\n");
      
      sb.Append("  CodigoAtividadeProfissionalSUS: ").Append(CodigoAtividadeProfissionalSUS).Append("\n");
      
      sb.Append("  DescricaoAtividadeProfissional: ").Append(DescricaoAtividadeProfissional).Append("\n");
      
      sb.Append("  Sexo: ").Append(Sexo).Append("\n");
      
      sb.Append("  Idade: ").Append(Idade).Append("\n");
      
      sb.Append("  Hora: ").Append(Hora).Append("\n");
      
      sb.Append("  Periodo: ").Append(Periodo).Append("\n");
      
      sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
      
      sb.Append("  QuantidadeRealizada: ").Append(QuantidadeRealizada).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
