using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.helpers
{
    public static class MachineStateHelpers
    {
        public static MachineState Next(this MachineState current)
        {
            return current switch
            {
                MachineState.Free => MachineState.Starting,
                MachineState.Starting => MachineState.Busy,
                MachineState.Busy => MachineState.WindDown,
                MachineState.WindDown => MachineState.Free,
                _ => throw new ArgumentOutOfRangeException(nameof(current), current, null)
            };
        }
    }
}