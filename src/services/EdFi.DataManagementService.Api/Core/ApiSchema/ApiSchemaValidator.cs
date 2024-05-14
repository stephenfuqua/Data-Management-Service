// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Text.Json.Nodes;
using EdFi.DataManagementService.Api.Core.ApiSchema.Extensions;
using EdFi.DataManagementService.Api.Core.Model;
using EdFi.DataManagementService.Api.Core.Response;
using Json.Schema;

namespace EdFi.DataManagementService.Api.Core.ApiSchema;

/// <summary>
/// Validator for Api Schema
/// </summary>
public interface IApiSchemaValidator
{
    /// <summary>
    /// Validates Api Schema against Schema
    /// </summary>
    /// <param name="apiSchemaContent"></param>
    /// <returns></returns>
    Lazy<List<SchemaValidationFailure>> Validate(JsonNode? apiSchemaContent);
}

public class ApiSchemaValidator(IApiSchemaSchemaProvider _apiSchemaSchemaProvider) : IApiSchemaValidator
{
    public Lazy<List<SchemaValidationFailure>> Validate(JsonNode? apiSchemaContent)
    {
        var validationErrors = new List<SchemaValidationFailure>();
        var formatValidationResult = apiSchemaContent.ValidateJsonFormat();
        if (formatValidationResult != null && formatValidationResult.Any())
        {
            validationErrors.Add(
                new SchemaValidationFailure(new JsonPath(""), formatValidationResult.ToList())
            );
        }

        EvaluationOptions validatorEvaluationOptions =
            new() { OutputFormat = OutputFormat.List, RequireFormatValidation = true };

        var schema = _apiSchemaSchemaProvider.ApiSchemaSchema;

        var results = schema.Evaluate(apiSchemaContent, validatorEvaluationOptions);
        ValidationErrorsFrom(results);

        return new Lazy<List<SchemaValidationFailure>>(() =>
        {
            return validationErrors;
        });

        void ValidationErrorsFrom(EvaluationResults results)
        {
            foreach (var detail in results.Details)
            {
                var propertyPathAndName = "$.";

                if (detail.InstanceLocation != null && detail.InstanceLocation.Segments.Length != 0)
                {
                    propertyPathAndName = $"${detail.InstanceLocation.ToString().Replace("/", ".")}";
                }
                if (detail.Errors != null && detail.Errors.Any())
                {
                    var errors = new List<string>();
                    foreach (var error in detail.Errors)
                    {
                        errors.Add(error.Value);
                    }
                    validationErrors.Add(
                        new SchemaValidationFailure(new JsonPath(propertyPathAndName), errors)
                    );
                }
            }
        }
    }
}