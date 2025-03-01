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
using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

namespace Amazon.PowerShell.Cmdlets.AS
{
    /// <summary>
    /// Describes the available types of lifecycle hooks.
    /// 
    ///  
    /// <para>
    /// The following hook types are supported:
    /// </para><ul><li><para><code>autoscaling:EC2_INSTANCE_LAUNCHING</code></para></li><li><para><code>autoscaling:EC2_INSTANCE_TERMINATING</code></para></li></ul>
    /// </summary>
    [Cmdlet("Get", "ASLifecycleHookType")]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Auto Scaling DescribeLifecycleHookTypes API operation.", Operation = new[] {"DescribeLifecycleHookTypes"}, SelectReturnType = typeof(Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse), LegacyAlias="Get-ASLifecycleHookTypes")]
    [AWSCmdletOutput("System.String or Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse",
        "This cmdlet returns a collection of System.String objects.",
        "The service call response (type Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetASLifecycleHookTypeCmdlet : AmazonAutoScalingClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'LifecycleHookTypes'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse).
        /// Specifying the name of a property of type Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "LifecycleHookTypes";
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
                context.Select = CreateSelectDelegate<Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse, GetASLifecycleHookTypeCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            
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
            var request = new Amazon.AutoScaling.Model.DescribeLifecycleHookTypesRequest();
            
            
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
        
        private Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse CallAWSServiceOperation(IAmazonAutoScaling client, Amazon.AutoScaling.Model.DescribeLifecycleHookTypesRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Auto Scaling", "DescribeLifecycleHookTypes");
            try
            {
                #if DESKTOP
                return client.DescribeLifecycleHookTypes(request);
                #elif CORECLR
                return client.DescribeLifecycleHookTypesAsync(request).GetAwaiter().GetResult();
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
            public System.Func<Amazon.AutoScaling.Model.DescribeLifecycleHookTypesResponse, GetASLifecycleHookTypeCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.LifecycleHookTypes;
        }
        
    }
}
