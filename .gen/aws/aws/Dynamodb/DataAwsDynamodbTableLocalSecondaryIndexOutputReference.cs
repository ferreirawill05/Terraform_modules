using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    [JsiiClass(nativeType: typeof(aws.Dynamodb.DataAwsDynamodbTableLocalSecondaryIndexOutputReference), fullyQualifiedName: "aws.dynamodb.DataAwsDynamodbTableLocalSecondaryIndexOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDynamodbTableLocalSecondaryIndexOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDynamodbTableLocalSecondaryIndexOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTableLocalSecondaryIndexOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTableLocalSecondaryIndexOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NonKeyAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableLocalSecondaryIndex\"}", isOptional: true)]
        public virtual aws.Dynamodb.IDataAwsDynamodbTableLocalSecondaryIndex? InternalValue
        {
            get => GetInstanceProperty<aws.Dynamodb.IDataAwsDynamodbTableLocalSecondaryIndex?>();
            set => SetInstanceProperty(value);
        }
    }
}
