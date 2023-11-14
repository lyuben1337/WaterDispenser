using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.Company
{
    public class CompanyRepository
    {
        private static CompanyRepository instance;
        private List<WaterProvider> _waterProviders;

        private CompanyRepository()
        {
            _waterProviders = new List<WaterProvider>();
        }

        public static CompanyRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CompanyRepository();
                }
                return instance;
            }
        }

        public List<WaterProvider> WaterProviders { get { return _waterProviders; } }
    }
}
