//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UnlinkIdentity Request Marshaller
    /// </summary>       
    public class UnlinkIdentityRequestMarshaller : IMarshaller<IRequest, UnlinkIdentityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UnlinkIdentityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UnlinkIdentityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.UnlinkIdentity";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentityId())
                {
                    context.Writer.WritePropertyName("IdentityId");
                    context.Writer.Write(publicRequest.IdentityId);
                }

                if(publicRequest.IsSetLogins())
                {
                    context.Writer.WritePropertyName("Logins");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestLoginsKvp in publicRequest.Logins)
                    {
                        context.Writer.WritePropertyName(publicRequestLoginsKvp.Key);
                        var publicRequestLoginsValue = publicRequestLoginsKvp.Value;

                            context.Writer.Write(publicRequestLoginsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLoginsToRemove())
                {
                    context.Writer.WritePropertyName("LoginsToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLoginsToRemoveListValue in publicRequest.LoginsToRemove)
                    {
                            context.Writer.Write(publicRequestLoginsToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}