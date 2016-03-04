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
  public class ReceitaResponse {
    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<LinksModel> Links { get; set; }

    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* Ano e MÃªs da EmissÃ£o de Receita */
    [DataMember(Name="anoMesEmissao", EmitDefaultValue=false)]
    public int? AnoMesEmissao { get; set; }

    
    /* CÃ³digo da Origem do Recurso */
    [DataMember(Name="codigoOrigemRecurso", EmitDefaultValue=false)]
    public string CodigoOrigemRecurso { get; set; }

    
    /* Valor Prevista da receita */
    [DataMember(Name="valorPrevisao", EmitDefaultValue=false)]
    public string ValorPrevisao { get; set; }

    
    /* Valor de previsÃ£o inicial da Receita */
    [DataMember(Name="valorPrevisaoInicial", EmitDefaultValue=false)]
    public string ValorPrevisaoInicial { get; set; }

    
    /* Valor de previsÃ£o adicicional da receita */
    [DataMember(Name="valorPrevisaoAdicional", EmitDefaultValue=false)]
    public string ValorPrevisaoAdicional { get; set; }

    
    /* Valor de DeduÃ§Ã£o previsto da receita */
    [DataMember(Name="valorPrevisaoDeducao", EmitDefaultValue=false)]
    public string ValorPrevisaoDeducao { get; set; }

    
    /* valor de AnulaÃ§Ã£o previsto da receita */
    [DataMember(Name="valorPrevisaoAnulacao", EmitDefaultValue=false)]
    public string ValorPrevisaoAnulacao { get; set; }

    
    /* Valor Realizado da receita */
    [DataMember(Name="valorRealizado", EmitDefaultValue=false)]
    public string ValorRealizado { get; set; }

    
    /* Valor Realizado Deduzido da Receita */
    [DataMember(Name="valorRealizadoDeduzido", EmitDefaultValue=false)]
    public string ValorRealizadoDeduzido { get; set; }

    
    /* Valor a Realizar da Receita */
    [DataMember(Name="valorARealizar", EmitDefaultValue=false)]
    public string ValorARealizar { get; set; }

    
    /* Valor a Realizar deduzido da Receita */
    [DataMember(Name="valorARealizarDeduzido", EmitDefaultValue=false)]
    public string ValorARealizarDeduzido { get; set; }

    
    /* Valor de AcrÃ©scimo previsto da receita */
    [DataMember(Name="valorPrevisaoAcrescimo", EmitDefaultValue=false)]
    public string ValorPrevisaoAcrescimo { get; set; }

    
    /* Valor de acrÃ©scimo previsto inicialmente da receita */
    [DataMember(Name="valorPrevisaoInicialAcrescimo", EmitDefaultValue=false)]
    public string ValorPrevisaoInicialAcrescimo { get; set; }

    
    /* Valor de AcrÃ©cimo Adicional previsto da receita */
    [DataMember(Name="valorPrevisaoAdicionalAcrescimo", EmitDefaultValue=false)]
    public string ValorPrevisaoAdicionalAcrescimo { get; set; }

    
    /* Valor de AcrÃ©scimo deduzido previsto da receita */
    [DataMember(Name="valorPrevisaoDeducaoAcrescimo", EmitDefaultValue=false)]
    public string ValorPrevisaoDeducaoAcrescimo { get; set; }

    
    /* Valor de Acrescimo anulado previsto da receita */
    [DataMember(Name="valorPrevisaoAnulacaoAcrescimo", EmitDefaultValue=false)]
    public string ValorPrevisaoAnulacaoAcrescimo { get; set; }

    
    /* Valor de Acrescimo realizado da receita */
    [DataMember(Name="valorRealizadoAcrescimo", EmitDefaultValue=false)]
    public string ValorRealizadoAcrescimo { get; set; }

    
    /* Valor de Acrescimo deduzido realizado da receita */
    [DataMember(Name="valorRealizadoDeduzidoAcrescimo", EmitDefaultValue=false)]
    public string ValorRealizadoDeduzidoAcrescimo { get; set; }

    
    /* Valor de Acrescimo a realizar da receita */
    [DataMember(Name="valorARealizarAcrescimo", EmitDefaultValue=false)]
    public string ValorARealizarAcrescimo { get; set; }

    
    /* Valor de Acrescimo deduzido a realizar da receita */
    [DataMember(Name="valorARealizarDeduzidoAcrescimo", EmitDefaultValue=false)]
    public string ValorARealizarDeduzidoAcrescimo { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReceitaResponse {\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  AnoMesEmissao: ").Append(AnoMesEmissao).Append("\n");
      
      sb.Append("  CodigoOrigemRecurso: ").Append(CodigoOrigemRecurso).Append("\n");
      
      sb.Append("  ValorPrevisao: ").Append(ValorPrevisao).Append("\n");
      
      sb.Append("  ValorPrevisaoInicial: ").Append(ValorPrevisaoInicial).Append("\n");
      
      sb.Append("  ValorPrevisaoAdicional: ").Append(ValorPrevisaoAdicional).Append("\n");
      
      sb.Append("  ValorPrevisaoDeducao: ").Append(ValorPrevisaoDeducao).Append("\n");
      
      sb.Append("  ValorPrevisaoAnulacao: ").Append(ValorPrevisaoAnulacao).Append("\n");
      
      sb.Append("  ValorRealizado: ").Append(ValorRealizado).Append("\n");
      
      sb.Append("  ValorRealizadoDeduzido: ").Append(ValorRealizadoDeduzido).Append("\n");
      
      sb.Append("  ValorARealizar: ").Append(ValorARealizar).Append("\n");
      
      sb.Append("  ValorARealizarDeduzido: ").Append(ValorARealizarDeduzido).Append("\n");
      
      sb.Append("  ValorPrevisaoAcrescimo: ").Append(ValorPrevisaoAcrescimo).Append("\n");
      
      sb.Append("  ValorPrevisaoInicialAcrescimo: ").Append(ValorPrevisaoInicialAcrescimo).Append("\n");
      
      sb.Append("  ValorPrevisaoAdicionalAcrescimo: ").Append(ValorPrevisaoAdicionalAcrescimo).Append("\n");
      
      sb.Append("  ValorPrevisaoDeducaoAcrescimo: ").Append(ValorPrevisaoDeducaoAcrescimo).Append("\n");
      
      sb.Append("  ValorPrevisaoAnulacaoAcrescimo: ").Append(ValorPrevisaoAnulacaoAcrescimo).Append("\n");
      
      sb.Append("  ValorRealizadoAcrescimo: ").Append(ValorRealizadoAcrescimo).Append("\n");
      
      sb.Append("  ValorRealizadoDeduzidoAcrescimo: ").Append(ValorRealizadoDeduzidoAcrescimo).Append("\n");
      
      sb.Append("  ValorARealizarAcrescimo: ").Append(ValorARealizarAcrescimo).Append("\n");
      
      sb.Append("  ValorARealizarDeduzidoAcrescimo: ").Append(ValorARealizarDeduzidoAcrescimo).Append("\n");
      
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
