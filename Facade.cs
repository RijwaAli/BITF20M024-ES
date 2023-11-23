using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//task 5
namespace Assignment_7
{
    // Example 1
    class Subsystem1
    {
        public string Operation1()
        {
            return "Subsystem1 operation";
        }
    }
    class Subsystem2
    {
        public string Operation2()
        {
            return "Subsystem2 operation";
        }
    }
    class Facade
    {
        private Subsystem1 subsystem1;
        private Subsystem2 subsystem2;

        public Facade()
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();
        }

        public string Operation()
        {
            string result = $"{subsystem1.Operation1()}, {subsystem2.Operation2()}";
            return $"Facade: {result}";
        }
    }

    // Example 2
    class CPU
    {
        public string Freeze()
        {
            return "CPU freeze";
        }

        public string Jump(int position)
        {
            return $"CPU jump to {position}";
        }

        public string Execute()
        {
            return "CPU execute";
        }
    }

    class Memory
    {
        public string Load(string data)
        {
            return $"Memory load {data}";
        }
    }

    class HardDrive
    {
        public string Read(int sector, int size)
        {
            return $"HardDrive read sector {sector} with size {size}";
        }
    }

    class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;

        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            hardDrive = new HardDrive();
        }

        public string Start()
        {
            string result = $"{cpu.Freeze()}, {memory.Load("BOOT_SECTOR")}, {hardDrive.Read(0, 1024)}, {cpu.Jump(1024)}, {cpu.Execute()}";
            return $"ComputerFacade: {result}";
        }
    }
}
