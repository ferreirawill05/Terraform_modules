using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaAliasRoutingConfigOutputReference), fullyQualifiedName: "aws.lambdafunction.LambdaAliasRoutingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaAliasRoutingConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaAliasRoutingConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaAliasRoutingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaAliasRoutingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdditionalVersionWeights")]
        public virtual void ResetAdditionalVersionWeights()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalVersionWeightsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeightsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
        }

        [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, double> AdditionalVersionWeights
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaAliasRoutingConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaAliasRoutingConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaAliasRoutingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
