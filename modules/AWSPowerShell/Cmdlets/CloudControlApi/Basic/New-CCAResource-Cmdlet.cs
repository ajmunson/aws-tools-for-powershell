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
using Amazon.CloudControlApi;
using Amazon.CloudControlApi.Model;

namespace Amazon.PowerShell.Cmdlets.CCA
{
    /// <summary>
    /// Creates the specified resource. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-create.html">Creating
    /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
    /// 
    ///  
    /// <para>
    /// After you have initiated a resource creation request, you can monitor the progress
    /// of your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
    /// using the <code>RequestToken</code> of the <code>ProgressEvent</code> type returned
    /// by <code>CreateResource</code>.
    /// </para>
    /// </summary>
    [Cmdlet("New", "CCAResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.CloudControlApi.Model.ProgressEvent")]
    [AWSCmdlet("Calls the AWS Cloud Control API CreateResource API operation.", Operation = new[] {"CreateResource"}, SelectReturnType = typeof(Amazon.CloudControlApi.Model.CreateResourceResponse))]
    [AWSCmdletOutput("Amazon.CloudControlApi.Model.ProgressEvent or Amazon.CloudControlApi.Model.CreateResourceResponse",
        "This cmdlet returns an Amazon.CloudControlApi.Model.ProgressEvent object.",
        "The service call response (type Amazon.CloudControlApi.Model.CreateResourceResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewCCAResourceCmdlet : AmazonCloudControlApiClientCmdlet, IExecutor
    {
        
        #region Parameter DesiredState
        /// <summary>
        /// <para>
        /// <para>Structured data format representing the desired state of the resource, consisting
        /// of that resource's properties and their desired values.</para><note><para>Cloud Control API currently supports JSON as a structured data format.</para></note><pre><code> &lt;p&gt;Specify the desired state as one of the following:&lt;/p&gt;
        /// &lt;ul&gt; &lt;li&gt; &lt;p&gt;A JSON blob&lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt;A
        /// local path containing the desired state in JSON data format&lt;/p&gt; &lt;/li&gt;
        /// &lt;/ul&gt; &lt;p&gt;For more information, see &lt;a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-create.html#resource-operations-create-desiredstate"&gt;Composing
        /// the desired state of the resource&lt;/a&gt; in the &lt;i&gt;Amazon Web Services Cloud
        /// Control API User Guide&lt;/i&gt;.&lt;/p&gt; &lt;p&gt;For more information about the
        /// properties of a specific resource, refer to the related topic for the resource in
        /// the &lt;a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html"&gt;Resource
        /// and property types reference&lt;/a&gt; in the &lt;i&gt;CloudFormation Users Guide&lt;/i&gt;.&lt;/p&gt;
        /// </code></pre>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String DesiredState { get; set; }
        #endregion
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role for
        /// Cloud Control API to use when performing this resource operation. The role specified
        /// must have the permissions required for this operation. The necessary permissions for
        /// each event handler are defined in the <code><a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html#schema-properties-handlers">handlers</a></code> section of the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">resource
        /// type definition schema</a>.</para><para>If you do not specify a role, Cloud Control API uses a temporary session created using
        /// your Amazon Web Services user credentials.</para><para>For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations.html#resource-operations-permissions">Specifying
        /// credentials</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter TypeName
        /// <summary>
        /// <para>
        /// <para>The name of the resource type.</para>
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
        public System.String TypeName { get; set; }
        #endregion
        
        #region Parameter TypeVersionId
        /// <summary>
        /// <para>
        /// <para>For private resource types, the type version to use in this resource operation. If
        /// you do not specify a resource version, CloudFormation uses the default version.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String TypeVersionId { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique identifier to ensure the idempotency of the resource request. As a best practice,
        /// specify this token to ensure idempotency, so that Amazon Web Services Cloud Control
        /// API can accurately distinguish between request retries and new resource requests.
        /// You might retry a resource request to ensure that it was successfully received.</para><para>A client token is valid for 36 hours once used. After that, a resource request with
        /// the same client token is treated as a new request.</para><para>If you do not specify a client token, one is generated for inclusion in the request.</para><para>For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations.html#resource-operations-idempotency">Ensuring
        /// resource operation requests are unique</a> in the <i>Amazon Web Services Cloud Control
        /// API User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ProgressEvent'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CloudControlApi.Model.CreateResourceResponse).
        /// Specifying the name of a property of type Amazon.CloudControlApi.Model.CreateResourceResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ProgressEvent";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the TypeName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^TypeName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^TypeName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.TypeName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-CCAResource (CreateResource)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CloudControlApi.Model.CreateResourceResponse, NewCCAResourceCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.TypeName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.DesiredState = this.DesiredState;
            #if MODULAR
            if (this.DesiredState == null && ParameterWasBound(nameof(this.DesiredState)))
            {
                WriteWarning("You are passing $null as a value for parameter DesiredState which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RoleArn = this.RoleArn;
            context.TypeName = this.TypeName;
            #if MODULAR
            if (this.TypeName == null && ParameterWasBound(nameof(this.TypeName)))
            {
                WriteWarning("You are passing $null as a value for parameter TypeName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TypeVersionId = this.TypeVersionId;
            
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
            var request = new Amazon.CloudControlApi.Model.CreateResourceRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.DesiredState != null)
            {
                request.DesiredState = cmdletContext.DesiredState;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
            }
            if (cmdletContext.TypeName != null)
            {
                request.TypeName = cmdletContext.TypeName;
            }
            if (cmdletContext.TypeVersionId != null)
            {
                request.TypeVersionId = cmdletContext.TypeVersionId;
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
        
        private Amazon.CloudControlApi.Model.CreateResourceResponse CallAWSServiceOperation(IAmazonCloudControlApi client, Amazon.CloudControlApi.Model.CreateResourceRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Cloud Control API", "CreateResource");
            try
            {
                #if DESKTOP
                return client.CreateResource(request);
                #elif CORECLR
                return client.CreateResourceAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String DesiredState { get; set; }
            public System.String RoleArn { get; set; }
            public System.String TypeName { get; set; }
            public System.String TypeVersionId { get; set; }
            public System.Func<Amazon.CloudControlApi.Model.CreateResourceResponse, NewCCAResourceCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ProgressEvent;
        }
        
    }
}
