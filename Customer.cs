namespace pcStore
{
    public class Customer
    {
        private string mName,mNID,mEmail,mPhoneN;
        private bool mPartner;

        public string Name{
            get{ return mName; }
            set{ mName = value; }
        }
        public string NID{
            get{ return mNID; }
            set{ mNID = value; }
        }
        public string Email{
            get{ return mEmail; }
            set{ mEmail = value; }
        }
        public string PhoneN{
            get{ return mPhoneN; }
            set{ mPhoneN = value; }
        }
        public bool Partner{
            get{ return mPartner; }
            set{ mPartner = value; }
        }

        public string showData()
        {
            string data="---------"+"\n"+"NID: "+NID+"\n";
            data += "Name: "+Name+
            "\n"+"Email: "+Email+
            "\n"+"Telephone: "+PhoneN+
            "\n"+"Partner: "+Partner+
            "\n"+"---------";
            return data;
        }

    }
}