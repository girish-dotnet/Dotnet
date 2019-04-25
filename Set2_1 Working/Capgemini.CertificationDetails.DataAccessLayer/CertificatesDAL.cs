using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Capgemini.CertificationDetails.Entities;
using Capgemini.CertificationDetails.Exceptions;
using System.Threading.Tasks;

namespace Capgemini.CertificationDetails.DataAccessLayer
{
    public class CertificatesDAL
    {
        public Certificates SearchCertificateDAL(string voucherNumber)
        {
           
            string strcon = "integrated security=true;data source=DESKTOP-07HGAQG\\GIRISH;initial catalog=sqlpractice";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmdSearch = new SqlCommand("prcCertificationSearch", conn);
            cmdSearch.CommandType = CommandType.StoredProcedure;
            cmdSearch.Parameters.AddWithValue("@VourcherNumber", voucherNumber);
            SqlDataReader dr = cmdSearch.ExecuteReader();
            Certificates certificates = null;
            if(dr.Read())
            {
                certificates = new Certificates();
                certificates.ParticipantName = dr["ParticipantName"].ToString();
                certificates.Technology = dr["Technology"].ToString();
                certificates.CertificationCode = dr["CertificationCode"].ToString();
                certificates.CertificaionName = dr["CertificaionName"].ToString();
                certificates.CertificationDate = Convert.ToDateTime(dr["CertificationDate"]);
             
            }
            return certificates;
        }
    }
}
