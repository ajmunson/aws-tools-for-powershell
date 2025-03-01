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
using Amazon.Chime;
using Amazon.Chime.Model;

namespace Amazon.PowerShell.Cmdlets.CHM
{
    /// <summary>
    /// Promotes an <code>AppInstanceUser</code> to an <code>AppInstanceAdmin</code>. The
    /// promoted user can perform the following actions. 
    /// 
    ///  <ul><li><para><code>ChannelModerator</code> actions across all channels in the <code>AppInstance</code>.
    /// </para></li><li><para><code>DeleteChannelMessage</code> actions.
    /// </para></li></ul><para>
    /// Only an <code>AppInstanceUser</code> can be promoted to an <code>AppInstanceAdmin</code>
    /// role.
    /// </para>
    /// </summary>
    [Cmdlet("New", "CHMAppInstanceAdmin", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Chime.Model.CreateAppInstanceAdminResponse")]
    [AWSCmdlet("Calls the Amazon Chime CreateAppInstanceAdmin API operation.", Operation = new[] {"CreateAppInstanceAdmin"}, SelectReturnType = typeof(Amazon.Chime.Model.CreateAppInstanceAdminResponse))]
    [AWSCmdletOutput("Amazon.Chime.Model.CreateAppInstanceAdminResponse",
        "This cmdlet returns an Amazon.Chime.Model.CreateAppInstanceAdminResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewCHMAppInstanceAdminCmdlet : AmazonChimeClientCmdlet, IExecutor
    {
        
        #region Parameter AppInstanceAdminArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the administrator of the current <code>AppInstance</code>.</para>
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
        public System.String AppInstanceAdminArn { get; set; }
        #endregion
        
        #region Parameter AppInstanceArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the <code>AppInstance</code>.</para>
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
        public System.String AppInstanceArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Chime.Model.CreateAppInstanceAdminResponse).
        /// Specifying the name of a property of type Amazon.Chime.Model.CreateAppInstanceAdminResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AppInstanceArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AppInstanceArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AppInstanceArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AppInstanceAdminArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-CHMAppInstanceAdmin (CreateAppInstanceAdmin)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Chime.Model.CreateAppInstanceAdminResponse, NewCHMAppInstanceAdminCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AppInstanceArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AppInstanceAdminArn = this.AppInstanceAdminArn;
            #if MODULAR
            if (this.AppInstanceAdminArn == null && ParameterWasBound(nameof(this.AppInstanceAdminArn)))
            {
                WriteWarning("You are passing $null as a value for parameter AppInstanceAdminArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AppInstanceArn = this.AppInstanceArn;
            #if MODULAR
            if (this.AppInstanceArn == null && ParameterWasBound(nameof(this.AppInstanceArn)))
            {
                WriteWarning("You are passing $null as a value for parameter AppInstanceArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.Chime.Model.CreateAppInstanceAdminRequest();
            
            if (cmdletContext.AppInstanceAdminArn != null)
            {
                request.AppInstanceAdminArn = cmdletContext.AppInstanceAdminArn;
            }
            if (cmdletContext.AppInstanceArn != null)
            {
                request.AppInstanceArn = cmdletContext.AppInstanceArn;
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
        
        private Amazon.Chime.Model.CreateAppInstanceAdminResponse CallAWSServiceOperation(IAmazonChime client, Amazon.Chime.Model.CreateAppInstanceAdminRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Chime", "CreateAppInstanceAdmin");
            try
            {
                #if DESKTOP
                return client.CreateAppInstanceAdmin(request);
                #elif CORECLR
                return client.CreateAppInstanceAdminAsync(request).GetAwaiter().GetResult();
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
            public System.String AppInstanceAdminArn { get; set; }
            public System.String AppInstanceArn { get; set; }
            public System.Func<Amazon.Chime.Model.CreateAppInstanceAdminResponse, NewCHMAppInstanceAdminCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
