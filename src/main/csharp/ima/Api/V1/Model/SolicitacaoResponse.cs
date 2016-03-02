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
  public class SolicitacaoResponse {
    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* Nome da administraÃ§Ã£o regional. */
    [DataMember(Name="nomeRegional", EmitDefaultValue=false)]
    public string NomeRegional { get; set; }

    
    /* CÃ³digo da regiÃ£o. */
    [DataMember(Name="codigoRegiao", EmitDefaultValue=false)]
    public string CodigoRegiao { get; set; }

    
    /* Nome / DescriÃ§Ã£o da regiÃ£o. */
    [DataMember(Name="nomeRegiao", EmitDefaultValue=false)]
    public string NomeRegiao { get; set; }

    
    /* Nome da secretÃ¡ria. */
    [DataMember(Name="secretaria", EmitDefaultValue=false)]
    public string Secretaria { get; set; }

    
    /* CÃ³digo da bairro. */
    [DataMember(Name="codigoBairro", EmitDefaultValue=false)]
    public long? CodigoBairro { get; set; }

    
    /* Nome do bairro. */
    [DataMember(Name="nomeBairro", EmitDefaultValue=false)]
    public string NomeBairro { get; set; }

    
    /* CÃ³digo do assunto da solicitaÃ§Ã£o. */
    [DataMember(Name="codigoAssunto", EmitDefaultValue=false)]
    public int? CodigoAssunto { get; set; }

    
    /* DescriÃ§Ã£o do assunto da solicitaÃ§Ã£o. */
    [DataMember(Name="descricaoAssunto", EmitDefaultValue=false)]
    public string DescricaoAssunto { get; set; }

    
    /* Ano em que a solicitaÃ§Ã£o ocorreu. */
    [DataMember(Name="anoSolicitacao", EmitDefaultValue=false)]
    public int? AnoSolicitacao { get; set; }

    
    /* CÃ³digo referente ao tipo de solicitaÃ§Ã£o. */
    [DataMember(Name="tipoSolicitacao", EmitDefaultValue=false)]
    public int? TipoSolicitacao { get; set; }

    
    /* DescriÃ§Ã£o do tipo de solicitaÃ§Ã£o realizada. */
    [DataMember(Name="descricaoTipoSolicitacao", EmitDefaultValue=false)]
    public string DescricaoTipoSolicitacao { get; set; }

    
    /* CÃ³digo do status da solicitaÃ§Ã£o. */
    [DataMember(Name="statusSolicitacao", EmitDefaultValue=false)]
    public int? StatusSolicitacao { get; set; }

    
    /* DescriÃ§Ã£o do status. */
    [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
    public string DescricaoStatus { get; set; }

    
    /* Data do cadastramento da solicitaÃ§Ã£o. */
    [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
    public DateTime? DataCadastro { get; set; }

    
    /* Data da previsÃ£o de resposta da solicitaÃ§Ã£o depois de executada. */
    [DataMember(Name="dataPrevisaoResposta", EmitDefaultValue=false)]
    public DateTime? DataPrevisaoResposta { get; set; }

    
    /* Data em que o atendimento ocorreu */
    [DataMember(Name="dataAtendimento", EmitDefaultValue=false)]
    public DateTime? DataAtendimento { get; set; }

    
    /* Data em que a solicitaÃ§Ã£o foi concluÃ­da. */
    [DataMember(Name="dataConclusao", EmitDefaultValue=false)]
    public DateTime? DataConclusao { get; set; }

    
    /* CEP */
    [DataMember(Name="cep", EmitDefaultValue=false)]
    public string Cep { get; set; }

    
    /* Tipo de logradouro (Exemplo > Rua, Avenida, etc.) */
    [DataMember(Name="tipoLogradouro", EmitDefaultValue=false)]
    public string TipoLogradouro { get; set; }

    
    /* Nome da rua / logradouro. */
    [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
    public string NomeLogradouro { get; set; }

    
    /* Data da providÃªncia */
    [DataMember(Name="dataProvidencia", EmitDefaultValue=false)]
    public DateTime? DataProvidencia { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SolicitacaoResponse {\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  NomeRegional: ").Append(NomeRegional).Append("\n");
      
      sb.Append("  CodigoRegiao: ").Append(CodigoRegiao).Append("\n");
      
      sb.Append("  NomeRegiao: ").Append(NomeRegiao).Append("\n");
      
      sb.Append("  Secretaria: ").Append(Secretaria).Append("\n");
      
      sb.Append("  CodigoBairro: ").Append(CodigoBairro).Append("\n");
      
      sb.Append("  NomeBairro: ").Append(NomeBairro).Append("\n");
      
      sb.Append("  CodigoAssunto: ").Append(CodigoAssunto).Append("\n");
      
      sb.Append("  DescricaoAssunto: ").Append(DescricaoAssunto).Append("\n");
      
      sb.Append("  AnoSolicitacao: ").Append(AnoSolicitacao).Append("\n");
      
      sb.Append("  TipoSolicitacao: ").Append(TipoSolicitacao).Append("\n");
      
      sb.Append("  DescricaoTipoSolicitacao: ").Append(DescricaoTipoSolicitacao).Append("\n");
      
      sb.Append("  StatusSolicitacao: ").Append(StatusSolicitacao).Append("\n");
      
      sb.Append("  DescricaoStatus: ").Append(DescricaoStatus).Append("\n");
      
      sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
      
      sb.Append("  DataPrevisaoResposta: ").Append(DataPrevisaoResposta).Append("\n");
      
      sb.Append("  DataAtendimento: ").Append(DataAtendimento).Append("\n");
      
      sb.Append("  DataConclusao: ").Append(DataConclusao).Append("\n");
      
      sb.Append("  Cep: ").Append(Cep).Append("\n");
      
      sb.Append("  TipoLogradouro: ").Append(TipoLogradouro).Append("\n");
      
      sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
      
      sb.Append("  DataProvidencia: ").Append(DataProvidencia).Append("\n");
      
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
