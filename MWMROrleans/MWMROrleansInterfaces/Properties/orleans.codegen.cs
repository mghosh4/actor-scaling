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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1376685924, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(852692164, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task @ClearValues()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1684944735, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1134793430, new global::System.Object[]{@key});
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IStatefulGrain)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1376685924, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(852692164, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task @ClearValues()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1684944735, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1134793430, new global::System.Object[]{@key});
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1376685924, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(852692164, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task @ClearValues()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1684944735, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1134793430, new global::System.Object[]{@key});
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IStronglyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1376685924, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(852692164, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task @ClearValues()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1684944735, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1134793430, new global::System.Object[]{@key});
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentReader)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IEventuallyConsistentWriter))]
    internal class OrleansCodeGenEventuallyConsistentWriterReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IEventuallyConsistentWriter
    {
        protected @OrleansCodeGenEventuallyConsistentWriterReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenEventuallyConsistentWriterReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 2117398069;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IEventuallyConsistentWriter";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 2117398069 || @interfaceId == 810781155 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 2117398069:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
                            return "RegisterWriterGrain";
                        case -435906145:
                            return "DeregisterWriterGrain";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 2117398069 + ",methodId=" + @methodId);
                    }

                case 810781155:
                    switch (@methodId)
                    {
                        case 1200397339:
                            return "SetState";
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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
                        case -1376685924:
                            return "GetValue";
                        case 852692164:
                            return "GetAllEntries";
                        case -562543526:
                            return "SetValue";
                        case -291970914:
                            return "ClearValues";
                        case 1684944735:
                            return "RegisterReaderGrain";
                        case 2004399442:
                            return "DeregisterReaderGrain";
                        case -1134793430:
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

        public global::System.Threading.Tasks.Task<global::System.String> @GetValue(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1376685924, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> @GetAllEntries()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>(852692164, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-562543526, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task @ClearValues()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-291970914, null);
        }

        public global::System.Threading.Tasks.Task @RegisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1684944735, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @DeregisterReaderGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2004399442, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @RegisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1134793430, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task @DeregisterWriterGrain(global::System.String @key)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-435906145, new global::System.Object[]{@key});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IEventuallyConsistentWriter", 2117398069, typeof (global::MWMROrleansInterfaces.IEventuallyConsistentWriter)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenEventuallyConsistentWriterMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 2117398069:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 2117398069 + ",methodId=" + @methodId);
                        }

                    case 810781155:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 810781155 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@ClearValues().@Box();
                            case 1684944735:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@RegisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case 2004399442:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@DeregisterReaderGrain((global::System.String)@arguments[0]).@Box();
                            case -1134793430:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@RegisterWriterGrain((global::System.String)@arguments[0]).@Box();
                            case -435906145:
                                return ((global::MWMROrleansInterfaces.IEventuallyConsistentWriter)@grain).@DeregisterWriterGrain((global::System.String)@arguments[0]).@Box();
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
                return 2117398069;
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
