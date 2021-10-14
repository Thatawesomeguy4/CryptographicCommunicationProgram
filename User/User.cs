using System;
using System.Collections.Generic;
using System.Net;
using System.Text;


/**
 * This class will hold the main functionality for users.
 * 
 * 
 */
namespace CryptographicCommunicationProgram.User
{
    class User
    {
        string username;
        string password;                //this should never be in plain text. would be able to be caught by debugging programs
        Array contacts;                 //this will be the list of other partners that the user has talked to before/registered on the platform
        IPAddress publicIpAddress;      //This may be moved elsewhere later, for now it holds the user's public IP for setting up connections

    }
}
