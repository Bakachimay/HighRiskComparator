using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighRiskComparator.Models
{
    public class PatientDataContext : DbContext
    {
		public PatientDataContext(DbContextOptions<PatientDataContext> options)
            : base(options)
        {
		}

		public DbSet<PatientData> PatientDatas { get; set; }

	}
}
