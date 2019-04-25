using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.CertificationDetails.Entities;
using Capgemini.CertificationDetails.DataAccessLayer;
using Capgemini.CertificationDetails.Exceptions;

namespace Capgemini.CertificationDetails.BusinessLayer
{
    public class CertificatesBL
    {
        private static bool Validate(Certificates certificate)
        {
            StringBuilder sb = new StringBuilder();
            bool validateEmploy = true;
            if (certificate.CertificaionName.Length == 0)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "CertificaionName must be entered.");
            }
            if (certificate.ParticipantName.Length == 0)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "ParticipantName must be entered.");
            }

            return validateEmploy;
        }

        public static Certificates SearchCertificateBL(string voucherNumber)
        {
            Certificates certificate = null;
            try
            {
                certificate = new CertificatesDAL().SearchCertificateDAL(voucherNumber);
            }
            catch (CertificateException )
            {

                throw;
            }
            return certificate;
        }
    }
}
