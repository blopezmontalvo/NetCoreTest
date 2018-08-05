using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Common
{
    public interface IGeneralManager<GeneralDTO, NewDTO, UpdateDTO>
    {
        Task<List<GeneralDTO>> List(Page page);
        Task<GeneralDTO> Create(NewDTO newRegistry);
        Task<GeneralDTO> Update(UpdateDTO ÚpdateRegistry);
        Task Delete(int Id);
    }
}
