using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehaviorForwardedValues), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValues")]
    public interface ICloudfrontDistributionOrderedCacheBehaviorForwardedValues
    {
        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cookies CloudfrontDistribution#cookies}
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"}")]
        aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies Cookies
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#query_string CloudfrontDistribution#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object QueryString
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#headers CloudfrontDistribution#headers}.</summary>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#query_string_cache_keys CloudfrontDistribution#query_string_cache_keys}.</summary>
        [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? QueryStringCacheKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehaviorForwardedValues), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValues")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cookies CloudfrontDistribution#cookies}
            /// </remarks>
            [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"}")]
            public aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies Cookies
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#query_string CloudfrontDistribution#query_string}.</summary>
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object QueryString
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#headers CloudfrontDistribution#headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Headers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#query_string_cache_keys CloudfrontDistribution#query_string_cache_keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? QueryStringCacheKeys
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
