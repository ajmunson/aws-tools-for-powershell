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
using Amazon.KendraRanking;
using Amazon.KendraRanking.Model;

namespace Amazon.PowerShell.Cmdlets.KNRK
{
    /// <summary>
    /// Rescores or re-ranks search results from a search service such as OpenSearch (self
    /// managed). You use the semantic search capabilities of Amazon Kendra Intelligent Ranking
    /// to improve the search service's results.
    /// </summary>
    [Cmdlet("Invoke", "KNRKRescore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.KendraRanking.Model.RescoreResponse")]
    [AWSCmdlet("Calls the Amazon Kendra Intelligent Ranking Rescore API operation.", Operation = new[] {"Rescore"}, SelectReturnType = typeof(Amazon.KendraRanking.Model.RescoreResponse))]
    [AWSCmdletOutput("Amazon.KendraRanking.Model.RescoreResponse",
        "This cmdlet returns an Amazon.KendraRanking.Model.RescoreResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class InvokeKNRKRescoreCmdlet : AmazonKendraRankingClientCmdlet, IExecutor
    {
        
        #region Parameter Document
        /// <summary>
        /// <para>
        /// <para>The list of documents for Amazon Kendra Intelligent Ranking to rescore or rank on.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("Documents")]
        public Amazon.KendraRanking.Model.Document[] Document { get; set; }
        #endregion
        
        #region Parameter RescoreExecutionPlanId
        /// <summary>
        /// <para>
        /// <para>The identifier of the rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// API.</para>
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
        public System.String RescoreExecutionPlanId { get; set; }
        #endregion
        
        #region Parameter SearchQuery
        /// <summary>
        /// <para>
        /// <para>The input query from the search service.</para>
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
        public System.String SearchQuery { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.KendraRanking.Model.RescoreResponse).
        /// Specifying the name of a property of type Amazon.KendraRanking.Model.RescoreResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the RescoreExecutionPlanId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^RescoreExecutionPlanId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^RescoreExecutionPlanId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.RescoreExecutionPlanId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Invoke-KNRKRescore (Rescore)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.KendraRanking.Model.RescoreResponse, InvokeKNRKRescoreCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.RescoreExecutionPlanId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Document != null)
            {
                context.Document = new List<Amazon.KendraRanking.Model.Document>(this.Document);
            }
            #if MODULAR
            if (this.Document == null && ParameterWasBound(nameof(this.Document)))
            {
                WriteWarning("You are passing $null as a value for parameter Document which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RescoreExecutionPlanId = this.RescoreExecutionPlanId;
            #if MODULAR
            if (this.RescoreExecutionPlanId == null && ParameterWasBound(nameof(this.RescoreExecutionPlanId)))
            {
                WriteWarning("You are passing $null as a value for parameter RescoreExecutionPlanId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SearchQuery = this.SearchQuery;
            #if MODULAR
            if (this.SearchQuery == null && ParameterWasBound(nameof(this.SearchQuery)))
            {
                WriteWarning("You are passing $null as a value for parameter SearchQuery which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.KendraRanking.Model.RescoreRequest();
            
            if (cmdletContext.Document != null)
            {
                request.Documents = cmdletContext.Document;
            }
            if (cmdletContext.RescoreExecutionPlanId != null)
            {
                request.RescoreExecutionPlanId = cmdletContext.RescoreExecutionPlanId;
            }
            if (cmdletContext.SearchQuery != null)
            {
                request.SearchQuery = cmdletContext.SearchQuery;
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
        
        private Amazon.KendraRanking.Model.RescoreResponse CallAWSServiceOperation(IAmazonKendraRanking client, Amazon.KendraRanking.Model.RescoreRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Kendra Intelligent Ranking", "Rescore");
            try
            {
                #if DESKTOP
                return client.Rescore(request);
                #elif CORECLR
                return client.RescoreAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.KendraRanking.Model.Document> Document { get; set; }
            public System.String RescoreExecutionPlanId { get; set; }
            public System.String SearchQuery { get; set; }
            public System.Func<Amazon.KendraRanking.Model.RescoreResponse, InvokeKNRKRescoreCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
