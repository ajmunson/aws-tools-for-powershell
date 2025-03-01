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
using Amazon.SecurityLake;
using Amazon.SecurityLake.Model;

namespace Amazon.PowerShell.Cmdlets.SLK
{
    /// <summary>
    /// Retrieves the log sources in the current Amazon Web Services Region.
    /// </summary>
    [Cmdlet("Get", "SLKLogSourceList")]
    [OutputType("System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>>")]
    [AWSCmdlet("Calls the Amazon Security Lake ListLogSources API operation.", Operation = new[] {"ListLogSources"}, SelectReturnType = typeof(Amazon.SecurityLake.Model.ListLogSourcesResponse))]
    [AWSCmdletOutput("System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>> or Amazon.SecurityLake.Model.ListLogSourcesResponse",
        "This cmdlet returns a collection of Dictionary<System.String, Dictionary<System.String, List<System.String>>> objects.",
        "The service call response (type Amazon.SecurityLake.Model.ListLogSourcesResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetSLKLogSourceListCmdlet : AmazonSecurityLakeClientCmdlet, IExecutor
    {
        
        #region Parameter InputOrder
        /// <summary>
        /// <para>
        /// <para>Lists the log sources in input order, namely Region, source type, and member account.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] InputOrder { get; set; }
        #endregion
        
        #region Parameter ListAllDimension
        /// <summary>
        /// <para>
        /// <para>List the view of log sources for enabled Amazon Security Lake accounts for specific
        /// Amazon Web Services sources from specific accounts and specific Regions.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ListAllDimensions")]
        public System.Collections.Hashtable ListAllDimension { get; set; }
        #endregion
        
        #region Parameter ListSingleDimension
        /// <summary>
        /// <para>
        /// <para>List the view of log sources for enabled Security Lake accounts for all Amazon Web
        /// Services sources from specific accounts or specific Regions.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] ListSingleDimension { get; set; }
        #endregion
        
        #region Parameter ListTwoDimension
        /// <summary>
        /// <para>
        /// <para>Lists the view of log sources for enabled Security Lake accounts for specific Amazon
        /// Web Services sources from specific accounts or specific Regions.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ListTwoDimensions")]
        public System.Collections.Hashtable ListTwoDimension { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of accounts for which the log sources are displayed.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>If nextToken is returned, there are more results available. You can repeat the call
        /// using the returned token to retrieve the next page.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'RegionSourceTypesAccountsList'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecurityLake.Model.ListLogSourcesResponse).
        /// Specifying the name of a property of type Amazon.SecurityLake.Model.ListLogSourcesResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "RegionSourceTypesAccountsList";
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecurityLake.Model.ListLogSourcesResponse, GetSLKLogSourceListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.InputOrder != null)
            {
                context.InputOrder = new List<System.String>(this.InputOrder);
            }
            if (this.ListAllDimension != null)
            {
                context.ListAllDimension = new Dictionary<System.String, Dictionary<System.String, List<System.String>>>(StringComparer.Ordinal);
                foreach (var hashKey in this.ListAllDimension.Keys)
                {
                    context.ListAllDimension.Add((String)hashKey, (Dictionary<String,List<String>>)(this.ListAllDimension[hashKey]));
                }
            }
            if (this.ListSingleDimension != null)
            {
                context.ListSingleDimension = new List<System.String>(this.ListSingleDimension);
            }
            if (this.ListTwoDimension != null)
            {
                context.ListTwoDimension = new Dictionary<System.String, List<System.String>>(StringComparer.Ordinal);
                foreach (var hashKey in this.ListTwoDimension.Keys)
                {
                    object hashValue = this.ListTwoDimension[hashKey];
                    if (hashValue == null)
                    {
                        context.ListTwoDimension.Add((String)hashKey, null);
                        continue;
                    }
                    var enumerable = SafeEnumerable(hashValue);
                    var valueSet = new List<System.String>();
                    foreach (var s in enumerable)
                    {
                        valueSet.Add((System.String)s);
                    }
                    context.ListTwoDimension.Add((String)hashKey, valueSet);
                }
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            
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
            var request = new Amazon.SecurityLake.Model.ListLogSourcesRequest();
            
            if (cmdletContext.InputOrder != null)
            {
                request.InputOrder = cmdletContext.InputOrder;
            }
            if (cmdletContext.ListAllDimension != null)
            {
                request.ListAllDimensions = cmdletContext.ListAllDimension;
            }
            if (cmdletContext.ListSingleDimension != null)
            {
                request.ListSingleDimension = cmdletContext.ListSingleDimension;
            }
            if (cmdletContext.ListTwoDimension != null)
            {
                request.ListTwoDimensions = cmdletContext.ListTwoDimension;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
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
        
        private Amazon.SecurityLake.Model.ListLogSourcesResponse CallAWSServiceOperation(IAmazonSecurityLake client, Amazon.SecurityLake.Model.ListLogSourcesRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Security Lake", "ListLogSources");
            try
            {
                #if DESKTOP
                return client.ListLogSources(request);
                #elif CORECLR
                return client.ListLogSourcesAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> InputOrder { get; set; }
            public Dictionary<System.String, Dictionary<System.String, List<System.String>>> ListAllDimension { get; set; }
            public List<System.String> ListSingleDimension { get; set; }
            public Dictionary<System.String, List<System.String>> ListTwoDimension { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.SecurityLake.Model.ListLogSourcesResponse, GetSLKLogSourceListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.RegionSourceTypesAccountsList;
        }
        
    }
}
