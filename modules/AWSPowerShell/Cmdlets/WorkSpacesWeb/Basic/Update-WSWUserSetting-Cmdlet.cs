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
using Amazon.WorkSpacesWeb;
using Amazon.WorkSpacesWeb.Model;

namespace Amazon.PowerShell.Cmdlets.WSW
{
    /// <summary>
    /// Updates the user settings.
    /// </summary>
    [Cmdlet("Update", "WSWUserSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.WorkSpacesWeb.Model.UserSettings")]
    [AWSCmdlet("Calls the Amazon WorkSpaces Web UpdateUserSettings API operation.", Operation = new[] {"UpdateUserSettings"}, SelectReturnType = typeof(Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse))]
    [AWSCmdletOutput("Amazon.WorkSpacesWeb.Model.UserSettings or Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse",
        "This cmdlet returns an Amazon.WorkSpacesWeb.Model.UserSettings object.",
        "The service call response (type Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateWSWUserSettingCmdlet : AmazonWorkSpacesWebClientCmdlet, IExecutor
    {
        
        #region Parameter CopyAllowed
        /// <summary>
        /// <para>
        /// <para>Specifies whether the user can copy text from the streaming session to the local device.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.WorkSpacesWeb.EnabledType")]
        public Amazon.WorkSpacesWeb.EnabledType CopyAllowed { get; set; }
        #endregion
        
        #region Parameter DisconnectTimeoutInMinute
        /// <summary>
        /// <para>
        /// <para>The amount of time that a streaming session remains active after users disconnect.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("DisconnectTimeoutInMinutes")]
        public System.Int32? DisconnectTimeoutInMinute { get; set; }
        #endregion
        
        #region Parameter DownloadAllowed
        /// <summary>
        /// <para>
        /// <para>Specifies whether the user can download files from the streaming session to the local
        /// device.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.WorkSpacesWeb.EnabledType")]
        public Amazon.WorkSpacesWeb.EnabledType DownloadAllowed { get; set; }
        #endregion
        
        #region Parameter IdleDisconnectTimeoutInMinute
        /// <summary>
        /// <para>
        /// <para>The amount of time that users can be idle (inactive) before they are disconnected
        /// from their streaming session and the disconnect timeout interval begins.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("IdleDisconnectTimeoutInMinutes")]
        public System.Int32? IdleDisconnectTimeoutInMinute { get; set; }
        #endregion
        
        #region Parameter PasteAllowed
        /// <summary>
        /// <para>
        /// <para>Specifies whether the user can paste text from the local device to the streaming session.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.WorkSpacesWeb.EnabledType")]
        public Amazon.WorkSpacesWeb.EnabledType PasteAllowed { get; set; }
        #endregion
        
        #region Parameter PrintAllowed
        /// <summary>
        /// <para>
        /// <para>Specifies whether the user can print to the local device.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.WorkSpacesWeb.EnabledType")]
        public Amazon.WorkSpacesWeb.EnabledType PrintAllowed { get; set; }
        #endregion
        
        #region Parameter UploadAllowed
        /// <summary>
        /// <para>
        /// <para>Specifies whether the user can upload files from the local device to the streaming
        /// session.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.WorkSpacesWeb.EnabledType")]
        public Amazon.WorkSpacesWeb.EnabledType UploadAllowed { get; set; }
        #endregion
        
        #region Parameter UserSettingsArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the user settings.</para>
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
        public System.String UserSettingsArn { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, subsequent retries
        /// with the same client token return the result from the original successful request.
        /// </para><para>If you do not specify a client token, one is automatically generated by the AWS SDK.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'UserSettings'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse).
        /// Specifying the name of a property of type Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "UserSettings";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the UserSettingsArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^UserSettingsArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^UserSettingsArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.UserSettingsArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-WSWUserSetting (UpdateUserSettings)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse, UpdateWSWUserSettingCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.UserSettingsArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.CopyAllowed = this.CopyAllowed;
            context.DisconnectTimeoutInMinute = this.DisconnectTimeoutInMinute;
            context.DownloadAllowed = this.DownloadAllowed;
            context.IdleDisconnectTimeoutInMinute = this.IdleDisconnectTimeoutInMinute;
            context.PasteAllowed = this.PasteAllowed;
            context.PrintAllowed = this.PrintAllowed;
            context.UploadAllowed = this.UploadAllowed;
            context.UserSettingsArn = this.UserSettingsArn;
            #if MODULAR
            if (this.UserSettingsArn == null && ParameterWasBound(nameof(this.UserSettingsArn)))
            {
                WriteWarning("You are passing $null as a value for parameter UserSettingsArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.WorkSpacesWeb.Model.UpdateUserSettingsRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.CopyAllowed != null)
            {
                request.CopyAllowed = cmdletContext.CopyAllowed;
            }
            if (cmdletContext.DisconnectTimeoutInMinute != null)
            {
                request.DisconnectTimeoutInMinutes = cmdletContext.DisconnectTimeoutInMinute.Value;
            }
            if (cmdletContext.DownloadAllowed != null)
            {
                request.DownloadAllowed = cmdletContext.DownloadAllowed;
            }
            if (cmdletContext.IdleDisconnectTimeoutInMinute != null)
            {
                request.IdleDisconnectTimeoutInMinutes = cmdletContext.IdleDisconnectTimeoutInMinute.Value;
            }
            if (cmdletContext.PasteAllowed != null)
            {
                request.PasteAllowed = cmdletContext.PasteAllowed;
            }
            if (cmdletContext.PrintAllowed != null)
            {
                request.PrintAllowed = cmdletContext.PrintAllowed;
            }
            if (cmdletContext.UploadAllowed != null)
            {
                request.UploadAllowed = cmdletContext.UploadAllowed;
            }
            if (cmdletContext.UserSettingsArn != null)
            {
                request.UserSettingsArn = cmdletContext.UserSettingsArn;
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
        
        private Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse CallAWSServiceOperation(IAmazonWorkSpacesWeb client, Amazon.WorkSpacesWeb.Model.UpdateUserSettingsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon WorkSpaces Web", "UpdateUserSettings");
            try
            {
                #if DESKTOP
                return client.UpdateUserSettings(request);
                #elif CORECLR
                return client.UpdateUserSettingsAsync(request).GetAwaiter().GetResult();
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
            public Amazon.WorkSpacesWeb.EnabledType CopyAllowed { get; set; }
            public System.Int32? DisconnectTimeoutInMinute { get; set; }
            public Amazon.WorkSpacesWeb.EnabledType DownloadAllowed { get; set; }
            public System.Int32? IdleDisconnectTimeoutInMinute { get; set; }
            public Amazon.WorkSpacesWeb.EnabledType PasteAllowed { get; set; }
            public Amazon.WorkSpacesWeb.EnabledType PrintAllowed { get; set; }
            public Amazon.WorkSpacesWeb.EnabledType UploadAllowed { get; set; }
            public System.String UserSettingsArn { get; set; }
            public System.Func<Amazon.WorkSpacesWeb.Model.UpdateUserSettingsResponse, UpdateWSWUserSettingCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.UserSettings;
        }
        
    }
}
