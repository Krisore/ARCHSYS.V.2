using ARCHSYS.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.AcademicPrograms.Interface
{
    public interface IViewAcademicProgramById
    {
        Task<AcademicProgram> ExecuteAsync(int academicProgramId);
    }
}
