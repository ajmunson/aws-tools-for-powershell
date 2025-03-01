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
using Amazon.CloudTrail;
using Amazon.CloudTrail.Model;

namespace Amazon.PowerShell.Cmdlets.CT
{
    /// <summary>
    /// Updates an event data store. The required <code>EventDataStore</code> value is an
    /// ARN or the ID portion of the ARN. Other parameters are optional, but at least one
    /// optional parameter must be specified, or CloudTrail throws an error. <code>RetentionPeriod</code>
    /// is in days, and valid values are integers between 90 and 2557. By default, <code>TerminationProtection</code>
    /// is enabled.
    /// 
    ///  
    /// <para>
    /// For event data stores for CloudTrail events, <code>AdvancedEventSelectors</code> includes
    /// or excludes management and data events in your event data store. For more information
    /// about <code>AdvancedEventSelectors</code>, see <a>PutEventSelectorsRequest$AdvancedEventSelectors</a>.
    /// 
    /// </para><para>
    ///  For event data stores for Config configuration items, Audit Manager evidence, or
    /// non-Amazon Web Services events, <code>AdvancedEventSelectors</code> includes events
    /// of that type in your event data store.
    /// </para>
    /// </summary>
    [Cmdlet("Update", "CTEventDataStore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.CloudTrail.Model.UpdateEventDataStoreResponse")]
    [AWSCmdlet("Calls the AWS CloudTrail UpdateEventDataStore API operation.", Operation = new[] {"UpdateEventDataStore"}, SelectReturnType = typeof(Amazon.CloudTrail.Model.UpdateEventDataStoreResponse))]
    [AWSCmdletOutput("Amazon.CloudTrail.Model.UpdateEventDataStoreResponse",
        "This cmdlet returns an Amazon.CloudTrail.Model.UpdateEventDataStoreResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateCTEventDataStoreCmdlet : AmazonCloudTrailClientCmdlet, IExecutor
    {
        
        #region Parameter AdvancedEventSelector
        /// <summary>
        /// <para>
        /// <para>The advanced event selectors used to select events for the event data store. You can
        /// configure up to five advanced event selectors for each event data store.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AdvancedEventSelectors")]
        public Amazon.CloudTrail.Model.AdvancedEventSelector[] AdvancedEventSelector { get; set; }
        #endregion
        
        #region Parameter EventDataStore
        /// <summary>
        /// <para>
        /// <para>The ARN (or the ID suffix of the ARN) of the event data store that you want to update.</para>
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
        public System.String EventDataStore { get; set; }
        #endregion
        
        #region Parameter KmsKeyId
        /// <summary>
        /// <para>
        /// <para>Specifies the KMS key ID to use to encrypt the events delivered by CloudTrail. The
        /// value can be an alias name prefixed by <code>alias/</code>, a fully specified ARN
        /// to an alias, a fully specified ARN to a key, or a globally unique identifier.</para><important><para>Disabling or deleting the KMS key, or removing CloudTrail permissions on the key,
        /// prevents CloudTrail from logging events to the event data store, and prevents users
        /// from querying the data in the event data store that was encrypted with the key. After
        /// you associate an event data store with a KMS key, the KMS key cannot be removed or
        /// changed. Before you disable or delete a KMS key that you are using with an event data
        /// store, delete or back up your event data store.</para></important><para>CloudTrail also supports KMS multi-Region keys. For more information about multi-Region
        /// keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.</para><para>Examples:</para><ul><li><para><code>alias/MyAliasName</code></para></li><li><para><code>arn:aws:kms:us-east-2:123456789012:alias/MyAliasName</code></para></li><li><para><code>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</code></para></li><li><para><code>12345678-1234-1234-1234-123456789012</code></para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KmsKeyId { get; set; }
        #endregion
        
        #region Parameter MultiRegionEnabled
        /// <summary>
        /// <para>
        /// <para>Specifies whether an event data store collects events from all regions, or only from
        /// the region in which it was created.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? MultiRegionEnabled { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The event data store name.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter OrganizationEnabled
        /// <summary>
        /// <para>
        /// <para>Specifies whether an event data store collects events logged for an organization in
        /// Organizations.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? OrganizationEnabled { get; set; }
        #endregion
        
        #region Parameter RetentionPeriod
        /// <summary>
        /// <para>
        /// <para>The retention period, in days.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? RetentionPeriod { get; set; }
        #endregion
        
        #region Parameter TerminationProtectionEnabled
        /// <summary>
        /// <para>
        /// <para>Indicates that termination protection is enabled and the event data store cannot be
        /// automatically deleted.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? TerminationProtectionEnabled { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CloudTrail.Model.UpdateEventDataStoreResponse).
        /// Specifying the name of a property of type Amazon.CloudTrail.Model.UpdateEventDataStoreResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-CTEventDataStore (UpdateEventDataStore)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CloudTrail.Model.UpdateEventDataStoreResponse, UpdateCTEventDataStoreCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.AdvancedEventSelector != null)
            {
                context.AdvancedEventSelector = new List<Amazon.CloudTrail.Model.AdvancedEventSelector>(this.AdvancedEventSelector);
            }
            context.EventDataStore = this.EventDataStore;
            #if MODULAR
            if (this.EventDataStore == null && ParameterWasBound(nameof(this.EventDataStore)))
            {
                WriteWarning("You are passing $null as a value for parameter EventDataStore which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.KmsKeyId = this.KmsKeyId;
            context.MultiRegionEnabled = this.MultiRegionEnabled;
            context.Name = this.Name;
            context.OrganizationEnabled = this.OrganizationEnabled;
            context.RetentionPeriod = this.RetentionPeriod;
            context.TerminationProtectionEnabled = this.TerminationProtectionEnabled;
            
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
            var request = new Amazon.CloudTrail.Model.UpdateEventDataStoreRequest();
            
            if (cmdletContext.AdvancedEventSelector != null)
            {
                request.AdvancedEventSelectors = cmdletContext.AdvancedEventSelector;
            }
            if (cmdletContext.EventDataStore != null)
            {
                request.EventDataStore = cmdletContext.EventDataStore;
            }
            if (cmdletContext.KmsKeyId != null)
            {
                request.KmsKeyId = cmdletContext.KmsKeyId;
            }
            if (cmdletContext.MultiRegionEnabled != null)
            {
                request.MultiRegionEnabled = cmdletContext.MultiRegionEnabled.Value;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.OrganizationEnabled != null)
            {
                request.OrganizationEnabled = cmdletContext.OrganizationEnabled.Value;
            }
            if (cmdletContext.RetentionPeriod != null)
            {
                request.RetentionPeriod = cmdletContext.RetentionPeriod.Value;
            }
            if (cmdletContext.TerminationProtectionEnabled != null)
            {
                request.TerminationProtectionEnabled = cmdletContext.TerminationProtectionEnabled.Value;
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
        
        private Amazon.CloudTrail.Model.UpdateEventDataStoreResponse CallAWSServiceOperation(IAmazonCloudTrail client, Amazon.CloudTrail.Model.UpdateEventDataStoreRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS CloudTrail", "UpdateEventDataStore");
            try
            {
                #if DESKTOP
                return client.UpdateEventDataStore(request);
                #elif CORECLR
                return client.UpdateEventDataStoreAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.CloudTrail.Model.AdvancedEventSelector> AdvancedEventSelector { get; set; }
            public System.String EventDataStore { get; set; }
            public System.String KmsKeyId { get; set; }
            public System.Boolean? MultiRegionEnabled { get; set; }
            public System.String Name { get; set; }
            public System.Boolean? OrganizationEnabled { get; set; }
            public System.Int32? RetentionPeriod { get; set; }
            public System.Boolean? TerminationProtectionEnabled { get; set; }
            public System.Func<Amazon.CloudTrail.Model.UpdateEventDataStoreResponse, UpdateCTEventDataStoreCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
