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
using Amazon.Personalize;
using Amazon.Personalize.Model;

namespace Amazon.PowerShell.Cmdlets.PERS
{
    /// <summary>
    /// Amazon.Personalize.IAmazonPersonalize.CreateSolution
    /// </summary>
    [Cmdlet("New", "PERSSolution", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Personalize CreateSolution API operation.", Operation = new[] {"CreateSolution"}, SelectReturnType = typeof(Amazon.Personalize.Model.CreateSolutionResponse))]
    [AWSCmdletOutput("System.String or Amazon.Personalize.Model.CreateSolutionResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Personalize.Model.CreateSolutionResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewPERSSolutionCmdlet : AmazonPersonalizeClientCmdlet, IExecutor
    {
        
        #region Parameter SolutionConfig_AlgorithmHyperParameter
        /// <summary>
        /// <para>
        /// <para>Lists the hyperparameter names and ranges.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_AlgorithmHyperParameters")]
        public System.Collections.Hashtable SolutionConfig_AlgorithmHyperParameter { get; set; }
        #endregion
        
        #region Parameter AlgorithmHyperParameterRanges_CategoricalHyperParameterRange
        /// <summary>
        /// <para>
        /// <para>The categorical hyperparameters and their ranges.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_AlgorithmHyperParameterRanges_CategoricalHyperParameterRanges")]
        public Amazon.Personalize.Model.CategoricalHyperParameterRange[] AlgorithmHyperParameterRanges_CategoricalHyperParameterRange { get; set; }
        #endregion
        
        #region Parameter AlgorithmHyperParameterRanges_ContinuousHyperParameterRange
        /// <summary>
        /// <para>
        /// <para>The continuous hyperparameters and their ranges.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_AlgorithmHyperParameterRanges_ContinuousHyperParameterRanges")]
        public Amazon.Personalize.Model.ContinuousHyperParameterRange[] AlgorithmHyperParameterRanges_ContinuousHyperParameterRange { get; set; }
        #endregion
        
        #region Parameter DatasetGroupArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the dataset group that provides the training data.</para>
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
        public System.String DatasetGroupArn { get; set; }
        #endregion
        
        #region Parameter EventType
        /// <summary>
        /// <para>
        /// <para>When your have multiple event types (using an <code>EVENT_TYPE</code> schema field),
        /// this parameter specifies which event type (for example, 'click' or 'like') is used
        /// for training the model.</para><para>If you do not provide an <code>eventType</code>, Amazon Personalize will use all interactions
        /// for training with equal weight regardless of type.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EventType { get; set; }
        #endregion
        
        #region Parameter SolutionConfig_EventValueThreshold
        /// <summary>
        /// <para>
        /// <para>Only events with a value greater than or equal to this threshold are used for training
        /// a model.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SolutionConfig_EventValueThreshold { get; set; }
        #endregion
        
        #region Parameter SolutionConfig_FeatureTransformationParameter
        /// <summary>
        /// <para>
        /// <para>Lists the feature transformation parameters.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_FeatureTransformationParameters")]
        public System.Collections.Hashtable SolutionConfig_FeatureTransformationParameter { get; set; }
        #endregion
        
        #region Parameter AlgorithmHyperParameterRanges_IntegerHyperParameterRange
        /// <summary>
        /// <para>
        /// <para>The integer-valued hyperparameters and their ranges.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_AlgorithmHyperParameterRanges_IntegerHyperParameterRanges")]
        public Amazon.Personalize.Model.IntegerHyperParameterRange[] AlgorithmHyperParameterRanges_IntegerHyperParameterRange { get; set; }
        #endregion
        
        #region Parameter OptimizationObjective_ItemAttribute
        /// <summary>
        /// <para>
        /// <para>The numerical metadata column in an Items dataset related to the optimization objective.
        /// For example, VIDEO_LENGTH (to maximize streaming minutes), or PRICE (to maximize revenue).</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_OptimizationObjective_ItemAttribute")]
        public System.String OptimizationObjective_ItemAttribute { get; set; }
        #endregion
        
        #region Parameter HpoResourceConfig_MaxNumberOfTrainingJob
        /// <summary>
        /// <para>
        /// <para>The maximum number of training jobs when you create a solution version. The maximum
        /// value for <code>maxNumberOfTrainingJobs</code> is <code>40</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_HpoResourceConfig_MaxNumberOfTrainingJobs")]
        public System.String HpoResourceConfig_MaxNumberOfTrainingJob { get; set; }
        #endregion
        
        #region Parameter HpoResourceConfig_MaxParallelTrainingJob
        /// <summary>
        /// <para>
        /// <para>The maximum number of parallel training jobs when you create a solution version. The
        /// maximum value for <code>maxParallelTrainingJobs</code> is <code>10</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_HpoResourceConfig_MaxParallelTrainingJobs")]
        public System.String HpoResourceConfig_MaxParallelTrainingJob { get; set; }
        #endregion
        
        #region Parameter AutoMLConfig_MetricName
        /// <summary>
        /// <para>
        /// <para>The metric to optimize.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_AutoMLConfig_MetricName")]
        public System.String AutoMLConfig_MetricName { get; set; }
        #endregion
        
        #region Parameter HpoObjective_MetricName
        /// <summary>
        /// <para>
        /// <para>The name of the metric.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_HpoObjective_MetricName")]
        public System.String HpoObjective_MetricName { get; set; }
        #endregion
        
        #region Parameter HpoObjective_MetricRegex
        /// <summary>
        /// <para>
        /// <para>A regular expression for finding the metric in the training job logs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_HpoObjective_MetricRegex")]
        public System.String HpoObjective_MetricRegex { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name for the solution.</para>
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
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter OptimizationObjective_ObjectiveSensitivity
        /// <summary>
        /// <para>
        /// <para>Specifies how Amazon Personalize balances the importance of your optimization objective
        /// versus relevance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_OptimizationObjective_ObjectiveSensitivity")]
        [AWSConstantClassSource("Amazon.Personalize.ObjectiveSensitivity")]
        public Amazon.Personalize.ObjectiveSensitivity OptimizationObjective_ObjectiveSensitivity { get; set; }
        #endregion
        
        #region Parameter PerformAutoML
        /// <summary>
        /// <para>
        /// <para>Whether to perform automated machine learning (AutoML). The default is <code>false</code>.
        /// For this case, you must specify <code>recipeArn</code>.</para><para>When set to <code>true</code>, Amazon Personalize analyzes your training data and
        /// selects the optimal USER_PERSONALIZATION recipe and hyperparameters. In this case,
        /// you must omit <code>recipeArn</code>. Amazon Personalize determines the optimal recipe
        /// by running tests with different values for the hyperparameters. AutoML lengthens the
        /// training process as compared to selecting a specific recipe.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? PerformAutoML { get; set; }
        #endregion
        
        #region Parameter PerformHPO
        /// <summary>
        /// <para>
        /// <para>Whether to perform hyperparameter optimization (HPO) on the specified or selected
        /// recipe. The default is <code>false</code>.</para><para>When performing AutoML, this parameter is always <code>true</code> and you should
        /// not set it to <code>false</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? PerformHPO { get; set; }
        #endregion
        
        #region Parameter RecipeArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the recipe to use for model training. Only specified when <code>performAutoML</code>
        /// is false.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RecipeArn { get; set; }
        #endregion
        
        #region Parameter AutoMLConfig_RecipeList
        /// <summary>
        /// <para>
        /// <para>The list of candidate recipes.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_AutoMLConfig_RecipeList")]
        public System.String[] AutoMLConfig_RecipeList { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of <a href="https://docs.aws.amazon.com/personalize/latest/dev/tagging-resources.html">tags</a>
        /// to apply to the solution.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.Personalize.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter HpoObjective_Type
        /// <summary>
        /// <para>
        /// <para>The type of the metric. Valid values are <code>Maximize</code> and <code>Minimize</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SolutionConfig_HpoConfig_HpoObjective_Type")]
        public System.String HpoObjective_Type { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SolutionArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Personalize.Model.CreateSolutionResponse).
        /// Specifying the name of a property of type Amazon.Personalize.Model.CreateSolutionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SolutionArn";
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-PERSSolution (CreateSolution)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Personalize.Model.CreateSolutionResponse, NewPERSSolutionCmdlet>(Select) ??
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
            context.DatasetGroupArn = this.DatasetGroupArn;
            #if MODULAR
            if (this.DatasetGroupArn == null && ParameterWasBound(nameof(this.DatasetGroupArn)))
            {
                WriteWarning("You are passing $null as a value for parameter DatasetGroupArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.EventType = this.EventType;
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.PerformAutoML = this.PerformAutoML;
            context.PerformHPO = this.PerformHPO;
            context.RecipeArn = this.RecipeArn;
            if (this.SolutionConfig_AlgorithmHyperParameter != null)
            {
                context.SolutionConfig_AlgorithmHyperParameter = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.SolutionConfig_AlgorithmHyperParameter.Keys)
                {
                    context.SolutionConfig_AlgorithmHyperParameter.Add((String)hashKey, (String)(this.SolutionConfig_AlgorithmHyperParameter[hashKey]));
                }
            }
            context.AutoMLConfig_MetricName = this.AutoMLConfig_MetricName;
            if (this.AutoMLConfig_RecipeList != null)
            {
                context.AutoMLConfig_RecipeList = new List<System.String>(this.AutoMLConfig_RecipeList);
            }
            context.SolutionConfig_EventValueThreshold = this.SolutionConfig_EventValueThreshold;
            if (this.SolutionConfig_FeatureTransformationParameter != null)
            {
                context.SolutionConfig_FeatureTransformationParameter = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.SolutionConfig_FeatureTransformationParameter.Keys)
                {
                    context.SolutionConfig_FeatureTransformationParameter.Add((String)hashKey, (String)(this.SolutionConfig_FeatureTransformationParameter[hashKey]));
                }
            }
            if (this.AlgorithmHyperParameterRanges_CategoricalHyperParameterRange != null)
            {
                context.AlgorithmHyperParameterRanges_CategoricalHyperParameterRange = new List<Amazon.Personalize.Model.CategoricalHyperParameterRange>(this.AlgorithmHyperParameterRanges_CategoricalHyperParameterRange);
            }
            if (this.AlgorithmHyperParameterRanges_ContinuousHyperParameterRange != null)
            {
                context.AlgorithmHyperParameterRanges_ContinuousHyperParameterRange = new List<Amazon.Personalize.Model.ContinuousHyperParameterRange>(this.AlgorithmHyperParameterRanges_ContinuousHyperParameterRange);
            }
            if (this.AlgorithmHyperParameterRanges_IntegerHyperParameterRange != null)
            {
                context.AlgorithmHyperParameterRanges_IntegerHyperParameterRange = new List<Amazon.Personalize.Model.IntegerHyperParameterRange>(this.AlgorithmHyperParameterRanges_IntegerHyperParameterRange);
            }
            context.HpoObjective_MetricName = this.HpoObjective_MetricName;
            context.HpoObjective_MetricRegex = this.HpoObjective_MetricRegex;
            context.HpoObjective_Type = this.HpoObjective_Type;
            context.HpoResourceConfig_MaxNumberOfTrainingJob = this.HpoResourceConfig_MaxNumberOfTrainingJob;
            context.HpoResourceConfig_MaxParallelTrainingJob = this.HpoResourceConfig_MaxParallelTrainingJob;
            context.OptimizationObjective_ItemAttribute = this.OptimizationObjective_ItemAttribute;
            context.OptimizationObjective_ObjectiveSensitivity = this.OptimizationObjective_ObjectiveSensitivity;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.Personalize.Model.Tag>(this.Tag);
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
            var request = new Amazon.Personalize.Model.CreateSolutionRequest();
            
            if (cmdletContext.DatasetGroupArn != null)
            {
                request.DatasetGroupArn = cmdletContext.DatasetGroupArn;
            }
            if (cmdletContext.EventType != null)
            {
                request.EventType = cmdletContext.EventType;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.PerformAutoML != null)
            {
                request.PerformAutoML = cmdletContext.PerformAutoML.Value;
            }
            if (cmdletContext.PerformHPO != null)
            {
                request.PerformHPO = cmdletContext.PerformHPO.Value;
            }
            if (cmdletContext.RecipeArn != null)
            {
                request.RecipeArn = cmdletContext.RecipeArn;
            }
            
             // populate SolutionConfig
            var requestSolutionConfigIsNull = true;
            request.SolutionConfig = new Amazon.Personalize.Model.SolutionConfig();
            Dictionary<System.String, System.String> requestSolutionConfig_solutionConfig_AlgorithmHyperParameter = null;
            if (cmdletContext.SolutionConfig_AlgorithmHyperParameter != null)
            {
                requestSolutionConfig_solutionConfig_AlgorithmHyperParameter = cmdletContext.SolutionConfig_AlgorithmHyperParameter;
            }
            if (requestSolutionConfig_solutionConfig_AlgorithmHyperParameter != null)
            {
                request.SolutionConfig.AlgorithmHyperParameters = requestSolutionConfig_solutionConfig_AlgorithmHyperParameter;
                requestSolutionConfigIsNull = false;
            }
            System.String requestSolutionConfig_solutionConfig_EventValueThreshold = null;
            if (cmdletContext.SolutionConfig_EventValueThreshold != null)
            {
                requestSolutionConfig_solutionConfig_EventValueThreshold = cmdletContext.SolutionConfig_EventValueThreshold;
            }
            if (requestSolutionConfig_solutionConfig_EventValueThreshold != null)
            {
                request.SolutionConfig.EventValueThreshold = requestSolutionConfig_solutionConfig_EventValueThreshold;
                requestSolutionConfigIsNull = false;
            }
            Dictionary<System.String, System.String> requestSolutionConfig_solutionConfig_FeatureTransformationParameter = null;
            if (cmdletContext.SolutionConfig_FeatureTransformationParameter != null)
            {
                requestSolutionConfig_solutionConfig_FeatureTransformationParameter = cmdletContext.SolutionConfig_FeatureTransformationParameter;
            }
            if (requestSolutionConfig_solutionConfig_FeatureTransformationParameter != null)
            {
                request.SolutionConfig.FeatureTransformationParameters = requestSolutionConfig_solutionConfig_FeatureTransformationParameter;
                requestSolutionConfigIsNull = false;
            }
            Amazon.Personalize.Model.AutoMLConfig requestSolutionConfig_solutionConfig_AutoMLConfig = null;
            
             // populate AutoMLConfig
            var requestSolutionConfig_solutionConfig_AutoMLConfigIsNull = true;
            requestSolutionConfig_solutionConfig_AutoMLConfig = new Amazon.Personalize.Model.AutoMLConfig();
            System.String requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_MetricName = null;
            if (cmdletContext.AutoMLConfig_MetricName != null)
            {
                requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_MetricName = cmdletContext.AutoMLConfig_MetricName;
            }
            if (requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_MetricName != null)
            {
                requestSolutionConfig_solutionConfig_AutoMLConfig.MetricName = requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_MetricName;
                requestSolutionConfig_solutionConfig_AutoMLConfigIsNull = false;
            }
            List<System.String> requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_RecipeList = null;
            if (cmdletContext.AutoMLConfig_RecipeList != null)
            {
                requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_RecipeList = cmdletContext.AutoMLConfig_RecipeList;
            }
            if (requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_RecipeList != null)
            {
                requestSolutionConfig_solutionConfig_AutoMLConfig.RecipeList = requestSolutionConfig_solutionConfig_AutoMLConfig_autoMLConfig_RecipeList;
                requestSolutionConfig_solutionConfig_AutoMLConfigIsNull = false;
            }
             // determine if requestSolutionConfig_solutionConfig_AutoMLConfig should be set to null
            if (requestSolutionConfig_solutionConfig_AutoMLConfigIsNull)
            {
                requestSolutionConfig_solutionConfig_AutoMLConfig = null;
            }
            if (requestSolutionConfig_solutionConfig_AutoMLConfig != null)
            {
                request.SolutionConfig.AutoMLConfig = requestSolutionConfig_solutionConfig_AutoMLConfig;
                requestSolutionConfigIsNull = false;
            }
            Amazon.Personalize.Model.OptimizationObjective requestSolutionConfig_solutionConfig_OptimizationObjective = null;
            
             // populate OptimizationObjective
            var requestSolutionConfig_solutionConfig_OptimizationObjectiveIsNull = true;
            requestSolutionConfig_solutionConfig_OptimizationObjective = new Amazon.Personalize.Model.OptimizationObjective();
            System.String requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ItemAttribute = null;
            if (cmdletContext.OptimizationObjective_ItemAttribute != null)
            {
                requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ItemAttribute = cmdletContext.OptimizationObjective_ItemAttribute;
            }
            if (requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ItemAttribute != null)
            {
                requestSolutionConfig_solutionConfig_OptimizationObjective.ItemAttribute = requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ItemAttribute;
                requestSolutionConfig_solutionConfig_OptimizationObjectiveIsNull = false;
            }
            Amazon.Personalize.ObjectiveSensitivity requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ObjectiveSensitivity = null;
            if (cmdletContext.OptimizationObjective_ObjectiveSensitivity != null)
            {
                requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ObjectiveSensitivity = cmdletContext.OptimizationObjective_ObjectiveSensitivity;
            }
            if (requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ObjectiveSensitivity != null)
            {
                requestSolutionConfig_solutionConfig_OptimizationObjective.ObjectiveSensitivity = requestSolutionConfig_solutionConfig_OptimizationObjective_optimizationObjective_ObjectiveSensitivity;
                requestSolutionConfig_solutionConfig_OptimizationObjectiveIsNull = false;
            }
             // determine if requestSolutionConfig_solutionConfig_OptimizationObjective should be set to null
            if (requestSolutionConfig_solutionConfig_OptimizationObjectiveIsNull)
            {
                requestSolutionConfig_solutionConfig_OptimizationObjective = null;
            }
            if (requestSolutionConfig_solutionConfig_OptimizationObjective != null)
            {
                request.SolutionConfig.OptimizationObjective = requestSolutionConfig_solutionConfig_OptimizationObjective;
                requestSolutionConfigIsNull = false;
            }
            Amazon.Personalize.Model.HPOConfig requestSolutionConfig_solutionConfig_HpoConfig = null;
            
             // populate HpoConfig
            var requestSolutionConfig_solutionConfig_HpoConfigIsNull = true;
            requestSolutionConfig_solutionConfig_HpoConfig = new Amazon.Personalize.Model.HPOConfig();
            Amazon.Personalize.Model.HPOResourceConfig requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig = null;
            
             // populate HpoResourceConfig
            var requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfigIsNull = true;
            requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig = new Amazon.Personalize.Model.HPOResourceConfig();
            System.String requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxNumberOfTrainingJob = null;
            if (cmdletContext.HpoResourceConfig_MaxNumberOfTrainingJob != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxNumberOfTrainingJob = cmdletContext.HpoResourceConfig_MaxNumberOfTrainingJob;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxNumberOfTrainingJob != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig.MaxNumberOfTrainingJobs = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxNumberOfTrainingJob;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfigIsNull = false;
            }
            System.String requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxParallelTrainingJob = null;
            if (cmdletContext.HpoResourceConfig_MaxParallelTrainingJob != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxParallelTrainingJob = cmdletContext.HpoResourceConfig_MaxParallelTrainingJob;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxParallelTrainingJob != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig.MaxParallelTrainingJobs = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig_hpoResourceConfig_MaxParallelTrainingJob;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfigIsNull = false;
            }
             // determine if requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig should be set to null
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfigIsNull)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig = null;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig.HpoResourceConfig = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoResourceConfig;
                requestSolutionConfig_solutionConfig_HpoConfigIsNull = false;
            }
            Amazon.Personalize.Model.HyperParameterRanges requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges = null;
            
             // populate AlgorithmHyperParameterRanges
            var requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRangesIsNull = true;
            requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges = new Amazon.Personalize.Model.HyperParameterRanges();
            List<Amazon.Personalize.Model.CategoricalHyperParameterRange> requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_CategoricalHyperParameterRange = null;
            if (cmdletContext.AlgorithmHyperParameterRanges_CategoricalHyperParameterRange != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_CategoricalHyperParameterRange = cmdletContext.AlgorithmHyperParameterRanges_CategoricalHyperParameterRange;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_CategoricalHyperParameterRange != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges.CategoricalHyperParameterRanges = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_CategoricalHyperParameterRange;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRangesIsNull = false;
            }
            List<Amazon.Personalize.Model.ContinuousHyperParameterRange> requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_ContinuousHyperParameterRange = null;
            if (cmdletContext.AlgorithmHyperParameterRanges_ContinuousHyperParameterRange != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_ContinuousHyperParameterRange = cmdletContext.AlgorithmHyperParameterRanges_ContinuousHyperParameterRange;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_ContinuousHyperParameterRange != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges.ContinuousHyperParameterRanges = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_ContinuousHyperParameterRange;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRangesIsNull = false;
            }
            List<Amazon.Personalize.Model.IntegerHyperParameterRange> requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_IntegerHyperParameterRange = null;
            if (cmdletContext.AlgorithmHyperParameterRanges_IntegerHyperParameterRange != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_IntegerHyperParameterRange = cmdletContext.AlgorithmHyperParameterRanges_IntegerHyperParameterRange;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_IntegerHyperParameterRange != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges.IntegerHyperParameterRanges = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges_algorithmHyperParameterRanges_IntegerHyperParameterRange;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRangesIsNull = false;
            }
             // determine if requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges should be set to null
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRangesIsNull)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges = null;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig.AlgorithmHyperParameterRanges = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_AlgorithmHyperParameterRanges;
                requestSolutionConfig_solutionConfig_HpoConfigIsNull = false;
            }
            Amazon.Personalize.Model.HPOObjective requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective = null;
            
             // populate HpoObjective
            var requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjectiveIsNull = true;
            requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective = new Amazon.Personalize.Model.HPOObjective();
            System.String requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricName = null;
            if (cmdletContext.HpoObjective_MetricName != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricName = cmdletContext.HpoObjective_MetricName;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricName != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective.MetricName = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricName;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjectiveIsNull = false;
            }
            System.String requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricRegex = null;
            if (cmdletContext.HpoObjective_MetricRegex != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricRegex = cmdletContext.HpoObjective_MetricRegex;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricRegex != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective.MetricRegex = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_MetricRegex;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjectiveIsNull = false;
            }
            System.String requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_Type = null;
            if (cmdletContext.HpoObjective_Type != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_Type = cmdletContext.HpoObjective_Type;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_Type != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective.Type = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective_hpoObjective_Type;
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjectiveIsNull = false;
            }
             // determine if requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective should be set to null
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjectiveIsNull)
            {
                requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective = null;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective != null)
            {
                requestSolutionConfig_solutionConfig_HpoConfig.HpoObjective = requestSolutionConfig_solutionConfig_HpoConfig_solutionConfig_HpoConfig_HpoObjective;
                requestSolutionConfig_solutionConfig_HpoConfigIsNull = false;
            }
             // determine if requestSolutionConfig_solutionConfig_HpoConfig should be set to null
            if (requestSolutionConfig_solutionConfig_HpoConfigIsNull)
            {
                requestSolutionConfig_solutionConfig_HpoConfig = null;
            }
            if (requestSolutionConfig_solutionConfig_HpoConfig != null)
            {
                request.SolutionConfig.HpoConfig = requestSolutionConfig_solutionConfig_HpoConfig;
                requestSolutionConfigIsNull = false;
            }
             // determine if request.SolutionConfig should be set to null
            if (requestSolutionConfigIsNull)
            {
                request.SolutionConfig = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.Personalize.Model.CreateSolutionResponse CallAWSServiceOperation(IAmazonPersonalize client, Amazon.Personalize.Model.CreateSolutionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Personalize", "CreateSolution");
            try
            {
                #if DESKTOP
                return client.CreateSolution(request);
                #elif CORECLR
                return client.CreateSolutionAsync(request).GetAwaiter().GetResult();
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
            public System.String DatasetGroupArn { get; set; }
            public System.String EventType { get; set; }
            public System.String Name { get; set; }
            public System.Boolean? PerformAutoML { get; set; }
            public System.Boolean? PerformHPO { get; set; }
            public System.String RecipeArn { get; set; }
            public Dictionary<System.String, System.String> SolutionConfig_AlgorithmHyperParameter { get; set; }
            public System.String AutoMLConfig_MetricName { get; set; }
            public List<System.String> AutoMLConfig_RecipeList { get; set; }
            public System.String SolutionConfig_EventValueThreshold { get; set; }
            public Dictionary<System.String, System.String> SolutionConfig_FeatureTransformationParameter { get; set; }
            public List<Amazon.Personalize.Model.CategoricalHyperParameterRange> AlgorithmHyperParameterRanges_CategoricalHyperParameterRange { get; set; }
            public List<Amazon.Personalize.Model.ContinuousHyperParameterRange> AlgorithmHyperParameterRanges_ContinuousHyperParameterRange { get; set; }
            public List<Amazon.Personalize.Model.IntegerHyperParameterRange> AlgorithmHyperParameterRanges_IntegerHyperParameterRange { get; set; }
            public System.String HpoObjective_MetricName { get; set; }
            public System.String HpoObjective_MetricRegex { get; set; }
            public System.String HpoObjective_Type { get; set; }
            public System.String HpoResourceConfig_MaxNumberOfTrainingJob { get; set; }
            public System.String HpoResourceConfig_MaxParallelTrainingJob { get; set; }
            public System.String OptimizationObjective_ItemAttribute { get; set; }
            public Amazon.Personalize.ObjectiveSensitivity OptimizationObjective_ObjectiveSensitivity { get; set; }
            public List<Amazon.Personalize.Model.Tag> Tag { get; set; }
            public System.Func<Amazon.Personalize.Model.CreateSolutionResponse, NewPERSSolutionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SolutionArn;
        }
        
    }
}
