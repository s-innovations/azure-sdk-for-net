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
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// Represents the properties of a website.
    /// </summary>
    public partial class WebSiteProperties
    {
        private bool _adminEnabled;
        
        /// <summary>
        /// Optional. Read-only. This value is always true.
        /// </summary>
        public bool AdminEnabled
        {
            get { return this._adminEnabled; }
            set { this._adminEnabled = value; }
        }
        
        private WebSpaceAvailabilityState _availabilityState;
        
        /// <summary>
        /// Optional. The state of the availability of management information
        /// for the site. Possible values are Normal or Limited. Normal means
        /// that the site is running correctly and that management information
        /// for the site is available. Limited means that only partial
        /// management information for the site is available and that detailed
        /// site information is unavailable.
        /// </summary>
        public WebSpaceAvailabilityState AvailabilityState
        {
            get { return this._availabilityState; }
            set { this._availabilityState = value; }
        }
        
        private WebSiteComputeMode _computeMode;
        
        /// <summary>
        /// Optional. The Compute Mode for the web site. Possible values are
        /// Shared or Dedicated.
        /// </summary>
        public WebSiteComputeMode ComputeMode
        {
            get { return this._computeMode; }
            set { this._computeMode = value; }
        }
        
        private bool _enabled;
        
        /// <summary>
        /// Optional. true if the site is enabled; otherwise, false. Setting
        /// this value to false disables the site (takes the site off line).
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private IList<string> _enabledHostNames;
        
        /// <summary>
        /// Optional. An array of strings that contains enabled hostnames for
        /// the site. By default, these are [SiteName].azurewebsites.net and
        /// [SiteName].scm.azurewebsites.net.
        /// </summary>
        public IList<string> EnabledHostNames
        {
            get { return this._enabledHostNames; }
            set { this._enabledHostNames = value; }
        }
        
        private IList<string> _hostNames;
        
        /// <summary>
        /// Optional. An array of strings that contains the public hostnames
        /// for the site, including custom domains. Important: When you add a
        /// custom domain in a PUT operation, be sure to include every
        /// hostname that you want for the web site. To delete a custom domain
        /// name in a PUT operation, include all of the hostnames for the site
        /// that you want to keep, but leave out the one that you wangt to
        /// delete.
        /// </summary>
        public IList<string> HostNames
        {
            get { return this._hostNames; }
            set { this._hostNames = value; }
        }
        
        private IList<WebSiteProperties.WebSiteHostNameSslState> _hostNameSslStates;
        
        /// <summary>
        /// Optional. SSL states bound to the website.
        /// </summary>
        public IList<WebSiteProperties.WebSiteHostNameSslState> HostNameSslStates
        {
            get { return this._hostNameSslStates; }
            set { this._hostNameSslStates = value; }
        }
        
        private DateTime _lastModifiedTimeUtc;
        
        /// <summary>
        /// Optional. A dateTime value that contains, in Coordinated Universal
        /// Time, the last time the web site was modified.
        /// </summary>
        public DateTime LastModifiedTimeUtc
        {
            get { return this._lastModifiedTimeUtc; }
            set { this._lastModifiedTimeUtc = value; }
        }
        
        private string _owner;
        
        /// <summary>
        /// Optional. Owner of the web site.
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }
        
        private WebSiteProperties.SiteProperties _properties;
        
        /// <summary>
        /// Optional. Contains AppSettings, Metadata, and Properties for a site.
        /// </summary>
        public WebSiteProperties.SiteProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets resource provisioning state.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _repositorySiteName;
        
        /// <summary>
        /// Optional. The name of the repository web site.
        /// </summary>
        public string RepositorySiteName
        {
            get { return this._repositorySiteName; }
            set { this._repositorySiteName = value; }
        }
        
        private WebSiteRuntimeAvailabilityState _runtimeAvailabilityState;
        
        /// <summary>
        /// Optional. Possible values are Normal, Degraded, or NotAvailable.
        /// Normal: the web site is running correctly. Degraded: the web site
        /// is running temporarily in a degraded mode (typically with less
        /// memory and a shared instance.) Not Available: due to an unexpected
        /// issue, the site has been excluded from provisioning. This
        /// typically occurs only for free sites.
        /// </summary>
        public WebSiteRuntimeAvailabilityState RuntimeAvailabilityState
        {
            get { return this._runtimeAvailabilityState; }
            set { this._runtimeAvailabilityState = value; }
        }
        
        private string _serverFarm;
        
        /// <summary>
        /// Optional. String. If a server farm exists, this value is
        /// DefaultServerFarm.
        /// </summary>
        public string ServerFarm
        {
            get { return this._serverFarm; }
            set { this._serverFarm = value; }
        }
        
        private WebSiteMode _siteMode;
        
        /// <summary>
        /// Optional. String that represents the web site mode. If the web site
        /// mode is Free, this value is Limited. If the web site mode is
        /// Shared, this value is Basic.  Note: The SiteMode value is not used
        /// for Reserved mode. Reserved mode uses the ComputeMode setting.
        /// </summary>
        public WebSiteMode SiteMode
        {
            get { return this._siteMode; }
            set { this._siteMode = value; }
        }
        
        private IList<WebSiteProperties.WebSiteSslCertificate> _sslCertificates;
        
        /// <summary>
        /// Optional. SSL certificates bound to the web site.
        /// </summary>
        public IList<WebSiteProperties.WebSiteSslCertificate> SslCertificates
        {
            get { return this._sslCertificates; }
            set { this._sslCertificates = value; }
        }
        
        private WebSiteState _state;
        
        /// <summary>
        /// Optional. A string that describes the state of the web site.
        /// Possible values are Stopped or Running.
        /// </summary>
        public WebSiteState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private IList<string> _trafficManagerHostNames;
        
        /// <summary>
        /// Optional. An array of strings that contain the traffic manager
        /// hostnames.
        /// </summary>
        public IList<string> TrafficManagerHostNames
        {
            get { return this._trafficManagerHostNames; }
            set { this._trafficManagerHostNames = value; }
        }
        
        private Uri _uri;
        
        /// <summary>
        /// Optional. Direct URL to the web site endpoint on Windows Azure Web
        /// Sites, including the subscription ID, webspace name, and site name.
        /// </summary>
        public Uri Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }
        
        private WebSiteUsageState _usageState;
        
        /// <summary>
        /// Optional. Possible values are Normal or Exceeded. If any quota is
        /// exceeded, the UsageState value changes to Exceeded and the site
        /// goes off line.
        /// </summary>
        public WebSiteUsageState UsageState
        {
            get { return this._usageState; }
            set { this._usageState = value; }
        }
        
        private string _webSpace;
        
        /// <summary>
        /// Optional. The name of the webspace in which the web site is
        /// located. This property is read-only.
        /// </summary>
        public string WebSpace
        {
            get { return this._webSpace; }
            set { this._webSpace = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteProperties class.
        /// </summary>
        public WebSiteProperties()
        {
            this.EnabledHostNames = new List<string>();
            this.HostNames = new List<string>();
            this.HostNameSslStates = new List<WebSiteProperties.WebSiteHostNameSslState>();
            this.SslCertificates = new List<WebSiteProperties.WebSiteSslCertificate>();
            this.TrafficManagerHostNames = new List<string>();
        }
        
        public partial class SiteProperties
        {
            private IDictionary<string, string> _appSettings;
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain application
            /// settings for a site.
            /// </summary>
            public IDictionary<string, string> AppSettings
            {
                get { return this._appSettings; }
                set { this._appSettings = value; }
            }
            
            private IDictionary<string, string> _metadata;
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain metadata
            /// information for a site.
            /// </summary>
            public IDictionary<string, string> Metadata
            {
                get { return this._metadata; }
                set { this._metadata = value; }
            }
            
            private IDictionary<string, string> _properties;
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain properties for
            /// a site.
            /// </summary>
            public IDictionary<string, string> Properties
            {
                get { return this._properties; }
                set { this._properties = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the SiteProperties class.
            /// </summary>
            public SiteProperties()
            {
                this.AppSettings = new Dictionary<string, string>();
                this.Metadata = new Dictionary<string, string>();
                this.Properties = new Dictionary<string, string>();
            }
        }
        
        /// <summary>
        /// SSL states bound to a website.
        /// </summary>
        public partial class WebSiteHostNameSslState
        {
            private string _ipBasedSslResult;
            
            /// <summary>
            /// Optional. The IP based SSL result
            /// </summary>
            public string IpBasedSslResult
            {
                get { return this._ipBasedSslResult; }
                set { this._ipBasedSslResult = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The URL of the web site.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private WebSiteSslState _sslState;
            
            /// <summary>
            /// Optional. The SSL state. Possible values are Disabled,
            /// SniEnabled, or IpBasedEnabled.
            /// </summary>
            public WebSiteSslState SslState
            {
                get { return this._sslState; }
                set { this._sslState = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. A string that contains the thumbprint of the SSL
            /// certificate.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            private bool? _toUpdate;
            
            /// <summary>
            /// Optional. Boolean value indicating if it should be updated
            /// </summary>
            public bool? ToUpdate
            {
                get { return this._toUpdate; }
                set { this._toUpdate = value; }
            }
            
            private bool? _toUpdateIpBasedSsl;
            
            /// <summary>
            /// Optional. Boolean value indicating if it should be updated
            /// based on ssl
            /// </summary>
            public bool? ToUpdateIpBasedSsl
            {
                get { return this._toUpdateIpBasedSsl; }
                set { this._toUpdateIpBasedSsl = value; }
            }
            
            private string _virtualIP;
            
            /// <summary>
            /// Optional. String. The IP address assigned to the hostname if
            /// the hostname uses IP SSL.
            /// </summary>
            public string VirtualIP
            {
                get { return this._virtualIP; }
                set { this._virtualIP = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteHostNameSslState class.
            /// </summary>
            public WebSiteHostNameSslState()
            {
            }
        }
        
        /// <summary>
        /// Contains SSL certificate properties.
        /// </summary>
        public partial class WebSiteSslCertificate
        {
            private byte[] _cerBlob;
            
            /// <summary>
            /// Optional. The certificate blob.
            /// </summary>
            public byte[] CerBlob
            {
                get { return this._cerBlob; }
                set { this._cerBlob = value; }
            }
            
            private DateTime _expirationDate;
            
            /// <summary>
            /// Optional. A dateTime value that contains the expiration date of
            /// the certificate.
            /// </summary>
            public DateTime ExpirationDate
            {
                get { return this._expirationDate; }
                set { this._expirationDate = value; }
            }
            
            private string _friendlyName;
            
            /// <summary>
            /// Optional. A string that contains the friendly name of the
            /// certificate.
            /// </summary>
            public string FriendlyName
            {
                get { return this._friendlyName; }
                set { this._friendlyName = value; }
            }
            
            private IList<string> _hostNames;
            
            /// <summary>
            /// Optional. An array of strings that contain the hostnames to
            /// which the certificate is bound.
            /// </summary>
            public IList<string> HostNames
            {
                get { return this._hostNames; }
                set { this._hostNames = value; }
            }
            
            private DateTime _issueDate;
            
            /// <summary>
            /// Optional. A dateTime value that contains the date that the
            /// certificate was issued.
            /// </summary>
            public DateTime IssueDate
            {
                get { return this._issueDate; }
                set { this._issueDate = value; }
            }
            
            private string _issuer;
            
            /// <summary>
            /// Optional. A string that identifies the issuer of the
            /// certificate.
            /// </summary>
            public string Issuer
            {
                get { return this._issuer; }
                set { this._issuer = value; }
            }
            
            private bool _isValid;
            
            /// <summary>
            /// Optional. Boolean. true if the certificate is valid; otherwise,
            /// false.
            /// </summary>
            public bool IsValid
            {
                get { return this._isValid; }
                set { this._isValid = value; }
            }
            
            private string _password;
            
            /// <summary>
            /// Optional. A string that contains the password for the
            /// certificate.
            /// </summary>
            public string Password
            {
                get { return this._password; }
                set { this._password = value; }
            }
            
            private byte[] _pfxBlob;
            
            /// <summary>
            /// Optional. A base64Binary value that contains the PfxBlob of the
            /// certificate.
            /// </summary>
            public byte[] PfxBlob
            {
                get { return this._pfxBlob; }
                set { this._pfxBlob = value; }
            }
            
            private string _publicKeyHash;
            
            /// <summary>
            /// Optional. The public key hash.
            /// </summary>
            public string PublicKeyHash
            {
                get { return this._publicKeyHash; }
                set { this._publicKeyHash = value; }
            }
            
            private Uri _selfLinkUri;
            
            /// <summary>
            /// Optional. An anyURI value that contains the endpoint of the
            /// site to which the certificate is bound.
            /// </summary>
            public Uri SelfLinkUri
            {
                get { return this._selfLinkUri; }
                set { this._selfLinkUri = value; }
            }
            
            private string _siteName;
            
            /// <summary>
            /// Optional. A string that contains the name of the site to which
            /// the certificate is bound.
            /// </summary>
            public string SiteName
            {
                get { return this._siteName; }
                set { this._siteName = value; }
            }
            
            private string _subjectName;
            
            /// <summary>
            /// Optional. A string that contains the name of the entity to whom
            /// the certificate was issued.
            /// </summary>
            public string SubjectName
            {
                get { return this._subjectName; }
                set { this._subjectName = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. A string that contains the certificate thumbprint.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            private bool _toDelete;
            
            /// <summary>
            /// Optional. Boolean. true if the certificate is to be deleted.
            /// </summary>
            public bool ToDelete
            {
                get { return this._toDelete; }
                set { this._toDelete = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteSslCertificate class.
            /// </summary>
            public WebSiteSslCertificate()
            {
                this.HostNames = new List<string>();
            }
        }
    }
}
