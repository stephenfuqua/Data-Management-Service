// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
using System.Diagnostics;
using System.Text.Json.Nodes;
using Microsoft.Extensions.Logging;
using EdFi.DataManagementService.Core.Pipeline;

namespace EdFi.DataManagementService.Core.Middleware;

/// <summary>
/// Extracts identity and reference information from a valid JSON document
/// </summary>
internal partial class ExtractDocumentInfoMiddleware(ILogger _logger) : IPipelineStep
{
    /// <summary>
    /// Builds a DocumentInfo using the various extractors on a document body
    /// </summary>
    public async Task Execute(PipelineContext context, Func<Task> next)
    {
        _logger.LogDebug(
            "Entering ExtractDocumentInfoMiddleware - {TraceId}",
            context.FrontendRequest.TraceId
        );

        Debug.Assert(context.FrontendRequest.Body != null, "Body was null, pipeline config invalid");
        JsonNode documentBody = context.FrontendRequest.Body;

        var (documentIdentity, superclassIdentity) = context.ResourceSchema.ExtractIdentities(documentBody);

        context.DocumentInfo = new(
            DocumentReferences: context.ResourceSchema.ExtractDocumentReferences(documentBody),
            DescriptorReferences: context.ResourceSchema.ExtractDescriptorValues(documentBody),
            DocumentIdentity: documentIdentity,
            SuperclassIdentity: superclassIdentity
        );

        await next();
    }
}