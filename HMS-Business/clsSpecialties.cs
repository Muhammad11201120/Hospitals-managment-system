using HMS_DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataBusinessLayer
{
    public class clsSpecialties
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;
        private int? _SpecialityID = null;
        public int? SpecialityID { get { return _SpecialityID; } }
        public string SpecialityName { set; get; }
        public clsSpecialties()
        {
            this._SpecialityID = null;
            this.SpecialityName = string.Empty;
            Mode = enMode.AddNew;
        }
        private clsSpecialties( int specialityID, string specialityName )
        {
            _SpecialityID = specialityID;
            SpecialityName = specialityName;
            this.Mode = enMode.Update;
        }

        private bool _AddNewSpeciality()
        {
            SqlParameter[] sp = new SqlParameter[ 1 ];
            sp[ 0 ] = new SqlParameter( "SpecialityName", this.SpecialityName );
            this._SpecialityID = clsSpecialityData.AddNewSpecialtie( sp );
            return ( this._SpecialityID != null );
        }
        private bool _UpdateSpeciality()
        {
            SqlParameter[] sp = new SqlParameter[ 2 ];
            sp[ 0 ] = new SqlParameter( "SpecialityID", this._SpecialityID );
            sp[ 1 ] = new SqlParameter( "SpecialityName", this.SpecialityName );
            return clsSpecialityData.UpdateSpeciality( sp );
        }

        public bool Save()
        {
            switch ( this.Mode )
            {
                case enMode.AddNew:
                    if ( _AddNewSpeciality() )
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateSpeciality();
                default:
                    return false;
            }
        }
        public static clsSpecialties Find( string SpecialityName )
        {
            SqlParameter[] sp = new SqlParameter[ 2 ];
            sp[ 0 ] = new SqlParameter( "SpecialityID", null );
            sp[ 1 ] = new SqlParameter( "SpecialityName", SpecialityName );
            bool IsFind = clsSpecialityData.FindSpecialityByNaem( ref sp );
            if ( IsFind )
                return new clsSpecialties( ( int ) sp[ 0 ].Value, ( string ) sp[ 1 ].Value );
            else
                return null;
        }
        public static clsSpecialties Find( int? SpecialityID )
        {
            SqlParameter[] sp = new SqlParameter[ 2 ];
            sp[ 0 ] = new SqlParameter( "SpecialityID", SpecialityID );
            sp[ 1 ] = new SqlParameter( "SpecialityName", null );
            bool IsFind = clsSpecialityData.FindSpeciality( ref sp );
            if ( IsFind )
                return new clsSpecialties( ( int ) sp[ 0 ].Value, ( string ) sp[ 1 ].Value );
            else
                return null;
        }
        public static bool IsSpecialityExist( int SpecialityID )
        {
            SqlParameter sp = new SqlParameter( "SpecialityID", SpecialityID );
            return true;
        }

        public static DataTable GetAllSpecialties()
        {
            return clsSpecialityData.GetAllSpecialties();
        }
        public static bool DeleteSpeciality( int SpecialityID )
        {
            SqlParameter parameter = new SqlParameter( "SpecialityID", SpecialityID );

            return clsSpecialityData.DeleteSpeciality( parameter );
        }
    }
}
