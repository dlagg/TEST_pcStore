using System.Collections;

namespace pcStore
{
    public class Invoice
    {
        Customer xCustomer = new Customer();
        Employee xEmployee = new Employee();
        Product xProduct = new Product();
        //Subordinated class
        private class rowsProd
        {
            Product xProduct;
            private string mProdName;
            private int mProdPrice,mQuProd,mTotPrice;

            public string ProdName{
                get{ return mProdName; }
                set{ mProdName = value; }
            }
            public int ProdPrice{
                get{ return mProdPrice; }
                set{ mProdPrice = value; }
            }
            public int QuProd{
                get{ return mQuProd; }
                set{ mQuProd = value; }
            }
            public int TotPrice{
                get{ return mTotPrice; }
                set{ mTotPrice = value; }
            }
            QuProd = 4; //test
            TotPrice = QuProd * xProduct.Price;
        }
        //
        private int mID,mTcost,mTcostDirty;
        private const int mTax = 15;
        private ArrayList allRows = new ArrayList();

        public int ID{
            get{ return mID; }
            set{ mID = value; }
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

            data+="--------INVOICE ID: "+ID+"--------"+"\n"
            +"Customer: "+xCustomer.Name+" / Employee: "+xEmployee.Name+". "+xEmployee.ID+"\n"
            +


            return data;
        }
    }
}