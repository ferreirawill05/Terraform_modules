using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.AlbListenerRuleActionAuthenticateCognitoOutputReference), fullyQualifiedName: "aws.elb.AlbListenerRuleActionAuthenticateCognitoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbListenerRuleActionAuthenticateCognitoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbListenerRuleActionAuthenticateCognitoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleActionAuthenticateCognitoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleActionAuthenticateCognitoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthenticationRequestExtraParams")]
        public virtual void ResetAuthenticationRequestExtraParams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnUnauthenticatedRequest")]
        public virtual void ResetOnUnauthenticatedRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScope")]
        public virtual void ResetScope()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionCookieName")]
        public virtual void ResetSessionCookieName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionTimeout")]
        public virtual void ResetSessionTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationRequestExtraParamsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AuthenticationRequestExtraParamsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onUnauthenticatedRequestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnUnauthenticatedRequestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionCookieNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SessionCookieNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SessionTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolClientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AuthenticationRequestExtraParams
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnUnauthenticatedRequest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionCookieName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerRuleActionAuthenticateCognito? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionAuthenticateCognito?>();
            set => SetInstanceProperty(value);
        }
    }
}
