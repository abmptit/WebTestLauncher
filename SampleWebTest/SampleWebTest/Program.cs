using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SeleniumGridHelper.TestGrid())
            {
                throw new Exception("Error on Grid Initialization, Grid is already started");
            }

            var gridProcess = SeleniumGridHelper.InitializeGrid();

            if (!SeleniumGridHelper.TestGrid())
            {
                gridProcess.Kill();
                throw new Exception("Error on Grid Initialization");
            }


            gridProcess.WaitForExit();
        }
    }
}
