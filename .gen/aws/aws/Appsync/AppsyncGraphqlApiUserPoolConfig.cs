using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiUserPoolConfig")]
    public class AppsyncGraphqlApiUserPoolConfig : aws.Appsync.IAppsyncGraphqlApiUserPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#default_action AppsyncGraphqlApi#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_id AppsyncGraphqlApi#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserPoolId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#app_id_client_regex AppsyncGraphqlApi#app_id_client_regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppIdClientRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#aws_region AppsyncGraphqlApi#aws_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsRegion
        {
            get;
            set;
        }
    }
}
