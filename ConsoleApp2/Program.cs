using System.Dynamic;

namespace ConsoleApp2
{

    //this is the type and fields 
    public class Customer
    {
        #region Fields
        private int _id;
        private string _LName;
        private string _FName;
        #endregion

        #region Properties
        public int ID
        {
            //properties is the and method are types memebers 
            get { return _id; }
            set { _id = value; }
        }

        public string LastName
        {
            get { return _LName; }
            set { _LName = value; }
        }

        public string FirstName
        {
            get { return _FName; }
            set { _FName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return _FName + " " + _LName;
        }
        #endregion
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                
                
                //difference btw types and type memebers 
                //organizing codes with regions

                //type memebers have all access modifiers whereas type can have only
                //2 (internal and public)
                //regions has you organize your code

            }
        }
}