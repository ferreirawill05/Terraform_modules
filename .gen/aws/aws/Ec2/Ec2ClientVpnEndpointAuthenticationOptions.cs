using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.Ec2ClientVpnEndpointAuthenticationOptions")]
    public class Ec2ClientVpnEndpointAuthenticationOptions : aws.Ec2.IEc2ClientVpnEndpointAuthenticationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#type Ec2ClientVpnEndpoint#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#active_directory_id Ec2ClientVpnEndpoint#active_directory_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActiveDirectoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#root_certificate_chain_arn Ec2ClientVpnEndpoint#root_certificate_chain_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootCertificateChainArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootCertificateChainArn
        {
            get;
            set;
        }
    }
}
