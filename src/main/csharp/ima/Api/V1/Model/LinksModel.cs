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
  public class LinksModel {
    
    /* TODO */
    [DataMember(Name="rel", EmitDefaultValue=false)]
    public string Rel { get; set; }

    
    /* TODO */
    [DataMember(Name="href", EmitDefaultValue=false)]
    public string Href { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LinksModel {\n");
      
      sb.Append("  Rel: ").Append(Rel).Append("\n");
      
      sb.Append("  Href: ").Append(Href).Append("\n");
      
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
