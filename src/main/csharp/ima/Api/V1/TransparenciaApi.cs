using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ima.Api.V1.Client;
using ima.Api.V1.Model;

namespace ima.Api.V1 {
  

  public interface ITransparenciaApi {
    
    /// <summary>
    /// Consulta das aÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<AcoesResponse></returns>
    List<AcoesResponse> QueryfiltroAcao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das aÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<AcoesResponse></returns>
    Task<List<AcoesResponse>> QueryfiltroAcaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da aÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>AcoesResponse</returns>
    AcoesResponse QueryfiltroAcao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da aÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>AcoesResponse</returns>
    Task<AcoesResponse> QueryfiltroAcao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de credores. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<CredorResponse></returns>
    List<CredorResponse> PtrLkpCredor (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de credores. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<CredorResponse></returns>
    Task<List<CredorResponse>> PtrLkpCredorAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de credor. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>CredorResponse</returns>
    CredorResponse PtrLkpCredor2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de credor. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>CredorResponse</returns>
    Task<CredorResponse> PtrLkpCredor2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de despesas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="AnoExercicio">Ano de exercÃ­cio</param>/// <param name="Acao">AÃ§Ã£o, lista disponÃ­vel em GET /transparencia/acoes</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Orgao">OrgÃ£os, lista disponÃ­vel em GET /transparencia/unidadesGestoras</param>/// <param name="Funcao">FunÃ§Ã£o, lista disponÃ­vel em GET /transparencia/funcoes</param>/// <param name="Subfuncao">Sub-funÃ§Ã£o, lista disponÃ­vel em GET /transparencia/subfuncoes</param>/// <param name="Programa">Programa, lista disponÃ­vel em GET /transparencia/programas</param>/// <param name="OrigemFonte">Origem das fontes, lista disponÃ­vel em GET /transparencia/fontesDetalhadas</param>/// <param name="Fonte">Fontes, lista disponÃ­vel em GET /transparencia/fontes</param>/// <param name="NaturezaDespesa">Natureza da despesa, lista disponÃ­vel em GET /transparencia/subItensContas</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>
    /// <returns>List<DespesasResponse></returns>
    List<DespesasResponse> PtrFtDespesa (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string AnoExercicio, string Acao, string Mes, string Orgao, string Funcao, string Subfuncao, string Programa, string OrigemFonte, string Fonte, string NaturezaDespesa, string Expand);

    /// <summary>
    /// Consulta de despesas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="AnoExercicio">Ano de exercÃ­cio</param>/// <param name="Acao">AÃ§Ã£o, lista disponÃ­vel em GET /transparencia/acoes</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Orgao">OrgÃ£os, lista disponÃ­vel em GET /transparencia/unidadesGestoras</param>/// <param name="Funcao">FunÃ§Ã£o, lista disponÃ­vel em GET /transparencia/funcoes</param>/// <param name="Subfuncao">Sub-funÃ§Ã£o, lista disponÃ­vel em GET /transparencia/subfuncoes</param>/// <param name="Programa">Programa, lista disponÃ­vel em GET /transparencia/programas</param>/// <param name="OrigemFonte">Origem das fontes, lista disponÃ­vel em GET /transparencia/fontesDetalhadas</param>/// <param name="Fonte">Fontes, lista disponÃ­vel em GET /transparencia/fontes</param>/// <param name="NaturezaDespesa">Natureza da despesa, lista disponÃ­vel em GET /transparencia/subItensContas</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>
    /// <returns>List<DespesasResponse></returns>
    Task<List<DespesasResponse>> PtrFtDespesaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string AnoExercicio, string Acao, string Mes, string Orgao, string Funcao, string Subfuncao, string Programa, string OrigemFonte, string Fonte, string NaturezaDespesa, string Expand);
    
