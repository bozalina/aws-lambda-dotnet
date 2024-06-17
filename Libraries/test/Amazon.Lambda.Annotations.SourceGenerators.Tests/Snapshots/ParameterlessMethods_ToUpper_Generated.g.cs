// <auto-generated/>

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.Lambda.Core;

namespace TestServerlessApp
{
    public class ParameterlessMethods_NoParameter_Generated
    {
        private readonly ParameterlessMethods parameterlessMethods;
        private readonly Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer serializer;

        /// <summary>
        /// Default constructor. This constructor is used by Lambda to construct the instance. When invoked in a Lambda environment
        /// the AWS credentials will come from the IAM role associated with the function and the AWS region will be set to the
        /// region the Lambda function is executed in.
        /// </summary>
        public ParameterlessMethods_NoParameter_Generated()
        {
            SetExecutionEnvironment();
            parameterlessMethods = new ParameterlessMethods();
            serializer = new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer();
        }

        /// <summary>
        /// The generated Lambda function handler for <see cref="NoParameter"/>
        /// </summary>
        /// <returns>Result of the Lambda function execution</returns>
        public void NoParameter(Stream stream)
        {
            parameterlessMethods.NoParameter();
        }

        private static void SetExecutionEnvironment()
        {
            const string envName = "AWS_EXECUTION_ENV";

            var envValue = new StringBuilder();

            // If there is an existing execution environment variable add the annotations package as a suffix.
            if(!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(envName)))
            {
                envValue.Append($"{Environment.GetEnvironmentVariable(envName)}_");
            }

            envValue.Append("lib/amazon-lambda-annotations#1.5.0.0");

            Environment.SetEnvironmentVariable(envName, envValue.ToString());
        }
    }
}