using System;
using System.Collections.Generic;

namespace Cake_Clicker_Game
{
    //Class that handles cheat detection and Clicking Analytics
    class ClickAnalytics
    {

        //Private Fields
        private int _maxCPS;
        private bool _autoclickerDetected;
        private List<ClickData> CPSData;

        //Constructor
        public ClickAnalytics()
        {
            _maxCPS = 0;
            _autoclickerDetected = false;
            CPSData = new List<ClickData>();
            CPSData.Add(new ClickData(DateTime.Now, 0));
        }


        //Method processes a user click and saves data accordingly
        //This is the main method that should be called when a user performs a click
        public void AddUserClick()
        {
            //Last element in the list
            int index = CPSData.Count - 1;

            //Checks if the timestamp is the same as the current time, if so then we need to increment the clicks and check if an autoclicker is active
            if (DateTime.Now.Second == CPSData[index].GetTimestamp().Second)
            {
                CPSData[index].IncrementClicks();
                if (CPSData[index].GetClicks() > 15)
                {
                    _autoclickerDetected = true;
                }
            }
            else
            {
                if (_maxCPS < CPSData[index].GetClicks())
                {
                    _maxCPS = CPSData[index].GetClicks();
                }

                //Since timestamp is different, is so we make a new ClickData element and add to the back of the list
                CPSData.Add(new ClickData(DateTime.Now, 0));
            }
        }

        //This method returns true if an autoclicker has been detected
        public bool GetCheatStatus()
        {
            return _autoclickerDetected;
        }

        //This method returns the int of the max cps registered
        //If the user hasn't clicked yet then the method will return 0
        public int GetMaxCPS()
        {
            return _maxCPS;
        }

        //Get average CPS
        public double AverageCPS()
        {
            int totalClicks = 0;

            //gets total amount of clicks
            for(int i = 0; i < CPSData.Count-1; i++)
            {
                totalClicks += CPSData[i].GetClicks();
            }

            double totalClickSaves = (double) CPSData.Count;

            return totalClicks / totalClickSaves;
        }


        //This is an internal method that can be called to clean up the CPSData array by removing
        //Timestamps where the clicks saved is 0. However it won't delete the last element in the array since that is the current timestamp
        private void ClickSaveCleanup()
        {
            for(int i = 0; i < CPSData.Count-2; i++)
            {
                if(CPSData[i].GetClicks() == 0)
                {
                    CPSData.RemoveAt(i);
                    i--;
                }
            }
        }
    }

    public class ClickData
    {
        //Private Fields
        private DateTime _timestamp;
        private int _clicks;

        //Constructor for the struct
        public ClickData(DateTime time, int inputtedCPS)
        {
            _timestamp = time;
            _clicks = inputtedCPS;
        }

        //returns the timestamp of the object
        public DateTime GetTimestamp()
        {
            return _timestamp;
        }

        //Returns the amount of clicks
        public int GetClicks()
        {
            return _clicks;
        }

        //Allows the user to set how many clicks are stored in the object
        public void SetClicks(int newClicks)
        {
            _clicks = newClicks;
        }

        //Increments by one the amount of clicks stored in the object
        public void IncrementClicks()
        {
            _clicks++;
        }

    }
}

