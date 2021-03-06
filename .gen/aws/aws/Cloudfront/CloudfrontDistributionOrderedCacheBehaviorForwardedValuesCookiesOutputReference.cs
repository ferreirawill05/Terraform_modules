using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetWhitelistedNames")]
        public virtual void ResetWhitelistedNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "whitelistedNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? WhitelistedNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Forward
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WhitelistedNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies?>();
            set => SetInstanceProperty(value);
        }
    }
}
