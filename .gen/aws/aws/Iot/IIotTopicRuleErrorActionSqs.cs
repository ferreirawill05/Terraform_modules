using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionSqs), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionSqs")]
    public interface IIotTopicRuleErrorActionSqs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#queue_url IotTopicRule#queue_url}.</summary>
        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
        string QueueUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#use_base64 IotTopicRule#use_base64}.</summary>
        [JsiiProperty(name: "useBase64", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object UseBase64
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionSqs), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionSqs")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleErrorActionSqs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#queue_url IotTopicRule#queue_url}.</summary>
            [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#use_base64 IotTopicRule#use_base64}.</summary>
            [JsiiProperty(name: "useBase64", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object UseBase64
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
