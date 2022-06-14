using System;

using System.Collections.Generic;

namespace Badetidssystemet22
{
    public class Badetidsperiode
    {
        //globale variabler
        private string morningSession;
        private string nightSession;
        private DateTime startTime;
        private DateTime endTime;
        private DayOfWeek weekDay;
        private Dictionary<string, Kreds> objectives;
        public bool startAndEnd;

        //constructors
        public Badetidsperiode(string morningSession, string nightSession, DateTime startTime, DateTime endTime, DayOfWeek weekDay)
        {
            this.morningSession = morningSession;
            this.nightSession = nightSession;
            this.startTime = startTime;
            this.endTime = endTime;
            this.weekDay = weekDay;
            objectives = new Dictionary<string, Kreds>();
        }
        public Badetidsperiode(string v1, string v2, DateTime dateTime1, DateTime dateTime2, string v3)
        {

        }
        public bool StartAndEnd(DateTime start, DateTime end)
        {
            if (startTime < endTime)
            {
                return true;
            }
            else return false;
        }
        public void AddKreds(Kreds kreds)
        {
            objectives.Add(kreds.GetID(), kreds);
        }
        public void DeleteKreds(string id)
        {
            objectives.Remove(id);
        }
        public void SetMorningSession(string morningSession)
        {
            this.morningSession = morningSession;
        }
        public string GetMorningSession()
        {
            return morningSession;
        }
        public void SetNightSession(string nightSession)
        {
            this.nightSession = nightSession;
        }
        public string GetNightSession()
        {
            return nightSession;
        }
        public void SetStartTime(DateTime startTime)
        {
            this.startTime = startTime;
        }
        public DateTime GetStartTime()
        {
            return startTime;
        }
        public void SetEndTime(DateTime endTime)
        {
            this.endTime = endTime;
        }
        public DateTime GetEndTime()
        {
            return endTime;
        }
        public void SetWeekDay(DayOfWeek weekDay)
        {
            this.weekDay = weekDay;
        }
        public DayOfWeek GetWeekDay()
        {
            return weekDay;
        }
        public override string ToString()
        {
            return "Morning session:" + this.morningSession + "\n" + "Night Session: " + this.nightSession + "\n" + "Start time: " + this.startTime + "\n" + "End time: " + this.endTime + "\n" + "Weekday: " + this.weekDay;
        }
    }
}
