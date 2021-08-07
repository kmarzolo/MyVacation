using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class file is to contain public information and methods
//that is meant to be accessed by the entire program

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

public class LoginHandler
{
    LinkedList<LoginEntry> logins = new LinkedList<LoginEntry>();
    LinkedListNode<LoginEntry> node;
    LoginEntry login;
    bool loginFound = false;

    public bool GetLoginStatus()
    {
        return loginFound;
    }
    public void SetLoginStatus(bool temp)
    {
        loginFound = temp;
    }
    public LoginEntry GetLoginAccount()
    {
        return login;
    }
    public void SetLoginAccount(LoginEntry temp)
    {
        login = temp;
    }
    public void AddAccount(LoginEntry temp)
    {
        if ((logins.First == null) && (logins.Last == null))
        {
            logins.AddFirst(temp);
            return;
        }

        if (SearchAccounts(temp))
        {
            return;
        }

        logins.AddLast(temp);
    }
    public bool SearchAccounts(LoginEntry temp)
    {
        node = logins.First;
        while (!(node == null))
        {
            if (node.Value.username == temp.username)
            {
                loginFound = true;
                return true;
            }

            node = node.Next;
        }
        loginFound = false;
        return false;
    }
    public LoginEntry VerifyAccount(string username, string password)
    {
        node = logins.First;
        while (!(node == null))
        {
            if (node.Value.username == username)
            {
                if (node.Value.password == password)
                {
                    loginFound = true;
                    login = node.Value;
                    return login;
                }
            }

            node = node.Next;
        }

        loginFound = false;
        login = new LoginEntry();
        return login;
    }
}


namespace MyVacation
{
    public static class Variables
    {
        public static LoginHandler logins = new LoginHandler();
    }
}
