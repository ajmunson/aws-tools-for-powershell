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
    /// Updates some of the parameters of a previously created location for Server Message
    /// Block (SMB) file system access. For information about creating an SMB location, see
    /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Creating
    /// a location for SMB</a>.
    /// </summary>
    [Cmdlet("Update", "DSYNLocationSmb", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS DataSync UpdateLocationSmb API operation.", Operation = new[] {"UpdateLocationSmb"}, SelectReturnType = typeof(Amazon.DataSync.Model.UpdateLocationSmbResponse))]
    [AWSCmdletOutput("None or Amazon.DataSync.Model.UpdateLocationSmbResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.DataSync.Model.UpdateLocationSmbResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateDSYNLocationSmbCmdlet : AmazonDataSyncClientCmdlet, IExecutor
    {
        
        #region Parameter AgentArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Names (ARNs) of agents to use for a Simple Message Block (SMB)
        /// location.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AgentArns")]
        public System.String[] AgentArn { get; set; }
        #endregion
        
        #region Parameter Domain
        /// <summary>
        /// <para>
        /// <para>The name of the Windows domain that the SMB server belongs to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Domain { get; set; }
        #endregion
        
        #region Parameter LocationArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the SMB location to update.</para>
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
        
        #region Parameter Password
        /// <summary>
        /// <para>
        /// <para>The password of the user who can mount the share has the permissions to access files
        /// and folders in the SMB share.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Password { get; set; }
        #endregion
        
        #region Parameter Subdirectory
        /// <summary>
        /// <para>
        /// <para>The subdirectory in the SMB file system that is used to read data from the SMB source
        /// location or write data to the SMB destination. The SMB path should be a path that's
        /// exported by the SMB server, or a subdirectory of that path. The path should be such
        /// that it can be mounted by other SMB clients in your network.</para><note><para><code>Subdirectory</code> must be specified with forward slashes. For example, <code>/path/to/folder</code>.</para></note><para>To transfer all the data in the folder that you specified, DataSync must have permissions
        /// to mount the SMB share and to access all the data in that share. To ensure this, do
        /// either of the following:</para><ul><li><para>Ensure that the user/password specified belongs to the user who can mount the share
        /// and who has the appropriate permissions for all of the files and directories that
        /// you want DataSync to access.</para></li><li><para>Use credentials of a member of the Backup Operators group to mount the share. </para></li></ul><para>Doing either of these options enables the agent to access the data. For the agent
        /// to access directories, you must also enable all execute access.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Subdirectory { get; set; }
        #endregion
        
        #region Parameter User
        /// <summary>
        /// <para>
        /// <para>The user who can mount the share has the permissions to access files and folders in
        /// the SMB share.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String User { get; set; }
        #endregion
        
        #region Parameter MountOptions_Version
        /// <summary>
        /// <para>
        /// <para>Specifies the SMB version that you want DataSync to use when mounting your SMB share.
        /// If you don't specify a version, DataSync defaults to <code>AUTOMATIC</code> and chooses
        /// a version based on negotiation with the SMB server.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.DataSync.SmbVersion")]
        public Amazon.DataSync.SmbVersion MountOptions_Version { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DataSync.Model.UpdateLocationSmbResponse).
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-DSYNLocationSmb (UpdateLocationSmb)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.DataSync.Model.UpdateLocationSmbResponse, UpdateDSYNLocationSmbCmdlet>(Select) ??
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
            if (this.AgentArn != null)
            {
                context.AgentArn = new List<System.String>(this.AgentArn);
            }
            context.Domain = this.Domain;
            context.LocationArn = this.LocationArn;
            #if MODULAR
            if (this.LocationArn == null && ParameterWasBound(nameof(this.LocationArn)))
            {
                WriteWarning("You are passing $null as a value for parameter LocationArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MountOptions_Version = this.MountOptions_Version;
            context.Password = this.Password;
            context.Subdirectory = this.Subdirectory;
            context.User = this.User;
            
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
            var request = new Amazon.DataSync.Model.UpdateLocationSmbRequest();
            
            if (cmdletContext.AgentArn != null)
            {
                request.AgentArns = cmdletContext.AgentArn;
            }
            if (cmdletContext.Domain != null)
            {
                request.Domain = cmdletContext.Domain;
            }
            if (cmdletContext.LocationArn != null)
            {
                request.LocationArn = cmdletContext.LocationArn;
            }
            
             // populate MountOptions
            var requestMountOptionsIsNull = true;
            request.MountOptions = new Amazon.DataSync.Model.SmbMountOptions();
            Amazon.DataSync.SmbVersion requestMountOptions_mountOptions_Version = null;
            if (cmdletContext.MountOptions_Version != null)
            {
                requestMountOptions_mountOptions_Version = cmdletContext.MountOptions_Version;
            }
            if (requestMountOptions_mountOptions_Version != null)
            {
                request.MountOptions.Version = requestMountOptions_mountOptions_Version;
                requestMountOptionsIsNull = false;
            }
             // determine if request.MountOptions should be set to null
            if (requestMountOptionsIsNull)
            {
                request.MountOptions = null;
            }
            if (cmdletContext.Password != null)
            {
                request.Password = cmdletContext.Password;
            }
            if (cmdletContext.Subdirectory != null)
            {
                request.Subdirectory = cmdletContext.Subdirectory;
            }
            if (cmdletContext.User != null)
            {
                request.User = cmdletContext.User;
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
        
        private Amazon.DataSync.Model.UpdateLocationSmbResponse CallAWSServiceOperation(IAmazonDataSync client, Amazon.DataSync.Model.UpdateLocationSmbRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS DataSync", "UpdateLocationSmb");
            try
            {
                #if DESKTOP
                return client.UpdateLocationSmb(request);
                #elif CORECLR
                return client.UpdateLocationSmbAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> AgentArn { get; set; }
            public System.String Domain { get; set; }
            public System.String LocationArn { get; set; }
            public Amazon.DataSync.SmbVersion MountOptions_Version { get; set; }
            public System.String Password { get; set; }
            public System.String Subdirectory { get; set; }
            public System.String User { get; set; }
            public System.Func<Amazon.DataSync.Model.UpdateLocationSmbResponse, UpdateDSYNLocationSmbCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
