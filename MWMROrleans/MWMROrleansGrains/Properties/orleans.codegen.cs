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
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::MWMROrleansGrains.StatefulGrainState).@GetField("currentContext", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Func<global::MWMROrleansGrains.StatefulGrainState, global::MWMROrleansInterfaces.Context> getField0 = (global::System.Func<global::MWMROrleansGrains.StatefulGrainState, global::MWMROrleansInterfaces.Context>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::MWMROrleansGrains.StatefulGrainState, global::MWMROrleansInterfaces.Context> setField0 = (global::System.Action<global::MWMROrleansGrains.StatefulGrainState, global::MWMROrleansInterfaces.Context>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::MWMROrleansGrains.StatefulGrainState input = ((global::MWMROrleansGrains.StatefulGrainState)original);
            global::MWMROrleansGrains.StatefulGrainState result = new global::MWMROrleansGrains.StatefulGrainState();
            result.@Etag = input.@Etag;
            result.@Prefs = input.@Prefs;
            result.@readers = input.@readers;
            result.@writers = input.@writers;
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::MWMROrleansGrains.StatefulGrainState input = (global::MWMROrleansGrains.StatefulGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Etag, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Prefs, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@readers, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::MWMROrleansInterfaces.ConsistencyLevel>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@writers, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::MWMROrleansInterfaces.ConsistencyLevel>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::MWMROrleansInterfaces.Context));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::MWMROrleansGrains.StatefulGrainState result = new global::MWMROrleansGrains.StatefulGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Etag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Prefs = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>), stream);
            result.@readers = (global::System.Collections.Generic.IDictionary<global::System.String, global::MWMROrleansInterfaces.ConsistencyLevel>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::MWMROrleansInterfaces.ConsistencyLevel>), stream);
            result.@writers = (global::System.Collections.Generic.IDictionary<global::System.String, global::MWMROrleansInterfaces.ConsistencyLevel>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::MWMROrleansInterfaces.ConsistencyLevel>), stream);
            setField0(result, (global::MWMROrleansInterfaces.Context)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::MWMROrleansInterfaces.Context), stream));
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::MWMROrleansInterfaces.Context)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMWMROrleansInterfaces_ContextSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::MWMROrleansInterfaces.Context).@GetField("timestamp", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Func<global::MWMROrleansInterfaces.Context, global::System.DateTime> getField0 = (global::System.Func<global::MWMROrleansInterfaces.Context, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::MWMROrleansInterfaces.Context, global::System.DateTime> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::MWMROrleansInterfaces.Context, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::MWMROrleansInterfaces.Context input = ((global::MWMROrleansInterfaces.Context)original);
            global::MWMROrleansInterfaces.Context result = default (global::MWMROrleansInterfaces.Context);
            setField0(ref result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::MWMROrleansInterfaces.Context input = (global::MWMROrleansInterfaces.Context)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.DateTime));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::MWMROrleansInterfaces.Context result = default (global::MWMROrleansInterfaces.Context);
            setField0(ref result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            return (global::MWMROrleansInterfaces.Context)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::MWMROrleansInterfaces.Context), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMWMROrleansInterfaces_ContextSerializer()
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
