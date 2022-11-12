using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassStructAndDelegate
{
	
	// Class
    public class Person 
    {         
       
       // Fields
        #region -- Fields --
        
        private string _firstName;
        
        #endregion
        
        // Properties
        #region -- Properties --
        
        public string FirstName {
        	get {
        		return _firstName;
        	}
        	set {
        		_firstName = value;
        	}
        }
        
        public string LastName { get; set; }
        
        public string FullName {
        	get {
        		return $"{FirstName} {LastName}";
        	}
        }
        
        private string _nickName;
        public string NickName {
        	get {
        		if (string.IsNullOrEmpty(_nickName))
        		   return "N/A";
        		   
        		return _nickName;
        	}
        	set {
        		if (value == null)
        		   _nickName = string.Empty;
        		else 
        		   _nickName = value;
        }
        
        }
        #endregion
        
        // Constructor
        #region -- Constructor --
        
        public Person() {
        	
        }
        
        public Person(string firtsName) {
        	FirstName = firtsName;
        }
        
        public Person(string firtsName, string lastName): this(firtsName) {
        	LastName = lastName;
        }
        
        #endregion
        
        // Methods
        #region -- Methods --
        
        public void Update (string firtsName) {
        	FirstName = firtsName;
        }
        
        public void Update (string firtsName, string lastName) {
        	Update(firtsName);
        	LastName = lastName;
        }
        
        public void Update (string firtsName, string lastName, string nickName) {
        	Update(firtsName, lastName);
        	NickName = nickName;
        }
        
        #endregion
        
        // Events
        #region -- Events -- 
        
        #endregion
        
        
}
}









