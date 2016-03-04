using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ima.Api.V1.Client;
using ima.Api.V1.Model;

namespace ima.Api.V1 {
  

  public interface IProtocoloApi {
    
    /// <summary>
    /// Dados sobre protocolo O recurso de protocolo existe para fornecer informaÃ§Ãµes sobre protocolos gerados pela prefeitura.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra resultados por Ã¡rea regional. (Exemplo &gt; &#39;NORTE&#39;)</param>/// <param name="CodigoBairro">Filtra resultados por cÃ³digo do bairro.</param>/// <param name="SiglaExpediente">Filtra resultados pelo cÃ³digo da secretaria expediente.</param>/// <param name="AnoProcesso">Filtra resultados pelo ano em que foram lanÃ§ados.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProtocoloResponse></returns>
    List<ProtocoloResponse> ProtocoloGet (string ClientId, string Offset, string Limit, string NomeRegiao, int? CodigoBairro, string SiglaExpediente, int? AnoProcesso, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Dados sobre protocolo O recurso de protocolo existe para fornecer informaÃ§Ãµes sobre protocolos gerados pela prefeitura.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra resultados por Ã¡rea regional. (Exemplo &gt; &#39;NORTE&#39;)</param>/// <param name="CodigoBairro">Filtra resultados por cÃ³digo do bairro.</param>/// <param name="SiglaExpediente">Filtra resultados pelo cÃ³digo da secretaria expediente.</param>/// <param name="AnoProcesso">Filtra resultados pelo ano em que foram lanÃ§ados.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProtocoloResponse></returns>
    Task<List<ProtocoloResponse>> ProtocoloGetAsync (string ClientId, string Offset, string Limit, string NomeRegiao, int? CodigoBairro, string SiglaExpediente, int? AnoProcesso, List<string> Fields, List<string> Filters);
    
    /// <summary>
    /// Dados sobre um protocolo especifico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProtocoloResponse</returns>
    ProtocoloResponse ProtocoloIdGet (string ClientId, long? Id, List<string> Fields, List<string> Filters);

    /// <summary>
    /// Dados sobre um protocolo especifico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProtocoloResponse</returns>
    Task<ProtocoloResponse> ProtocoloIdGetAsync (string ClientId, long? Id, List<string> Fields, List<string> Filters);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class ProtocoloApi : IProtocoloApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocoloApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public ProtocoloApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocoloApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ProtocoloApi(String basePath)
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
    /// Dados sobre protocolo O recurso de protocolo existe para fornecer informaÃ§Ãµes sobre protocolos gerados pela prefeitura.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra resultados por Ã¡rea regional. (Exemplo &gt; &#39;NORTE&#39;)</param>/// <param name="CodigoBairro">Filtra resultados por cÃ³digo do bairro.</param>/// <param name="SiglaExpediente">Filtra resultados pelo cÃ³digo da secretaria expediente.</param>/// <param name="AnoProcesso">Filtra resultados pelo ano em que foram lanÃ§ados.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProtocoloResponse></returns>
    public List<ProtocoloResponse> ProtocoloGet (string ClientId, string Offset, string Limit, string NomeRegiao, int? CodigoBairro, string SiglaExpediente, int? AnoProcesso, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ProtocoloGet");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling ProtocoloGet");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling ProtocoloGet");
      

      var path = "/protocolo";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (NomeRegiao != null) queryParams.Add("nomeRegiao", apiClient.ParameterToString(NomeRegiao)); // query parameter
       if (CodigoBairro != null) queryParams.Add("codigoBairro", apiClient.ParameterToString(CodigoBairro)); // query parameter
       if (SiglaExpediente != null) queryParams.Add("siglaExpediente", apiClient.ParameterToString(SiglaExpediente)); // query parameter
       if (AnoProcesso != null) queryParams.Add("anoProcesso", apiClient.ParameterToString(AnoProcesso)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ProtocoloGet: " + response.Content, response.Content);
      }
      return (List<ProtocoloResponse>) apiClient.Deserialize(response.Content, typeof(List<ProtocoloResponse>));
    }
	
	 /// <summary>
    /// Dados sobre protocolo O recurso de protocolo existe para fornecer informaÃ§Ãµes sobre protocolos gerados pela prefeitura.\n
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra resultados por Ã¡rea regional. (Exemplo &gt; &#39;NORTE&#39;)</param>/// <param name="CodigoBairro">Filtra resultados por cÃ³digo do bairro.</param>/// <param name="SiglaExpediente">Filtra resultados pelo cÃ³digo da secretaria expediente.</param>/// <param name="AnoProcesso">Filtra resultados pelo ano em que foram lanÃ§ados.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>List<ProtocoloResponse></returns>
    public async Task<List<ProtocoloResponse>> ProtocoloGetAsync (string ClientId, string Offset, string Limit, string NomeRegiao, int? CodigoBairro, string SiglaExpediente, int? AnoProcesso, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ProtocoloGet");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling ProtocoloGet");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling ProtocoloGet");
      

      var path = "/protocolo";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (NomeRegiao != null) queryParams.Add("nomeRegiao", apiClient.ParameterToString(NomeRegiao)); // query parameter
       if (CodigoBairro != null) queryParams.Add("codigoBairro", apiClient.ParameterToString(CodigoBairro)); // query parameter
       if (SiglaExpediente != null) queryParams.Add("siglaExpediente", apiClient.ParameterToString(SiglaExpediente)); // query parameter
       if (AnoProcesso != null) queryParams.Add("anoProcesso", apiClient.ParameterToString(AnoProcesso)); // query parameter
       if (Fields != null) queryParams.Add("fields", apiClient.ParameterToString(Fields)); // query parameter
       if (Filters != null) queryParams.Add("filters", apiClient.ParameterToString(Filters)); // query parameter
      
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ProtocoloGet: " + response.Content, response.Content);
      }
      return (List<ProtocoloResponse>) apiClient.Deserialize(response.Content, typeof(List<ProtocoloResponse>));
    }
    
    /// <summary>
    /// Dados sobre um protocolo especifico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProtocoloResponse</returns>
    public ProtocoloResponse ProtocoloIdGet (string ClientId, long? Id, List<string> Fields, List<string> Filters) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ProtocoloIdGet");
      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ProtocoloIdGet");
      

      var path = "/protocolo/{id}";
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
        throw new ApiException ((int)response.StatusCode, "Error calling ProtocoloIdGet: " + response.Content, response.Content);
      }
      return (ProtocoloResponse) apiClient.Deserialize(response.Content, typeof(ProtocoloResponse));
    }
	
	 /// <summary>
    /// Dados sobre um protocolo especifico. 
    /// </summary>
    /// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do protocolo.</param>/// <param name="Fields">ParÃ¢metro utilizado para pesquisar campos especÃ­ficos</param>/// <param name="Filters">ParÃ¢metro utilizado para pesquisar valores de campos especÃ­ficos, por exemplo, para pesquisar um id de valor 123, passar o valor id:123</param>
    /// <returns>ProtocoloResponse</returns>
    public async Task<ProtocoloResponse> ProtocoloIdGetAsync (string ClientId, long? Id, List<string> Fields, List<string> Filters) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ProtocoloIdGet");
      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ProtocoloIdGet");
      

      var path = "/protocolo/{id}";
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
        throw new ApiException ((int)response.StatusCode, "Error calling ProtocoloIdGet: " + response.Content, response.Content);
      }
      return (ProtocoloResponse) apiClient.Deserialize(response.Content, typeof(ProtocoloResponse));
    }
    
  }  
  
}
