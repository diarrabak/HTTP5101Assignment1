using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_B_Diarra.Controllers
{

    /******************************************************************
     *                                                                *
     *   Assignment 1-Diarra  Bonus Question: Solution.               *
     *                                                                *
     * ****************************************************************/


    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns three strings containing the information related to the hosting cost.
        /// <example>  GET api/HostingCost/15 </example>
        /// </summary>
        /// <returns> [  " 1 fortnights at $5.50/FN = $11.00 CAD"
        ///              " HST 13% = $1.43 CAD " 
        ///              " Total = $12.43 CAD "] </returns>

        public IEnumerable<string> Get(int id)
        {
            int numberOfdays = id;                                                //Number of days of web hosting
            int fortNight = 14;
            int numberOfFortnights = numberOfdays / fortNight;                    //Number of fortnights
            double fortNightRate = 5.5;                                             //Fortnight rate in $ CAD
            double taxRate = 0.13;                                                // Canada tax rate of 13/100;
            double fortNightFees = (numberOfFortnights + 1) * fortNightRate;      //Fees of the fortnights
            double taxFees = fortNightFees * taxRate;                             //Taxes related to the fortnights fees
            double Total = fortNightFees + taxFees;                               // Total of taxes + regular fees
            fortNightFees = Math.Round(fortNightFees, 2);                         //Limit the decimal number to two digits
            taxFees = Math.Round(taxFees, 2);
            Total = Math.Round(Total, 2);

            //Three strings containing information related to fees

            string FirstRow = numberOfFortnights + " fortnights at $5.50 / FN = $" + fortNightFees + " CAD";
            string SecondRow = "HST 13 % = $" + taxFees + " CAD";
            string ThirdRow = "Total = $" + Total + " CAD";

            return new string[] { FirstRow, SecondRow, ThirdRow };  //Three strings in a table of strings and returned by the function
        }
    }
}
