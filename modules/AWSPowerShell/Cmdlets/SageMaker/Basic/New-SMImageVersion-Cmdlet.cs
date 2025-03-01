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
using Amazon.SageMaker;
using Amazon.SageMaker.Model;

namespace Amazon.PowerShell.Cmdlets.SM
{
    /// <summary>
    /// Creates a version of the SageMaker image specified by <code>ImageName</code>. The
    /// version represents the Amazon Elastic Container Registry (ECR) container image specified
    /// by <code>BaseImage</code>.
    /// </summary>
    [Cmdlet("New", "SMImageVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon SageMaker Service CreateImageVersion API operation.", Operation = new[] {"CreateImageVersion"}, SelectReturnType = typeof(Amazon.SageMaker.Model.CreateImageVersionResponse))]
    [AWSCmdletOutput("System.String or Amazon.SageMaker.Model.CreateImageVersionResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.SageMaker.Model.CreateImageVersionResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSMImageVersionCmdlet : AmazonSageMakerClientCmdlet, IExecutor
    {
        
        #region Parameter Alias
        /// <summary>
        /// <para>
        /// <para>A list of aliases created with the image version.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Aliases")]
        public System.String[] Alias { get; set; }
        #endregion
        
        #region Parameter BaseImage
        /// <summary>
        /// <para>
        /// <para>The registry path of the container image to use as the starting point for this version.
        /// The path is an Amazon Elastic Container Registry (ECR) URI in the following format:</para><para><code>&lt;acct-id&gt;.dkr.ecr.&lt;region&gt;.amazonaws.com/&lt;repo-name[:tag] or
        /// [@digest]&gt;</code></para>
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
        public System.String BaseImage { get; set; }
        #endregion
        
        #region Parameter Horovod
        /// <summary>
        /// <para>
        /// <para>Indicates Horovod compatibility.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Horovod { get; set; }
        #endregion
        
        #region Parameter ImageName
        /// <summary>
        /// <para>
        /// <para>The <code>ImageName</code> of the <code>Image</code> to create a version of.</para>
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
        public System.String ImageName { get; set; }
        #endregion
        
        #region Parameter JobType
        /// <summary>
        /// <para>
        /// <para>Indicates SageMaker job type compatibility.</para><ul><li><para><code>TRAINING</code>: The image version is compatible with SageMaker training jobs.</para></li><li><para><code>INFERENCE</code>: The image version is compatible with SageMaker inference
        /// jobs.</para></li><li><para><code>NOTEBOOK_KERNEL</code>: The image version is compatible with SageMaker notebook
        /// kernels.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SageMaker.JobType")]
        public Amazon.SageMaker.JobType JobType { get; set; }
        #endregion
        
        #region Parameter MLFramework
        /// <summary>
        /// <para>
        /// <para>The machine learning framework vended in the image version.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MLFramework { get; set; }
        #endregion
        
        #region Parameter Processor
        /// <summary>
        /// <para>
        /// <para>Indicates CPU or GPU compatibility.</para><ul><li><para><code>CPU</code>: The image version is compatible with CPU.</para></li><li><para><code>GPU</code>: The image version is compatible with GPU.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SageMaker.Processor")]
        public Amazon.SageMaker.Processor Processor { get; set; }
        #endregion
        
        #region Parameter ProgrammingLang
        /// <summary>
        /// <para>
        /// <para>The supported programming language and its version.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ProgrammingLang { get; set; }
        #endregion
        
        #region Parameter ReleaseNote
        /// <summary>
        /// <para>
        /// <para>The maintainer description of the image version.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ReleaseNotes")]
        public System.String ReleaseNote { get; set; }
        #endregion
        
        #region Parameter VendorGuidance
        /// <summary>
        /// <para>
        /// <para>The stability of the image version, specified by the maintainer.</para><ul><li><para><code>NOT_PROVIDED</code>: The maintainers did not provide a status for image version
        /// stability.</para></li><li><para><code>STABLE</code>: The image version is stable.</para></li><li><para><code>TO_BE_ARCHIVED</code>: The image version is set to be archived. Custom image
        /// versions that are set to be archived are automatically archived after three months.</para></li><li><para><code>ARCHIVED</code>: The image version is archived. Archived image versions are
        /// not searchable and are no longer actively supported. </para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SageMaker.VendorGuidance")]
        public Amazon.SageMaker.VendorGuidance VendorGuidance { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique ID. If not specified, the Amazon Web Services CLI and Amazon Web Services
        /// SDKs, such as the SDK for Python (Boto3), add a unique value to the call.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ImageVersionArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SageMaker.Model.CreateImageVersionResponse).
        /// Specifying the name of a property of type Amazon.SageMaker.Model.CreateImageVersionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ImageVersionArn";
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ImageName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SMImageVersion (CreateImageVersion)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SageMaker.Model.CreateImageVersionResponse, NewSMImageVersionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.Alias != null)
            {
                context.Alias = new List<System.String>(this.Alias);
            }
            context.BaseImage = this.BaseImage;
            #if MODULAR
            if (this.BaseImage == null && ParameterWasBound(nameof(this.BaseImage)))
            {
                WriteWarning("You are passing $null as a value for parameter BaseImage which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ClientToken = this.ClientToken;
            context.Horovod = this.Horovod;
            context.ImageName = this.ImageName;
            #if MODULAR
            if (this.ImageName == null && ParameterWasBound(nameof(this.ImageName)))
            {
                WriteWarning("You are passing $null as a value for parameter ImageName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.JobType = this.JobType;
            context.MLFramework = this.MLFramework;
            context.Processor = this.Processor;
            context.ProgrammingLang = this.ProgrammingLang;
            context.ReleaseNote = this.ReleaseNote;
            context.VendorGuidance = this.VendorGuidance;
            
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
            var request = new Amazon.SageMaker.Model.CreateImageVersionRequest();
            
            if (cmdletContext.Alias != null)
            {
                request.Aliases = cmdletContext.Alias;
            }
            if (cmdletContext.BaseImage != null)
            {
                request.BaseImage = cmdletContext.BaseImage;
            }
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.Horovod != null)
            {
                request.Horovod = cmdletContext.Horovod.Value;
            }
            if (cmdletContext.ImageName != null)
            {
                request.ImageName = cmdletContext.ImageName;
            }
            if (cmdletContext.JobType != null)
            {
                request.JobType = cmdletContext.JobType;
            }
            if (cmdletContext.MLFramework != null)
            {
                request.MLFramework = cmdletContext.MLFramework;
            }
            if (cmdletContext.Processor != null)
            {
                request.Processor = cmdletContext.Processor;
            }
            if (cmdletContext.ProgrammingLang != null)
            {
                request.ProgrammingLang = cmdletContext.ProgrammingLang;
            }
            if (cmdletContext.ReleaseNote != null)
            {
                request.ReleaseNotes = cmdletContext.ReleaseNote;
            }
            if (cmdletContext.VendorGuidance != null)
            {
                request.VendorGuidance = cmdletContext.VendorGuidance;
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
        
        private Amazon.SageMaker.Model.CreateImageVersionResponse CallAWSServiceOperation(IAmazonSageMaker client, Amazon.SageMaker.Model.CreateImageVersionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon SageMaker Service", "CreateImageVersion");
            try
            {
                #if DESKTOP
                return client.CreateImageVersion(request);
                #elif CORECLR
                return client.CreateImageVersionAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> Alias { get; set; }
            public System.String BaseImage { get; set; }
            public System.String ClientToken { get; set; }
            public System.Boolean? Horovod { get; set; }
            public System.String ImageName { get; set; }
            public Amazon.SageMaker.JobType JobType { get; set; }
            public System.String MLFramework { get; set; }
            public Amazon.SageMaker.Processor Processor { get; set; }
            public System.String ProgrammingLang { get; set; }
            public System.String ReleaseNote { get; set; }
            public Amazon.SageMaker.VendorGuidance VendorGuidance { get; set; }
            public System.Func<Amazon.SageMaker.Model.CreateImageVersionResponse, NewSMImageVersionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ImageVersionArn;
        }
        
    }
}
