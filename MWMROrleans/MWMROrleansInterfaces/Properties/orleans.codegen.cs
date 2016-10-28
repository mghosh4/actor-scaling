#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("MWMROrleansInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace MWMROrleansInterfaces
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IMetadataGrain))]
    internal class OrleansCodeGenMetadataGrainReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IMetadataGrain
    {
        protected @OrleansCodeGenMetadataGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMetadataGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -165421008;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IMetadataGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -165421008;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -165421008:
                    switch (@methodId)
                    {
                        case 499177615:
                            return "GetGrain";
                        case 58988437:
                            return "GetGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -165421008 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.IStatefulGrain> @GetGrain(global::System.Boolean @readwrite, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.IStatefulGrain>(499177615, new global::System.Object[]{@readwrite, @level});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.IStatefulGrain> @GetGrain(global::System.String @primaryKey, global::System.Boolean @readwrite, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.IStatefulGrain>(58988437, new global::System.Object[]{@primaryKey, @readwrite, @level});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IMetadataGrain", -165421008, typeof (global::MWMROrleansInterfaces.IMetadataGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMetadataGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -165421008:
                        switch (@methodId)
                        {
                            case 499177615:
                                return ((global::MWMROrleansInterfaces.IMetadataGrain)@grain).@GetGrain((global::System.Boolean)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 58988437:
                                return ((global::MWMROrleansInterfaces.IMetadataGrain)@grain).@GetGrain((global::System.String)@arguments[0], (global::System.Boolean)@arguments[1], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[2]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -165421008 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -165421008;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IStatefulGrain))]
    internal class OrleansCodeGenStatefulGrainReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IStatefulGrain
    {
        protected @OrleansCodeGenStatefulGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStatefulGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1038577650;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IStatefulGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IStatefulGrain", -1038577650, typeof (global::MWMROrleansInterfaces.IStatefulGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStatefulGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1038577650;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::MWMROrleansInterfaces.Context)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMWMROrleansInterfaces_ContextSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::MWMROrleansInterfaces.Context).@GetField("id", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Func<global::MWMROrleansInterfaces.Context, global::System.Int64> getField1 = (global::System.Func<global::MWMROrleansInterfaces.Context, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::MWMROrleansInterfaces.Context, global::System.Int64> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::MWMROrleansInterfaces.Context, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::MWMROrleansInterfaces.Context).@GetField("timestamp", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Func<global::MWMROrleansInterfaces.Context, global::System.DateTime> getField0 = (global::System.Func<global::MWMROrleansInterfaces.Context, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::MWMROrleansInterfaces.Context, global::System.DateTime> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::MWMROrleansInterfaces.Context, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::MWMROrleansInterfaces.Context input = ((global::MWMROrleansInterfaces.Context)original);
            global::MWMROrleansInterfaces.Context result = default (global::MWMROrleansInterfaces.Context);
            setField1(ref result, getField1(input));
            setField0(ref result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::MWMROrleansInterfaces.Context input = (global::MWMROrleansInterfaces.Context)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.DateTime));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::MWMROrleansInterfaces.Context result = default (global::MWMROrleansInterfaces.Context);
            setField1(ref result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IStronglyConsistentReader))]
    internal class OrleansCodeGenStronglyConsistentReaderReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IStronglyConsistentReader
    {
        protected @OrleansCodeGenStronglyConsistentReaderReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStronglyConsistentReaderReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1087870377;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IStronglyConsistentReader";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1087870377 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1087870377:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1087870377 + ",methodId=" + @methodId);
                    }

                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IStronglyConsistentReader", -1087870377, typeof (global::MWMROrleansInterfaces.IStronglyConsistentReader)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStronglyConsistentReaderMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1087870377:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1087870377 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1087870377;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IEventuallyConsistentReader))]
    internal class OrleansCodeGenEventuallyConsistentReaderReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IEventuallyConsistentReader
    {
        protected @OrleansCodeGenEventuallyConsistentReaderReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenEventuallyConsistentReaderReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 810781155;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IEventuallyConsistentReader";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 810781155 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 810781155:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 810781155 + ",methodId=" + @methodId);
                    }

                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IEventuallyConsistentReader", 810781155, typeof (global::MWMROrleansInterfaces.IEventuallyConsistentReader)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenEventuallyConsistentReaderMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 810781155:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 810781155 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 810781155;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IReadMyWriteReader))]
    internal class OrleansCodeGenReadMyWriteReaderReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IReadMyWriteReader
    {
        protected @OrleansCodeGenReadMyWriteReaderReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenReadMyWriteReaderReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -295426919;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IReadMyWriteReader";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -295426919 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -295426919:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -295426919 + ",methodId=" + @methodId);
                    }

                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IReadMyWriteReader", -295426919, typeof (global::MWMROrleansInterfaces.IReadMyWriteReader)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenReadMyWriteReaderMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -295426919:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -295426919 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IReadMyWriteReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -295426919;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IBoundedStalenessReader))]
    internal class OrleansCodeGenBoundedStalenessReaderReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IBoundedStalenessReader
    {
        protected @OrleansCodeGenBoundedStalenessReaderReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenBoundedStalenessReaderReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 256872296;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IBoundedStalenessReader";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 256872296 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 256872296:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 256872296 + ",methodId=" + @methodId);
                    }

                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IBoundedStalenessReader", 256872296, typeof (global::MWMROrleansInterfaces.IBoundedStalenessReader)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenBoundedStalenessReaderMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 256872296:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 256872296 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IBoundedStalenessReader)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 256872296;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IStronglyConsistentWriter))]
    internal class OrleansCodeGenStronglyConsistentWriterReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IStronglyConsistentWriter
    {
        protected @OrleansCodeGenStronglyConsistentWriterReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStronglyConsistentWriterReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1294813229;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IStronglyConsistentWriter";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1294813229 || @interfaceId == -1087870377 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1294813229:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1294813229 + ",methodId=" + @methodId);
                    }

                case -1087870377:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1087870377 + ",methodId=" + @methodId);
                    }

                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IStronglyConsistentWriter", 1294813229, typeof (global::MWMROrleansInterfaces.IStronglyConsistentWriter)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStronglyConsistentWriterMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1294813229:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1294813229 + ",methodId=" + @methodId);
                        }

                    case -1087870377:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1087870377 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1294813229;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IWhereInTheWorldData))]
    internal class OrleansCodeGenWhereInTheWorldDataReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IWhereInTheWorldData
    {
        protected @OrleansCodeGenWhereInTheWorldDataReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenWhereInTheWorldDataReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1314149748;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IWhereInTheWorldData";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1314149748 || @interfaceId == 1294813229 || @interfaceId == -1087870377 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1314149748:
                    switch (@methodId)
                    {
                        case -1829284004:
                            return "StartLease";
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1314149748 + ",methodId=" + @methodId);
                    }

                case 1294813229:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1294813229 + ",methodId=" + @methodId);
                    }

                case -1087870377:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1087870377 + ",methodId=" + @methodId);
                    }

                case -1038577650:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -454132849:
                            return "GetState";
                        case -633486763:
                            return "GetValue";
                        case 1383116710:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case -1334497665:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -29357609:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @StartLease(global::System.DateTime @time)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1829284004, new global::System.Object[]{@time});
        }

        public global::System.Threading.Tasks.Task @SetState(global::Orleans.GrainState @state)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1200397339, new global::System.Object[]{@state});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainState> @GetState()
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainState>(-454132849, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key, global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.String>(-633486763, new global::System.Object[]{@key, @cntxt});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries(global::MWMROrleansInterfaces.Context @cntxt)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(1383116710, new global::System.Object[]{@cntxt});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.Context> @ClearValues()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.Context>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1334497665, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-29357609, new global::System.Object[]{@key, @level});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IWhereInTheWorldData", -1314149748, typeof (global::MWMROrleansInterfaces.IWhereInTheWorldData)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenWhereInTheWorldDataMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1314149748:
                        switch (@methodId)
                        {
                            case -1829284004:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@StartLease((global::System.DateTime)@arguments[0]).@Box();
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1314149748 + ",methodId=" + @methodId);
                        }

                    case 1294813229:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1294813229 + ",methodId=" + @methodId);
                        }

                    case -1087870377:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1087870377 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -454132849:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetState().@Box();
                            case -633486763:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetValue((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.Context)@arguments[1]).@Box();
                            case 1383116710:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@GetAllEntries((global::MWMROrleansInterfaces.Context)@arguments[0]).@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@ClearValues().@Box();
                            case -1334497665:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterReaderGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -29357609:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@RegisterWriterGrain((global::System.String)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IWhereInTheWorldData)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1038577650 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1314149748;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IWITWDMetadataGrain))]
    internal class OrleansCodeGenWITWDMetadataGrainReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IWITWDMetadataGrain
    {
        protected @OrleansCodeGenWITWDMetadataGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenWITWDMetadataGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -698110863;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IWITWDMetadataGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -698110863 || @interfaceId == -165421008;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -698110863:
                    switch (@methodId)
                    {
                        case -1303693824:
                            return "GetNearestFullReplica";
                        case -1446789174:
                            return "GetAllFullReplicas";
                        case 499177615:
                            return "GetGrain";
                        case 58988437:
                            return "GetGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -698110863 + ",methodId=" + @methodId);
                    }

                case -165421008:
                    switch (@methodId)
                    {
                        case 499177615:
                            return "GetGrain";
                        case 58988437:
                            return "GetGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -165421008 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.IWhereInTheWorldData> @GetNearestFullReplica()
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.IWhereInTheWorldData>(-1303693824, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.String>> @GetAllFullReplicas()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.String>>(-1446789174, null);
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.IStatefulGrain> @GetGrain(global::System.Boolean @readwrite, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.IStatefulGrain>(499177615, new global::System.Object[]{@readwrite, @level});
        }

        public global::System.Threading.Tasks.Task<global::MWMROrleansInterfaces.IStatefulGrain> @GetGrain(global::System.String @primaryKey, global::System.Boolean @readwrite, global::MWMROrleansInterfaces.ConsistencyLevel @level)
        {
            return base.@InvokeMethodAsync<global::MWMROrleansInterfaces.IStatefulGrain>(58988437, new global::System.Object[]{@primaryKey, @readwrite, @level});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IWITWDMetadataGrain", -698110863, typeof (global::MWMROrleansInterfaces.IWITWDMetadataGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenWITWDMetadataGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -698110863:
                        switch (@methodId)
                        {
                            case -1303693824:
                                return ((global::MWMROrleansInterfaces.IWITWDMetadataGrain)@grain).@GetNearestFullReplica().@Box();
                            case -1446789174:
                                return ((global::MWMROrleansInterfaces.IWITWDMetadataGrain)@grain).@GetAllFullReplicas().@Box();
                            case 499177615:
                                return ((global::MWMROrleansInterfaces.IWITWDMetadataGrain)@grain).@GetGrain((global::System.Boolean)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 58988437:
                                return ((global::MWMROrleansInterfaces.IWITWDMetadataGrain)@grain).@GetGrain((global::System.String)@arguments[0], (global::System.Boolean)@arguments[1], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[2]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -698110863 + ",methodId=" + @methodId);
                        }

                    case -165421008:
                        switch (@methodId)
                        {
                            case 499177615:
                                return ((global::MWMROrleansInterfaces.IWITWDMetadataGrain)@grain).@GetGrain((global::System.Boolean)@arguments[0], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[1]).@Box();
                            case 58988437:
                                return ((global::MWMROrleansInterfaces.IWITWDMetadataGrain)@grain).@GetGrain((global::System.String)@arguments[0], (global::System.Boolean)@arguments[1], (global::MWMROrleansInterfaces.ConsistencyLevel)@arguments[2]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -165421008 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -698110863;
            }
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
