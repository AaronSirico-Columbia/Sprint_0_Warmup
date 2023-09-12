using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class ToyPlane : Airplane
    {
        public bool isWoundUp { get; set; }


        ToyPlane()
        {

        }

        public string About()
        {
            return "ToyPlane's engine will not start unless it is woundup. ToyPlanes MaxAltitude is 50 ft";
        }

        //public string getWindUpString()
        //{

        //}

        public void StartEngine()
        {

        }

        //public string TakeOff()
        //{

        //}

        public void UnWind()
        {

        }

        public void WindUp()
        {

        }

    }
}