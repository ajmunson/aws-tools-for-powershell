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
using Amazon.LocationService;
using Amazon.LocationService.Model;

namespace Amazon.PowerShell.Cmdlets.LOC
{
    /// <summary>
    /// Retrieves glyphs used to display labels on a map.
    /// </summary>
    [Cmdlet("Get", "LOCMapGlyph")]
    [OutputType("Amazon.LocationService.Model.GetMapGlyphsResponse")]
    [AWSCmdlet("Calls the Amazon Location Service GetMapGlyphs API operation.", Operation = new[] {"GetMapGlyphs"}, SelectReturnType = typeof(Amazon.LocationService.Model.GetMapGlyphsResponse))]
    [AWSCmdletOutput("Amazon.LocationService.Model.GetMapGlyphsResponse",
        "This cmdlet returns an Amazon.LocationService.Model.GetMapGlyphsResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetLOCMapGlyphCmdlet : AmazonLocationServiceClientCmdlet, IExecutor
    {
        
        #region Parameter FontStack
        /// <summary>
        /// <para>
        /// <para>A comma-separated list of fonts to load glyphs from in order of preference. For example,
        /// <code>Noto Sans Regular, Arial Unicode</code>.</para><para>Valid fonts stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/esri.html">Esri</a>
        /// styles: </para><ul><li><para>VectorEsriDarkGrayCanvas – <code>Ubuntu Medium Italic</code> | <code>Ubuntu Medium</code>
        /// | <code>Ubuntu Italic</code> | <code>Ubuntu Regular</code> | <code>Ubuntu Bold</code></para></li><li><para>VectorEsriLightGrayCanvas – <code>Ubuntu Italic</code> | <code>Ubuntu Regular</code>
        /// | <code>Ubuntu Light</code> | <code>Ubuntu Bold</code></para></li><li><para>VectorEsriTopographic – <code>Noto Sans Italic</code> | <code>Noto Sans Regular</code>
        /// | <code>Noto Sans Bold</code> | <code>Noto Serif Regular</code> | <code>Roboto Condensed
        /// Light Italic</code></para></li><li><para>VectorEsriStreets – <code>Arial Regular</code> | <code>Arial Italic</code> | <code>Arial
        /// Bold</code></para></li><li><para>VectorEsriNavigation – <code>Arial Regular</code> | <code>Arial Italic</code> | <code>Arial
        /// Bold</code></para></li></ul><para>Valid font stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/HERE.html">HERE
        /// Technologies</a> styles:</para><ul><li><para>VectorHereContrast – <code>Fira GO Regular</code> | <code>Fira GO Bold</code></para></li><li><para>VectorHereExplore, VectorHereExploreTruck, HybridHereExploreSatellite – <code>Fira
        /// GO Italic</code> | <code>Fira GO Map</code> | <code>Fira GO Map Bold</code> | <code>Noto
        /// Sans CJK JP Bold</code> | <code>Noto Sans CJK JP Light</code> | <code>Noto Sans CJK
        /// JP Regular</code></para></li></ul><para>Valid font stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/grab.html">GrabMaps</a>
        /// styles:</para><ul><li><para>VectorGrabStandardLight, VectorGrabStandardDark – <code>Noto Sans Regular</code> |
        /// <code>Noto Sans Medium</code> | <code>Noto Sans Bold</code></para></li></ul><para>Valid font stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/open-data.html">Open
        /// Data (Preview)</a> styles:</para><ul><li><para>VectorOpenDataStandardLight – <code>Amazon Ember Regular,Noto Sans Regular</code>
        /// | <code>Amazon Ember Bold,Noto Sans Bold</code> | <code>Amazon Ember Medium,Noto Sans
        /// Medium</code> | <code>Amazon Ember Regular Italic,Noto Sans Italic</code> | <code>Amazon
        /// Ember Condensed RC Regular,Noto Sans Regular</code> | <code>Amazon Ember Condensed
        /// RC Bold,Noto Sans Bold</code></para></li></ul><note><para>The fonts used by <code>VectorOpenDataStandardLight</code> are combined fonts that
        /// use <code>Amazon Ember</code> for most glyphs but <code>Noto Sans</code> for glyphs
        /// unsupported by <code>Amazon Ember</code>.</para></note>
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
        public System.String FontStack { get; set; }
        #endregion
        
        #region Parameter FontUnicodeRange
        /// <summary>
        /// <para>
        /// <para>A Unicode range of characters to download glyphs for. Each response will contain 256
        /// characters. For example, 0–255 includes all characters from range <code>U+0000</code>
        /// to <code>00FF</code>. Must be aligned to multiples of 256.</para>
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
        public System.String FontUnicodeRange { get; set; }
        #endregion
        
        #region Parameter MapName
        /// <summary>
        /// <para>
        /// <para>The map resource associated with the glyph ﬁle.</para>
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
        public System.String MapName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.LocationService.Model.GetMapGlyphsResponse).
        /// Specifying the name of a property of type Amazon.LocationService.Model.GetMapGlyphsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the MapName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^MapName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^MapName' instead. This parameter will be removed in a future version.")]
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
                context.Select = CreateSelectDelegate<Amazon.LocationService.Model.GetMapGlyphsResponse, GetLOCMapGlyphCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.MapName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.FontStack = this.FontStack;
            #if MODULAR
            if (this.FontStack == null && ParameterWasBound(nameof(this.FontStack)))
            {
                WriteWarning("You are passing $null as a value for parameter FontStack which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.FontUnicodeRange = this.FontUnicodeRange;
            #if MODULAR
            if (this.FontUnicodeRange == null && ParameterWasBound(nameof(this.FontUnicodeRange)))
            {
                WriteWarning("You are passing $null as a value for parameter FontUnicodeRange which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MapName = this.MapName;
            #if MODULAR
            if (this.MapName == null && ParameterWasBound(nameof(this.MapName)))
            {
                WriteWarning("You are passing $null as a value for parameter MapName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.LocationService.Model.GetMapGlyphsRequest();
            
            if (cmdletContext.FontStack != null)
            {
                request.FontStack = cmdletContext.FontStack;
            }
            if (cmdletContext.FontUnicodeRange != null)
            {
                request.FontUnicodeRange = cmdletContext.FontUnicodeRange;
            }
            if (cmdletContext.MapName != null)
            {
                request.MapName = cmdletContext.MapName;
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
        
        private Amazon.LocationService.Model.GetMapGlyphsResponse CallAWSServiceOperation(IAmazonLocationService client, Amazon.LocationService.Model.GetMapGlyphsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Location Service", "GetMapGlyphs");
            try
            {
                #if DESKTOP
                return client.GetMapGlyphs(request);
                #elif CORECLR
                return client.GetMapGlyphsAsync(request).GetAwaiter().GetResult();
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
            public System.String FontStack { get; set; }
            public System.String FontUnicodeRange { get; set; }
            public System.String MapName { get; set; }
            public System.Func<Amazon.LocationService.Model.GetMapGlyphsResponse, GetLOCMapGlyphCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
