/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateApplicationVersion operation
    /// </summary>  
    public class CreateApplicationVersionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateApplicationVersionResponse response = new CreateApplicationVersionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applicationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ApplicationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parameterDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ParameterDefinition, ParameterDefinitionUnmarshaller>(ParameterDefinitionUnmarshaller.Instance);
                    response.ParameterDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredCapabilities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.RequiredCapabilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourcesSupported", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.ResourcesSupported = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("semanticVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SemanticVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceCodeArchiveUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceCodeArchiveUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceCodeUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceCodeUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TemplateUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
            {
                return new BadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
            {
                return new ConflictException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
            {
                return new ForbiddenException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
            {
                return new TooManyRequestsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonServerlessApplicationRepositoryException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateApplicationVersionResponseUnmarshaller _instance = new CreateApplicationVersionResponseUnmarshaller();        

        internal static CreateApplicationVersionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationVersionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}