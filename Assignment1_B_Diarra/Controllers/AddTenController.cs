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
     *       Assignment 1-Diarra  Question 1: Solution.          *
     *                                                           *
     * ***********************************************************/


    public class AddTenController : ApiController
    {

        /// <summary>
        /// This method adds 10 to its argument and returns the sum.
        /// <example>  GET api/AddTen/7 </example>
        /// </summary>
        /// <returns>[ 17]</returns>


        public int Get(int id)
        {
            int id_plus_10 = id + 10;
            return id_plus_10;
        }
    }
}
