using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class ASyncPractice : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        /*Debug.Log("Before");
        BasicAsyncMethod();
        Debug.Log("After");*/

       /* Debug.Log("Here is your number:");
        int number = await AsyncNumberReturn();
        Debug.Log("Your final number is: " + number);
        Debug.Log("Async Done!");*/

        Debug.Log("Before running all asyncs.");
        await Task.WhenAll(AsyncNumberReturn(), SecondAsyncNumberReturn());
        Debug.Log("YAY! WE ARE DONE!");

    }

    async void BasicAsyncMethod()
    {
        Debug.Log("The Async started");       
        await Task.Delay(2000);                
        Debug.Log("The Async finished");      
    }


    /*  async Task<int> AsyncNumberReturn()
      {
          await Task.Delay(2000);
          return 69;
      }*/

    async Task<int> AsyncNumberReturn()
    {
        await Task.Delay(2000);
        Debug.Log("First number is 69");
        int num = await SecondAsyncNumberReturn();
        return num+69;
    }
    async Task<int> SecondAsyncNumberReturn()
    {
        BasicAsyncMethod();
        await Task.Delay(2000);
        return 49;
    }

}
