using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference), fullyQualifiedName: "aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLaunchTemplateId")]
        public virtual void ResetLaunchTemplateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplateName")]
        public virtual void ResetLaunchTemplateName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTemplateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTemplateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchTemplateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchTemplateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
