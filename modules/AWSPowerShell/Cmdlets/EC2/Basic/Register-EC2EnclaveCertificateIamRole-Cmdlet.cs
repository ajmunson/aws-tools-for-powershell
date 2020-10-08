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
using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.PowerShell.Cmdlets.EC2
{
    /// <summary>
    /// Associates an AWS Identity and Access Management (IAM) role with an AWS Certificate
    /// Manager (ACM) certificate. This enables the certificate to be used by the ACM for
    /// Nitro Enclaves application inside an enclave. For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-refapp.html">AWS
    /// Certificate Manager for Nitro Enclaves</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When the IAM role is associated with the ACM certificate, places the certificate,
    /// certificate chain, and encrypted private key in an Amazon S3 bucket that only the
    /// associated IAM role can access. The private key of the certificate is encrypted with
    /// an AWS-managed KMS key that has an attached attestation-based key policy.
    /// </para><para>
    /// To enable the IAM role to access the Amazon S3 object, you must grant it permission
    /// to call <code>s3:GetObject</code> on the Amazon S3 bucket returned by the command.
    /// To enable the IAM role to access the AWS KMS key, you must grant it permission to
    /// call <code>kms:Decrypt</code> on AWS KMS key returned by the command. For more information,
    /// see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-refapp.html#add-policy">
    /// Grant the role permission to access the certificate and encryption key</a> in the
    /// <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    [Cmdlet("Register", "EC2EnclaveCertificateIamRole", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse")]
    [AWSCmdlet("Calls the Amazon Elastic Compute Cloud (EC2) AssociateEnclaveCertificateIamRole API operation.", Operation = new[] {"AssociateEnclaveCertificateIamRole"}, SelectReturnType = typeof(Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse))]
    [AWSCmdletOutput("Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse",
        "This cmdlet returns an Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RegisterEC2EnclaveCertificateIamRoleCmdlet : AmazonEC2ClientCmdlet, IExecutor
    {
        
        #region Parameter CertificateArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the ACM certificate with which to associate the IAM role.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String CertificateArn { get; set; }
        #endregion
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the IAM role to associate with the ACM certificate. You can associate up
        /// to 16 IAM roles with an ACM certificate.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse).
        /// Specifying the name of a property of type Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the CertificateArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^CertificateArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^CertificateArn' instead. This parameter will be removed in a future version.")]
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
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.CertificateArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Register-EC2EnclaveCertificateIamRole (AssociateEnclaveCertificateIamRole)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse, RegisterEC2EnclaveCertificateIamRoleCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.CertificateArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CertificateArn = this.CertificateArn;
            context.RoleArn = this.RoleArn;
            
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
            var request = new Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleRequest();
            
            if (cmdletContext.CertificateArn != null)
            {
                request.CertificateArn = cmdletContext.CertificateArn;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
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
        
        private Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse CallAWSServiceOperation(IAmazonEC2 client, Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Elastic Compute Cloud (EC2)", "AssociateEnclaveCertificateIamRole");
            try
            {
                #if DESKTOP
                return client.AssociateEnclaveCertificateIamRole(request);
                #elif CORECLR
                return client.AssociateEnclaveCertificateIamRoleAsync(request).GetAwaiter().GetResult();
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
            public System.String CertificateArn { get; set; }
            public System.String RoleArn { get; set; }
            public System.Func<Amazon.EC2.Model.AssociateEnclaveCertificateIamRoleResponse, RegisterEC2EnclaveCertificateIamRoleCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
