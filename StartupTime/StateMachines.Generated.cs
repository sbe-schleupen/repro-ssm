//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartupTime {
    using System;
    using System.Text;
    using System.Collections.Generic;
    
    
    public partial class StateMachines : StateMachinesBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 5 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n\r\nusing MassTransit;\r\n\r\nnamespace StartupTime;\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"

for(int i = 1; i < 100; i++)
{

            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\npublic class Start");
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class StartComplete" +
                    "d");
            
            #line default
            #line hidden
            
            #line 21 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 21 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class SpeedIncrease" +
                    "d");
            
            #line default
            #line hidden
            
            #line 26 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 26 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class SpeedDecrease" +
                    "d");
            
            #line default
            #line hidden
            
            #line 31 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 31 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class ShotTaken");
            
            #line default
            #line hidden
            
            #line 36 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 36 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class RequestA");
            
            #line default
            #line hidden
            
            #line 41 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 41 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class ResponseA");
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class RequestB");
            
            #line default
            #line hidden
            
            #line 51 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 51 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class ResponseB");
            
            #line default
            #line hidden
            
            #line 56 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 56 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("\r\n{\r\n    public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class SampleStateMa" +
                    "chineInstance");
            
            #line default
            #line hidden
            
            #line 61 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 61 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(" :\r\n    SagaStateMachineInstance\r\n{\r\n    public int CurrentState { get; set; }\r\n " +
                    "   public Guid CorrelationId { get; set; }\r\n}\r\n\r\npublic class SampleStateMachine" +
                    "");
            
            #line default
            #line hidden
            
            #line 68 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 68 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(" :\r\n    MassTransitStateMachine<SampleStateMachineInstance");
            
            #line default
            #line hidden
            
            #line 69 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 69 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(">\r\n{\r\n    public SampleStateMachine");
            
            #line default
            #line hidden
            
            #line 71 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 71 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(@"()
    {
        InstanceState(x => x.CurrentState, Starting, Started, Running, Walking, Sipping, Stalking);

        Request(() => ShotRequest, x => x.Timeout = TimeSpan.Zero);

        Initially(
            When(Start)
                .TransitionTo(Starting));

        During(Starting,
            When(StartCompleted)
                .TransitionTo(Started));
        During(Started,
            When(SpeedIncreased)
                .TransitionTo(Running));
        During(Running,
            When(SpeedDecreased)
                .TransitionTo(Walking));
        DuringAny(
            When(ShotTaken)
                .Request(ShotRequest, context => new RequestA");
            
            #line default
            #line hidden
            
            #line 92 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 92 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("()),\r\n            When(ShotRequest.Completed)\r\n                .Then(_ => { }),\r\n" +
                    "            When(ShotRequest.Faulted)\r\n                .Then(_ => { }));\r\n    }\r" +
                    "\n\r\n    public Request<SampleStateMachineInstance");
            
            #line default
            #line hidden
            
            #line 99 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 99 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(", RequestA");
            
            #line default
            #line hidden
            
            #line 99 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 99 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(", ResponseA");
            
            #line default
            #line hidden
            
            #line 99 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 99 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("> ShotRequest { get; } = null!;\r\n\r\n    public Event<Start");
            
            #line default
            #line hidden
            
            #line 101 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 101 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("> Start { get; } = null!;\r\n    public Event<StartCompleted");
            
            #line default
            #line hidden
            
            #line 102 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 102 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("> StartCompleted { get; } = null!;\r\n    public Event<SpeedIncreased");
            
            #line default
            #line hidden
            
            #line 103 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 103 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("> SpeedIncreased { get; } = null!;\r\n    public Event<SpeedDecreased");
            
            #line default
            #line hidden
            
            #line 104 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 104 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write("> SpeedDecreased { get; } = null!;\r\n    public Event<ShotTaken");
            
            #line default
            #line hidden
            
            #line 105 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            
            #line default
            #line hidden
            
            #line 105 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"
            this.Write(@"> ShotTaken { get; } = null!;

    public State Starting { get; } = null!;
    public State Started { get; } = null!;
    public State Running { get; } = null!;
    public State Walking { get; } = null!;
    public State Sipping { get; } = null!;
    public State Stalking { get; } = null!;
}

");
            
            #line default
            #line hidden
            
            #line 115 "C:\Users\Chris\Code\StartupTime\StartupTime\StartupTime\StateMachines.tt"

}

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class StateMachinesBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}