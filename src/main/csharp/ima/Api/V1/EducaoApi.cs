using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ima.Api.V1.Client;
using ima.Api.V1.Model;

namespace ima.Api.V1 {
  

  public interface IEducaoApi {
    
    /// <summary>
    /// Dados sobre educaÃ§Ã£o O recurso de educaÃ§Ã£o retorna dados sobre instituiÃ§Ãµes educacionais na \nÃ¡rea de Campinas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>
    /// <returns>List<EducacaoResponse></returns>
    List<EducacaoResponse> EducacaoGet (string AccessToken, string ClientId, string Offset, string Limit);

    /// <summary>
    /// Dados sobre educaÃ§Ã£o O recurso de educaÃ§Ã£o retorna dados sobre instituiÃ§Ãµes educacionais na \nÃ¡rea de Campinas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>
    /// <returns>List<EducacaoResponse></returns>
    Task<List<EducacaoResponse>> EducacaoGetAsync (string AccessToken, string ClientId, string Offset, string Limit);
    
    /// <summary>
    /// Retorna um dado sobre educaÃ§Ã£o especÃ­fico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do registro.</param>
    /// <returns>EducacaoResponse</returns>
    EducacaoResponse EducacaoIdGet (string AccessToken, string ClientId, long? Id);

    /// <summary>
    /// Retorna um dado sobre educaÃ§Ã£o especÃ­fico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do registro.</param>
    /// <returns>EducacaoResponse</returns>
    Task<EducacaoResponse> EducacaoIdGetAsync (string AccessToken, string ClientId, long? Id);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class EducaoApi : IEducaoApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="EducaoApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public EducaoApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EducaoApi"/> class.
    /// </summary>
    /// <returns></returns>
    public EducaoApi(String basePath)
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
    /// Dados sobre educaÃ§Ã£o O recurso de educaÃ§Ã£o retorna dados sobre instituiÃ§Ãµes educacionais na \nÃ¡rea de Campinas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>
    /// <returns>List<EducacaoResponse></returns>
    public List<EducacaoResponse> EducacaoGet (string AccessToken, string ClientId, string Offset, string Limit) {

      
      // verify the required parameter 'AccessToken' is set
      if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling EducacaoGet");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling EducacaoGet");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling EducacaoGet");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling EducacaoGet");
      

      var path = "/educacao";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
      
       if (AccessToken != null) headerParams.Add("access-token", apiClient.ParameterToString(AccessToken)); // header parameter
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling EducacaoGet: " + response.Content, response.Content);
      }
      return (List<EducacaoResponse>) apiClient.Deserialize(response.Content, typeof(List<EducacaoResponse>));
    }
	
	 /// <summary>
    /// Dados sobre educaÃ§Ã£o O recurso de educaÃ§Ã£o retorna dados sobre instituiÃ§Ãµes educacionais na \nÃ¡rea de Campinas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>
    /// <returns>List<EducacaoResponse></returns>
    public async Task<List<EducacaoResponse>> EducacaoGetAsync (string AccessToken, string ClientId, string Offset, string Limit) {

      
          // verify the required parameter 'AccessToken' is set
          if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling EducacaoGet");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling EducacaoGet");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling EducacaoGet");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling EducacaoGet");
      

      var path = "/educacao";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
      
       if (AccessToken != null) headerParams.Add("access-token", apiClient.ParameterToString(AccessToken)); // header parameter
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling EducacaoGet: " + response.Content, response.Content);
      }
      return (List<EducacaoResponse>) apiClient.Deserialize(response.Content, typeof(List<EducacaoResponse>));
    }
    
    /// <summary>
    /// Retorna um dado sobre educaÃ§Ã£o especÃ­fico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do registro.</param>
    /// <returns>EducacaoResponse</returns>
    public EducacaoResponse EducacaoIdGet (string AccessToken, string ClientId, long? Id) {

      
      // verify the required parameter 'AccessToken' is set
      if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling EducacaoIdGet");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling EducacaoIdGet");
      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling EducacaoIdGet");
      

      var path = "/educacao/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (AccessToken != null) headerParams.Add("access-token", apiClient.ParameterToString(AccessToken)); // header parameter
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling EducacaoIdGet: " + response.Content, response.Content);
      }
      return (EducacaoResponse) apiClient.Deserialize(response.Content, typeof(EducacaoResponse));
    }
	
	 /// <summary>
    /// Retorna um dado sobre educaÃ§Ã£o especÃ­fico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador do registro.</param>
    /// <returns>EducacaoResponse</returns>
    public async Task<EducacaoResponse> EducacaoIdGetAsync (string AccessToken, string ClientId, long? Id) {

      
          // verify the required parameter 'AccessToken' is set
          if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling EducacaoIdGet");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling EducacaoIdGet");
      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling EducacaoIdGet");
      

      var path = "/educacao/{id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "id" + "}", apiClient.ParameterToString(Id));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (AccessToken != null) headerParams.Add("access-token", apiClient.ParameterToString(AccessToken)); // header parameter
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling EducacaoIdGet: " + response.Content, response.Content);
      }
      return (EducacaoResponse) apiClient.Deserialize(response.Content, typeof(EducacaoResponse));
    }
    
  }  
  
}
