using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiClass(nativeType: typeof(aws.Acm.AcmCertificateOptionsOutputReference), fullyQualifiedName: "aws.acm.AcmCertificateOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AcmCertificateOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AcmCertificateOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmCertificateOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmCertificateOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCertificateTransparencyLoggingPreference")]
        public virtual void ResetCertificateTransparencyLoggingPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateTransparencyLoggingPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateTransparencyLoggingPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateTransparencyLoggingPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateOptions\"}", isOptional: true)]
        public virtual aws.Acm.IAcmCertificateOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Acm.IAcmCertificateOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
