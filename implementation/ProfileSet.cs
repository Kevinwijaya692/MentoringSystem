using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.Implementation
{
    internal class ProfileSet<T>
    {
        public T namaUser;
        public T umurUser;
        public T userName;
        public T password;
        public T email;
        public T phoneNumber;
        public T address;
        public T profilePicture;

        public ProfileSet(T namaUser, T umurUser, T userName, T password, T email, T phoneNumber, T address, T profilePicture)
        {
            this.namaUser = namaUser;
            this.umurUser = umurUser;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.profilePicture = profilePicture;
        }

        // Precondition: parameter namaUser, umurUser, userName, dan password tidak boleh null
        // Postcondition: objek ProfileSet diisi dengan parameter namaUser, umurUser, userName, dan password
        public void ProfileSets(T namaUser, T umurUser, T userName, T password)
        {
            Debug.Assert(namaUser != null, "namaUser tidak boleh null");
            Debug.Assert(umurUser != null, "umurUser tidak boleh null");
            Debug.Assert(userName != null, "userName tidak boleh null");
            Debug.Assert(password != null, "password tidak boleh null");

            this.namaUser = namaUser;
            this.umurUser = umurUser;
            this.userName = userName;
            this.password = password;
        }

        public T Getnama()
        {
            return this.namaUser;
        }

        public T Getumur()
        {
            return this.umurUser;
        }

        public T GetuserName()
        {
            return this.userName;

        }

        public T Getpassword()
        {
            return this.password;
        }

        public T GetEmail()
        {
            return this.email;
        }

        public T GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetEmail(T email)
        {
            this.email = email;
        }

        public void SetPhoneNumber(T phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public T GetAddress()
        {
            return this.address;
        }

        public void SetAddress(T address)
        {
            this.address = address;
        }

        public T GetProfilePicture()
        {
            return this.profilePicture;
        }

        public void SetProfilePicture(T profilePicture)
        {
            this.profilePicture = profilePicture;
        }

        // Invariant: namaUser, umurUser, userName, dan password tidak boleh null
        public void PrintProfile()
        {
            Debug.Assert(namaUser != null, "namaUser tidak boleh null");
            Debug.Assert(umurUser != null, "umurUser tidak boleh null");
            Debug.Assert(userName != null, "userName tidak boleh null");
            Debug.Assert(password != null, "password tidak boleh null");

            Console.WriteLine("Nama: " + Getnama());
            Console.WriteLine("Umur " + Getumur());
            Console.WriteLine("Username " + GetuserName());
            Console.WriteLine("Password: " + Getpassword());
        }

        public void PrintProfileWithContactDetails()
        {
            Debug.Assert(namaUser != null, "namaUser tidak boleh null");
            Debug.Assert(umurUser != null, "umurUser tidak boleh null");
            Debug.Assert(userName != null, "userName tidak boleh null");
            Debug.Assert(password != null, "password tidak boleh null");
            Debug.Assert(email != null, "email tidak boleh null");
            Debug.Assert(phoneNumber != null, "phoneNumber tidak boleh null");
            Debug.Assert(address != null, "address tidak boleh null");

            Console.WriteLine("Nama: " + Getnama());
            Console.WriteLine("Umur " + Getumur());
            Console.WriteLine("Username " + GetuserName());
            Console.WriteLine("Password: " + Getpassword());
            Console.WriteLine("Email: " + GetEmail());
            Console.WriteLine("Phone Number: " + GetPhoneNumber());
            Console.WriteLine("Address: " + GetAddress());
        }

        public bool ValidatePassword(string password)
        {
            // Validation logic
            return true;
        }

        public bool ValidateEmail(string email)
        {
            // Validation logic
            return true;
        }

        public bool ValidateName(string name)
        {
            // Validation logic
            return true;
        }

        public bool ValidateAge(int age)
        {
            // Validation logic
            return true;
        }

        public bool ValidateAddress(string address)
        {
            // Validation logic
            return true;
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            // Validation logic
            return true;
        }

        public void PrintProfileWithPicture()
        {
            Debug.Assert(namaUser != null, "namaUser tidak boleh null");
            Debug.Assert(umurUser != null, "umurUser tidak boleh null");
            Debug.Assert(userName != null, "userName tidak boleh null");
            Debug.Assert(password != null, "password tidak boleh null");
            Debug.Assert(email != null, "email tidak boleh null");
            Debug.Assert(phoneNumber != null, "phoneNumber tidak boleh null");
            Debug.Assert(address != null, "address tidak boleh null");
            Debug.Assert(profilePicture != null, "profilePicture tidak boleh null");

            Console.WriteLine("Nama: " + Getnama());
            Console.WriteLine("Umur " + Getumur());
            Console.WriteLine("Username " + GetuserName());
            Console.WriteLine("Password: " + Getpassword());
            Console.WriteLine("Email: " + GetEmail());
            Console.WriteLine("Phone Number: " + GetPhoneNumber());
            Console.WriteLine("Address: " + GetAddress());
            Console.WriteLine("Profile Picture: " + GetProfilePicture());
        }

        public bool IsComplete<T>(T namaUser, T umurUser, T password, T email, T phoneNumber, T address)
        {
            
            return ValidateName(namaUser.ToString()) && 
                ValidateAge(Convert.ToInt32(umurUser)) && 
                ValidatePassword(password.ToString()) && 
                ValidateEmail(email.ToString()) && 
                ValidatePhoneNumber(phoneNumber.ToString()) && 
                ValidateAddress(address.ToString());
        }

    }
}
