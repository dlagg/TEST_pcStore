using System.Collections;

namespace pcStore
{
    public class Invoice
    {
        private int mID,mTaxes,mTcost,mTcostDirty;
        private const int tax = 15;
        private ArrayList rowsProd = new ArrayList();

        public int ID{
            get{ return mID; }
            set{ mID = value; }
        }
        public int Taxes{
            get{ return mTaxes; }
            set{ mTaxes = value; }
        }
        public int Tcost{
            get{ return mTcost; }
            set{ mTcost = value; }
        }
        public int TcostDirty{
            get{ return mTcostDirty; }
            set{ mTcostDirty = value; }
        }

        public string showData()
        {
            string data="";



            return data;
        }
    }
}