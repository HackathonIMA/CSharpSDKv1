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
  public class DespesasResponse {
    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<LinksModel> Links { get; set; }

    
    /* Identificador do registro. */
    [DataMember(Name="ID", EmitDefaultValue=false)]
    public string ID { get; set; }

    
    /* Ano e MÃªs da EmissÃ£o da Nota de Empenho */
    [DataMember(Name="anoMesEmissao", EmitDefaultValue=false)]
    public int? AnoMesEmissao { get; set; }

    
    /* Ano , Mes e Dia do LanÃ§amento da Nota de Empenho */
    [DataMember(Name="diaLancamento", EmitDefaultValue=false)]
    public int? DiaLancamento { get; set; }

    
    /* Ano , Mes e Dia do Vencimento da Nota de Empenho */
    [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
    public int? DiaVencimento { get; set; }

    
    /* Numero da Nota de Empenho */
    [DataMember(Name="notaEmpenho", EmitDefaultValue=false)]
    public string NotaEmpenho { get; set; }

    
    /* Numero do Processo de Compra */
    [DataMember(Name="processoDescricao", EmitDefaultValue=false)]
    public string ProcessoDescricao { get; set; }

    
    /* Valor Empenhado */
    [DataMember(Name="valorEmpenho", EmitDefaultValue=false)]
    public int? ValorEmpenho { get; set; }

    
    /* Valor Liquidado */
    [DataMember(Name="valorLiquidado", EmitDefaultValue=false)]
    public int? ValorLiquidado { get; set; }

    
    /* Valor a Liquidar */
    [DataMember(Name="valorALiquidar", EmitDefaultValue=false)]
    public int? ValorALiquidar { get; set; }

    
    /* Valor Pago */
    [DataMember(Name="valorPago", EmitDefaultValue=false)]
    public int? ValorPago { get; set; }

    
    /* Valor a Pagar */
    [DataMember(Name="valorAPagar", EmitDefaultValue=false)]
    public int? ValorAPagar { get; set; }

    
    /* Valor de AcrÃ©scimo do Empenho */
    [DataMember(Name="valorAcrescimoEmpenho", EmitDefaultValue=false)]
    public int? ValorAcrescimoEmpenho { get; set; }

    
    /* Valor de AcrÃ©scimo Liquidado */
    [DataMember(Name="valorAcrescimoLiquidado", EmitDefaultValue=false)]
    public int? ValorAcrescimoLiquidado { get; set; }

    
    /* Valor de AcrÃ©scimo a Liquidar */
    [DataMember(Name="valorAcrescimoALiquidar", EmitDefaultValue=false)]
    public int? ValorAcrescimoALiquidar { get; set; }

    
    /* Valor de AcrÃ©cimo Pago */
    [DataMember(Name="valorAcrescimoPago", EmitDefaultValue=false)]
    public int? ValorAcrescimoPago { get; set; }

    
    /* Valor de AcrÃ©scimo a Pagar */
    [DataMember(Name="valorAcrescimoAPagar", EmitDefaultValue=false)]
    public int? ValorAcrescimoAPagar { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DespesasResponse {\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
      sb.Append("  ID: ").Append(ID).Append("\n");
      
      sb.Append("  AnoMesEmissao: ").Append(AnoMesEmissao).Append("\n");
      
      sb.Append("  DiaLancamento: ").Append(DiaLancamento).Append("\n");
      
      sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
      
      sb.Append("  NotaEmpenho: ").Append(NotaEmpenho).Append("\n");
      
      sb.Append("  ProcessoDescricao: ").Append(ProcessoDescricao).Append("\n");
      
      sb.Append("  ValorEmpenho: ").Append(ValorEmpenho).Append("\n");
      
      sb.Append("  ValorLiquidado: ").Append(ValorLiquidado).Append("\n");
      
      sb.Append("  ValorALiquidar: ").Append(ValorALiquidar).Append("\n");
      
      sb.Append("  ValorPago: ").Append(ValorPago).Append("\n");
      
      sb.Append("  ValorAPagar: ").Append(ValorAPagar).Append("\n");
      
      sb.Append("  ValorAcrescimoEmpenho: ").Append(ValorAcrescimoEmpenho).Append("\n");
      
      sb.Append("  ValorAcrescimoLiquidado: ").Append(ValorAcrescimoLiquidado).Append("\n");
      
      sb.Append("  ValorAcrescimoALiquidar: ").Append(ValorAcrescimoALiquidar).Append("\n");
      
      sb.Append("  ValorAcrescimoPago: ").Append(ValorAcrescimoPago).Append("\n");
      
      sb.Append("  ValorAcrescimoAPagar: ").Append(ValorAcrescimoAPagar).Append("\n");
      
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
