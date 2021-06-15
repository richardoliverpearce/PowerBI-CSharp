// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PipelinesOperations.
    /// </summary>
    public static partial class PipelinesOperationsExtensions
    {
            /// <summary>
            /// Returns a list of deployment pipelines the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.Read.All or Pipeline.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Pipelines GetPipelines(this IPipelinesOperations operations)
            {
                return operations.GetPipelinesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of deployment pipelines the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.Read.All or Pipeline.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pipelines> GetPipelinesAsync(this IPipelinesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelinesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified deployment pipeline.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or Pipeline.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: stages
            /// </param>
            public static Pipeline GetPipeline(this IPipelinesOperations operations, System.Guid pipelineId, string expand = "stages")
            {
                return operations.GetPipelineAsync(pipelineId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified deployment pipeline.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or Pipeline.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: stages
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pipeline> GetPipelineAsync(this IPipelinesOperations operations, System.Guid pipelineId, string expand = "stages", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelineWithHttpMessagesAsync(pipelineId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the supported items from the workspace assigned to the specified
            /// deployment pipeline stage. To learn more about items that are not supported
            /// in deployment pipelines, see [unsupported
            /// items](https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#unsupported-items)
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must be at least a
            /// contributor on the workspace assigned to the specified stage. For more
            /// information, see
            /// [permissions]([https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#permissions)
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or
            /// Pipeline.Read.All &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='stageOrder'>
            /// The deployment pipeline stage order. Development (0), Test (1), Production
            /// (2).
            /// </param>
            public static PipelineStageArtifacts GetPipelineStageArtifacts(this IPipelinesOperations operations, System.Guid pipelineId, int stageOrder)
            {
                return operations.GetPipelineStageArtifactsAsync(pipelineId, stageOrder).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the supported items from the workspace assigned to the specified
            /// deployment pipeline stage. To learn more about items that are not supported
            /// in deployment pipelines, see [unsupported
            /// items](https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#unsupported-items)
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must be at least a
            /// contributor on the workspace assigned to the specified stage. For more
            /// information, see
            /// [permissions]([https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#permissions)
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or
            /// Pipeline.Read.All &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='stageOrder'>
            /// The deployment pipeline stage order. Development (0), Test (1), Production
            /// (2).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineStageArtifacts> GetPipelineStageArtifactsAsync(this IPipelinesOperations operations, System.Guid pipelineId, int stageOrder, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelineStageArtifactsWithHttpMessagesAsync(pipelineId, stageOrder, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of up to 20 last deploy operations performed on the
            /// specified deployment pipeline.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or Pipeline.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline Id
            /// </param>
            public static PipelineOperations GetPipelineOperations(this IPipelinesOperations operations, System.Guid pipelineId)
            {
                return operations.GetPipelineOperationsAsync(pipelineId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of up to 20 last deploy operations performed on the
            /// specified deployment pipeline.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or Pipeline.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineOperations> GetPipelineOperationsAsync(this IPipelinesOperations operations, System.Guid pipelineId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelineOperationsWithHttpMessagesAsync(pipelineId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the details of the specified deploy operation performed on the
            /// specified deployment pipeline including the `executionPlan`. Use to track
            /// the status of the deploy operation.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or Pipeline.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='operationId'>
            /// The operation Id
            /// </param>
            public static PipelineOperation GetPipelineOperation(this IPipelinesOperations operations, System.Guid pipelineId, System.Guid operationId)
            {
                return operations.GetPipelineOperationAsync(pipelineId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the details of the specified deploy operation performed on the
            /// specified deployment pipeline including the `executionPlan`. Use to track
            /// the status of the deploy operation.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Pipeline.ReadWrite.All or Pipeline.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='operationId'>
            /// The operation Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineOperation> GetPipelineOperationAsync(this IPipelinesOperations operations, System.Guid pipelineId, System.Guid operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelineOperationWithHttpMessagesAsync(pipelineId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deploy all supported items from the specified deployment pipeline source
            /// stage. To learn more about items that are not supported in deployment
            /// pipelines, see [unsupported
            /// items](https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#unsupported-items)
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note**: To perform this operation, the user must be at least a
            /// member on both workpsaces. For more information, see
            /// [permissions]([https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#permissions)
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Pipeline.Deploy &lt;br/&gt;To set
            /// the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;h4&gt;Limitations&lt;/h4&gt;&lt;ul&gt;&lt;li&gt;You
            /// can deploy up to 300 items per request&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='deployRequest'>
            /// The deploy request
            /// </param>
            public static PipelineOperation DeployAll(this IPipelinesOperations operations, System.Guid pipelineId, DeployAllRequest deployRequest)
            {
                return operations.DeployAllAsync(pipelineId, deployRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deploy all supported items from the specified deployment pipeline source
            /// stage. To learn more about items that are not supported in deployment
            /// pipelines, see [unsupported
            /// items](https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#unsupported-items)
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note**: To perform this operation, the user must be at least a
            /// member on both workpsaces. For more information, see
            /// [permissions]([https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#permissions)
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Pipeline.Deploy &lt;br/&gt;To set
            /// the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;h4&gt;Limitations&lt;/h4&gt;&lt;ul&gt;&lt;li&gt;You
            /// can deploy up to 300 items per request&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='deployRequest'>
            /// The deploy request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineOperation> DeployAllAsync(this IPipelinesOperations operations, System.Guid pipelineId, DeployAllRequest deployRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeployAllWithHttpMessagesAsync(pipelineId, deployRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deploy the specified items from the specified deployment pipeline source
            /// stage.
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must be at least a member on
            /// both workpsaces. For more information, see
            /// [permissions]([https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#permissions)
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Pipeline.Deploy &lt;br/&gt;To set
            /// the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;h4&gt;Limitations&lt;/h4&gt;&lt;ul&gt;&lt;li&gt;You
            /// can deploy up to 300 items per request&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='deployRequest'>
            /// The selective deploy request
            /// </param>
            public static PipelineOperation SelectiveDeploy(this IPipelinesOperations operations, System.Guid pipelineId, SelectiveDeployRequest deployRequest)
            {
                return operations.SelectiveDeployAsync(pipelineId, deployRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deploy the specified items from the specified deployment pipeline source
            /// stage.
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must be at least a member on
            /// both workpsaces. For more information, see
            /// [permissions]([https://docs.microsoft.com/power-bi/create-reports/deployment-pipelines-process#permissions)
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Pipeline.Deploy &lt;br/&gt;To set
            /// the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;h4&gt;Limitations&lt;/h4&gt;&lt;ul&gt;&lt;li&gt;You
            /// can deploy up to 300 items per request&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineId'>
            /// The deployment pipeline ID
            /// </param>
            /// <param name='deployRequest'>
            /// The selective deploy request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineOperation> SelectiveDeployAsync(this IPipelinesOperations operations, System.Guid pipelineId, SelectiveDeployRequest deployRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SelectiveDeployWithHttpMessagesAsync(pipelineId, deployRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
