using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    [JsiiInterface(nativeType: typeof(IPinpointAppCampaignHook), fullyQualifiedName: "aws.pinpoint.PinpointAppCampaignHook")]
    public interface IPinpointAppCampaignHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#lambda_function_name PinpointApp#lambda_function_name}.</summary>
        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaFunctionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#mode PinpointApp#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#web_url PinpointApp#web_url}.</summary>
        [JsiiProperty(name: "webUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointAppCampaignHook), fullyQualifiedName: "aws.pinpoint.PinpointAppCampaignHook")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpoint.IPinpointAppCampaignHook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#lambda_function_name PinpointApp#lambda_function_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaFunctionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#mode PinpointApp#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#web_url PinpointApp#web_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
