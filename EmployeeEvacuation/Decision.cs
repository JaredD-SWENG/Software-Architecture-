﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Decision
    /// A class that serves as a decision generated by a manager, and granted by CEO
    /// </summary>
    class Decision
    {
        public string decision;
        public Decision(string decision)
        {
            this.decision = decision;
        }
        public void doIt()
        {
            Console.WriteLine(decision + " granted...");
        }
    }
}