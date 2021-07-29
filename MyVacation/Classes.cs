using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct LoginEntry
{
    //used for user's account information
    public string firstName;
    public string lastName;
    public string username;
    public string password;
};

public struct Flight
{
    //used for flight information
    public string startLocation;
    public string endLocation;
    public string departDate;
    public string returnDate;
    public int price;
}

namespace MyVacation
{
    //class has methods for searching linked lists
    public class ListOps
    {
        LinkedListNode<LoginEntry> temp;
        public bool Search(ref LoginEntry login, ref LinkedList<LoginEntry> loglist)
        {//using username to search for accounts
            //check if list is empty first
            if ((loglist.First == null) && (loglist.Last == null))
            {
                return false;
            }
            temp = loglist.First;

            //search through list
            while(!(temp == null))
            {
                if(temp.Value.username == login.username)
                {
                    login = temp.Value;
                    return true;
                }
                temp = temp.Next;
            }

            //username not found
            return false;
        }//end of method

        public bool Verify(ref LoginEntry login, ref LinkedList<LoginEntry> loglist)
        {//search list and check if password is correct
            bool usernamefound = false;
            
            //check if list is empty first
            if ((loglist.First == null) && (loglist.Last == null))
            {
                return false;
            }
            temp = loglist.First;

            //search through list
            while (!(temp == null))
            {
                if (temp.Value.username == login.username)
                {
                    if (login.password == temp.Value.password)
                    {
                        login = temp.Value;
                        return true;
                    }
                }
                temp = temp.Next;
            }


            return false;
        }
    }
}
