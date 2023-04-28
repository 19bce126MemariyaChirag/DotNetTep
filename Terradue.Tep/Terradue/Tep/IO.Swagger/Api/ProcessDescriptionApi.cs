/* 
 * The OGC API - Processes
 *
 * WARNING - THIS IS WORK IN PROGRESS
 *
 * OpenAPI spec version: 1.0-draft.5
 * Contact: b.pross@52north.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IProcessDescriptionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// retrieve a process description
        /// </summary>
        /// <remarks>
        /// Describes a process.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>Process</returns>
        Process GetProcessDescription (string processId);

        /// <summary>
        /// retrieve a process description
        /// </summary>
        /// <remarks>
        /// Describes a process.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>ApiResponse of Process</returns>
        ApiResponse<Process> GetProcessDescriptionWithHttpInfo (string processId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// retrieve a process description
        /// </summary>
        /// <remarks>
        /// Describes a process.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>Task of Process</returns>
        System.Threading.Tasks.Task<Process> GetProcessDescriptionAsync (string processId);

        /// <summary>
        /// retrieve a process description
        /// </summary>
        /// <remarks>
        /// Describes a process.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>Task of ApiResponse (Process)</returns>
        System.Threading.Tasks.Task<ApiResponse<Process>> GetProcessDescriptionAsyncWithHttpInfo (string processId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProcessDescriptionApi : IProcessDescriptionApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDescriptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProcessDescriptionApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDescriptionApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProcessDescriptionApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDescriptionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProcessDescriptionApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// retrieve a process description Describes a process.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>Process</returns>
        public Process GetProcessDescription (string processId)
        {
             ApiResponse<Process> localVarResponse = GetProcessDescriptionWithHttpInfo(processId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// retrieve a process description Describes a process.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>ApiResponse of Process</returns>
        public ApiResponse< Process > GetProcessDescriptionWithHttpInfo (string processId)
        {
            // verify the required parameter 'processId' is set
            if (processId == null)
                throw new Client.ApiException(400, "Missing required parameter 'processId' when calling ProcessDescriptionApi->GetProcessDescription");

            var localVarPath = "./processes/" + processId;
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            //if (processId != null) localVarPathParams.Add("processId", this.Configuration.ApiClient.ParameterToString(processId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                ApiException exception = ExceptionFactory("GetProcessDescription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Process>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Process) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Process)));
        }

        /// <summary>
        /// retrieve a process description Describes a process.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>Task of Process</returns>
        public async System.Threading.Tasks.Task<Process> GetProcessDescriptionAsync (string processId)
        {
             ApiResponse<Process> localVarResponse = await GetProcessDescriptionAsyncWithHttpInfo(processId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// retrieve a process description Describes a process.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">local identifier of a process</param>
        /// <returns>Task of ApiResponse (Process)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Process>> GetProcessDescriptionAsyncWithHttpInfo (string processId)
        {
            // verify the required parameter 'processId' is set
            if (processId == null)
                throw new Client.ApiException(400, "Missing required parameter 'processId' when calling ProcessDescriptionApi->GetProcessDescription");

            var localVarPath = "./processes/{processId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/html"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (processId != null) localVarPathParams.Add("processId", this.Configuration.ApiClient.ParameterToString(processId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                ApiException exception = ExceptionFactory("GetProcessDescription", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Process>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Process) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Process)));
        }

    }
}
