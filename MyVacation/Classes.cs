using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class file is to contain public information and methods
//that is meant to be accessed by the entire program

public struct Flight
{
    public string startlocation;
    public string endlocation;
    public string departdate;
    public string returndate;
    public int price;
}

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
    public Flight flight;
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

    public void SetElement(string element, string value)
    {
        if (element == "username")
        {
            login.username = value;
        }
        else if (element == "password")
        {
            login.password = value;
        }
        else if (element == "email")
        {
            login.email = value;
        }
        else if (element == "cardNumber")
        {
            login.cardNumber = value;
        }
        else if (element == "expirationDate")
        {
            login.expirationDate = value;
        }
        else if (element == "cvv")
        {
            login.cvv = value;
        }
        else if (element == "firstName")
        {
            login.firstName = value;
        }
        else if (element == "lastName")
        {
            login.lastName = value;
        }
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

    public void EditAccount(LoginEntry temp)
    {
        //update login
        login = temp;

        //find login in list
        node.Value = login;

        node = logins.First;
        while (node != null)
        {
            if (node.Value.username == temp.username)
            {
                node.Value = temp;
                break;
            }

            node = node.Next;
        }

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
                login = node.Value;
                return true;
            }

            node = node.Next;
        }

        //account was not found
        loginFound = false;
        login = new LoginEntry();
        return false;
    }

    public bool CheckPassword(string username, string password)
    {
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
                    return true;
                }
            }

            node = node.Next;
        }

        //account was not found
        loginFound = false;
        return false;
    }

    public bool VerifyAccount(string username, string password)
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
                    return true;
                }
            }

            node = node.Next;
        }

        //account was not found
        loginFound = false;
        login = new LoginEntry();
        return false;
    }

    public void SetFlight(Flight flight)
    {
        login.flight = flight;
    }

    public void SetFlight(string startlocation, string endlocation,
        string departdate, string returndate, int price)
    {
        login.flight.startlocation = startlocation;
        login.flight.endlocation = endlocation;
        login.flight.departdate = departdate;
        login.flight.returndate = returndate;
        login.flight.price = price;
    }

    public Flight GetFlight()
    {
        return login.flight;
    }
}


public class FlightHandler
{
    public string[] flights = new string[54];
    Flight flight;

    public void SetFlight(Flight temp)
    {
        flight = temp;
    }

    public void SetFlight(string startlocation, string endlocation,
        string departdate, string returndate, int price)
    {
        flight.startlocation = startlocation;
        flight.endlocation = endlocation;
        flight.departdate = departdate;
        flight.returndate = returndate;
        flight.price = price;
    }

    public void SetPrice(int price)
    {
        flight.price = price;
    }

    public Flight GetFlight()
    {
        return flight;
    }

    public void AddFlights(string strg)
    {
        //read flights from file
        flights = System.IO.File.ReadAllLines(strg);
    }

    public bool FindFlights(string temp)
    {
        //search flight in list
        for (int i = 0; i < flights.Length; i++)
        {
            if (flights[i].Contains(temp))
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
        for (int i = 0; i < flights.Length; i++)
        {
            if (flights[i].Contains(temp))
            {
                returnList[count] = flights[i];
                count++;
            }
        }

        return returnList;
    }
}

public class ValidationMethods
{
    public bool ValidateCardNumber(string cardNumber)
    {
        int[] numbers = new int[cardNumber.Length - 3];
        if ((cardNumber.Length > 19) || (cardNumber.Length < 15))
        {
            return false;
        }

        //convert strings to integer
        for (int i = 0, j = 0; i < cardNumber.Length; i++)
        {
            if (cardNumber[i] == ' ')
            {
                i++;
            }
            numbers[j] = Int32.Parse(cardNumber[i].ToString());
            j++;
        }

        //start Luhn's algorithm
        //double every second integer
        //if doubling results in double digit number, add digits together
        //sum integers together
        //if mod 10 == 0, card is valid
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if ((i % 2) == 1)
            {
                numbers[i] = numbers[i] * 2;

                //if numbers[i] > 9, add digits
                if (numbers[i] > 9)
                {
                    string temp = numbers[i].ToString();
                    int[] templist = new int[2];

                    templist[0] = Int32.Parse(temp[0].ToString());
                    templist[1] = Int32.Parse(temp[1].ToString());

                    numbers[i] = templist[0] + templist[1];
                }
            }
            sum = numbers[i] + sum;
        }

        if (!((sum % 10) == 0))
        {
            return false;
        }

        return true;
    }

    public bool ValidateExpirationDate(string expirationDate)
    {
        int month, year;

        month = Int32.Parse(expirationDate.Substring(0, 2));
        year = Int32.Parse(expirationDate.Substring(3, 2));

        //if the year is 2021, 8-12 months are valid
        if (year == 21)
        {
            if ((month < 8) || (month > 12))
            {
                return false;
            }
        }
        //if the year is higher than 2021, any month is valid
        else if (year > 21)
        {
            if ((month < 0) || (month > 12))
            {
                return false;
            }
        }
        //if the year is lower than 2021, invalid
        else if (year < 21)
        {
            return false;
        }

        return true;
    }
}

namespace MyVacation
{
    public static class Variables
    {
        public static LoginHandler logins = new LoginHandler();
        public static FlightHandler flights = new FlightHandler();
        public static ValidationMethods validation = new ValidationMethods();
    }
}
