using System;
using System.Reflection;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using System.Diagnostics;

namespace PostSharp.Custom
{
    [Serializable]
    public sealed class TimedAttribute : OnMethodBoundaryAspect
    {
        #region Build-Time Logic

        public override bool CompileTimeValidate(MethodBase method)
        {
            return method.Name.Equals("SayHello");
        }

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            this.CompileTime = DateTime.Now;
        }

        #endregion

        #region Run-Time Logic

        public override void RuntimeInitialize(MethodBase method)
        {
            this.RuntimeTime = DateTime.Now;
        }

        #endregion

        public override void OnEntry(MethodExecutionArgs args)
        {
            // It is equiavlent to the start of the "try"
            Stopwatch sw = new Stopwatch();
            args.MethodExecutionTag = sw;
            sw.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            // It is equivalent to the 'finally' block.

            var sw = args.MethodExecutionTag as Stopwatch;
            sw.Stop();

            Console.WriteLine("{0} took {1}ms [run started at {2}, compiled at {3}]",
                args.Method.Name,
                sw.ElapsedMilliseconds,
                RuntimeTime.ToLongTimeString(),
                CompileTime.ToLongTimeString());
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            // This method is invoked after successful execution of the method to which the current aspect is applied.
        }

        public override void OnException(MethodExecutionArgs args)
        {
            // This method is invoked upon exception in the method to which the current aspect is applied.
            // It is equivelent to the 'catch' block.
        }

        public DateTime CompileTime { get; private set; }
        public DateTime RuntimeTime { get; private set; }
    }
}
