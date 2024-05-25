using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DataBusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace Test
{

    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace HospitalManagementTest
    {
        class Program
        {
<<<<<<< HEAD
            static void Main(string[] args)
            {


            }

=======
            AddNewPeopleAndContact();
            FindPeopleAndContact();
            UpdatePeopleAndContact();
            IsExistsPeopleAndContact();
            DeletePeopleAndContact();
            Console.ReadKey();
        }

        static bool AddNewPeopleAndContact()
        {
            // Add New People & Contact
            SqlParameter[] Cantact_parameters = new SqlParameter[ 2 ];

            Cantact_parameters[ 0 ] = new SqlParameter( "Email", "Osama@gmail.com" );
            Cantact_parameters[ 1 ] = new SqlParameter( "PhoneNumber", "0554669791" );

            Nullable<int> CantactID = clsContactData.AddNewContact( Cantact_parameters );

            if ( CantactID != null )
            {
                SqlParameter[] People_parameters = new SqlParameter[ 8 ];

                People_parameters[ 0 ] = new SqlParameter( "NationalNo", "215" );
                People_parameters[ 1 ] = new SqlParameter( "FirstName", "Osama" );
                People_parameters[ 2 ] = new SqlParameter( "LastName", "Abdulaziz" );
                People_parameters[ 3 ] = new SqlParameter( "DateOfBirth", DateTime.Now );
                People_parameters[ 4 ] = new SqlParameter( "Gender", ( byte ) 1 );
                People_parameters[ 5 ] = new SqlParameter( "Address", "Taif" );
                People_parameters[ 6 ] = new SqlParameter( "ContactID", CantactID );
                People_parameters[ 7 ] = new SqlParameter( "CountryID", 2 );

                if ( clsPeopleData.AddNewPerson( People_parameters ) != null )
                {
                    Console.WriteLine( "Successfully. :-)" );
                    return true;
                }
                else
                    Console.WriteLine( "play away" );
            }
            else
                return false;

            return false;
        }

        static bool FindPeopleAndContact()
        {
            // Find People & Contact
            SqlParameter[] People_parameters = new SqlParameter[ 9 ];

            People_parameters[ 0 ] = new SqlParameter( "PersonID", 2 );
            People_parameters[ 1 ] = new SqlParameter( "NationalNo", null );
            People_parameters[ 2 ] = new SqlParameter( "FirstName", null );
            People_parameters[ 3 ] = new SqlParameter( "LastName", null );
            People_parameters[ 4 ] = new SqlParameter( "DateOfBirth", null );
            People_parameters[ 5 ] = new SqlParameter( "Gender", null );
            People_parameters[ 6 ] = new SqlParameter( "Address", null );
            People_parameters[ 7 ] = new SqlParameter( "ContactID", null );
            People_parameters[ 8 ] = new SqlParameter( "CountryID", null );

            if ( clsPeopleData.GetPersonByID( ref People_parameters ) )
            {
                Console.WriteLine( "Find Person Successfully. :-)\n\n" );

                SqlParameter[] Contact_parameters = new SqlParameter[ 3 ];

                Contact_parameters[ 0 ] = new SqlParameter( "ContactID", People_parameters[ 7 ].Value );
                Contact_parameters[ 1 ] = new SqlParameter( "Email", null );
                Contact_parameters[ 2 ] = new SqlParameter( "PhoneNumber", null );

                if ( clsContactData.GetContactByID( ref Contact_parameters ) )
                    Console.WriteLine( "Find Contact Successfully. :-)\n\n" );
                else
                    return true;
            }
            else
                Console.WriteLine( "play away" );

            return false;
        }

        static bool UpdatePeopleAndContact()
        {
            // Find People & Contact
            SqlParameter[] People_parameters = new SqlParameter[ 9 ];

            People_parameters[ 0 ] = new SqlParameter( "PersonID", 2 );
            People_parameters[ 1 ] = new SqlParameter( "NationalNo", "204" );
            People_parameters[ 2 ] = new SqlParameter( "FirstName", "Osama" );
            People_parameters[ 3 ] = new SqlParameter( "LastName", "Abdulaziz" );
            People_parameters[ 4 ] = new SqlParameter( "DateOfBirth", DateTime.Now );
            People_parameters[ 5 ] = new SqlParameter( "Gender", ( byte ) 1 );
            People_parameters[ 6 ] = new SqlParameter( "Address", DBNull.Value );
            People_parameters[ 7 ] = new SqlParameter( "ContactID", 4 );
            People_parameters[ 8 ] = new SqlParameter( "CountryID", 178 );

            if ( clsPeopleData.UpdatePerson( People_parameters ) )
            {
                Console.WriteLine( "Update Person Successfully. :-)\n\n" );

                SqlParameter[] Contact_parameters = new SqlParameter[ 3 ];

                Contact_parameters[ 0 ] = new SqlParameter( "ContactID", People_parameters[ 7 ].Value );
                Contact_parameters[ 1 ] = new SqlParameter( "Email", "Osama@gmail.com" );
                Contact_parameters[ 2 ] = new SqlParameter( "PhoneNumber", "00000000001" );

                if ( clsContactData.UpdateContact( Contact_parameters ) )
                    Console.WriteLine( "Update Contact Successfully. :-)\n\n" );
                else
                    return true;
            }
            else
                Console.WriteLine( "play away" );

            return false;
        }

        static bool IsExistsPeopleAndContact()
        {
            SqlParameter PersonID = new SqlParameter( "PersonID", 2 );
            if ( clsPeopleData.IsPersonExist( PersonID ) )
            {
                Console.WriteLine( "this Person Exists. :-)\n\n" );

                SqlParameter ContactID = new SqlParameter( "ContactID", 4 );
                if ( clsContactData.IsContactExist( ContactID ) )
                {
                    Console.WriteLine( "this Contact Exists. :-)\n\n" );
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        static bool DeletePeopleAndContact()
        {
            SqlParameter PersonID = new SqlParameter( "PersonID", 2 );
            if ( clsPeopleData.DeletePerson( PersonID ) )
            {
                Console.WriteLine( "Delete Person Successfully. :-)\n\n" );

                SqlParameter ContactID = new SqlParameter( "ContactID", 4 );
                if ( clsContactData.DeleteContact( ContactID ) )
                {
                    Console.WriteLine( "Delete Contact Successfully. :-)\n\n" );
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
>>>>>>> 2fb63ace2d5e8a08b8c122bb9f45d9ec22066886
        }
    }

}
