#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("MWMROrleansGrains, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace MWMROrleansGrains
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::MWMROrleansGrains.StatefulGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMWMROrleansGrains_StatefulGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::MWMROrleansGrains.StatefulGrainState input = ((global::MWMROrleansGrains.StatefulGrainState)original);
            global::MWMROrleansGrains.StatefulGrainState result = new global::MWMROrleansGrains.StatefulGrainState();
            result.@Etag = input.@Etag;
            result.@Prefs = input.@Prefs;
            result.@readerGrains = input.@readerGrains;
            result.@writerGrains = input.@writerGrains;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::MWMROrleansGrains.StatefulGrainState input = (global::MWMROrleansGrains.StatefulGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Etag, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Prefs, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@readerGrains, stream, typeof (global::System.Collections.Generic.IList<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@writerGrains, stream, typeof (global::System.Collections.Generic.IList<global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::MWMROrleansGrains.StatefulGrainState result = new global::MWMROrleansGrains.StatefulGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Etag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Prefs = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>), stream);
            result.@readerGrains = (global::System.Collections.Generic.IList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.String>), stream);
            result.@writerGrains = (global::System.Collections.Generic.IList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.String>), stream);
            return (global::MWMROrleansGrains.StatefulGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::MWMROrleansGrains.StatefulGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMWMROrleansGrains_StatefulGrainStateSerializer()
        {
            Register();
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
