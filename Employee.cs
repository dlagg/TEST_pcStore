using System;
using System.Collections;

namespace pcStore
{
    public class Employee
    {
        private string mName,mSurname,mID,mCity,mStudies,mPhoneN;
        private int mYears,mSalary;
        private char mGender; //M:Male F:Female
        private ArrayList mSales = new ArrayList();

        public string Name{
            get{ return mName; }
            set{ mName = value; }
        }
        public string Surname{
            get{ return Surname; }
            set{ Surname = value; }
        }
        public string ID{
            get{ return mID; }
            set{ mID = value; }
        }
        public string City{
            get{ return mCity; }
            set{ mCity = value; }
        }
        public string Studies{
            get{ return mStudies; }
            set{ mStudies = value; }
        }
        public int Years{
            get{ return mYears; }
            set{ mYears = value; }
        }
        public string PhoneN{
            get{ return mPhoneN; }
            set{ mPhoneN = value; }
        }
        public int Salary{
            get{ return mSalary; }
            set{ mSalary = value; }
        }
        public char Gender{
            get{ return mGender; }
            set{ mGender = value; }
        }

        public string showData()
        {
            string data="---------"+"\n"+"ID: "+ID+"\n";
            data += "Name: "+Name+
            "\n"+"Surname: "+Surname+
            "\n"+"Gender: "+Gender+
            "\n"+"City: "+City+
            "\n"+"Studies: "+Studies+
            "\n"+"Telephone: "+PhoneN+
            "\n"+"Years old: "+Years+
            "\n"+"Salary: "+Salary+"/year"+
            "\n"+"Sales: "+"\n"+showSales()+
            "\n"+"---------";
            return data;
        }
        private string showSales()
        {
            string data="";
            foreach (Invoice xInvoice in mSales)
            {
                data+=
            }
            return data;
        }
        public bool addSale(Invoice xInvoice)
        {
            bool added = false;

            return added;
        }
        public bool delSale(Invoice xInvoice)
        {
            bool added = false;

            return added;
        }
    }
}