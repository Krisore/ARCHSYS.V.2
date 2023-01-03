using ARCHSYS.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.PluginInterfaces
{
    public interface IAcademicProgramRepository
    {
        Task<AcademicProgram> GetAcademicProgramByIdAsync(int academicProgramId);
    }
}
