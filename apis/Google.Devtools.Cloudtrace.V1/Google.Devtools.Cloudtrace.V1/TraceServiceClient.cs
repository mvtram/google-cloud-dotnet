// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Devtools.Cloudtrace.V1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="TraceServiceClient"/>.
    /// </summary>
    public static partial class TraceServiceExtensions
    {
        /// <summary>
        /// Wrap a GRPC TraceService client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="TraceServiceSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="TraceServiceClient"/> that wraps the specified GRPC client.</returns>
        public static TraceServiceClient ToClient(
            this TraceService.TraceServiceClient grpcClient,
            TraceServiceSettings settings = null
        ) => new TraceServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a TraceService wrapper.
    /// </summary>
    public sealed partial class TraceServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="TraceServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default TraceServiceSettings.</returns>
        public static TraceServiceSettings GetDefault() => new TraceServiceSettings();

        /// <summary>
        /// Constructs a new TraceServiceSettings object with default settings.
        /// </summary>
        public TraceServiceSettings() { }

        private TraceServiceSettings(TraceServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTracesSettings = existing.ListTracesSettings?.Clone();
            GetTraceSettings = existing.GetTraceSettings?.Clone();
            PatchTracesSettings = existing.PatchTracesSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="TraceServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="TraceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.2,
            MaxDelay = TimeSpan.FromMilliseconds(1000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="TraceServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="TraceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(20000),
            DelayMultiplier = 1.5,
            MaxDelay = TimeSpan.FromMilliseconds(30000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="TraceServiceClient.ListTraces"/> and <see cref="TraceServiceClient.ListTracesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="TraceServiceClient.ListTraces"/> and
        /// <see cref="TraceServiceClient.ListTracesAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListTracesSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="TraceServiceClient.GetTrace"/> and <see cref="TraceServiceClient.GetTraceAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="TraceServiceClient.GetTrace"/> and
        /// <see cref="TraceServiceClient.GetTraceAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings GetTraceSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="TraceServiceClient.PatchTraces"/> and <see cref="TraceServiceClient.PatchTracesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="TraceServiceClient.PatchTraces"/> and
        /// <see cref="TraceServiceClient.PatchTracesAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings PatchTracesSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of TraceService settings.</returns>
        public TraceServiceSettings Clone() => new TraceServiceSettings(this);
    }

    /// <summary>
    /// TraceService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class TraceServiceClient
    {
        /// <summary>
        /// The default endpoint for the TraceService service, which is a host of "cloudtrace.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("cloudtrace.googleapis.com", 443);

        /// <summary>
        /// The default TraceService scopes
        /// </summary>
        /// <remarks>
        /// The default TraceService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/trace.append"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/trace.readonly"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
            "https://www.googleapis.com/auth/trace.readonly",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TraceServiceClient"/>.</returns>
        public static async Task<TraceServiceClient> CreateAsync(ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(Channel channel, TraceServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            TraceService.TraceServiceClient grpcClient = new TraceService.TraceServiceClient(channel);
            return new TraceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, TraceServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, TraceServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC TraceService client.
        /// </summary>
        public virtual TraceService.TraceServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Trace resources.</returns>
        public virtual IPagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Trace resources.</returns>
        public virtual IPagedEnumerable<ListTracesResponse, Trace> ListTraces(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            CancellationToken cancellationToken) => GetTraceAsync(
                projectId,
                traceId,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trace GetTrace(
            string projectId,
            string traceId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traces"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task PatchTracesAsync(
            string projectId,
            Traces traces,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traces"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task PatchTracesAsync(
            string projectId,
            Traces traces,
            CancellationToken cancellationToken) => PatchTracesAsync(
                projectId,
                traces,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traces"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PatchTraces(
            string projectId,
            Traces traces,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class TraceServiceClientImpl : TraceServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListTracesRequest, ListTracesResponse> _callListTraces;
        private readonly ApiCall<GetTraceRequest, Trace> _callGetTrace;
        private readonly ApiCall<PatchTracesRequest, Empty> _callPatchTraces;

        public TraceServiceClientImpl(TraceService.TraceServiceClient grpcClient, TraceServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            TraceServiceSettings effectiveSettings = settings ?? TraceServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callListTraces = _clientHelper.BuildApiCall<ListTracesRequest, ListTracesResponse>(
                GrpcClient.ListTracesAsync, GrpcClient.ListTraces, effectiveSettings.ListTracesSettings);
            _callGetTrace = _clientHelper.BuildApiCall<GetTraceRequest, Trace>(
                GrpcClient.GetTraceAsync, GrpcClient.GetTrace, effectiveSettings.GetTraceSettings);
            _callPatchTraces = _clientHelper.BuildApiCall<PatchTracesRequest, Empty>(
                GrpcClient.PatchTracesAsync, GrpcClient.PatchTraces, effectiveSettings.PatchTracesSettings);
        }

        public override TraceService.TraceServiceClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Trace resources.</returns>
        public override IPagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListTracesRequest, ListTracesResponse, Trace>(
                _callListTraces,
                new ListTracesRequest
                {
                    ProjectId = projectId,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Trace resources.</returns>
        public override IPagedEnumerable<ListTracesResponse, Trace> ListTraces(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListTracesRequest, ListTracesResponse, Trace>(
                _callListTraces,
                new ListTracesRequest
                {
                    ProjectId = projectId,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            CallSettings callSettings = null) => _callGetTrace.Async(
                new GetTraceRequest
                {
                    ProjectId = projectId,
                    TraceId = traceId,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trace GetTrace(
            string projectId,
            string traceId,
            CallSettings callSettings = null) => _callGetTrace.Sync(
                new GetTraceRequest
                {
                    ProjectId = projectId,
                    TraceId = traceId,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traces"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task PatchTracesAsync(
            string projectId,
            Traces traces,
            CallSettings callSettings = null) => _callPatchTraces.Async(
                new PatchTracesRequest
                {
                    ProjectId = projectId,
                    Traces = traces,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traces"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PatchTraces(
            string projectId,
            Traces traces,
            CallSettings callSettings = null) => _callPatchTraces.Sync(
                new PatchTracesRequest
                {
                    ProjectId = projectId,
                    Traces = traces,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListTracesRequest : IPageRequest { }
    public partial class ListTracesResponse : IPageResponse<Trace>
    {
        public IEnumerator<Trace> GetEnumerator() => Traces.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}