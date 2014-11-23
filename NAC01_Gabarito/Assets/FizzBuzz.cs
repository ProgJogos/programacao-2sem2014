using UnityEngine;
using System.Collections;

public class FizzBuzz : MonoBehaviour 
{
	float demora = 0;
	void Calcular () 
	{
		
		for (int num = 0; num < 10000; num++)
		{
			string msg = "";
			
			if (num % 3 == 0)
			{  
				msg += "fizz";
			}
			
			if (num % 5 == 0)
			{
				msg += "buzz";
			}
			
			if (num % 3 != 0 && num % 5 != 0)
			{
				msg = num.ToString();
			}
			
			print(msg);
		}
		/*
		for(int i = 0; i < 10000; i++){
			if((i % 3) == 0){
				print ("fizz");
			}
			else if((i % 5) == 0){
				print ("buzz");
			}
			else if(((i % 3) == 0) && ((i % 5) == 0)){
				print ("fizz buzz");
			}
			else{
				print (i);
			}
		}
		*/
	}
	
	void Update () {
	
		print (Time.realtimeSinceStartup - demora);
		demora = Time.realtimeSinceStartup;
		
		if(Input.GetKeyDown(KeyCode.R))
		{
			demora = 0;
			Calcular();
		}
	}
}