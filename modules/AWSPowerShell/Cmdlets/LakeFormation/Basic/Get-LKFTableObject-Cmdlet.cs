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
using Amazon.LakeFormation;
using Amazon.LakeFormation.Model;

namespace Amazon.PowerShell.Cmdlets.LKF
{
    /// <summary>
    /// Returns the set of Amazon S3 objects that make up the specified governed table. A
    /// transaction ID or timestamp can be specified for time-travel queries.<br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "LKFTableObject")]
    [OutputType("Amazon.LakeFormation.Model.PartitionObjects")]
    [AWSCmdlet("Calls the AWS Lake Formation GetTableObjects API operation.", Operation = new[] {"GetTableObjects"}, SelectReturnType = typeof(Amazon.LakeFormation.Model.GetTableObjectsResponse))]
    [AWSCmdletOutput("Amazon.LakeFormation.Model.PartitionObjects or Amazon.LakeFormation.Model.GetTableObjectsResponse",
        "This cmdlet returns a collection of Amazon.LakeFormation.Model.PartitionObjects objects.",
        "The service call response (type Amazon.LakeFormation.Model.GetTableObjectsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetLKFTableObjectCmdlet : AmazonLakeFormationClientCmdlet, IExecutor
    {
        
        #region Parameter CatalogId
        /// <summary>
        /// <para>
        /// <para>The catalog containing the governed table. Defaults to the caller’s account.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CatalogId { get; set; }
        #endregion
        
        #region Parameter DatabaseName
        /// <summary>
        /// <para>
        /// <para>The database containing the governed table.</para>
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
        public System.String DatabaseName { get; set; }
        #endregion
        
        #region Parameter PartitionPredicate
        /// <summary>
        /// <para>
        /// <para>A predicate to filter the objects returned based on the partition keys defined in
        /// the governed table.</para><ul><li><para>The comparison operators supported are: =, &gt;, &lt;, &gt;=, &lt;=</para></li><li><para>The logical operators supported are: AND</para></li><li><para>The data types supported are integer, long, date(yyyy-MM-dd), timestamp(yyyy-MM-dd
        /// HH:mm:ssXXX or yyyy-MM-dd HH:mm:ss"), string and decimal.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PartitionPredicate { get; set; }
        #endregion
        
        #region Parameter QueryAsOfTime
        /// <summary>
        /// <para>
        /// <para>The time as of when to read the governed table contents. If not set, the most recent
        /// transaction commit time is used. Cannot be specified along with <code>TransactionId</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.DateTime? QueryAsOfTime { get; set; }
        #endregion
        
        #region Parameter TableName
        /// <summary>
        /// <para>
        /// <para>The governed table for which to retrieve objects.</para>
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
        public System.String TableName { get; set; }
        #endregion
        
        #region Parameter TransactionId
        /// <summary>
        /// <para>
        /// <para>The transaction ID at which to read the governed table contents. If this transaction
        /// has aborted, an error is returned. If not set, defaults to the most recent committed
        /// transaction. Cannot be specified along with <code>QueryAsOfTime</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String TransactionId { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>Specifies how many values to return in a page.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>A continuation token if this is not the first call to retrieve these objects.</para>
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
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Objects'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.LakeFormation.Model.GetTableObjectsResponse).
        /// Specifying the name of a property of type Amazon.LakeFormation.Model.GetTableObjectsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Objects";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the TableName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^TableName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^TableName' instead. This parameter will be removed in a future version.")]
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
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.LakeFormation.Model.GetTableObjectsResponse, GetLKFTableObjectCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.TableName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CatalogId = this.CatalogId;
            context.DatabaseName = this.DatabaseName;
            #if MODULAR
            if (this.DatabaseName == null && ParameterWasBound(nameof(this.DatabaseName)))
            {
                WriteWarning("You are passing $null as a value for parameter DatabaseName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            context.PartitionPredicate = this.PartitionPredicate;
            context.QueryAsOfTime = this.QueryAsOfTime;
            context.TableName = this.TableName;
            #if MODULAR
            if (this.TableName == null && ParameterWasBound(nameof(this.TableName)))
            {
                WriteWarning("You are passing $null as a value for parameter TableName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TransactionId = this.TransactionId;
            
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
            var request = new Amazon.LakeFormation.Model.GetTableObjectsRequest();
            
            if (cmdletContext.CatalogId != null)
            {
                request.CatalogId = cmdletContext.CatalogId;
            }
            if (cmdletContext.DatabaseName != null)
            {
                request.DatabaseName = cmdletContext.DatabaseName;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.PartitionPredicate != null)
            {
                request.PartitionPredicate = cmdletContext.PartitionPredicate;
            }
            if (cmdletContext.QueryAsOfTime != null)
            {
                request.QueryAsOfTime = cmdletContext.QueryAsOfTime.Value;
            }
            if (cmdletContext.TableName != null)
            {
                request.TableName = cmdletContext.TableName;
            }
            if (cmdletContext.TransactionId != null)
            {
                request.TransactionId = cmdletContext.TransactionId;
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
        
        private Amazon.LakeFormation.Model.GetTableObjectsResponse CallAWSServiceOperation(IAmazonLakeFormation client, Amazon.LakeFormation.Model.GetTableObjectsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Lake Formation", "GetTableObjects");
            try
            {
                #if DESKTOP
                return client.GetTableObjects(request);
                #elif CORECLR
                return client.GetTableObjectsAsync(request).GetAwaiter().GetResult();
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
            public System.String CatalogId { get; set; }
            public System.String DatabaseName { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.String PartitionPredicate { get; set; }
            public System.DateTime? QueryAsOfTime { get; set; }
            public System.String TableName { get; set; }
            public System.String TransactionId { get; set; }
            public System.Func<Amazon.LakeFormation.Model.GetTableObjectsResponse, GetLKFTableObjectCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Objects;
        }
        
    }
}
