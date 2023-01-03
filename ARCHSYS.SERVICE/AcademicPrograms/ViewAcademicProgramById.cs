using ARCHSYS.CORE;
using ARCHSYS.SERVICE.AcademicPrograms.Interface;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.AcademicPrograms
{
    public class ViewAcademicProgramById : IViewAcademicProgramById
    {
        private readonly IAcademicProgramRepository academicProgramRepository;

        public ViewAcademicProgramById(IAcademicProgramRepository academicProgramRepository)
        {
            this.academicProgramRepository = academicProgramRepository;
        }
        public async Task<AcademicProgram> ExecuteAsync(int academicProgramId)
        {
            return await academicProgramRepository.GetAcademicProgramByIdAsync(academicProgramId);
        }
    }
}
