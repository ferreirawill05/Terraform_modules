using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterEncryptionInfo), fullyQualifiedName: "aws.msk.MskClusterEncryptionInfo")]
    public interface IMskClusterEncryptionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_at_rest_kms_key_arn MskCluster#encryption_at_rest_kms_key_arn}.</summary>
        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionAtRestKmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_in_transit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_in_transit MskCluster#encryption_in_transit}
        /// </remarks>
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterEncryptionInfo), fullyQualifiedName: "aws.msk.MskClusterEncryptionInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterEncryptionInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_at_rest_kms_key_arn MskCluster#encryption_at_rest_kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionAtRestKmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_in_transit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#encryption_in_transit MskCluster#encryption_in_transit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
            public aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransit
            {
                get => GetInstanceProperty<aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit?>();
            }
        }
    }
}
