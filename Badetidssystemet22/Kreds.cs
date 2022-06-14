using System;

namespace Badetidssystemet22
{
    public class Kreds
    {
        //globale variabler
        private string kredsID;
        private string kredsName;
        private string kredsAddresse;
        private int numberOfMembers;

        //constructors
        public Kreds(string kredsID, string kredsName, string kredsAddresse, int numberOfMembers)
        {
            this.kredsID = kredsID;
            this.kredsName = kredsName;
            this.kredsAddresse = kredsAddresse;
            this.numberOfMembers = numberOfMembers;
        }
        public bool GreaterThanZero(int numberOfMembers)
        {
            if (numberOfMembers < 1)
            {
                return false;
            }
            else return true;
        }
        public void SetID(string kredsID)
        {
            this.kredsID = kredsID;
        }
        public string GetID()
        {
            return kredsID;
        }
        public void SetName(string kredsName)
        {
            this.kredsName = kredsName;
        }
        public string GetName()
        {
            return kredsName;
        }
        public void SetAddresse(string kredsAddresse)
        {
            this.kredsAddresse = kredsAddresse;
        }
        public string GetAddresse()
        {
            return kredsAddresse;
        }
        public void SetMembers(int numberOfMembers)
        {
            this.numberOfMembers = numberOfMembers;
        }
        public int GetMembers()
        {
            return numberOfMembers;
        }
        public override string ToString()
        {
            return "ID: " + this.kredsID + "\n" + "Name: " + this.kredsName + "\n" + "Addresse: " + this.kredsAddresse + "\n" + "Number of members: " + this.numberOfMembers;
        }
    }
}
