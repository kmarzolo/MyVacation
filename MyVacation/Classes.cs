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
    public string email;
    public string cardNumber;
    public string expirationDate;
    public string cvv;
};

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
        //check if list is full
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
    {//search for accounts
        node = logins.First;
        while (!(node == null))
        {
            //check username
            if (node.Value.username == temp.username)
            {
                loginFound = true;
                return true;
            }

            node = node.Next;
        }

        //account was not found
        loginFound = false;
        return false;
    }

    public LoginEntry VerifyAccount(string username, string password)
    {//used to check if account exists
        node = logins.First;
        while (!(node == null))
        {
            //check username
            if (node.Value.username == username)
            {
                //check password
                if (node.Value.password == password)
                {
                    loginFound = true;
                    login = node.Value;
                    return login;
                }
            }

            node = node.Next;
        }

        //account was not found
        loginFound = false;
        login = new LoginEntry();
        return login;
    }
}

public class FlightHandler
{
    public string[] flights = new string[54];

    public void AddFlights(string strg)
    {
        //read flights from file
        flights = System.IO.File.ReadAllLines(strg);
    }

    public bool FindFlights(string temp)
    {
        //search flight in list
        for(int i = 0; i < flights.Length; i++)
        {
            if(flights[i].Contains(temp))
            {
                return true;
            }
        }
        return false;
    }
    
    public string GetFlight(string temp)
    {
        //retrieve flight
        for (int i = 0; i < flights.Length; i++)
        {
            if (flights[i].Contains(temp))
            {
                return flights[i];
            }
        }
        return temp;
    }

    public string[] GetAllFlights(string temp)
    {//returns all possible flights
        //count amount of possible flights
        int count = 0;
        for (int i = 0; i < flights.Length; i++)
        {
            if (flights[i].Contains(temp))
            {
                count++;
            }
        }

        //allocate appropriate memory
        string[] returnList = new string[count];
        count = 0;

        //create return list
        for(int i = 0;i < flights.Length;i++)
        {
            if(flights[i].Contains(temp))
            {
                returnList[count] = flights[i];
                count++;
            }
        }

        return returnList;
    }
}

namespace MyVacation
{
    public static class Variables
    {
        public static LoginHandler logins = new LoginHandler();
        public static FlightHandler flights = new FlightHandler();
    }
}
