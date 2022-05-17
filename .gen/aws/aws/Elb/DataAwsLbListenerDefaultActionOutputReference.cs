using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.DataAwsLbListenerDefaultActionOutputReference), fullyQualifiedName: "aws.elb.DataAwsLbListenerDefaultActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLbListenerDefaultActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLbListenerDefaultActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.DataAwsLbListenerDefaultActionAuthenticateCognitoList\"}")]
        public virtual aws.Elb.DataAwsLbListenerDefaultActionAuthenticateCognitoList AuthenticateCognito
        {
            get => GetInstanceProperty<aws.Elb.DataAwsLbListenerDefaultActionAuthenticateCognitoList>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.DataAwsLbListenerDefaultActionAuthenticateOidcList\"}")]
        public virtual aws.Elb.DataAwsLbListenerDefaultActionAuthenticateOidcList AuthenticateOidc
        {
            get => GetInstanceProperty<aws.Elb.DataAwsLbListenerDefaultActionAuthenticateOidcList>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.DataAwsLbListenerDefaultActionFixedResponseList\"}")]
        public virtual aws.Elb.DataAwsLbListenerDefaultActionFixedResponseList FixedResponse
        {
            get => GetInstanceProperty<aws.Elb.DataAwsLbListenerDefaultActionFixedResponseList>()!;
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.DataAwsLbListenerDefaultActionRedirectList\"}")]
        public virtual aws.Elb.DataAwsLbListenerDefaultActionRedirectList Redirect
        {
            get => GetInstanceProperty<aws.Elb.DataAwsLbListenerDefaultActionRedirectList>()!;
        }

        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.DataAwsLbListenerDefaultAction\"}", isOptional: true)]
        public virtual aws.Elb.IDataAwsLbListenerDefaultAction? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.IDataAwsLbListenerDefaultAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
