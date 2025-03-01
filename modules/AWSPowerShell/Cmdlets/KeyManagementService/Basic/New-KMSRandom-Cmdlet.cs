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
using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;

namespace Amazon.PowerShell.Cmdlets.KMS
{
    /// <summary>
    /// Returns a random byte string that is cryptographically secure.
    /// 
    ///  
    /// <para>
    /// You must use the <code>NumberOfBytes</code> parameter to specify the length of the
    /// random byte string. There is no default value for string length.
    /// </para><para>
    /// By default, the random byte string is generated in KMS. To generate the byte string
    /// in the CloudHSM cluster associated with an CloudHSM key store, use the <code>CustomKeyStoreId</code>
    /// parameter.
    /// </para><para>
    /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
    /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
    /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
    /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
    /// Guide</i>.
    /// </para><para>
    /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
    /// Management Service Cryptographic Details</a>.
    /// </para><para><b>Cross-account use</b>: Not applicable. <code>GenerateRandom</code> does not use
    /// any account-specific resources, such as KMS keys.
    /// </para><para><b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
    /// (IAM policy)
    /// </para>
    /// </summary>
    [Cmdlet("New", "KMSRandom", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.IO.MemoryStream")]
    [AWSCmdlet("Calls the AWS Key Management Service GenerateRandom API operation.", Operation = new[] {"GenerateRandom"}, SelectReturnType = typeof(Amazon.KeyManagementService.Model.GenerateRandomResponse))]
    [AWSCmdletOutput("System.IO.MemoryStream or Amazon.KeyManagementService.Model.GenerateRandomResponse",
        "This cmdlet returns a System.IO.MemoryStream object.",
        "The service call response (type Amazon.KeyManagementService.Model.GenerateRandomResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewKMSRandomCmdlet : AmazonKeyManagementServiceClientCmdlet, IExecutor
    {
        
        #region Parameter CustomKeyStoreId
        /// <summary>
        /// <para>
        /// <para>Generates the random byte string in the CloudHSM cluster that is associated with the
        /// specified CloudHSM key store. To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.</para><para>External key store IDs are not valid for this parameter. If you specify the ID of
        /// an external key store, <code>GenerateRandom</code> throws an <code>UnsupportedOperationException</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CustomKeyStoreId { get; set; }
        #endregion
        
        #region Parameter NumberOfBytes
        /// <summary>
        /// <para>
        /// <para>The length of the random byte string. This parameter is required.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.Int32? NumberOfBytes { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Plaintext'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.KeyManagementService.Model.GenerateRandomResponse).
        /// Specifying the name of a property of type Amazon.KeyManagementService.Model.GenerateRandomResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Plaintext";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the NumberOfBytes parameter.
        /// The -PassThru parameter is deprecated, use -Select '^NumberOfBytes' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^NumberOfBytes' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = string.Empty;
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-KMSRandom (GenerateRandom)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.KeyManagementService.Model.GenerateRandomResponse, NewKMSRandomCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.NumberOfBytes;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CustomKeyStoreId = this.CustomKeyStoreId;
            context.NumberOfBytes = this.NumberOfBytes;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.KeyManagementService.Model.GenerateRandomRequest();
            
            if (cmdletContext.CustomKeyStoreId != null)
            {
                request.CustomKeyStoreId = cmdletContext.CustomKeyStoreId;
            }
            if (cmdletContext.NumberOfBytes != null)
            {
                request.NumberOfBytes = cmdletContext.NumberOfBytes.Value;
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
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.KeyManagementService.Model.GenerateRandomResponse CallAWSServiceOperation(IAmazonKeyManagementService client, Amazon.KeyManagementService.Model.GenerateRandomRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Key Management Service", "GenerateRandom");
            try
            {
                #if DESKTOP
                return client.GenerateRandom(request);
                #elif CORECLR
                return client.GenerateRandomAsync(request).GetAwaiter().GetResult();
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
            public System.String CustomKeyStoreId { get; set; }
            public System.Int32? NumberOfBytes { get; set; }
            public System.Func<Amazon.KeyManagementService.Model.GenerateRandomResponse, NewKMSRandomCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Plaintext;
        }
        
    }
}
