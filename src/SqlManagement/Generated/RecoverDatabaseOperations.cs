// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// Contains the operation to create recovery requests for Azure SQL
    /// Databases.
    /// </summary>
    internal partial class RecoverDatabaseOperations : IServiceOperations<SqlManagementClient>, Microsoft.WindowsAzure.Management.Sql.IRecoverDatabaseOperations
    {
        /// <summary>
        /// Initializes a new instance of the RecoverDatabaseOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal RecoverDatabaseOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Issues a recovery request for an Azure SQL Database.
        /// </summary>
        /// <param name='targetServerName'>
        /// Required. The name of the Azure SQL Database Server on which to
        /// recover the source database.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for the Create Recover Database
        /// Operation request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Contains the response to the Create Recover Database Operation
        /// request.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Sql.Models.RecoverDatabaseOperationCreateResponse> CreateAsync(string targetServerName, RecoverDatabaseOperationCreateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (targetServerName == null)
            {
                throw new ArgumentNullException("targetServerName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.SourceDatabaseName == null)
            {
                throw new ArgumentNullException("parameters.SourceDatabaseName");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("targetServerName", targetServerName);
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "CreateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/sqlservers/servers/" + targetServerName.Trim() + "/recoverdatabaseoperations";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement serviceResourceElement = new XElement(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(serviceResourceElement);
                
                XElement sourceDatabaseNameElement = new XElement(XName.Get("SourceDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                sourceDatabaseNameElement.Value = parameters.SourceDatabaseName;
                serviceResourceElement.Add(sourceDatabaseNameElement);
                
                if (parameters.SourceServerName != null)
                {
                    XElement sourceServerNameElement = new XElement(XName.Get("SourceServerName", "http://schemas.microsoft.com/windowsazure"));
                    sourceServerNameElement.Value = parameters.SourceServerName;
                    serviceResourceElement.Add(sourceServerNameElement);
                }
                
                if (parameters.TargetDatabaseName != null)
                {
                    XElement targetDatabaseNameElement = new XElement(XName.Get("TargetDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                    targetDatabaseNameElement.Value = parameters.TargetDatabaseName;
                    serviceResourceElement.Add(targetDatabaseNameElement);
                }
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Created)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RecoverDatabaseOperationCreateResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new RecoverDatabaseOperationCreateResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement serviceResourceElement2 = responseDoc.Element(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                    if (serviceResourceElement2 != null)
                    {
                        RecoverDatabaseOperation serviceResourceInstance = new RecoverDatabaseOperation();
                        result.Operation = serviceResourceInstance;
                        
                        XElement requestIDElement = serviceResourceElement2.Element(XName.Get("RequestID", "http://schemas.microsoft.com/windowsazure"));
                        if (requestIDElement != null)
                        {
                            string requestIDInstance = requestIDElement.Value;
                            serviceResourceInstance.Id = requestIDInstance;
                        }
                        
                        XElement sourceServerNameElement2 = serviceResourceElement2.Element(XName.Get("SourceServerName", "http://schemas.microsoft.com/windowsazure"));
                        if (sourceServerNameElement2 != null)
                        {
                            string sourceServerNameInstance = sourceServerNameElement2.Value;
                            serviceResourceInstance.SourceServerName = sourceServerNameInstance;
                        }
                        
                        XElement sourceDatabaseNameElement2 = serviceResourceElement2.Element(XName.Get("SourceDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                        if (sourceDatabaseNameElement2 != null)
                        {
                            string sourceDatabaseNameInstance = sourceDatabaseNameElement2.Value;
                            serviceResourceInstance.SourceDatabaseName = sourceDatabaseNameInstance;
                        }
                        
                        XElement targetDatabaseNameElement2 = serviceResourceElement2.Element(XName.Get("TargetDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                        if (targetDatabaseNameElement2 != null)
                        {
                            string targetDatabaseNameInstance = targetDatabaseNameElement2.Value;
                            serviceResourceInstance.TargetDatabaseName = targetDatabaseNameInstance;
                        }
                        
                        XElement nameElement = serviceResourceElement2.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                        if (nameElement != null)
                        {
                            string nameInstance = nameElement.Value;
                            serviceResourceInstance.Name = nameInstance;
                        }
                        
                        XElement typeElement = serviceResourceElement2.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                        if (typeElement != null)
                        {
                            string typeInstance = typeElement.Value;
                            serviceResourceInstance.Type = typeInstance;
                        }
                        
                        XElement stateElement = serviceResourceElement2.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                        if (stateElement != null)
                        {
                            string stateInstance = stateElement.Value;
                            serviceResourceInstance.State = stateInstance;
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
