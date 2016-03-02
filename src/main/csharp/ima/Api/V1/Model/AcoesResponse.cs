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
  public class AcoesResponse {
    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* Nome da aÃ§Ã£o */
    [DataMember(Name="nome", EmitDefaultValue=false)]
    public string Nome { get; set; }

    
    /* DescriÃ§Ã£o da aÃ§Ã£o */
    [DataMember(Name="descricao", EmitDefaultValue=false)]
    public int? Descricao { get; set; }

    
    /* Numero da aÃ§Ã£o */
    [DataMember(Name="numero", EmitDefaultValue=false)]
    public string Numero { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcoesResponse {\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  Nome: ").Append(Nome).Append("\n");
      
      sb.Append("  Descricao: ").Append(Descricao).Append("\n");
      
      sb.Append("  Numero: ").Append(Numero).Append("\n");
      
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
