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
  public class ProtocoloResponse {
    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* CÃ³digo da regiÃ£o onde foi registrado o protocolo. */
    [DataMember(Name="codigoRegiao", EmitDefaultValue=false)]
    public int? CodigoRegiao { get; set; }

    
    /* Nome da Ã¡rea onde a regiÃ£o se encontra. (Exemplo > \"NORTE\") */
    [DataMember(Name="nomeRegiao", EmitDefaultValue=false)]
    public string NomeRegiao { get; set; }

    
    /* CÃ³digo de bairro referente ao protocolo. */
    [DataMember(Name="codigoBairro", EmitDefaultValue=false)]
    public long? CodigoBairro { get; set; }

    
    /* Nome do bairro. */
    [DataMember(Name="nomeBairro", EmitDefaultValue=false)]
    public string NomeBairro { get; set; }

    
    /* CÃ³digo do expediente emissor do protocolo. */
    [DataMember(Name="codigoExpediente", EmitDefaultValue=false)]
    public long? CodigoExpediente { get; set; }

    
    /* DescriÃ§Ã£o da Secretaria expediente do protocolo. */
    [DataMember(Name="secretariaExpediente", EmitDefaultValue=false)]
    public string SecretariaExpediente { get; set; }

    
    /* CÃ³digo do assunto referente ao protocolo. */
    [DataMember(Name="codigoAssunto", EmitDefaultValue=false)]
    public long? CodigoAssunto { get; set; }

    
    /* DescriÃ§Ã£o do assunto do protocolo. */
    [DataMember(Name="descricaoAssunto", EmitDefaultValue=false)]
    public string DescricaoAssunto { get; set; }

    
    /* Ano em que o processo foi iniciado. */
    [DataMember(Name="anoProcesso", EmitDefaultValue=false)]
    public long? AnoProcesso { get; set; }

    
    /* CÃ³digo do ponto onde o protocolo foi cadastrado. */
    [DataMember(Name="pontoCadastramento", EmitDefaultValue=false)]
    public int? PontoCadastramento { get; set; }

    
    /* Nome do ponto de cadastramento. */
    [DataMember(Name="nomePontoCadastramento", EmitDefaultValue=false)]
    public string NomePontoCadastramento { get; set; }

    
    /* Data do cadastro do protocolo. */
    [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
    public DateTime? DataCadastro { get; set; }

    
    /* Data do atendimento. */
    [DataMember(Name="dataAtendimento", EmitDefaultValue=false)]
    public DateTime? DataAtendimento { get; set; }

    
    /* Data em que o protocolo foi cancelado. */
    [DataMember(Name="dataCancelamento", EmitDefaultValue=false)]
    public DateTime? DataCancelamento { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtocoloResponse {\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  CodigoRegiao: ").Append(CodigoRegiao).Append("\n");
      
      sb.Append("  NomeRegiao: ").Append(NomeRegiao).Append("\n");
      
      sb.Append("  CodigoBairro: ").Append(CodigoBairro).Append("\n");
      
      sb.Append("  NomeBairro: ").Append(NomeBairro).Append("\n");
      
      sb.Append("  CodigoExpediente: ").Append(CodigoExpediente).Append("\n");
      
      sb.Append("  SecretariaExpediente: ").Append(SecretariaExpediente).Append("\n");
      
      sb.Append("  CodigoAssunto: ").Append(CodigoAssunto).Append("\n");
      
      sb.Append("  DescricaoAssunto: ").Append(DescricaoAssunto).Append("\n");
      
      sb.Append("  AnoProcesso: ").Append(AnoProcesso).Append("\n");
      
      sb.Append("  PontoCadastramento: ").Append(PontoCadastramento).Append("\n");
      
      sb.Append("  NomePontoCadastramento: ").Append(NomePontoCadastramento).Append("\n");
      
      sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
      
      sb.Append("  DataAtendimento: ").Append(DataAtendimento).Append("\n");
      
      sb.Append("  DataCancelamento: ").Append(DataCancelamento).Append("\n");
      
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
