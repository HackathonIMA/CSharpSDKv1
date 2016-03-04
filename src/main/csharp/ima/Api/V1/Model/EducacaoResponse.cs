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

    
    /* CÃ³digo do grupo escolar (AG1: 0~1,5 anos, AG2: 1,5~3 anos, AG3: 3 ~5 anos). */
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

    
    /* EndereÃ§o completo da unidade onde foi registrada a demanda. */
    [DataMember(Name="endereco_escola_demanda", EmitDefaultValue=false)]
    public string EnderecoEscolaDemanda { get; set; }

    
    /* Nome do logradouro da unidade onde foi registrada a demanda. */
    [DataMember(Name="logradouro_demanda", EmitDefaultValue=false)]
    public string LogradouroDemanda { get; set; }

    
    /* Nome do municÃ­pio da unidade onde foi registrada a demanda. (sempre Campinas) */
    [DataMember(Name="municipio_demanda", EmitDefaultValue=false)]
    public string MunicipioDemanda { get; set; }

    
    /* Sigla da unidade federativa do cadastro da demanda (sempre SP) */
    [DataMember(Name="uf_demanda", EmitDefaultValue=false)]
    public string UfDemanda { get; set; }

    
    /* CEP registrado do endereÃ§o da unidade onde foi registrada a demanda. */
    [DataMember(Name="cep_demanda", EmitDefaultValue=false)]
    public string CepDemanda { get; set; }

    
    /* Quantidade total do registro da demanda. Cada registro do webservice traz a tipificaÃ§Ã£o da demanda e este campo mostra os valores consolidados totais para a demanda. */
    [DataMember(Name="demanda", EmitDefaultValue=false)]
    public string Demanda { get; set; }

    

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
      
      sb.Append("  EnderecoEscolaDemanda: ").Append(EnderecoEscolaDemanda).Append("\n");
      
      sb.Append("  LogradouroDemanda: ").Append(LogradouroDemanda).Append("\n");
      
      sb.Append("  MunicipioDemanda: ").Append(MunicipioDemanda).Append("\n");
      
      sb.Append("  UfDemanda: ").Append(UfDemanda).Append("\n");
      
      sb.Append("  CepDemanda: ").Append(CepDemanda).Append("\n");
      
      sb.Append("  Demanda: ").Append(Demanda).Append("\n");
      
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
