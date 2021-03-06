using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketWebsite), fullyQualifiedName: "aws.s3.S3BucketWebsite")]
    public interface IS3BucketWebsite
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#error_document S3Bucket#error_document}.</summary>
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#index_document S3Bucket#index_document}.</summary>
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#redirect_all_requests_to S3Bucket#redirect_all_requests_to}.</summary>
        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectAllRequestsTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#routing_rules S3Bucket#routing_rules}.</summary>
        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketWebsite), fullyQualifiedName: "aws.s3.S3BucketWebsite")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketWebsite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#error_document S3Bucket#error_document}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#index_document S3Bucket#index_document}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#redirect_all_requests_to S3Bucket#redirect_all_requests_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectAllRequestsTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#routing_rules S3Bucket#routing_rules}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingRules
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