    /// <summary>
    /// Consulta de uma despesa da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>DespesasResponse</returns>
    DespesasResponse PtrFtDespesa2 (string Id, string ClientId, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de uma despesa da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>DespesasResponse</returns>
    Task<DespesasResponse> PtrFtDespesa2Async (string Id, string ClientId, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ElementoDespesaResponse></returns>
    List<ElementoDespesaResponse> PtrLkpElementoDespesa (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ElementoDespesaResponse></returns>
    Task<List<ElementoDespesaResponse>> PtrLkpElementoDespesaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ElementoDespesaResponse</returns>
    ElementoDespesaResponse PtrLkpElementoDespesa2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ElementoDespesaResponse</returns>
    Task<ElementoDespesaResponse> PtrLkpElementoDespesa2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<EmpenhoResponse></returns>
    List<EmpenhoResponse> PtrLkpNe (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<EmpenhoResponse></returns>
    Task<List<EmpenhoResponse>> PtrLkpNeAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>EmpenhoResponse</returns>
    EmpenhoResponse PtrLkpNe2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>EmpenhoResponse</returns>
    Task<EmpenhoResponse> PtrLkpNe2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de contas das fontes da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FontesResponse></returns>
    List<FontesResponse> PtrLkpFonteDetalhada (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de contas das fontes da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FontesResponse></returns>
    Task<List<FontesResponse>> PtrLkpFonteDetalhadaAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de conta da fonte da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FontesResponse</returns>
    FontesResponse PtrLkpFonteDetalhada2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de conta da fonte da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FontesResponse</returns>
    Task<FontesResponse> PtrLkpFonteDetalhada2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das receitas das fontes detalhadas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FonteDetalhadaResponse></returns>
    List<FonteDetalhadaResponse> PtrLkpFonte (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das receitas das fontes detalhadas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FonteDetalhadaResponse></returns>
    Task<List<FonteDetalhadaResponse>> PtrLkpFonteAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da receita da fonte detalhada da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FonteDetalhadaResponse</returns>
    FonteDetalhadaResponse PtrLkpFonte2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da receita da fonte detalhada da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FonteDetalhadaResponse</returns>
    Task<FonteDetalhadaResponse> PtrLkpFonte2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FuncoesResponse></returns>
    List<FuncoesResponse> PtrLkpFuncao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FuncoesResponse></returns>
    Task<List<FuncoesResponse>> PtrLkpFuncaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FuncoesResponse</returns>
    FuncoesResponse PtrLkpFuncao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FuncoesResponse</returns>
    Task<FuncoesResponse> PtrLkpFuncao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de contas das naturezas das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<NaturezasResponse></returns>
    List<NaturezasResponse> PtrLkpSubalineaReceita (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de contas das naturezas das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<NaturezasResponse></returns>
    Task<List<NaturezasResponse>> PtrLkpSubalineaReceitaAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de conta da natureza da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>NaturezasResponse</returns>
    NaturezasResponse PtrLkpSubalineaReceita2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de conta da natureza da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>NaturezasResponse</returns>
    Task<NaturezasResponse> PtrLkpSubalineaReceita2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta dos programas da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProgramaResponse></returns>
    List<ProgramaResponse> PtrLkpPrograma (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta dos programas da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProgramaResponse></returns>
    Task<List<ProgramaResponse>> PtrLkpProgramaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta do programa da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProgramaResponse</returns>
    ProgramaResponse PtrLkpPrograma2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta do programa da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProgramaResponse</returns>
    Task<ProgramaResponse> PtrLkpPrograma2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta dos projetos e atividades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProjetoAtividadeResponse></returns>
    List<ProjetoAtividadeResponse> PtrLkpProjetoAtividade (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta dos projetos e atividades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProjetoAtividadeResponse></returns>
    Task<List<ProjetoAtividadeResponse>> PtrLkpProjetoAtividadeAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta do projeto e atividade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProjetoAtividadeResponse</returns>
    ProjetoAtividadeResponse PtrLkpProjetoAtividade2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta do projeto e atividade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProjetoAtividadeResponse</returns>
    Task<ProjetoAtividadeResponse> PtrLkpProjetoAtividade2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>List<ReceitaResponse></returns>
    List<ReceitaResponse> PtrFtReceita (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza);

    /// <summary>
    /// Consulta das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>List<ReceitaResponse></returns>
    Task<List<ReceitaResponse>> PtrFtReceitaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza);
    
    /// <summary>
    /// Consulta da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio, lista disponÃ­vel em GET /transparencia/anosExercicioReceita</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>ReceitaResponse</returns>
    ReceitaResponse PtrFtReceita2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza);

    /// <summary>
    /// Consulta da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio, lista disponÃ­vel em GET /transparencia/anosExercicioReceita</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>ReceitaResponse</returns>
    Task<ReceitaResponse> PtrFtReceita2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza);
    
    /// <summary>
    /// Consulta dos sub-itens das contas. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubItensContasResponse></returns>
    List<SubItensContasResponse> PtrLkpSubitemConta (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta dos sub-itens das contas. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubItensContasResponse></returns>
    Task<List<SubItensContasResponse>> PtrLkpSubitemContaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta do sub-item das contas. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubItensContasResponse</returns>
    SubItensContasResponse PtrLkpSubitemConta2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta do sub-item das contas. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubItensContasResponse</returns>
    Task<SubItensContasResponse> PtrLkpSubitemConta2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das sub-funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubfuncoesResponse></returns>
    List<SubfuncoesResponse> PtrLkpSubfuncao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das sub-funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubfuncoesResponse></returns>
    Task<List<SubfuncoesResponse>> PtrLkpSubfuncaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da sub-funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubfuncoesResponse</returns>
    SubfuncoesResponse PtrLkpSubfuncao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da sub-funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubfuncoesResponse</returns>
    Task<SubfuncoesResponse> PtrLkpSubfuncao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta dos tipos de licitaÃ§Ãµes. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<TipoLicitacoesResponse></returns>
    List<TipoLicitacoesResponse> PtrLkpTipoLicitacao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta dos tipos de licitaÃ§Ãµes. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<TipoLicitacoesResponse></returns>
    Task<List<TipoLicitacoesResponse>> PtrLkpTipoLicitacaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta do tipo de licitaÃ§Ã£o. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>TipoLicitacoesResponse</returns>
    TipoLicitacoesResponse PtrLkpTipoLicitacao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta do tipo de licitaÃ§Ã£o. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>TipoLicitacoesResponse</returns>
    Task<TipoLicitacoesResponse> PtrLkpTipoLicitacao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta das unidades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadesResponse></returns>
    List<UnidadesResponse> PtrLkpUnidadeOrcamentaria (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta das unidades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadesResponse></returns>
    Task<List<UnidadesResponse>> PtrLkpUnidadeOrcamentariaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta da unidade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadesResponse</returns>
    UnidadesResponse PtrLkpUnidadeOrcamentaria2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta da unidade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadesResponse</returns>
    Task<UnidadesResponse> PtrLkpUnidadeOrcamentaria2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de contas das unidades gestoras da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadeGestoraResponse></returns>
    List<UnidadeGestoraResponse> PtrLkpUnidadeGestora (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de contas das unidades gestoras da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadeGestoraResponse></returns>
    Task<List<UnidadeGestoraResponse>> PtrLkpUnidadeGestoraAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Consulta de conta da unidade gestora da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadeGestoraResponse</returns>
    UnidadeGestoraResponse PtrLkpUnidadeGestora2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Consulta de conta da unidade gestora da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadeGestoraResponse</returns>
    Task<UnidadeGestoraResponse> PtrLkpUnidadeGestora2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class TransparenciaApi : ITransparenciaApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="TransparenciaApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public TransparenciaApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TransparenciaApi"/> class.
    /// </summary>
    /// <returns></returns>
    public TransparenciaApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Consulta das aÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<AcoesResponse></returns>
    public List<AcoesResponse> QueryfiltroAcao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling QueryfiltroAcao");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling QueryfiltroAcao");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling QueryfiltroAcao");
      

      var path = "/transparencia/acoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling QueryfiltroAcao: " + response.Content, response.Content);
      }
      return (List<AcoesResponse>) apiClient.Deserialize(response.Content, typeof(List<AcoesResponse>));
    }
	
	 /// <summary>
    /// Consulta das aÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<AcoesResponse></returns>
    public async Task<List<AcoesResponse>> QueryfiltroAcaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling QueryfiltroAcao");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling QueryfiltroAcao");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling QueryfiltroAcao");
      

      var path = "/transparencia/acoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling QueryfiltroAcao: " + response.Content, response.Content);
      }
      return (List<AcoesResponse>) apiClient.Deserialize(response.Content, typeof(List<AcoesResponse>));
    }
    
    /// <summary>
    /// Consulta da aÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>AcoesResponse</returns>
    public AcoesResponse QueryfiltroAcao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling QueryfiltroAcao2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling QueryfiltroAcao2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling QueryfiltroAcao2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling QueryfiltroAcao2");
      

      var path = "/transparencia/acoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling QueryfiltroAcao2: " + response.Content, response.Content);
      }
      return (AcoesResponse) apiClient.Deserialize(response.Content, typeof(AcoesResponse));
    }
	
	 /// <summary>
    /// Consulta da aÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>AcoesResponse</returns>
    public async Task<AcoesResponse> QueryfiltroAcao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling QueryfiltroAcao2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling QueryfiltroAcao2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling QueryfiltroAcao2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling QueryfiltroAcao2");
      

      var path = "/transparencia/acoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling QueryfiltroAcao2: " + response.Content, response.Content);
      }
      return (AcoesResponse) apiClient.Deserialize(response.Content, typeof(AcoesResponse));
    }
    
    /// <summary>
    /// Consulta de credores. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<CredorResponse></returns>
    public List<CredorResponse> PtrLkpCredor (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpCredor");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpCredor");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpCredor");
      

      var path = "/transparencia/credores";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpCredor: " + response.Content, response.Content);
      }
      return (List<CredorResponse>) apiClient.Deserialize(response.Content, typeof(List<CredorResponse>));
    }
	
	 /// <summary>
    /// Consulta de credores. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<CredorResponse></returns>
    public async Task<List<CredorResponse>> PtrLkpCredorAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpCredor");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpCredor");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpCredor");
      

      var path = "/transparencia/credores";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpCredor: " + response.Content, response.Content);
      }
      return (List<CredorResponse>) apiClient.Deserialize(response.Content, typeof(List<CredorResponse>));
    }
    
    /// <summary>
    /// Consulta de credor. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>CredorResponse</returns>
    public CredorResponse PtrLkpCredor2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpCredor2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpCredor2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpCredor2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpCredor2");
      

      var path = "/transparencia/credores/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpCredor2: " + response.Content, response.Content);
      }
      return (CredorResponse) apiClient.Deserialize(response.Content, typeof(CredorResponse));
    }
	
	 /// <summary>
    /// Consulta de credor. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>CredorResponse</returns>
    public async Task<CredorResponse> PtrLkpCredor2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpCredor2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpCredor2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpCredor2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpCredor2");
      

      var path = "/transparencia/credores/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpCredor2: " + response.Content, response.Content);
      }
      return (CredorResponse) apiClient.Deserialize(response.Content, typeof(CredorResponse));
    }
    
    /// <summary>
    /// Consulta de despesas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="AnoExercicio">Ano de exercÃ­cio</param>/// <param name="Acao">AÃ§Ã£o, lista disponÃ­vel em GET /transparencia/acoes</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Orgao">OrgÃ£os, lista disponÃ­vel em GET /transparencia/unidadesGestoras</param>/// <param name="Funcao">FunÃ§Ã£o, lista disponÃ­vel em GET /transparencia/funcoes</param>/// <param name="Subfuncao">Sub-funÃ§Ã£o, lista disponÃ­vel em GET /transparencia/subfuncoes</param>/// <param name="Programa">Programa, lista disponÃ­vel em GET /transparencia/programas</param>/// <param name="OrigemFonte">Origem das fontes, lista disponÃ­vel em GET /transparencia/fontesDetalhadas</param>/// <param name="Fonte">Fontes, lista disponÃ­vel em GET /transparencia/fontes</param>/// <param name="NaturezaDespesa">Natureza da despesa, lista disponÃ­vel em GET /transparencia/subItensContas</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>
    /// <returns>List<DespesasResponse></returns>
    public List<DespesasResponse> PtrFtDespesa (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string AnoExercicio, string Acao, string Mes, string Orgao, string Funcao, string Subfuncao, string Programa, string OrigemFonte, string Fonte, string NaturezaDespesa, string Expand) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtDespesa");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrFtDespesa");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrFtDespesa");
      

      var path = "/transparencia/despesas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
       if (AnoExercicio != null) queryParams.Add("anoExercicio", apiClient.ParameterToString(AnoExercicio)); // query parameter
       if (Acao != null) queryParams.Add("acao", apiClient.ParameterToString(Acao)); // query parameter
       if (Mes != null) queryParams.Add("mes", apiClient.ParameterToString(Mes)); // query parameter
       if (Orgao != null) queryParams.Add("orgao", apiClient.ParameterToString(Orgao)); // query parameter
       if (Funcao != null) queryParams.Add("funcao", apiClient.ParameterToString(Funcao)); // query parameter
       if (Subfuncao != null) queryParams.Add("subfuncao", apiClient.ParameterToString(Subfuncao)); // query parameter
       if (Programa != null) queryParams.Add("programa", apiClient.ParameterToString(Programa)); // query parameter
       if (OrigemFonte != null) queryParams.Add("origemFonte", apiClient.ParameterToString(OrigemFonte)); // query parameter
       if (Fonte != null) queryParams.Add("fonte", apiClient.ParameterToString(Fonte)); // query parameter
       if (NaturezaDespesa != null) queryParams.Add("naturezaDespesa", apiClient.ParameterToString(NaturezaDespesa)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtDespesa: " + response.Content, response.Content);
      }
      return (List<DespesasResponse>) apiClient.Deserialize(response.Content, typeof(List<DespesasResponse>));
    }
	
	 /// <summary>
    /// Consulta de despesas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="AnoExercicio">Ano de exercÃ­cio</param>/// <param name="Acao">AÃ§Ã£o, lista disponÃ­vel em GET /transparencia/acoes</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Orgao">OrgÃ£os, lista disponÃ­vel em GET /transparencia/unidadesGestoras</param>/// <param name="Funcao">FunÃ§Ã£o, lista disponÃ­vel em GET /transparencia/funcoes</param>/// <param name="Subfuncao">Sub-funÃ§Ã£o, lista disponÃ­vel em GET /transparencia/subfuncoes</param>/// <param name="Programa">Programa, lista disponÃ­vel em GET /transparencia/programas</param>/// <param name="OrigemFonte">Origem das fontes, lista disponÃ­vel em GET /transparencia/fontesDetalhadas</param>/// <param name="Fonte">Fontes, lista disponÃ­vel em GET /transparencia/fontes</param>/// <param name="NaturezaDespesa">Natureza da despesa, lista disponÃ­vel em GET /transparencia/subItensContas</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>
    /// <returns>List<DespesasResponse></returns>
    public async Task<List<DespesasResponse>> PtrFtDespesaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string AnoExercicio, string Acao, string Mes, string Orgao, string Funcao, string Subfuncao, string Programa, string OrigemFonte, string Fonte, string NaturezaDespesa, string Expand) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtDespesa");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrFtDespesa");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrFtDespesa");
      

      var path = "/transparencia/despesas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
       if (AnoExercicio != null) queryParams.Add("anoExercicio", apiClient.ParameterToString(AnoExercicio)); // query parameter
       if (Acao != null) queryParams.Add("acao", apiClient.ParameterToString(Acao)); // query parameter
       if (Mes != null) queryParams.Add("mes", apiClient.ParameterToString(Mes)); // query parameter
       if (Orgao != null) queryParams.Add("orgao", apiClient.ParameterToString(Orgao)); // query parameter
       if (Funcao != null) queryParams.Add("funcao", apiClient.ParameterToString(Funcao)); // query parameter
       if (Subfuncao != null) queryParams.Add("subfuncao", apiClient.ParameterToString(Subfuncao)); // query parameter
       if (Programa != null) queryParams.Add("programa", apiClient.ParameterToString(Programa)); // query parameter
       if (OrigemFonte != null) queryParams.Add("origemFonte", apiClient.ParameterToString(OrigemFonte)); // query parameter
       if (Fonte != null) queryParams.Add("fonte", apiClient.ParameterToString(Fonte)); // query parameter
       if (NaturezaDespesa != null) queryParams.Add("naturezaDespesa", apiClient.ParameterToString(NaturezaDespesa)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtDespesa: " + response.Content, response.Content);
      }
      return (List<DespesasResponse>) apiClient.Deserialize(response.Content, typeof(List<DespesasResponse>));
    }
    
    /// <summary>
    /// Consulta de uma despesa da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>DespesasResponse</returns>
    public DespesasResponse PtrFtDespesa2 (string Id, string ClientId, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrFtDespesa2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtDespesa2");
      

      var path = "/transparencia/despesas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtDespesa2: " + response.Content, response.Content);
      }
      return (DespesasResponse) apiClient.Deserialize(response.Content, typeof(DespesasResponse));
    }
	
	 /// <summary>
    /// Consulta de uma despesa da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>DespesasResponse</returns>
    public async Task<DespesasResponse> PtrFtDespesa2Async (string Id, string ClientId, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrFtDespesa2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtDespesa2");
      

      var path = "/transparencia/despesas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtDespesa2: " + response.Content, response.Content);
      }
      return (DespesasResponse) apiClient.Deserialize(response.Content, typeof(DespesasResponse));
    }
    
    /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ElementoDespesaResponse></returns>
    public List<ElementoDespesaResponse> PtrLkpElementoDespesa (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpElementoDespesa");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpElementoDespesa");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpElementoDespesa");
      

      var path = "/transparencia/elementos";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpElementoDespesa: " + response.Content, response.Content);
      }
      return (List<ElementoDespesaResponse>) apiClient.Deserialize(response.Content, typeof(List<ElementoDespesaResponse>));
    }
	
	 /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ElementoDespesaResponse></returns>
    public async Task<List<ElementoDespesaResponse>> PtrLkpElementoDespesaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpElementoDespesa");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpElementoDespesa");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpElementoDespesa");
      

      var path = "/transparencia/elementos";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpElementoDespesa: " + response.Content, response.Content);
      }
      return (List<ElementoDespesaResponse>) apiClient.Deserialize(response.Content, typeof(List<ElementoDespesaResponse>));
    }
    
    /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ElementoDespesaResponse</returns>
    public ElementoDespesaResponse PtrLkpElementoDespesa2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpElementoDespesa2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpElementoDespesa2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpElementoDespesa2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpElementoDespesa2");
      

      var path = "/transparencia/elementos/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpElementoDespesa2: " + response.Content, response.Content);
      }
      return (ElementoDespesaResponse) apiClient.Deserialize(response.Content, typeof(ElementoDespesaResponse));
    }
	
	 /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ElementoDespesaResponse</returns>
    public async Task<ElementoDespesaResponse> PtrLkpElementoDespesa2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpElementoDespesa2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpElementoDespesa2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpElementoDespesa2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpElementoDespesa2");
      

      var path = "/transparencia/elementos/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpElementoDespesa2: " + response.Content, response.Content);
      }
      return (ElementoDespesaResponse) apiClient.Deserialize(response.Content, typeof(ElementoDespesaResponse));
    }
    
    /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<EmpenhoResponse></returns>
    public List<EmpenhoResponse> PtrLkpNe (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpNe");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpNe");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpNe");
      

      var path = "/transparencia/empenhos";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpNe: " + response.Content, response.Content);
      }
      return (List<EmpenhoResponse>) apiClient.Deserialize(response.Content, typeof(List<EmpenhoResponse>));
    }
	
	 /// <summary>
    /// Consulta das despesas dos elementos da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<EmpenhoResponse></returns>
    public async Task<List<EmpenhoResponse>> PtrLkpNeAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpNe");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpNe");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpNe");
      

      var path = "/transparencia/empenhos";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpNe: " + response.Content, response.Content);
      }
      return (List<EmpenhoResponse>) apiClient.Deserialize(response.Content, typeof(List<EmpenhoResponse>));
    }
    
    /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>EmpenhoResponse</returns>
    public EmpenhoResponse PtrLkpNe2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpNe2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpNe2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpNe2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpNe2");
      

      var path = "/transparencia/empenhos/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpNe2: " + response.Content, response.Content);
      }
      return (EmpenhoResponse) apiClient.Deserialize(response.Content, typeof(EmpenhoResponse));
    }
	
	 /// <summary>
    /// Consulta da despesa do elemento da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>EmpenhoResponse</returns>
    public async Task<EmpenhoResponse> PtrLkpNe2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpNe2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpNe2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpNe2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpNe2");
      

      var path = "/transparencia/empenhos/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpNe2: " + response.Content, response.Content);
      }
      return (EmpenhoResponse) apiClient.Deserialize(response.Content, typeof(EmpenhoResponse));
    }
    
    /// <summary>
    /// Consulta de contas das fontes da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FontesResponse></returns>
    public List<FontesResponse> PtrLkpFonteDetalhada (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonteDetalhada");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonteDetalhada");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonteDetalhada");
      

      var path = "/transparencia/fontes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonteDetalhada: " + response.Content, response.Content);
      }
      return (List<FontesResponse>) apiClient.Deserialize(response.Content, typeof(List<FontesResponse>));
    }
	
	 /// <summary>
    /// Consulta de contas das fontes da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FontesResponse></returns>
    public async Task<List<FontesResponse>> PtrLkpFonteDetalhadaAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonteDetalhada");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonteDetalhada");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonteDetalhada");
      

      var path = "/transparencia/fontes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonteDetalhada: " + response.Content, response.Content);
      }
      return (List<FontesResponse>) apiClient.Deserialize(response.Content, typeof(List<FontesResponse>));
    }
    
    /// <summary>
    /// Consulta de conta da fonte da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FontesResponse</returns>
    public FontesResponse PtrLkpFonteDetalhada2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpFonteDetalhada2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonteDetalhada2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonteDetalhada2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonteDetalhada2");
      

      var path = "/transparencia/fontes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonteDetalhada2: " + response.Content, response.Content);
      }
      return (FontesResponse) apiClient.Deserialize(response.Content, typeof(FontesResponse));
    }
	
	 /// <summary>
    /// Consulta de conta da fonte da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FontesResponse</returns>
    public async Task<FontesResponse> PtrLkpFonteDetalhada2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpFonteDetalhada2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonteDetalhada2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonteDetalhada2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonteDetalhada2");
      

      var path = "/transparencia/fontes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonteDetalhada2: " + response.Content, response.Content);
      }
      return (FontesResponse) apiClient.Deserialize(response.Content, typeof(FontesResponse));
    }
    
    /// <summary>
    /// Consulta das receitas das fontes detalhadas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FonteDetalhadaResponse></returns>
    public List<FonteDetalhadaResponse> PtrLkpFonte (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonte");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonte");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonte");
      

      var path = "/transparencia/fontesDetalhadas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonte: " + response.Content, response.Content);
      }
      return (List<FonteDetalhadaResponse>) apiClient.Deserialize(response.Content, typeof(List<FonteDetalhadaResponse>));
    }
	
	 /// <summary>
    /// Consulta das receitas das fontes detalhadas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FonteDetalhadaResponse></returns>
    public async Task<List<FonteDetalhadaResponse>> PtrLkpFonteAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonte");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonte");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonte");
      

      var path = "/transparencia/fontesDetalhadas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonte: " + response.Content, response.Content);
      }
      return (List<FonteDetalhadaResponse>) apiClient.Deserialize(response.Content, typeof(List<FonteDetalhadaResponse>));
    }
    
    /// <summary>
    /// Consulta da receita da fonte detalhada da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FonteDetalhadaResponse</returns>
    public FonteDetalhadaResponse PtrLkpFonte2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpFonte2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonte2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonte2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonte2");
      

      var path = "/transparencia/fontesDetalhadas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonte2: " + response.Content, response.Content);
      }
      return (FonteDetalhadaResponse) apiClient.Deserialize(response.Content, typeof(FonteDetalhadaResponse));
    }
	
	 /// <summary>
    /// Consulta da receita da fonte detalhada da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FonteDetalhadaResponse</returns>
    public async Task<FonteDetalhadaResponse> PtrLkpFonte2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpFonte2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFonte2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFonte2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFonte2");
      

      var path = "/transparencia/fontesDetalhadas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFonte2: " + response.Content, response.Content);
      }
      return (FonteDetalhadaResponse) apiClient.Deserialize(response.Content, typeof(FonteDetalhadaResponse));
    }
    
    /// <summary>
    /// Consulta das funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FuncoesResponse></returns>
    public List<FuncoesResponse> PtrLkpFuncao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFuncao");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFuncao");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFuncao");
      

      var path = "/transparencia/funcoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFuncao: " + response.Content, response.Content);
      }
      return (List<FuncoesResponse>) apiClient.Deserialize(response.Content, typeof(List<FuncoesResponse>));
    }
	
	 /// <summary>
    /// Consulta das funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<FuncoesResponse></returns>
    public async Task<List<FuncoesResponse>> PtrLkpFuncaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFuncao");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFuncao");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFuncao");
      

      var path = "/transparencia/funcoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFuncao: " + response.Content, response.Content);
      }
      return (List<FuncoesResponse>) apiClient.Deserialize(response.Content, typeof(List<FuncoesResponse>));
    }
    
    /// <summary>
    /// Consulta da funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FuncoesResponse</returns>
    public FuncoesResponse PtrLkpFuncao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpFuncao2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFuncao2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFuncao2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFuncao2");
      

      var path = "/transparencia/funcoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFuncao2: " + response.Content, response.Content);
      }
      return (FuncoesResponse) apiClient.Deserialize(response.Content, typeof(FuncoesResponse));
    }
	
	 /// <summary>
    /// Consulta da funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>FuncoesResponse</returns>
    public async Task<FuncoesResponse> PtrLkpFuncao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpFuncao2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpFuncao2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpFuncao2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpFuncao2");
      

      var path = "/transparencia/funcoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpFuncao2: " + response.Content, response.Content);
      }
      return (FuncoesResponse) apiClient.Deserialize(response.Content, typeof(FuncoesResponse));
    }
    
    /// <summary>
    /// Consulta de contas das naturezas das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<NaturezasResponse></returns>
    public List<NaturezasResponse> PtrLkpSubalineaReceita (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubalineaReceita");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubalineaReceita");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubalineaReceita");
      

      var path = "/transparencia/naturezas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubalineaReceita: " + response.Content, response.Content);
      }
      return (List<NaturezasResponse>) apiClient.Deserialize(response.Content, typeof(List<NaturezasResponse>));
    }
	
	 /// <summary>
    /// Consulta de contas das naturezas das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<NaturezasResponse></returns>
    public async Task<List<NaturezasResponse>> PtrLkpSubalineaReceitaAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubalineaReceita");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubalineaReceita");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubalineaReceita");
      

      var path = "/transparencia/naturezas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubalineaReceita: " + response.Content, response.Content);
      }
      return (List<NaturezasResponse>) apiClient.Deserialize(response.Content, typeof(List<NaturezasResponse>));
    }
    
    /// <summary>
    /// Consulta de conta da natureza da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>NaturezasResponse</returns>
    public NaturezasResponse PtrLkpSubalineaReceita2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpSubalineaReceita2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubalineaReceita2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubalineaReceita2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubalineaReceita2");
      

      var path = "/transparencia/naturezas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubalineaReceita2: " + response.Content, response.Content);
      }
      return (NaturezasResponse) apiClient.Deserialize(response.Content, typeof(NaturezasResponse));
    }
	
	 /// <summary>
    /// Consulta de conta da natureza da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>NaturezasResponse</returns>
    public async Task<NaturezasResponse> PtrLkpSubalineaReceita2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpSubalineaReceita2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubalineaReceita2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubalineaReceita2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubalineaReceita2");
      

      var path = "/transparencia/naturezas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubalineaReceita2: " + response.Content, response.Content);
      }
      return (NaturezasResponse) apiClient.Deserialize(response.Content, typeof(NaturezasResponse));
    }
    
    /// <summary>
    /// Consulta dos programas da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProgramaResponse></returns>
    public List<ProgramaResponse> PtrLkpPrograma (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpPrograma");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpPrograma");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpPrograma");
      

      var path = "/transparencia/programas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpPrograma: " + response.Content, response.Content);
      }
      return (List<ProgramaResponse>) apiClient.Deserialize(response.Content, typeof(List<ProgramaResponse>));
    }
	
	 /// <summary>
    /// Consulta dos programas da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProgramaResponse></returns>
    public async Task<List<ProgramaResponse>> PtrLkpProgramaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpPrograma");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpPrograma");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpPrograma");
      

      var path = "/transparencia/programas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpPrograma: " + response.Content, response.Content);
      }
      return (List<ProgramaResponse>) apiClient.Deserialize(response.Content, typeof(List<ProgramaResponse>));
    }
    
    /// <summary>
    /// Consulta do programa da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProgramaResponse</returns>
    public ProgramaResponse PtrLkpPrograma2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpPrograma2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpPrograma2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpPrograma2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpPrograma2");
      

      var path = "/transparencia/programas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpPrograma2: " + response.Content, response.Content);
      }
      return (ProgramaResponse) apiClient.Deserialize(response.Content, typeof(ProgramaResponse));
    }
	
	 /// <summary>
    /// Consulta do programa da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProgramaResponse</returns>
    public async Task<ProgramaResponse> PtrLkpPrograma2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpPrograma2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpPrograma2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpPrograma2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpPrograma2");
      

      var path = "/transparencia/programas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpPrograma2: " + response.Content, response.Content);
      }
      return (ProgramaResponse) apiClient.Deserialize(response.Content, typeof(ProgramaResponse));
    }
    
    /// <summary>
    /// Consulta dos projetos e atividades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProjetoAtividadeResponse></returns>
    public List<ProjetoAtividadeResponse> PtrLkpProjetoAtividade (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpProjetoAtividade");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpProjetoAtividade");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpProjetoAtividade");
      

      var path = "/transparencia/projetosAtividades";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpProjetoAtividade: " + response.Content, response.Content);
      }
      return (List<ProjetoAtividadeResponse>) apiClient.Deserialize(response.Content, typeof(List<ProjetoAtividadeResponse>));
    }
	
	 /// <summary>
    /// Consulta dos projetos e atividades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProjetoAtividadeResponse></returns>
    public async Task<List<ProjetoAtividadeResponse>> PtrLkpProjetoAtividadeAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpProjetoAtividade");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpProjetoAtividade");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpProjetoAtividade");
      

      var path = "/transparencia/projetosAtividades";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpProjetoAtividade: " + response.Content, response.Content);
      }
      return (List<ProjetoAtividadeResponse>) apiClient.Deserialize(response.Content, typeof(List<ProjetoAtividadeResponse>));
    }
    
    /// <summary>
    /// Consulta do projeto e atividade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProjetoAtividadeResponse</returns>
    public ProjetoAtividadeResponse PtrLkpProjetoAtividade2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpProjetoAtividade2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpProjetoAtividade2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpProjetoAtividade2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpProjetoAtividade2");
      

      var path = "/transparencia/projetosAtividades/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpProjetoAtividade2: " + response.Content, response.Content);
      }
      return (ProjetoAtividadeResponse) apiClient.Deserialize(response.Content, typeof(ProjetoAtividadeResponse));
    }
	
	 /// <summary>
    /// Consulta do projeto e atividade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProjetoAtividadeResponse</returns>
    public async Task<ProjetoAtividadeResponse> PtrLkpProjetoAtividade2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpProjetoAtividade2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpProjetoAtividade2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpProjetoAtividade2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpProjetoAtividade2");
      

      var path = "/transparencia/projetosAtividades/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpProjetoAtividade2: " + response.Content, response.Content);
      }
      return (ProjetoAtividadeResponse) apiClient.Deserialize(response.Content, typeof(ProjetoAtividadeResponse));
    }
    
    /// <summary>
    /// Consulta das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>List<ReceitaResponse></returns>
    public List<ReceitaResponse> PtrFtReceita (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtReceita");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrFtReceita");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrFtReceita");
      

      var path = "/transparencia/receitas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
       if (Ano != null) queryParams.Add("ano", apiClient.ParameterToString(Ano)); // query parameter
       if (Mes != null) queryParams.Add("mes", apiClient.ParameterToString(Mes)); // query parameter
       if (Unidade != null) queryParams.Add("unidade", apiClient.ParameterToString(Unidade)); // query parameter
       if (Natureza != null) queryParams.Add("natureza", apiClient.ParameterToString(Natureza)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtReceita: " + response.Content, response.Content);
      }
      return (List<ReceitaResponse>) apiClient.Deserialize(response.Content, typeof(List<ReceitaResponse>));
    }
	
	 /// <summary>
    /// Consulta das receitas da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>List<ReceitaResponse></returns>
    public async Task<List<ReceitaResponse>> PtrFtReceitaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtReceita");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrFtReceita");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrFtReceita");
      

      var path = "/transparencia/receitas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
       if (Ano != null) queryParams.Add("ano", apiClient.ParameterToString(Ano)); // query parameter
       if (Mes != null) queryParams.Add("mes", apiClient.ParameterToString(Mes)); // query parameter
       if (Unidade != null) queryParams.Add("unidade", apiClient.ParameterToString(Unidade)); // query parameter
       if (Natureza != null) queryParams.Add("natureza", apiClient.ParameterToString(Natureza)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtReceita: " + response.Content, response.Content);
      }
      return (List<ReceitaResponse>) apiClient.Deserialize(response.Content, typeof(List<ReceitaResponse>));
    }
    
    /// <summary>
    /// Consulta da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio, lista disponÃ­vel em GET /transparencia/anosExercicioReceita</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>ReceitaResponse</returns>
    public ReceitaResponse PtrFtReceita2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrFtReceita2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtReceita2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrFtReceita2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrFtReceita2");
      

      var path = "/transparencia/receitas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
       if (Ano != null) queryParams.Add("ano", apiClient.ParameterToString(Ano)); // query parameter
       if (Mes != null) queryParams.Add("mes", apiClient.ParameterToString(Mes)); // query parameter
       if (Unidade != null) queryParams.Add("unidade", apiClient.ParameterToString(Unidade)); // query parameter
       if (Natureza != null) queryParams.Add("natureza", apiClient.ParameterToString(Natureza)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtReceita2: " + response.Content, response.Content);
      }
      return (ReceitaResponse) apiClient.Deserialize(response.Content, typeof(ReceitaResponse));
    }
	
	 /// <summary>
    /// Consulta da receita da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>/// <param name="Ano">Ano de exercÃ­cio, lista disponÃ­vel em GET /transparencia/anosExercicioReceita</param>/// <param name="Mes">MÃªs desejado</param>/// <param name="Unidade">Unidades, lista disponÃ­vel em GET /transparencia/unidades</param>/// <param name="Natureza">Natureza das receitas, lista disponÃ­vel em GET /transparencia/naturezas</param>
    /// <returns>ReceitaResponse</returns>
    public async Task<ReceitaResponse> PtrFtReceita2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters, string Ano, string Mes, string Unidade, string Natureza) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrFtReceita2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrFtReceita2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrFtReceita2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrFtReceita2");
      

      var path = "/transparencia/receitas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
       if (Ano != null) queryParams.Add("ano", apiClient.ParameterToString(Ano)); // query parameter
       if (Mes != null) queryParams.Add("mes", apiClient.ParameterToString(Mes)); // query parameter
       if (Unidade != null) queryParams.Add("unidade", apiClient.ParameterToString(Unidade)); // query parameter
       if (Natureza != null) queryParams.Add("natureza", apiClient.ParameterToString(Natureza)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrFtReceita2: " + response.Content, response.Content);
      }
      return (ReceitaResponse) apiClient.Deserialize(response.Content, typeof(ReceitaResponse));
    }
    
    /// <summary>
    /// Consulta dos sub-itens das contas. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubItensContasResponse></returns>
    public List<SubItensContasResponse> PtrLkpSubitemConta (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubitemConta");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubitemConta");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubitemConta");
      

      var path = "/transparencia/subItensContas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubitemConta: " + response.Content, response.Content);
      }
      return (List<SubItensContasResponse>) apiClient.Deserialize(response.Content, typeof(List<SubItensContasResponse>));
    }
	
	 /// <summary>
    /// Consulta dos sub-itens das contas. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubItensContasResponse></returns>
    public async Task<List<SubItensContasResponse>> PtrLkpSubitemContaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubitemConta");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubitemConta");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubitemConta");
      

      var path = "/transparencia/subItensContas";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubitemConta: " + response.Content, response.Content);
      }
      return (List<SubItensContasResponse>) apiClient.Deserialize(response.Content, typeof(List<SubItensContasResponse>));
    }
    
    /// <summary>
    /// Consulta do sub-item das contas. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubItensContasResponse</returns>
    public SubItensContasResponse PtrLkpSubitemConta2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpSubitemConta2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubitemConta2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubitemConta2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubitemConta2");
      

      var path = "/transparencia/subItensContas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubitemConta2: " + response.Content, response.Content);
      }
      return (SubItensContasResponse) apiClient.Deserialize(response.Content, typeof(SubItensContasResponse));
    }
	
	 /// <summary>
    /// Consulta do sub-item das contas. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubItensContasResponse</returns>
    public async Task<SubItensContasResponse> PtrLkpSubitemConta2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpSubitemConta2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubitemConta2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubitemConta2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubitemConta2");
      

      var path = "/transparencia/subItensContas/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubitemConta2: " + response.Content, response.Content);
      }
      return (SubItensContasResponse) apiClient.Deserialize(response.Content, typeof(SubItensContasResponse));
    }
    
    /// <summary>
    /// Consulta das sub-funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubfuncoesResponse></returns>
    public List<SubfuncoesResponse> PtrLkpSubfuncao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubfuncao");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubfuncao");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubfuncao");
      

      var path = "/transparencia/subfuncoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubfuncao: " + response.Content, response.Content);
      }
      return (List<SubfuncoesResponse>) apiClient.Deserialize(response.Content, typeof(List<SubfuncoesResponse>));
    }
	
	 /// <summary>
    /// Consulta das sub-funÃ§Ãµes da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SubfuncoesResponse></returns>
    public async Task<List<SubfuncoesResponse>> PtrLkpSubfuncaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubfuncao");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubfuncao");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubfuncao");
      

      var path = "/transparencia/subfuncoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubfuncao: " + response.Content, response.Content);
      }
      return (List<SubfuncoesResponse>) apiClient.Deserialize(response.Content, typeof(List<SubfuncoesResponse>));
    }
    
    /// <summary>
    /// Consulta da sub-funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubfuncoesResponse</returns>
    public SubfuncoesResponse PtrLkpSubfuncao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpSubfuncao2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubfuncao2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubfuncao2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubfuncao2");
      

      var path = "/transparencia/subfuncoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubfuncao2: " + response.Content, response.Content);
      }
      return (SubfuncoesResponse) apiClient.Deserialize(response.Content, typeof(SubfuncoesResponse));
    }
	
	 /// <summary>
    /// Consulta da sub-funÃ§Ã£o da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SubfuncoesResponse</returns>
    public async Task<SubfuncoesResponse> PtrLkpSubfuncao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpSubfuncao2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpSubfuncao2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpSubfuncao2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpSubfuncao2");
      

      var path = "/transparencia/subfuncoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpSubfuncao2: " + response.Content, response.Content);
      }
      return (SubfuncoesResponse) apiClient.Deserialize(response.Content, typeof(SubfuncoesResponse));
    }
    
    /// <summary>
    /// Consulta dos tipos de licitaÃ§Ãµes. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<TipoLicitacoesResponse></returns>
    public List<TipoLicitacoesResponse> PtrLkpTipoLicitacao (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpTipoLicitacao");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpTipoLicitacao");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpTipoLicitacao");
      

      var path = "/transparencia/tipoLicitacoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpTipoLicitacao: " + response.Content, response.Content);
      }
      return (List<TipoLicitacoesResponse>) apiClient.Deserialize(response.Content, typeof(List<TipoLicitacoesResponse>));
    }
	
	 /// <summary>
    /// Consulta dos tipos de licitaÃ§Ãµes. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<TipoLicitacoesResponse></returns>
    public async Task<List<TipoLicitacoesResponse>> PtrLkpTipoLicitacaoAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpTipoLicitacao");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpTipoLicitacao");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpTipoLicitacao");
      

      var path = "/transparencia/tipoLicitacoes";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpTipoLicitacao: " + response.Content, response.Content);
      }
      return (List<TipoLicitacoesResponse>) apiClient.Deserialize(response.Content, typeof(List<TipoLicitacoesResponse>));
    }
    
    /// <summary>
    /// Consulta do tipo de licitaÃ§Ã£o. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>TipoLicitacoesResponse</returns>
    public TipoLicitacoesResponse PtrLkpTipoLicitacao2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpTipoLicitacao2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpTipoLicitacao2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpTipoLicitacao2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpTipoLicitacao2");
      

      var path = "/transparencia/tipoLicitacoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpTipoLicitacao2: " + response.Content, response.Content);
      }
      return (TipoLicitacoesResponse) apiClient.Deserialize(response.Content, typeof(TipoLicitacoesResponse));
    }
	
	 /// <summary>
    /// Consulta do tipo de licitaÃ§Ã£o. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>TipoLicitacoesResponse</returns>
    public async Task<TipoLicitacoesResponse> PtrLkpTipoLicitacao2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpTipoLicitacao2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpTipoLicitacao2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpTipoLicitacao2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpTipoLicitacao2");
      

      var path = "/transparencia/tipoLicitacoes/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpTipoLicitacao2: " + response.Content, response.Content);
      }
      return (TipoLicitacoesResponse) apiClient.Deserialize(response.Content, typeof(TipoLicitacoesResponse));
    }
    
    /// <summary>
    /// Consulta das unidades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadesResponse></returns>
    public List<UnidadesResponse> PtrLkpUnidadeOrcamentaria (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeOrcamentaria");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeOrcamentaria");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeOrcamentaria");
      

      var path = "/transparencia/unidades";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeOrcamentaria: " + response.Content, response.Content);
      }
      return (List<UnidadesResponse>) apiClient.Deserialize(response.Content, typeof(List<UnidadesResponse>));
    }
	
	 /// <summary>
    /// Consulta das unidades da preifeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadesResponse></returns>
    public async Task<List<UnidadesResponse>> PtrLkpUnidadeOrcamentariaAsync (string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeOrcamentaria");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeOrcamentaria");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeOrcamentaria");
      

      var path = "/transparencia/unidades";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeOrcamentaria: " + response.Content, response.Content);
      }
      return (List<UnidadesResponse>) apiClient.Deserialize(response.Content, typeof(List<UnidadesResponse>));
    }
    
    /// <summary>
    /// Consulta da unidade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadesResponse</returns>
    public UnidadesResponse PtrLkpUnidadeOrcamentaria2 (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpUnidadeOrcamentaria2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeOrcamentaria2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeOrcamentaria2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeOrcamentaria2");
      

      var path = "/transparencia/unidades/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeOrcamentaria2: " + response.Content, response.Content);
      }
      return (UnidadesResponse) apiClient.Deserialize(response.Content, typeof(UnidadesResponse));
    }
	
	 /// <summary>
    /// Consulta da unidade da preifeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadesResponse</returns>
    public async Task<UnidadesResponse> PtrLkpUnidadeOrcamentaria2Async (string Id, string ClientId, string Offset, string Limit, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpUnidadeOrcamentaria2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeOrcamentaria2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeOrcamentaria2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeOrcamentaria2");
      

      var path = "/transparencia/unidades/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeOrcamentaria2: " + response.Content, response.Content);
      }
      return (UnidadesResponse) apiClient.Deserialize(response.Content, typeof(UnidadesResponse));
    }
    
    /// <summary>
    /// Consulta de contas das unidades gestoras da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadeGestoraResponse></returns>
    public List<UnidadeGestoraResponse> PtrLkpUnidadeGestora (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeGestora");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeGestora");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeGestora");
      

      var path = "/transparencia/unidadesGestoras";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeGestora: " + response.Content, response.Content);
      }
      return (List<UnidadeGestoraResponse>) apiClient.Deserialize(response.Content, typeof(List<UnidadeGestoraResponse>));
    }
	
	 /// <summary>
    /// Consulta de contas das unidades gestoras da prefeitura. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<UnidadeGestoraResponse></returns>
    public async Task<List<UnidadeGestoraResponse>> PtrLkpUnidadeGestoraAsync (string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeGestora");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeGestora");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeGestora");
      

      var path = "/transparencia/unidadesGestoras";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeGestora: " + response.Content, response.Content);
      }
      return (List<UnidadeGestoraResponse>) apiClient.Deserialize(response.Content, typeof(List<UnidadeGestoraResponse>));
    }
    
    /// <summary>
    /// Consulta de conta da unidade gestora da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadeGestoraResponse</returns>
    public UnidadeGestoraResponse PtrLkpUnidadeGestora2 (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpUnidadeGestora2");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeGestora2");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeGestora2");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeGestora2");
      

      var path = "/transparencia/unidadesGestoras/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeGestora2: " + response.Content, response.Content);
      }
      return (UnidadeGestoraResponse) apiClient.Deserialize(response.Content, typeof(UnidadeGestoraResponse));
    }
	
	 /// <summary>
    /// Consulta de conta da unidade gestora da prefeitura. 
    /// </summary>
    /// <param name="Id">Identificador do registro.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Expand">ParÃ¢metro utilizado para obter maiores detalhes sobre algum dos atributos do recurso. Podendo ser passados mÃºltiplos campos separados por vÃ­rgula</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>UnidadeGestoraResponse</returns>
    public async Task<UnidadeGestoraResponse> PtrLkpUnidadeGestora2Async (string Id, string ClientId, string Offset, string Limit, string Expand, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling PtrLkpUnidadeGestora2");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling PtrLkpUnidadeGestora2");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling PtrLkpUnidadeGestora2");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling PtrLkpUnidadeGestora2");
      

      var path = "/transparencia/unidadesGestoras/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PtrLkpUnidadeGestora2: " + response.Content, response.Content);
      }
      return (UnidadeGestoraResponse) apiClient.Deserialize(response.Content, typeof(UnidadeGestoraResponse));
    }
    
  }  
  
}
