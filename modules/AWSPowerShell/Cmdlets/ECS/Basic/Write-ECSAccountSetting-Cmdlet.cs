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
using Amazon.ECS;
using Amazon.ECS.Model;

namespace Amazon.PowerShell.Cmdlets.ECS
{
    /// <summary>
    /// Modifies an account setting. Account settings are set on a per-Region basis.
    /// 
    ///  
    /// <para>
    /// If you change the account setting for the root user, the default settings for all
    /// of the IAM users and roles that no individual account setting was specified are reset
    /// for. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html">Account
    /// Settings</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para><para>
    /// When <code>serviceLongArnFormat</code>, <code>taskLongArnFormat</code>, or <code>containerInstanceLongArnFormat</code>
    /// are specified, the Amazon Resource Name (ARN) and resource ID format of the resource
    /// type for a specified IAM user, IAM role, or the root user for an account is affected.
    /// The opt-in and opt-out account setting must be set for each Amazon ECS resource separately.
    /// The ARN and resource ID format of a resource is defined by the opt-in status of the
    /// IAM user or role that created the resource. You must turn on this setting to use Amazon
    /// ECS features such as resource tagging.
    /// </para><para>
    /// When <code>awsvpcTrunking</code> is specified, the elastic network interface (ENI)
    /// limit for any new container instances that support the feature is changed. If <code>awsvpcTrunking</code>
    /// is enabled, any new container instances that support the feature are launched have
    /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
    /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para><para>
    /// When <code>containerInsights</code> is specified, the default setting indicating whether
    /// CloudWatch Container Insights is enabled for your clusters is changed. If <code>containerInsights</code>
    /// is enabled, any new clusters that are created will have Container Insights enabled
    /// unless you disable it during cluster creation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">CloudWatch
    /// Container Insights</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    [Cmdlet("Write", "ECSAccountSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ECS.Model.Setting")]
    [AWSCmdlet("Calls the Amazon EC2 Container Service PutAccountSetting API operation.", Operation = new[] {"PutAccountSetting"}, SelectReturnType = typeof(Amazon.ECS.Model.PutAccountSettingResponse))]
    [AWSCmdletOutput("Amazon.ECS.Model.Setting or Amazon.ECS.Model.PutAccountSettingResponse",
        "This cmdlet returns an Amazon.ECS.Model.Setting object.",
        "The service call response (type Amazon.ECS.Model.PutAccountSettingResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class WriteECSAccountSettingCmdlet : AmazonECSClientCmdlet, IExecutor
    {
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The Amazon ECS resource name for which to modify the account setting. If <code>serviceLongArnFormat</code>
        /// is specified, the ARN for your Amazon ECS services is affected. If <code>taskLongArnFormat</code>
        /// is specified, the ARN and resource ID for your Amazon ECS tasks is affected. If <code>containerInstanceLongArnFormat</code>
        /// is specified, the ARN and resource ID for your Amazon ECS container instances is affected.
        /// If <code>awsvpcTrunking</code> is specified, the elastic network interface (ENI) limit
        /// for your Amazon ECS container instances is affected. If <code>containerInsights</code>
        /// is specified, the default setting for CloudWatch Container Insights for your clusters
        /// is affected.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.ECS.SettingName")]
        public Amazon.ECS.SettingName Name { get; set; }
        #endregion
        
        #region Parameter PrincipalArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the principal, which can be an IAM user, IAM role, or the root user. If
        /// you specify the root user, it modifies the account setting for all IAM users, IAM
        /// roles, and the root user of the account unless an IAM user or role explicitly overrides
        /// these settings. If this field is omitted, the setting is changed only for the authenticated
        /// user.</para><note><para>Federated users assume the account setting of the root user and can't have explicit
        /// account settings set for them.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PrincipalArn { get; set; }
        #endregion
        
        #region Parameter Value
        /// <summary>
        /// <para>
        /// <para>The account setting value for the specified principal ARN. Accepted values are <code>enabled</code>
        /// and <code>disabled</code>.</para>
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
        public System.String Value { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Setting'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ECS.Model.PutAccountSettingResponse).
        /// Specifying the name of a property of type Amazon.ECS.Model.PutAccountSettingResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Setting";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Value parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Value' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Value' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Write-ECSAccountSetting (PutAccountSetting)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ECS.Model.PutAccountSettingResponse, WriteECSAccountSettingCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Value;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.PrincipalArn = this.PrincipalArn;
            context.Value = this.Value;
            #if MODULAR
            if (this.Value == null && ParameterWasBound(nameof(this.Value)))
            {
                WriteWarning("You are passing $null as a value for parameter Value which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ECS.Model.PutAccountSettingRequest();
            
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.PrincipalArn != null)
            {
                request.PrincipalArn = cmdletContext.PrincipalArn;
            }
            if (cmdletContext.Value != null)
            {
                request.Value = cmdletContext.Value;
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
        
        private Amazon.ECS.Model.PutAccountSettingResponse CallAWSServiceOperation(IAmazonECS client, Amazon.ECS.Model.PutAccountSettingRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon EC2 Container Service", "PutAccountSetting");
            try
            {
                #if DESKTOP
                return client.PutAccountSetting(request);
                #elif CORECLR
                return client.PutAccountSettingAsync(request).GetAwaiter().GetResult();
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
            public Amazon.ECS.SettingName Name { get; set; }
            public System.String PrincipalArn { get; set; }
            public System.String Value { get; set; }
            public System.Func<Amazon.ECS.Model.PutAccountSettingResponse, WriteECSAccountSettingCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Setting;
        }
        
    }
}
