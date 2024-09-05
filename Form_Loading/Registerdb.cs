﻿//
// FORM TWO
// ========
// FormTwo has a child of its own called
// FormThree. FormThree is a grandchild of
// FormMain.

using System;
using System.Collections.Generic;

namespace Form_Loading
{
    public class Registerdb
    {
        // Defines the test data from this demonstration
        // Account table.        
       
       private List<string> usernames = new List<string>();
        private List<int> passwords = new List<int>();

     //   private readonly int NOT_FOUND = -1;
        private int currentID;

        //
        // Constructor dbDemo
        // ==================
        public Registerdb() 
        {
            usernames.Add("Satyam");
            passwords.Add(1234);

            usernames.Add("Pratham");
            passwords.Add(5678);
        }

        // Read
        // ====
        // Performs a fake read on the database to retrieve a
        // record.
        //


        //-------------------------------------
        //Method to Register or Add a new user
        //--------------------------------------


        public void AddRecord(string username, int password)
        {
            this.usernames.Add(username);
            this.passwords.Add(password);

        }
        public bool Read(string username, int password)
        {
            for (int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true; // User found with matching username and password
                }
            }
            return false; // No matching user found
        }

        public bool ValidateUser(string username, int password)
        {
            for (int i = 0; i < this.usernames.Count; i++)
            {
                if (this.usernames[i] == username && this.passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }


        //
        // Get ID
        // ======


        //
        // Get Set LastName
        // =================

    }
}