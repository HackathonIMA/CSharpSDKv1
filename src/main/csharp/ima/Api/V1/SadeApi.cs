using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ima.Api.V1.Client;
using ima.Api.V1.Model;

namespace ima.Api.V1 {
  

  public interface ISadeApi {
    
    /// <summary>
    /// Dados sobre sÃ¡ude O recurso sÃ¡ude tem a funÃ§Ã£o de mostrar os dados sobre atendimentos hospitalares realizados em hospitais da Ã¡rea de Campinas.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Uf">Filtra resultados por UF.</param>/// <param name="Municipio">Filtra resultados por cidade.</param>/// <param name="CodigoProcedimentoSUS">Filtra resultados por cÃ³digo de procedimento.</param>/// <param name="CodigoAtividadeProfissional">Filtra resultados pelo cÃ³digo do profissional.</param>/// <param name="DistritoAtendimento">Filtra resultados por distrito de atendimento.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SaudeResponse></returns>
    List<SaudeResponse> SaudeGet (string ClientId, string Offset, string Limit, string Uf, string Municipio, long? CodigoProcedimentoSUS, int? CodigoAtividadeProfissional, string DistritoAtendimento, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Dados sobre sÃ¡ude O recurso sÃ¡ude tem a funÃ§Ã£o de mostrar os dados sobre atendimentos hospitalares realizados em hospitais da Ã¡rea de Campinas.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Uf">Filtra resultados por UF.</param>/// <param name="Municipio">Filtra resultados por cidade.</param>/// <param name="CodigoProcedimentoSUS">Filtra resultados por cÃ³digo de procedimento.</param>/// <param name="CodigoAtividadeProfissional">Filtra resultados pelo cÃ³digo do profissional.</param>/// <param name="DistritoAtendimento">Filtra resultados por distrito de atendimento.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SaudeResponse></returns>
    Task<List<SaudeResponse>> SaudeGetAsync (string ClientId, string Offset, string Limit, string Uf, string Municipio, long? CodigoProcedimentoSUS, int? CodigoAtividadeProfissional, string DistritoAtendimento, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Retorna um dado hospitalar especÃ­fico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SaudeResponse</returns>
    SaudeResponse SaudeIdGet (string ClientId, long? Id, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Retorna um dado hospitalar especÃ­fico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SaudeResponse</returns>
    Task<SaudeResponse> SaudeIdGetAsync (string ClientId, long? Id, List<string> Fields, List<string> Filters);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class SadeApi : ISadeApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="SadeApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public SadeApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SadeApi"/> class.
    /// </summary>
    /// <returns></returns>
    public SadeApi(String basePath)
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
    /// Dados sobre sÃ¡ude O recurso sÃ¡ude tem a funÃ§Ã£o de mostrar os dados sobre atendimentos hospitalares realizados em hospitais da Ã¡rea de Campinas.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Uf">Filtra resultados por UF.</param>/// <param name="Municipio">Filtra resultados por cidade.</param>/// <param name="CodigoProcedimentoSUS">Filtra resultados por cÃ³digo de procedimento.</param>/// <param name="CodigoAtividadeProfissional">Filtra resultados pelo cÃ³digo do profissional.</param>/// <param name="DistritoAtendimento">Filtra resultados por distrito de atendimento.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SaudeResponse></returns>
    public List<SaudeResponse> SaudeGet (string ClientId, string Offset, string Limit, string Uf, string Municipio, long? CodigoProcedimentoSUS, int? CodigoAtividadeProfissional, string DistritoAtendimento, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling SaudeGet");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling SaudeGet");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling SaudeGet");
      

      var path = "/saude";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Uf != null) queryParams.Add("uf", apiClient.ParameterToString(Uf)); // query parameter
       if (Municipio != null) queryParams.Add("municipio", apiClient.ParameterToString(Municipio)); // query parameter
       if (CodigoProcedimentoSUS != null) queryParams.Add("codigoProcedimentoSUS", apiClient.ParameterToString(CodigoProcedimentoSUS)); // query parameter
       if (CodigoAtividadeProfissional != null) queryParams.Add("codigoAtividadeProfissional", apiClient.ParameterToString(CodigoAtividadeProfissional)); // query parameter
       if (DistritoAtendimento != null) queryParams.Add("distritoAtendimento", apiClient.ParameterToString(DistritoAtendimento)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaudeGet: " + response.Content, response.Content);
      }
      return (List<SaudeResponse>) apiClient.Deserialize(response.Content, typeof(List<SaudeResponse>));
    }
	
	 /// <summary>
    /// Dados sobre sÃ¡ude O recurso sÃ¡ude tem a funÃ§Ã£o de mostrar os dados sobre atendimentos hospitalares realizados em hospitais da Ã¡rea de Campinas.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="Uf">Filtra resultados por UF.</param>/// <param name="Municipio">Filtra resultados por cidade.</param>/// <param name="CodigoProcedimentoSUS">Filtra resultados por cÃ³digo de procedimento.</param>/// <param name="CodigoAtividadeProfissional">Filtra resultados pelo cÃ³digo do profissional.</param>/// <param name="DistritoAtendimento">Filtra resultados por distrito de atendimento.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<SaudeResponse></returns>
    public async Task<List<SaudeResponse>> SaudeGetAsync (string ClientId, string Offset, string Limit, string Uf, string Municipio, long? CodigoProcedimentoSUS, int? CodigoAtividadeProfissional, string DistritoAtendimento, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling SaudeGet");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling SaudeGet");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling SaudeGet");
      

      var path = "/saude";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Uf != null) queryParams.Add("uf", apiClient.ParameterToString(Uf)); // query parameter
       if (Municipio != null) queryParams.Add("municipio", apiClient.ParameterToString(Municipio)); // query parameter
       if (CodigoProcedimentoSUS != null) queryParams.Add("codigoProcedimentoSUS", apiClient.ParameterToString(CodigoProcedimentoSUS)); // query parameter
       if (CodigoAtividadeProfissional != null) queryParams.Add("codigoAtividadeProfissional", apiClient.ParameterToString(CodigoAtividadeProfissional)); // query parameter
       if (DistritoAtendimento != null) queryParams.Add("distritoAtendimento", apiClient.ParameterToString(DistritoAtendimento)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaudeGet: " + response.Content, response.Content);
      }
      return (List<SaudeResponse>) apiClient.Deserialize(response.Content, typeof(List<SaudeResponse>));
    }
    
    /// <summary>
    /// Retorna um dado hospitalar especÃ­fico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SaudeResponse</returns>
    public SaudeResponse SaudeIdGet (string ClientId, long? Id, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling SaudeIdGet");
      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling SaudeIdGet");
      

      var path = "/saude/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaudeIdGet: " + response.Content, response.Content);
      }
      return (SaudeResponse) apiClient.Deserialize(response.Content, typeof(SaudeResponse));
    }
	
	 /// <summary>
    /// Retorna um dado hospitalar especÃ­fico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>SaudeResponse</returns>
    public async Task<SaudeResponse> SaudeIdGetAsync (string ClientId, long? Id, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling SaudeIdGet");
      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling SaudeIdGet");
      

      var path = "/saude/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaudeIdGet: " + response.Content, response.Content);
      }
      return (SaudeResponse) apiClient.Deserialize(response.Content, typeof(SaudeResponse));
    }
    
  }  
  
}
