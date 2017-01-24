using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Speech.Synthesis;


namespace CPU_Memory_console
{
    class Program
    {
        public static PerformanceCounter perfCpuCount { get; private set; }

        static void Main(string[] args)
        {

            

            //This will create a speech string and welcome the user
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Made by: DestroyerX");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to your CPU/Memory counter, i will warn you if your CPU or Memory count gets too high.");
            synth.Speak("Welcome to your CPU slash memory counter, i will warn you if your cpu or memory count gets too high.");
            Console.ForegroundColor = ConsoleColor.White;

            #region Performance Counters
            //This will pull the current CPU load in precentage
            PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            perfCpuCount.NextValue();

            // This will putt the current available Memory in MegaBytes
            PerformanceCounter perfMemCount = new PerformanceCounter("Memory", "Available MBytes");
            perfMemCount.NextValue();

            // This will read out the system uptime (in seconds)
            PerformanceCounter perfUpTime = new PerformanceCounter("System", "System Up Time");
            #endregion

            // Infinite loop
            while (true)
            {
                // Get the current performace counter values
                int currentCpuPercentage = (int)perfCpuCount.NextValue();
                int currentAvailableMemory = (int)perfMemCount.NextValue();
                
                // Reads out perf(Cpu/Mem)Count every second
                Console.WriteLine("CPU Load        : {0}%", currentCpuPercentage);
                Console.WriteLine("Available Memory: {0} MB", currentAvailableMemory);

                // Only tell us when CPU is above 80 precent
                if(currentCpuPercentage > 80)
                {
                    if (currentCpuPercentage == 90)
                    {
                        string cpuLoadVocalMessage = String.Format("WARNING! The CPU count is over 90 precent!");
                        synth.Speak(cpuLoadVocalMessage);
                    }
                    else
                    {
                        string cpuLoadVocalMessage = String.Format("The current CPU load is {0} percent", currentCpuPercentage);
                        synth.Speak(cpuLoadVocalMessage);
                    }
                }

                // Only tell us when memory is below one gigabyte
                if(currentAvailableMemory < 1024)
                {
                    string memAvailableVocalMessage = String.Format("The current available memory is {0} megabytes", currentAvailableMemory);
                    synth.Speak(memAvailableVocalMessage);
                }

                // Speak to the user with text to speech to tell them what the current values are
                


                Thread.Sleep(1000);

            }   // End of loop


        }

    }
}
