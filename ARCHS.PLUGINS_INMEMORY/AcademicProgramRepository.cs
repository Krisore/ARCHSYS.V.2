using ARCHSYS.CORE;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.PLUGINS_INMEMORY
{
    public class AcademicProgramRepository : IAcademicProgramRepository
    {
        private readonly ARCHSYSContext database;

        public AcademicProgramRepository(ARCHSYSContext database)
        {
            this.database = database;
        }
        public async Task<AcademicProgram> GetAcademicProgramByIdAsync(int academicProgramId)
        {
            var academicProgram = await Task.FromResult(database.AcademicPrograms.FirstOrDefault(a => a.Id == academicProgramId));
            AcademicProgram newAcademicProgram = new();
            if (academicProgram != null)
            {
                newAcademicProgram = new AcademicProgram
                {
                    Id = academicProgram.Id,
                    Name = academicProgram.Name,
                    Acronym= academicProgram.Acronym,
                   
                };
            }
            return await Task.FromResult(newAcademicProgram);
        }
    }
}
