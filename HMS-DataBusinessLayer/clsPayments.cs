using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataBusinessLayer
{
    public class clsPayments
    {
        public enum enMode { AddNew=1, Update=2}
        public enMode Mode;
        private int? _PaymentID;
        public int? PaymentID { get { return _PaymentID; } }
        public DateTime PaymentDate { set; get; }
        public string PaymentMethod { set; get; }
        public double AmountPaid { set; get; }
        public int? MedicalRecordID { set; get; }
        public string AdditionalNotes { set; get; }
        public clsPayments() 
        {
            this._PaymentID = null;
            PaymentDate=DateTime.Now;
            PaymentMethod = string.Empty;
            AmountPaid = 0;
            MedicalRecordID = 0;
            AdditionalNotes = string.Empty;
            Mode = enMode.AddNew;
        }
        private clsPayments( int? paymentID, DateTime paymentDate, string paymentMethod, double amountPaid, int medicalRecordID, string additionalNotes)
        {
            _PaymentID = paymentID;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
            AmountPaid = amountPaid;
            MedicalRecordID = medicalRecordID;
            AdditionalNotes = additionalNotes;
            Mode = enMode.Update;
        }
        private bool _AddNewPayment()
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("paymentDate", this.PaymentDate);
            sp[1] = new SqlParameter("paymentMethod", this.PaymentMethod);
            sp[2] = new SqlParameter("amountPaid", this.AmountPaid);
            sp[3] = new SqlParameter("medicalRecordID", this.MedicalRecordID);
            sp[4] = new SqlParameter("additionalNotes", this.AdditionalNotes);
            //this._PaymentID= clsPaymentsData.AddNew(sp);
            return this._PaymentID != null;
        }
        private bool _UpdatePayment()
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("PaymentID", this.PaymentID);
            sp[1] = new SqlParameter("paymentDate", this.PaymentDate);
            sp[2] = new SqlParameter("paymentMethod", this.PaymentMethod);
            sp[3] = new SqlParameter("amountPaid", this.AmountPaid);
            sp[4] = new SqlParameter("medicalRecordID", this.MedicalRecordID);
            sp[5] = new SqlParameter("additionalNotes", this.AdditionalNotes);
            //return clsPaymentsData.Update(sp);
            return false;
        }
        public bool Save()
        {
            switch(this.Mode) 
            {
                case enMode.AddNew:
                    if(_AddNewPayment())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdatePayment();
                default:
                    return false;
            }
        }
        public static clsPayments Find(int PaymentID)
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("PaymentID", PaymentID);
            sp[1] = new SqlParameter("paymentDate",null);
            sp[2] = new SqlParameter("paymentMethod", null);
            sp[3] = new SqlParameter("amountPaid", null);
            sp[4] = new SqlParameter("medicalRecordID", null);
            sp[5] = new SqlParameter("additionalNotes",null);
            bool IsFind = false;
            if (IsFind)
                return new clsPayments((int)sp[0].Value, (DateTime)sp[1].Value, (string)sp[2].Value, (double)sp[3].Value, (int)sp[4].Value, (string)sp[5].Value);
            else
                return null;
        }
        public static bool IsPaymentExist(int PaymentID)
        {
            SqlParameter sp = new SqlParameter("PaymentID", PaymentID);
            return true;
        }
        public static DataTable GetAllPayments()
        {
            return new DataTable(); 
        }
        public static bool DeletePayment(int PaymentID)
        {
            return false;   
        }

    }
}
