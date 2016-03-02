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
  public class EducacaoResponse {
    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* Ano do registro. */
    [DataMember(Name="ano", EmitDefaultValue=false)]
    public long? Ano { get; set; }

    
    /* CÃ³digo da regiÃ£o. */
    [DataMember(Name="codigoRegiao", EmitDefaultValue=false)]
    public int? CodigoRegiao { get; set; }

    
    /* DescriÃ§Ã£o da regiÃ£o. */
    [DataMember(Name="descricaoRegiao", EmitDefaultValue=false)]
    public string DescricaoRegiao { get; set; }

    
    /* CÃ³digo do grupo escolar. */
    [DataMember(Name="escalaGrupo", EmitDefaultValue=false)]
    public string EscalaGrupo { get; set; }

    
    /* DescriÃ§Ã£o do regime escolar. */
    [DataMember(Name="regime", EmitDefaultValue=false)]
    public string Regime { get; set; }

    
    /* Nome da Unidade escolar. */
    [DataMember(Name="nomeUnidadeEscolar", EmitDefaultValue=false)]
    public string NomeUnidadeEscolar { get; set; }

    
    /* Nome do bairro onde a unidade escolar se encontra. */
    [DataMember(Name="bairro", EmitDefaultValue=false)]
    public string Bairro { get; set; }

    
    /* DescriÃ§Ã£o da demanda. */
    [DataMember(Name="descricao", EmitDefaultValue=false)]
    public string Descricao { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EducacaoResponse {\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  Ano: ").Append(Ano).Append("\n");
      
      sb.Append("  CodigoRegiao: ").Append(CodigoRegiao).Append("\n");
      
      sb.Append("  DescricaoRegiao: ").Append(DescricaoRegiao).Append("\n");
      
      sb.Append("  EscalaGrupo: ").Append(EscalaGrupo).Append("\n");
      
      sb.Append("  Regime: ").Append(Regime).Append("\n");
      
      sb.Append("  NomeUnidadeEscolar: ").Append(NomeUnidadeEscolar).Append("\n");
      
      sb.Append("  Bairro: ").Append(Bairro).Append("\n");
      
      sb.Append("  Descricao: ").Append(Descricao).Append("\n");
      
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
