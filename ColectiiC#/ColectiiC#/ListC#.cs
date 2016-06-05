using System;
using System.Collections.Generic;

namespace ColectiiC
{
	public class ListC_
	{
		public ListC_ ()
		{
			
			
		}
		
		public void printList()
		{
			//Declararea unei liste de tip string
			var fructe = new List<string> {"mere", "pere", "cirese"};
			//Parcurgerea listei cu foreach
			foreach(var fruct in fructe){
				Console.Write("\n" + fruct + " ");	
			}
			
			//Eliminarea unui element
			fructe.Remove("cirese");
			Console.Write("\nA fost eliminat cirese");
			//Parcurgerea listei dupa eliminarea unui element
			for(var index=0; index<fructe.Count; index++) {
				Console.Write("\n" + fructe[index] + " ");	
			}
			//Eliminarea unui element din colectie
			for(var index = 0; index<fructe.Count; index++){
				//Eliminarea unui element prin selectie
				if(fructe[index] == "mere"){
					Console.Write("\nA fost eliminat din lisat: "+fructe[index]+"\n");
					fructe.Remove(fructe[index]);
					
				}
			}
			//Parcurgerea listei cu o expresie lambda
			fructe.ForEach(fruct => Console.Write("A ramas in lista: " +fruct + " "));
			               
		}
		
	}
}

