

namespace pcStore
{
    public class Product
    {
        private string mName,mBrand;
        private int mId,mQuant,mPrice;
        private bool mAvailable;
        private char mCategory;

        public string Name{
            get{ return mName;}
            set{mName = value;}
        }
        public string Brand{
            get{ return mBrand;}
            set{mBrand = value;}
        }
        public int Id{
            get{ return mId;}
            set{mId = value;}
        }
        public int Price{
            get{ return mPrice;}
            set{mPrice = value;}
        }
        public int Quant{
            get{ return mQuant;}
            set{mQuant = value;}
        }
        public bool Available{
            get{ return mAvailable;}
            set{mAvailable = value;}
        }
        public char Category{
            get{ return mCategory;}
            set{mCategory = value;}
        }


        public string showData()
        {
            string data="---------"+"\n"+"ID: "+Id+"\n";
            data += "Name: "+Name+
            "\n"+"Brand: "+Brand+
            "\n"+"Available: "+Available+
            "\n"+"Quantity: "+Quant+
            "\n"+"Price: "+Price+
            "\n"+"Category: "+Category+
            "\n"+"---------";
            return data;
        }

    }
}