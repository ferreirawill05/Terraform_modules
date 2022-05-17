using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleConditionHostHeader), fullyQualifiedName: "aws.elb.AlbListenerRuleConditionHostHeader")]
    public interface IAlbListenerRuleConditionHostHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#values AlbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleConditionHostHeader), fullyQualifiedName: "aws.elb.AlbListenerRuleConditionHostHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerRuleConditionHostHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#values AlbListenerRule#values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
