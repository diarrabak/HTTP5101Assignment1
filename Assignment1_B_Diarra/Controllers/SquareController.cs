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
     *       Assignment 1-Diarra  Question 2: Solution.          *
     *                                                           *
     * ***********************************************************/

    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of its argument ".
        /// <example>  GET api/Square/7 </example>
        /// </summary>
        /// <returns> [ 49 ] </returns>

        public int Get(int id)
        {
            int id_squared = id * id; //Temporary store the square value of id
            return id_squared;
        }
    }
}
