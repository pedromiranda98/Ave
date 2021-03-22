using System;
using System.IO;
using System.Reflection;


namespace tpc2{
	
	class tpc02{
		
		static void Main(String []args){
			
			var getDll= Assembly.LoadFrom("C:\\Users\\pedro\\Desktop\\Universidade\\2021v\\AVE\\ave-2020-21-sem2-i41n\\aula03-reflection\\RestSharp.dll");
			var num=1;
			foreach(Type type in getDll.GetTypes()){
				Console.WriteLine("Type "+type+" has the following methods\n");
				
				foreach(MethodInfo method in type.GetMethods()){
					Console.WriteLine("Method "+num+": "+method.Name);
				}
			}
		}
	}
}