/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.DataSync;
using Amazon.DataSync.Model;

namespace Amazon.PowerShell.Cmdlets.DSYN
{
    /// <summary>
    /// Updates some parameters of an existing object storage location that DataSync accesses
    /// for a transfer. For information about creating a self-managed object storage location,
    /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
    /// a location for object storage</a>.
    /// </summary>
    [Cmdlet("Update", "DSYNLocationObjectStorage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS DataSync UpdateLocationObjectStorage API operation.", Operation = new[] {"UpdateLocationObjectStorage"}, SelectReturnType = typeof(Amazon.DataSync.Model.UpdateLocationObjectStorageResponse))]
    [AWSCmdletOutput("None or Amazon.DataSync.Model.UpdateLocationObjectStorageResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.DataSync.Model.UpdateLocationObjectStorageResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateDSYNLocationObjectStorageCmdlet : AmazonDataSyncClientCmdlet, IExecutor
    {
        
        #region Parameter BucketAccessKey
        /// <summary>
        /// <para>
        /// <para>Specifies the access key (for example, a user name) if credentials are required to
        /// authenticate with the object storage server.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String BucketAccessKey { get; set; }
        #endregion
        
        #region Parameter AgentArn
        /// <summary>
        /// <para>
        /// <para>Specifies the Amazon Resource Names (ARNs) of the DataSync agents that can securely
        /// connect with your location.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AgentArns")]
        public System.String[] AgentArn { get; set; }
        #endregion
        
        #region Parameter LocationArn
        /// <summary>
        /// <para>
        /// <para>Specifies the ARN of the object storage system location that you're updating.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String LocationArn { get; set; }
        #endregion
        
        #region Parameter BucketSecretKey
        /// <summary>
        /// <para>
        /// <para>Specifies the secret key (for example, a password) if credentials are required to
        /// authenticate with the object storage server.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String BucketSecretKey { get; set; }
        #endregion
        
        #region Parameter ServerCertificate
        /// <summary>
        /// <para>
        /// <para>Specifies a certificate to authenticate with an object storage system that uses a
        /// private or self-signed certificate authority (CA). You must specify a Base64-encoded
        /// <code>.pem</code> file (for example, <code>file:///home/user/.ssh/storage_sys_certificate.pem</code>).
        /// The certificate can be up to 32768 bytes (before Base64 encoding).</para><para>To use this parameter, configure <code>ServerProtocol</code> to <code>HTTPS</code>.</para><para>Updating the certificate doesn't interfere with tasks that you have in progress.</para>
        /// </para>
        /// <para>The cmdlet will automatically convert the supplied parameter of type string, string[], System.IO.FileInfo or System.IO.Stream to byte[] before supplying it to the service.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Amazon.PowerShell.Common.MemoryStreamParameterConverter]
        public byte[] ServerCertificate { get; set; }
        #endregion
        
        #region Parameter ServerPort
        /// <summary>
        /// <para>
        /// <para>Specifies the port that your object storage server accepts inbound network traffic
        /// on (for example, port 443).</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? ServerPort { get; set; }
        #endregion
        
        #region Parameter ServerProtocol
        /// <summary>
        /// <para>
        /// <para>Specifies the protocol that your object storage server uses to communicate.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.DataSync.ObjectStorageServerProtocol")]
        public Amazon.DataSync.ObjectStorageServerProtocol ServerProtocol { get; set; }
        #endregion
        
        #region Parameter Subdirectory
        /// <summary>
        /// <para>
        /// <para>Specifies the object prefix for your object storage server. If this is a source location,
        /// DataSync only copies objects with this prefix. If this is a destination location,
        /// DataSync writes all objects with this prefix.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Subdirectory { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DataSync.Model.UpdateLocationObjectStorageResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the LocationArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^LocationArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^LocationArn' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.LocationArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-DSYNLocationObjectStorage (UpdateLocationObjectStorage)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.DataSync.Model.UpdateLocationObjectStorageResponse, UpdateDSYNLocationObjectStorageCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.LocationArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BucketAccessKey = this.BucketAccessKey;
            if (this.AgentArn != null)
            {
                context.AgentArn = new List<System.String>(this.AgentArn);
            }
            context.LocationArn = this.LocationArn;
            #if MODULAR
            if (this.LocationArn == null && ParameterWasBound(nameof(this.LocationArn)))
            {
                WriteWarning("You are passing $null as a value for parameter LocationArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.BucketSecretKey = this.BucketSecretKey;
            context.ServerCertificate = this.ServerCertificate;
            context.ServerPort = this.ServerPort;
            context.ServerProtocol = this.ServerProtocol;
            context.Subdirectory = this.Subdirectory;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            System.IO.MemoryStream _ServerCertificateStream = null;
            
            try
            {
                var cmdletContext = context as CmdletContext;
                // create request
                var request = new Amazon.DataSync.Model.UpdateLocationObjectStorageRequest();
                
                if (cmdletContext.BucketAccessKey != null)
                {
                    request.AccessKey = cmdletContext.BucketAccessKey;
                }
                if (cmdletContext.AgentArn != null)
                {
                    request.AgentArns = cmdletContext.AgentArn;
                }
                if (cmdletContext.LocationArn != null)
                {
                    request.LocationArn = cmdletContext.LocationArn;
                }
                if (cmdletContext.BucketSecretKey != null)
                {
                    request.SecretKey = cmdletContext.BucketSecretKey;
                }
                if (cmdletContext.ServerCertificate != null)
                {
                    _ServerCertificateStream = new System.IO.MemoryStream(cmdletContext.ServerCertificate);
                    request.ServerCertificate = _ServerCertificateStream;
                }
                if (cmdletContext.ServerPort != null)
                {
                    request.ServerPort = cmdletContext.ServerPort.Value;
                }
                if (cmdletContext.ServerProtocol != null)
                {
                    request.ServerProtocol = cmdletContext.ServerProtocol;
                }
                if (cmdletContext.Subdirectory != null)
                {
                    request.Subdirectory = cmdletContext.Subdirectory;
                }
                
                CmdletOutput output;
                
                // issue call
                var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
                try
                {
                    var response = CallAWSServiceOperation(client, request);
                    object pipelineOutput = null;
                    pipelineOutput = cmdletContext.Select(response, this);
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                return output;
            }
            finally
            {
                if( _ServerCertificateStream != null)
                {
                    _ServerCertificateStream.Dispose();
                }
            }
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.DataSync.Model.UpdateLocationObjectStorageResponse CallAWSServiceOperation(IAmazonDataSync client, Amazon.DataSync.Model.UpdateLocationObjectStorageRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS DataSync", "UpdateLocationObjectStorage");
            try
            {
                #if DESKTOP
                return client.UpdateLocationObjectStorage(request);
                #elif CORECLR
                return client.UpdateLocationObjectStorageAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String BucketAccessKey { get; set; }
            public List<System.String> AgentArn { get; set; }
            public System.String LocationArn { get; set; }
            public System.String BucketSecretKey { get; set; }
            public byte[] ServerCertificate { get; set; }
            public System.Int32? ServerPort { get; set; }
            public Amazon.DataSync.ObjectStorageServerProtocol ServerProtocol { get; set; }
            public System.String Subdirectory { get; set; }
            public System.Func<Amazon.DataSync.Model.UpdateLocationObjectStorageResponse, UpdateDSYNLocationObjectStorageCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
