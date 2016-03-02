using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ima.Api.V1.Client;
using ima.Api.V1.Model;

namespace ima.Api.V1 {
  

  public interface IAtendimentosApi {
    
    /// <summary>
    /// Dados sobre atendimentos O recurso 156 foi projetado para retornar todas as informaÃ§Ãµes sobre solicitaÃ§Ãµes e atendimentos realizados pela prefeitura de Campinas. Ã recomendado o uso de filtros passados na query param para retornar conjuntos de informaÃ§Ãµes especificas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra os resultados por Ã¡rea regional. (Exemplo &gt; &#39;LESTE&#39;)</param>/// <param name="AnoSolicitacao">Filtra os resultados por ano em que a solicitaÃ§Ã£o foi feita.</param>/// <param name="CodigoCEP">Filtra os resultados pelo CEP em que a solicitacao estÃ¡ cadastrada.</param>/// <param name="DescricaoStatus">Filtra os resultados por status, passado o tipo de status referente. (Exemplo &gt; &#39;EXECUTADO&#39;)</param>
    /// <returns>List<SolicitacaoResponse></returns>
    List<SolicitacaoResponse> 156Get (string AccessToken, string ClientId, string Offset, string Limit, string NomeRegiao, int? AnoSolicitacao, string CodigoCEP, string DescricaoStatus);

    /// <summary>
    /// Dados sobre atendimentos O recurso 156 foi projetado para retornar todas as informaÃ§Ãµes sobre solicitaÃ§Ãµes e atendimentos realizados pela prefeitura de Campinas. Ã recomendado o uso de filtros passados na query param para retornar conjuntos de informaÃ§Ãµes especificas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra os resultados por Ã¡rea regional. (Exemplo &gt; &#39;LESTE&#39;)</param>/// <param name="AnoSolicitacao">Filtra os resultados por ano em que a solicitaÃ§Ã£o foi feita.</param>/// <param name="CodigoCEP">Filtra os resultados pelo CEP em que a solicitacao estÃ¡ cadastrada.</param>/// <param name="DescricaoStatus">Filtra os resultados por status, passado o tipo de status referente. (Exemplo &gt; &#39;EXECUTADO&#39;)</param>
    /// <returns>List<SolicitacaoResponse></returns>
    Task<List<SolicitacaoResponse>> 156GetAsync (string AccessToken, string ClientId, string Offset, string Limit, string NomeRegiao, int? AnoSolicitacao, string CodigoCEP, string DescricaoStatus);
    
    /// <summary>
    /// Dado de um atendimento especifico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador da solicitaÃ§Ã£o</param>
    /// <returns>SolicitacaoResponse</returns>
    SolicitacaoResponse 156IdGet (string AccessToken, string ClientId, string Id);

    /// <summary>
    /// Dado de um atendimento especifico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador da solicitaÃ§Ã£o</param>
    /// <returns>SolicitacaoResponse</returns>
    Task<SolicitacaoResponse> 156IdGetAsync (string AccessToken, string ClientId, string Id);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class AtendimentosApi : IAtendimentosApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="AtendimentosApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public AtendimentosApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AtendimentosApi"/> class.
    /// </summary>
    /// <returns></returns>
    public AtendimentosApi(String basePath)
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
    /// Dados sobre atendimentos O recurso 156 foi projetado para retornar todas as informaÃ§Ãµes sobre solicitaÃ§Ãµes e atendimentos realizados pela prefeitura de Campinas. Ã recomendado o uso de filtros passados na query param para retornar conjuntos de informaÃ§Ãµes especificas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra os resultados por Ã¡rea regional. (Exemplo &gt; &#39;LESTE&#39;)</param>/// <param name="AnoSolicitacao">Filtra os resultados por ano em que a solicitaÃ§Ã£o foi feita.</param>/// <param name="CodigoCEP">Filtra os resultados pelo CEP em que a solicitacao estÃ¡ cadastrada.</param>/// <param name="DescricaoStatus">Filtra os resultados por status, passado o tipo de status referente. (Exemplo &gt; &#39;EXECUTADO&#39;)</param>
    /// <returns>List<SolicitacaoResponse></returns>
    public List<SolicitacaoResponse> 156Get (string AccessToken, string ClientId, string Offset, string Limit, string NomeRegiao, int? AnoSolicitacao, string CodigoCEP, string DescricaoStatus) {

      
      // verify the required parameter 'AccessToken' is set
      if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling 156Get");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling 156Get");
      
      // verify the required parameter 'Offset' is set
      if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling 156Get");
      
      // verify the required parameter 'Limit' is set
      if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling 156Get");
      

      var path = "/156";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (NomeRegiao != null) queryParams.Add("nomeRegiao", apiClient.ParameterToString(NomeRegiao)); // query parameter
       if (AnoSolicitacao != null) queryParams.Add("anoSolicitacao", apiClient.ParameterToString(AnoSolicitacao)); // query parameter
       if (CodigoCEP != null) queryParams.Add("codigoCEP", apiClient.ParameterToString(CodigoCEP)); // query parameter
       if (DescricaoStatus != null) queryParams.Add("descricaoStatus", apiClient.ParameterToString(DescricaoStatus)); // query parameter
      
