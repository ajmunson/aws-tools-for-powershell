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
using Amazon.AccessAnalyzer;
using Amazon.AccessAnalyzer.Model;

namespace Amazon.PowerShell.Cmdlets.IAMAA
{
    /// <summary>
    /// Retrieves a list of findings generated by the specified analyzer.
    /// 
    ///  
    /// <para>
    /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">Access
    /// Analyzer filter keys</a> in the <b>IAM User Guide</b>.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "IAMAAFindingList")]
    [OutputType("Amazon.AccessAnalyzer.Model.FindingSummary")]
    [AWSCmdlet("Calls the AWS IAM Access Analyzer ListFindings API operation.", Operation = new[] {"ListFindings"}, SelectReturnType = typeof(Amazon.AccessAnalyzer.Model.ListFindingsResponse))]
    [AWSCmdletOutput("Amazon.AccessAnalyzer.Model.FindingSummary or Amazon.AccessAnalyzer.Model.ListFindingsResponse",
        "This cmdlet returns a collection of Amazon.AccessAnalyzer.Model.FindingSummary objects.",
        "The service call response (type Amazon.AccessAnalyzer.Model.ListFindingsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetIAMAAFindingListCmdlet : AmazonAccessAnalyzerClientCmdlet, IExecutor
    {
        
        #region Parameter AnalyzerArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the analyzer to retrieve findings from.</para>
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
        public System.String AnalyzerArn { get; set; }
        #endregion
        
        #region Parameter Sort_AttributeName
        /// <summary>
        /// <para>
        /// <para>The name of the attribute to sort on.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Sort_AttributeName { get; set; }
        #endregion
        
        #region Parameter Filter
        /// <summary>
        /// <para>
        /// <para>A filter to match for the findings to return.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Collections.Hashtable Filter { get; set; }
        #endregion
        
        #region Parameter Sort_OrderBy
        /// <summary>
        /// <para>
        /// <para>The sort order, ascending or descending.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AccessAnalyzer.OrderBy")]
        public Amazon.AccessAnalyzer.OrderBy Sort_OrderBy { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of results to return in the response.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>A token used for pagination of results returned.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Findings'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AccessAnalyzer.Model.ListFindingsResponse).
        /// Specifying the name of a property of type Amazon.AccessAnalyzer.Model.ListFindingsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Findings";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AnalyzerArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AnalyzerArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AnalyzerArn' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AccessAnalyzer.Model.ListFindingsResponse, GetIAMAAFindingListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AnalyzerArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AnalyzerArn = this.AnalyzerArn;
            #if MODULAR
            if (this.AnalyzerArn == null && ParameterWasBound(nameof(this.AnalyzerArn)))
            {
                WriteWarning("You are passing $null as a value for parameter AnalyzerArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Filter != null)
            {
                context.Filter = new Dictionary<System.String, Amazon.AccessAnalyzer.Model.Criterion>(StringComparer.Ordinal);
                foreach (var hashKey in this.Filter.Keys)
                {
                    context.Filter.Add((String)hashKey, (Criterion)(this.Filter[hashKey]));
                }
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            context.Sort_AttributeName = this.Sort_AttributeName;
            context.Sort_OrderBy = this.Sort_OrderBy;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
            // create request and set iteration invariants
            var request = new Amazon.AccessAnalyzer.Model.ListFindingsRequest();
            
            if (cmdletContext.AnalyzerArn != null)
            {
                request.AnalyzerArn = cmdletContext.AnalyzerArn;
            }
            if (cmdletContext.Filter != null)
            {
                request.Filter = cmdletContext.Filter;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            
             // populate Sort
            var requestSortIsNull = true;
            request.Sort = new Amazon.AccessAnalyzer.Model.SortCriteria();
            System.String requestSort_sort_AttributeName = null;
            if (cmdletContext.Sort_AttributeName != null)
            {
                requestSort_sort_AttributeName = cmdletContext.Sort_AttributeName;
            }
            if (requestSort_sort_AttributeName != null)
            {
                request.Sort.AttributeName = requestSort_sort_AttributeName;
                requestSortIsNull = false;
            }
            Amazon.AccessAnalyzer.OrderBy requestSort_sort_OrderBy = null;
            if (cmdletContext.Sort_OrderBy != null)
            {
                requestSort_sort_OrderBy = cmdletContext.Sort_OrderBy;
            }
            if (requestSort_sort_OrderBy != null)
            {
                request.Sort.OrderBy = requestSort_sort_OrderBy;
                requestSortIsNull = false;
            }
             // determine if request.Sort should be set to null
            if (requestSortIsNull)
            {
                request.Sort = null;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.AccessAnalyzer.Model.ListFindingsResponse CallAWSServiceOperation(IAmazonAccessAnalyzer client, Amazon.AccessAnalyzer.Model.ListFindingsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IAM Access Analyzer", "ListFindings");
            try
            {
                #if DESKTOP
                return client.ListFindings(request);
                #elif CORECLR
                return client.ListFindingsAsync(request).GetAwaiter().GetResult();
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
            public System.String AnalyzerArn { get; set; }
            public Dictionary<System.String, Amazon.AccessAnalyzer.Model.Criterion> Filter { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.String Sort_AttributeName { get; set; }
            public Amazon.AccessAnalyzer.OrderBy Sort_OrderBy { get; set; }
            public System.Func<Amazon.AccessAnalyzer.Model.ListFindingsResponse, GetIAMAAFindingListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Findings;
        }
        
    }
}
