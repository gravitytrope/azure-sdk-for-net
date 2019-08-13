// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SqlVirtualMachine.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Set the access level and network port settings for SQL Server.
    /// </summary>
    public partial class SqlConnectivityUpdateSettings
    {
        /// <summary>
        /// Initializes a new instance of the SqlConnectivityUpdateSettings
        /// class.
        /// </summary>
        public SqlConnectivityUpdateSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlConnectivityUpdateSettings
        /// class.
        /// </summary>
        /// <param name="connectivityType">SQL Server connectivity option.
        /// Possible values include: 'LOCAL', 'PRIVATE', 'PUBLIC'</param>
        /// <param name="port">SQL Server port.</param>
        /// <param name="sqlAuthUpdateUserName">SQL Server sysadmin login to
        /// create.</param>
        /// <param name="sqlAuthUpdatePassword">SQL Server sysadmin login
        /// password.</param>
        public SqlConnectivityUpdateSettings(string connectivityType = default(string), int? port = default(int?), string sqlAuthUpdateUserName = default(string), string sqlAuthUpdatePassword = default(string))
        {
            ConnectivityType = connectivityType;
            Port = port;
            SqlAuthUpdateUserName = sqlAuthUpdateUserName;
            SqlAuthUpdatePassword = sqlAuthUpdatePassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL Server connectivity option. Possible values
        /// include: 'LOCAL', 'PRIVATE', 'PUBLIC'
        /// </summary>
        [JsonProperty(PropertyName = "connectivityType")]
        public string ConnectivityType { get; set; }

        /// <summary>
        /// Gets or sets SQL Server port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets SQL Server sysadmin login to create.
        /// </summary>
        [JsonProperty(PropertyName = "sqlAuthUpdateUserName")]
        public string SqlAuthUpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets SQL Server sysadmin login password.
        /// </summary>
        [JsonProperty(PropertyName = "sqlAuthUpdatePassword")]
        public string SqlAuthUpdatePassword { get; set; }

    }
}