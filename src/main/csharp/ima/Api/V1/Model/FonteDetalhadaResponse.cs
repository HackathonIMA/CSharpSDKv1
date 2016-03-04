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
  public class FonteDetalhadaResponse {
    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<LinksModel> Links { get; set; }

    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* DescriÃ§Ã£o da fonte receita */
    [DataMember(Name="descricao", EmitDefaultValue=false)]
    public string Descricao { get; set; }

    
    /* cÃ³digo grupo fonte receita */
    [DataMember(Name="codigoGrupo", EmitDefaultValue=false)]
    public string CodigoGrupo { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FonteDetalhadaResponse {\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  Descricao: ").Append(Descricao).Append("\n");
      
      sb.Append("  CodigoGrupo: ").Append(CodigoGrupo).Append("\n");
      
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
