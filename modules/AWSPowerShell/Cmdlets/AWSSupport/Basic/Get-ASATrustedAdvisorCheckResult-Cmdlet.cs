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
using Amazon.AWSSupport;
using Amazon.AWSSupport.Model;

namespace Amazon.PowerShell.Cmdlets.ASA
{
    /// <summary>
    /// Returns the results of the Trusted Advisor check that has the specified check ID.
    /// You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a> operation.
    /// 
    ///  
    /// <para>
    /// The response contains a <a>TrustedAdvisorCheckResult</a> object, which contains these
    /// three objects:
    /// </para><ul><li><para><a>TrustedAdvisorCategorySpecificSummary</a></para></li><li><para><a>TrustedAdvisorResourceDetail</a></para></li><li><para><a>TrustedAdvisorResourcesSummary</a></para></li></ul><para>
    /// In addition, the response contains these fields:
    /// </para><ul><li><para><b>status</b> - The alert status of the check can be <code>ok</code> (green), <code>warning</code>
    /// (yellow), <code>error</code> (red), or <code>not_available</code>.
    /// </para></li><li><para><b>timestamp</b> - The time of the last refresh of the check.
    /// </para></li><li><para><b>checkId</b> - The unique identifier for the check.
    /// </para></li></ul><note><ul><li><para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para></li><li><para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para></li></ul></note><para>
    /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
    /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
    /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
    /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
    /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
    /// Guide</i>.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "ASATrustedAdvisorCheckResult")]
    [OutputType("Amazon.AWSSupport.Model.TrustedAdvisorCheckResult")]
    [AWSCmdlet("Calls the AWS Support DescribeTrustedAdvisorCheckResult API operation.", Operation = new[] {"DescribeTrustedAdvisorCheckResult"}, SelectReturnType = typeof(Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse))]
    [AWSCmdletOutput("Amazon.AWSSupport.Model.TrustedAdvisorCheckResult or Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse",
        "This cmdlet returns an Amazon.AWSSupport.Model.TrustedAdvisorCheckResult object.",
        "The service call response (type Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetASATrustedAdvisorCheckResultCmdlet : AmazonAWSSupportClientCmdlet, IExecutor
    {
        
        #region Parameter CheckId
        /// <summary>
        /// <para>
        /// <para>The unique identifier for the Trusted Advisor check.</para>
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
        public System.String CheckId { get; set; }
        #endregion
        
        #region Parameter Language
        /// <summary>
        /// <para>
        /// <para>The ISO 639-1 code for the language that you want your check results to appear in.</para><para>The Amazon Web Services Support API currently supports the following languages for
        /// Trusted Advisor:</para><ul><li><para>Chinese, Simplified - <code>zh</code></para></li><li><para>Chinese, Traditional - <code>zh_TW</code></para></li><li><para>English - <code>en</code></para></li><li><para>French - <code>fr</code></para></li><li><para>German - <code>de</code></para></li><li><para>Indonesian - <code>id</code></para></li><li><para>Italian - <code>it</code></para></li><li><para>Japanese - <code>ja</code></para></li><li><para>Korean - <code>ko</code></para></li><li><para>Portuguese, Brazilian - <code>pt_BR</code></para></li><li><para>Spanish - <code>es</code></para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        public System.String Language { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Result'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse).
        /// Specifying the name of a property of type Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Result";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the CheckId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^CheckId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^CheckId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse, GetASATrustedAdvisorCheckResultCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.CheckId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CheckId = this.CheckId;
            #if MODULAR
            if (this.CheckId == null && ParameterWasBound(nameof(this.CheckId)))
            {
                WriteWarning("You are passing $null as a value for parameter CheckId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Language = this.Language;
            
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
            var request = new Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultRequest();
            
            if (cmdletContext.CheckId != null)
            {
                request.CheckId = cmdletContext.CheckId;
            }
            if (cmdletContext.Language != null)
            {
                request.Language = cmdletContext.Language;
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
        
        private Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse CallAWSServiceOperation(IAmazonAWSSupport client, Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Support", "DescribeTrustedAdvisorCheckResult");
            try
            {
                #if DESKTOP
                return client.DescribeTrustedAdvisorCheckResult(request);
                #elif CORECLR
                return client.DescribeTrustedAdvisorCheckResultAsync(request).GetAwaiter().GetResult();
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
            public System.String CheckId { get; set; }
            public System.String Language { get; set; }
            public System.Func<Amazon.AWSSupport.Model.DescribeTrustedAdvisorCheckResultResponse, GetASATrustedAdvisorCheckResultCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Result;
        }
        
    }
}
