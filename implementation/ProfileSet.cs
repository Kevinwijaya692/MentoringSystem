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

        public ProfileSet(T namaUser, T umurUser, T userName, T password, T email, T phoneNumber, T address)
        {
            this.namaUser = namaUser;
            this.umurUser = umurUser;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
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
    }
}
