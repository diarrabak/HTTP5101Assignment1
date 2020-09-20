using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_B_Diarra.Controllers
{

    /*************************************************************
     *                                                           *
     *       Assignment 1-Diarra  Question 3 and 4: Solution.    
     *                                                           *
     * ***********************************************************/



    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!".
        /// <example>  POST api/Greeting </example>
        /// </summary>
        /// <returns> ["Hello World!"] </returns>

        public string Post()
        {
            string greeting = "Hello World!"; // Message to be sent out
            return greeting;
        }


        /// <summary>
        /// This method returns the string "Greetings to the number of people" in argument.
        /// <example>  Get api/Greeting/3 </example>
        /// </summary>
        /// <returns>  ["Greetings to 3 people!"] </returns>


        public string Get(int id)
        {
            int numberOfPeople = id;                                          //Number of people to greet
            string greeting = "Greetings to " + numberOfPeople + " people!";  //greetings to the specified number of people
            return greeting;
        }

    }
}
