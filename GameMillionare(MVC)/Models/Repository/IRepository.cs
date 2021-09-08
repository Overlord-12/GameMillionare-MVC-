using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMillionare_MVC_.Models.Repository
{
    interface IRepository<Answer> : IDisposable
    {
       List<Answer> GetAnswers(int val);
    }
}
