using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickByImage.model
{
    class ItemProcess : IComparable
    {
        public string processName { get; set; }
        public string displayText { get; set; }
        public IntPtr valueHandle { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            ItemProcess process = obj as ItemProcess;
            if (process != null)
            {
                return this.processName.CompareTo(process.processName);
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return displayText;
        }


    }
}
