using System;

namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool IsStarted { get; set; }

        public Engine() 
        {
           
        }

        public string About()
        {
            if (IsStarted == false)
                return "not started";
            else
                return "started";
        }

        public void start()
        {
            IsStarted= true;
        }

        public void stop()
        {
            IsStarted= false;
        }
    }
}