using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputsComparer
{
    public class MxAInput
    {
        public double DateTime { get; set; }

        public double Depth { get; set; }

        public short OnBtm { get; set; }

        public short InSlips { get; set; }

        public double HoleDepth { get; set; }

        public short TDActivity { get; set; }

        public double BlockPosition { get; set; }

        public double Rpm { get; set; }

        public double FlowIn { get; set; }

        public double Hookload { get; set; }

        public double Wob { get; set; }

        public double Torque { get; set; }

        public double SPP { get; set; }

        public double RunningSpeed { get; set; }

        public bool IsRealtime { get; set; }

        public bool IsNewDepthData { get; set; }
    }
}
