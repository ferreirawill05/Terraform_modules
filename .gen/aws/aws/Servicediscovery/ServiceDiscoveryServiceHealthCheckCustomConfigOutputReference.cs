using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    [JsiiClass(nativeType: typeof(aws.Servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFailureThreshold")]
        public virtual void ResetFailureThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailureThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig\"}", isOptional: true)]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