       if (AccessToken != null) headerParams.Add("access-token", apiClient.ParameterToString(AccessToken)); // header parameter
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling 156Get: " + response.Content, response.Content);
      }
      return (List<SolicitacaoResponse>) apiClient.Deserialize(response.Content, typeof(List<SolicitacaoResponse>));
    }
	
	 /// <summary>
    /// Dados sobre atendimentos O recurso 156 foi projetado para retornar todas as informaÃ§Ãµes sobre solicitaÃ§Ãµes e atendimentos realizados pela prefeitura de Campinas. Ã recomendado o uso de filtros passados na query param para retornar conjuntos de informaÃ§Ãµes especificas.\n
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Offset">ParÃ¢metro utilizado para indicar a posiÃ§Ã£o do registro inicial que serÃ¡ trazido. A primeira posiÃ§Ã£o Ã© sempre zero (0).</param>/// <param name="Limit">ParÃ¢metro utilizado para indicar a quantidade de registros que deve ser trazido na consulta.</param>/// <param name="NomeRegiao">Filtra os resultados por Ã¡rea regional. (Exemplo &gt; &#39;LESTE&#39;)</param>/// <param name="AnoSolicitacao">Filtra os resultados por ano em que a solicitaÃ§Ã£o foi feita.</param>/// <param name="CodigoCEP">Filtra os resultados pelo CEP em que a solicitacao estÃ¡ cadastrada.</param>/// <param name="DescricaoStatus">Filtra os resultados por status, passado o tipo de status referente. (Exemplo &gt; &#39;EXECUTADO&#39;)</param>
    /// <returns>List<SolicitacaoResponse></returns>
    public async Task<List<SolicitacaoResponse>> 156GetAsync (string AccessToken, string ClientId, string Offset, string Limit, string NomeRegiao, int? AnoSolicitacao, string CodigoCEP, string DescricaoStatus) {

      
          // verify the required parameter 'AccessToken' is set
          if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling 156Get");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling 156Get");
      
          // verify the required parameter 'Offset' is set
          if (Offset == null) throw new ApiException(400, "Missing required parameter 'Offset' when calling 156Get");
      
          // verify the required parameter 'Limit' is set
          if (Limit == null) throw new ApiException(400, "Missing required parameter 'Limit' when calling 156Get");
      

      var path = "/156";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (NomeRegiao != null) queryParams.Add("nomeRegiao", apiClient.ParameterToString(NomeRegiao)); // query parameter
       if (AnoSolicitacao != null) queryParams.Add("anoSolicitacao", apiClient.ParameterToString(AnoSolicitacao)); // query parameter
       if (CodigoCEP != null) queryParams.Add("codigoCEP", apiClient.ParameterToString(CodigoCEP)); // query parameter
       if (DescricaoStatus != null) queryParams.Add("descricaoStatus", apiClient.ParameterToString(DescricaoStatus)); // query parameter
      
       if (AccessToken != null) headerParams.Add("access-token", apiClient.ParameterToString(AccessToken)); // header parameter
       if (ClientId != null) headerParams.Add("client_id", apiClient.ParameterToString(ClientId)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling 156Get: " + response.Content, response.Content);
      }
      return (List<SolicitacaoResponse>) apiClient.Deserialize(response.Content, typeof(List<SolicitacaoResponse>));
    }
    
    /// <summary>
    /// Dado de um atendimento especifico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador da solicitaÃ§Ã£o</param>
    /// <returns>SolicitacaoResponse</returns>
    public SolicitacaoResponse 156IdGet (string AccessToken, string ClientId, string Id) {

      
      // verify the required parameter 'AccessToken' is set
      if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling 156IdGet");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling 156IdGet");
      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling 156IdGet");
      

      var path = "/156/{id}";
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
        throw new ApiException ((int)response.StatusCode, "Error calling 156IdGet: " + response.Content, response.Content);
      }
      return (SolicitacaoResponse) apiClient.Deserialize(response.Content, typeof(SolicitacaoResponse));
    }
	
	 /// <summary>
    /// Dado de um atendimento especifico. 
    /// </summary>
    /// <param name="AccessToken">Access Token com as permissÃµes de acesso.</param>/// <param name="ClientId">Token disponibilizado na criaÃ§Ã£o da APP.</param>/// <param name="Id">Identificador da solicitaÃ§Ã£o</param>
    /// <returns>SolicitacaoResponse</returns>
    public async Task<SolicitacaoResponse> 156IdGetAsync (string AccessToken, string ClientId, string Id) {

      
          // verify the required parameter 'AccessToken' is set
          if (AccessToken == null) throw new ApiException(400, "Missing required parameter 'AccessToken' when calling 156IdGet");
      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling 156IdGet");
      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling 156IdGet");
      

      var path = "/156/{id}";
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
        throw new ApiException ((int)response.StatusCode, "Error calling 156IdGet: " + response.Content, response.Content);
      }
      return (SolicitacaoResponse) apiClient.Deserialize(response.Content, typeof(SolicitacaoResponse));
    }
    
  }  
  
}
