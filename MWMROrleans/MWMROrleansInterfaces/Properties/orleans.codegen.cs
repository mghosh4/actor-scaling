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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IStatefulGrainReader))]
    internal class OrleansCodeGenStatefulGrainReaderReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IStatefulGrainReader
    {
        protected @OrleansCodeGenStatefulGrainReaderReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStatefulGrainReaderReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1340049260;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IStatefulGrainReader";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1340049260 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1340049260:
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
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1340049260 + ",methodId=" + @methodId);
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
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IStatefulGrainReader", 1340049260, typeof (global::MWMROrleansInterfaces.IStatefulGrainReader)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStatefulGrainReaderMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1340049260:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@ClearValues().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1340049260 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainReader)@grain).@ClearValues().@Box();
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
                return 1340049260;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::MWMROrleansInterfaces.IStatefulGrainWriter))]
    internal class OrleansCodeGenStatefulGrainWriterReference : global::Orleans.Runtime.GrainReference, global::MWMROrleansInterfaces.IStatefulGrainWriter
    {
        protected @OrleansCodeGenStatefulGrainWriterReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStatefulGrainWriterReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1496158020;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::MWMROrleansInterfaces.IStatefulGrainWriter";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1496158020 || @interfaceId == 1340049260 || @interfaceId == -1038577650 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1496158020:
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
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1496158020 + ",methodId=" + @methodId);
                    }

                case 1340049260:
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
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1340049260 + ",methodId=" + @methodId);
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
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::MWMROrleansInterfaces.IStatefulGrainWriter", 1496158020, typeof (global::MWMROrleansInterfaces.IStatefulGrainWriter)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStatefulGrainWriterMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1496158020:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@ClearValues().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1496158020 + ",methodId=" + @methodId);
                        }

                    case 1340049260:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@ClearValues().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1340049260 + ",methodId=" + @methodId);
                        }

                    case -1038577650:
                        switch (@methodId)
                        {
                            case 1200397339:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@SetState((global::Orleans.GrainState)@arguments[0]).@Box();
                            case -1376685924:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@GetValue((global::System.String)@arguments[0]).@Box();
                            case 852692164:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@GetAllEntries().@Box();
                            case -562543526:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@SetValue((global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>)@arguments[0]).@Box();
                            case -291970914:
                                return ((global::MWMROrleansInterfaces.IStatefulGrainWriter)@grain).@ClearValues().@Box();
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
                return 1496158020;
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
