using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

using System.IO;
using System.Threading;
using System.Diagnostics;

namespace TaskManager
{
	
	class Program
	{
		static Process[] GetProcesses(){
			
			return Process.GetProcesses();
		}
		static List<Process> ExclusiveLeftJoin(Process[] arr1,Process[] arr2){
			List<Process> result = new List<Process>();
			foreach(var oldProc in arr1){
				if(!arr2.Any(newProc=>oldProc.Id==newProc.Id)){
					result.Add(oldProc);
				}
			}
			return result;
		}
		static List<Process> Compare(Process[] arr1,Process[] arr2){
			return arr1.Except(arr2).ToList();			
		}
		static void Main(string[] args)
		{

			var processes1 = GetProcesses();
			Thread.Sleep(1000*3);
			Process.Start("taskmgr");			
			Console.WriteLine("started");
			Thread.Sleep(1000*3);
			var processes2 = GetProcesses();
			var result = ExclusiveLeftJoin(processes1,processes2);
			foreach(var process in result){
				Console.WriteLine("{0}   {1}",process.Id,process.ProcessName);	
			}
		}	
	}
}

