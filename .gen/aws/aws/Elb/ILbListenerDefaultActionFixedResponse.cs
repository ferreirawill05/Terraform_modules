using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerDefaultActionFixedResponse), fullyQualifiedName: "aws.elb.LbListenerDefaultActionFixedResponse")]
    public interface ILbListenerDefaultActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#content_type LbListener#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        string ContentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#message_body LbListener#message_body}.</summary>
        [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#status_code LbListener#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerDefaultActionFixedResponse), fullyQualifiedName: "aws.elb.LbListenerDefaultActionFixedResponse")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerDefaultActionFixedResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#content_type LbListener#content_type}.</summary>
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#message_body LbListener#message_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#status_code LbListener#status_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatusCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
